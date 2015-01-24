using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
	class RandomGenerator
	{
		readonly Game _game;
		readonly List<string> _firstNames;
		readonly List<string> _lastNames;
		Random _randomNumberGenerator;

        internal RandomGenerator(Game game, Random randomNumberGenerator )
		{
			_game = game;
            _firstNames = new List<string>();
            _lastNames = new List<string>();
			_randomNumberGenerator = randomNumberGenerator;
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"..\..\..\..\Data\FirstNames.txt" ) )
            {
                _firstNames.Add( line );
            }
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"..\..\..\..\Data\LastNames.txt" ) )
            {
                _lastNames.Add( line );
            }
		}

		#region Getters
		public List<string> FirstNames
		{
			get { return _firstNames; }
		}
		public List<string> LastNames
		{
			get { return _lastNames; }
		}
		public Random RandomNumberGenerator
		{
			get { return _randomNumberGenerator; }
		} 
		#endregion

		/// <summary>
		/// Method to get a random <see cref="Person"/>
		/// </summary>
		/// <param name="Lb"></param>
		/// <param name="ageMin"></param>
		/// <param name="ageMax"></param>
		/// <returns>A Person with a random name and a random age between ageMin and ageMax</returns>
		internal Person GetRandomPerson( LaborMarket Lb, int ageMin, int ageMax )
		{
			if( ageMin < 18 ) throw new ArgumentException( "The minimum age of a Person must be at least 18." );
			if( ageMax > 60 ) throw new ArgumentException( "The maximum age of a Person must be 60 or less." );

			string RandomFirstName = FirstNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ];
			string RandomLastName = LastNames[ RandomNumberGenerator.Next( 0, LastNames.Count ) ];
			int RandomAge = RandomNumberGenerator.Next( ageMin, ageMax );

			Person p = new Person( Lb, RandomFirstName, RandomLastName, RandomAge );

            AssignSkillPoints( p, GetRandomPoints() );

			return p;
		}

		internal string GetRandomSkillName()
		{
			string randomSkillName;
			List<string> skillsToChooseFrom = null;
			int alea = _randomNumberGenerator.Next( 1, 5 );

			if( alea == 1 )
			{
				IEnumerable<String> compaSkills = Game.SkillNames.Where( s => s.Key == "compa" ).Select( s => s.Value );
				skillsToChooseFrom = new List<string>( compaSkills );
				randomSkillName = skillsToChooseFrom[ _randomNumberGenerator.Next( 0, skillsToChooseFrom.Count ) ];
			}
			else
			{
				IEnumerable<String> projSkills = Game.SkillNames
					.Where( kvp => kvp.Key == "proj" && kvp.Value != "Développement" && kvp.Value != "Développement web" )
					.Select( kvp => kvp.Value );
				skillsToChooseFrom = new List<string>( projSkills );
                int aleaProj = _randomNumberGenerator.Next( 1, 11 );

				if( aleaProj <= 3 )
					randomSkillName = "Développement";
				else if( aleaProj <= 5 )
					randomSkillName = "Développement web";
				else
				{
					randomSkillName = skillsToChooseFrom[ _randomNumberGenerator.Next( 0, skillsToChooseFrom.Count ) ];
				}
			}

			return randomSkillName;
		}

		//TODO : make private, internal just for temporary tests
		internal int GetRandomPoints()
		{
			int points = 0;
			bool check = false;
			while( !check )
			{
				points = _randomNumberGenerator.Next( 2, 7 );
				if( points == 2 || points > 4 )
				{
					if( _randomNumberGenerator.Next( 1, 6 ) == 5 )
						check = true;
				}
				else
					check = true;
			}

			return points;
		}

        internal void AssignSkillPoints( Person p, int points )
        {
            // Add a first level 1 Skill to the Person
            p.AddSkill( GetRandomSkillName() );

            while( points > 1 )
            {
                int alea = _randomNumberGenerator.Next( 1, 4 );
                // Add a new level 1 Skill to the Person
                if( alea <= 2 && p.Skills.Count < 4 )
                {
                    bool check = false;
                    while( !check )
                    {
                        string randomSkillName = GetRandomSkillName();
                        if( p.Skills.Where( s => s.SkillName == randomSkillName ).SingleOrDefault() == null)
                        {
                            p.AddSkill( randomSkillName );
                            points--;
                            check = true;
                        }
                    }
                }
                else
                {
                    Skill skillToImprove = p.Skills[ _randomNumberGenerator.Next( 0, p.Skills.Count ) ];
                    skillToImprove.Level.CurrentLevel ++;
                    points--;
                }
            }
        }

		internal void EmployeeGetsSick( Employee e )
		{
			// If the employee hasn't been checked for at least a month and is not already sick
			if( e.Comp.Game.TimeGame.AreMonthsPassed( e.IsSick.Key, 1 ) && e.IsSick.Value == 0 )
			{
				if( _randomNumberGenerator.Next( 1, 13 ) == 12 )
				{
					e.IsSick = new KeyValuePair<DateTime, int>( _game.TimeGame.CurrentTimeOfGame, CreateRandomDuration() );
					e.Busy = true;

                    //_game.OnSeek += new Game.SomeoneIsSeek( _game.SomeoneSeek );
                    //_game.Seek( e );
				}
				else
					e.IsSick = new KeyValuePair<DateTime, int>( _game.TimeGame.CurrentTimeOfGame, 0 );
			}
		}

		internal void EmployeeGoesInVacation( Employee e )
		{
			// If the employee hasn't been checked for at least a month and is not already in vacation
			if( /*e.Comp.Game.TimeGame.AreMonthsPassed( e.InVacation.Key, 1 ) &&*/ e.InVacation.Value == 0 && e.VacationDays != 0)
			{
				if( _randomNumberGenerator.Next( 1, 2 ) == 1 )
				{
					int duration = CreateRandomDuration( e );

					e.InVacation = new KeyValuePair<DateTime, int>( _game.TimeGame.CurrentTimeOfGame, duration );
					e.Busy = true;

					e.VacationDays -= duration;

                    _game.OnHolidays += new Game.SomeoneGoInHolidays( _game.SomeoneHolidays );
                    _game.Holidays( e );
				}
				else
					e.InVacation = new KeyValuePair<DateTime, int>( _game.TimeGame.CurrentTimeOfGame, 0 );
			}
		}

		/// <summary>
		/// Creates a random number of vacation days, cannot be over the number of vacation days left, mostly between 3 and 10 days
		/// </summary>
		/// <param name="e"> The Employee that will go in vacation </param>
		/// <returns> A number of vacation days </returns>
		private int CreateRandomDuration( Employee e )
		{
			int days = 0;
			bool check = false;

			while( !check )
			{
				days = _randomNumberGenerator.Next( 1, e.VacationDays );
				if( days < 3 || days > 11 )
				{
					if( _randomNumberGenerator.Next( 1, 11 ) == 10 )
						check = true;
				}
				else
					check = true;
			}
			return days;
		}

		/// <summary>
		/// Creates a random number of sick days, no maximum in a year, if you're sick you're sick !
		/// </summary>
		/// <returns> A number of sick days </returns>
		private int CreateRandomDuration()
		{
			int days = 0;
			bool check = false;

			while(!check)
			{
				days = _randomNumberGenerator.Next( 1, 31 );
				if( days < 3 || days > 7 )
				{
					if( _randomNumberGenerator.Next( 1, 11 ) == 10 )
						check = true;
				}
				else
					check = true;
			}
			return days;
		}

        public int GetRandomMonth()
        {
            int month = RandomNumberGenerator.Next( 1, 12 );
            return month;
        }
	}
}
