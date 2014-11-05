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

		public Dictionary<string, string> GetRandomName()
		{
			Dictionary<string, string> randomName = new Dictionary<string, string>();
			randomName.Add( "FirstName", FirstNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ] );
			randomName.Add( "LastName", LastNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ] );
			return randomName;
		}

		public int GetRandomAge(int ageMin, int ageMax)
		{
			return RandomNumberGenerator.Next( ageMin, ageMax );
		}
	}
}
