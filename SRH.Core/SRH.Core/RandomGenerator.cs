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

        //internal List<KeyValuePair<string, int>> AssignPoints( Person p, int points )
        //{
        //    // Create the KeyValuePair and add a first SkillName level 1
        //    List<KeyValuePair<string, int>> skillsToGive = new List<KeyValuePair<string, int>>();
        //    skillsToGive.Add( new KeyValuePair<string, int>( GetRandomSkillName(), 1) );

        //    while( points > 1 )
        //    {
        //        int alea = _randomNumberGenerator.Next( 1, 4 );
        //        // Add a new SkillName to the KeyValuePair, level 1
        //        if( alea <= 2 && skillsToGive.Count < 4 )
        //        {
        //            bool check = false;
        //            while( !check )
        //            {
        //                string randomSkillName = GetRandomSkillName();
        //                if( !(bool)skillsToGive.Select( kvp => kvp.Key == randomSkillName ).SingleOrDefault() )
        //                {
        //                    skillsToGive.Add( new KeyValuePair<string, int>( randomSkillName, 1 ) );
        //                    points--;
        //                    check = true;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            KeyValuePair<string, int> skillToImprove = skillsToGive[ _randomNumberGenerator.Next( 0, skillsToGive.Count ) ];
        //            int newLevel = skillToImprove.Value +1;

        //            skillsToGive.Remove( skillsToGive.Where( kvp => kvp.Equals(skillToImprove) ).Single() );
        //            skillsToGive.Add( new KeyValuePair<string, int>( skillToImprove.Key, newLevel ) );
        //            points--;
        //        }
        //    }

        //    return skillsToGive;
        //}

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

        public int GetRandomMonth()
        {
            int month = RandomNumberGenerator.Next( 1, 12 );
            return month;
        }
	}
}
