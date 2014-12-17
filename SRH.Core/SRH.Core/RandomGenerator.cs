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

			// TODO : add a GetRandomSKill that gives more skills and/or more level of skills (native talent of the Person)
			int numberOfSKills = 0;
			while( numberOfSKills < 2 )
			{
				string randomSkillName = GetRandomSkillName();
				if( !(bool)p.Skills.Select(s => s.SkillName == randomSkillName).SingleOrDefault()  )
				{
					p.AddSkill( p, randomSkillName );
					numberOfSKills++;
				}
			}

			return p;
		}

		string GetRandomSkillName()
		{
			return Game.SkillNames[ _randomNumberGenerator.Next( 0, Game.SkillNames.Count ) ].Value;
		}
        public int GetRandomMonth()
        {
            int month = RandomNumberGenerator.Next( 1, 12 );
            return month;
        }
	}
}
