using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	class RandomGenerator
	{
		readonly List<string> _firstNames;
		readonly List<string> _lastNames;
		Random _randomNumberGenerator;

		public RandomGenerator ()
		{
            _firstNames = new List<string>();
            _lastNames = new List<string>();
			_randomNumberGenerator = new Random();
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"\Data\FirstNames.txt" ) )
            {
                _firstNames.Add( line );
            }
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"\Data\LastNames.txt" ) )
            {
                _lastNames.Add( line );
            }
		}

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

		public Person GetRandomPerson( LaborMarket Lb, int ageMin, int ageMax )
		{
			string RandomFirstName = FirstNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ];
			string RandomLastName = LastNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ];
			int RandomAge = RandomNumberGenerator.Next( 18, 60 );

			Person p = new Person( Lb, RandomFirstName, RandomLastName, RandomAge );
			return p;
		}

        public int GetRandomMonth()
        {
            int month = RandomNumberGenerator.Next( 1, 12 );
            return month;
        }
	}
}
