﻿using System;
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

		public RandomGenerator ( Random randomNumberGenerator )
		{
            _firstNames = new List<string>();
            _lastNames = new List<string>();
			_randomNumberGenerator = randomNumberGenerator;
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"\Data\FirstNames.txt" ) )
            {
                _firstNames.Add( line );
            }
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"\Data\LastNames.txt" ) )
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
		public Person GetRandomPerson( LaborMarket Lb, int ageMin, int ageMax )
		{
			if( ageMin < 18 ) throw new ArgumentException( "The minimum age of a Person must be at least 18." );
			if( ageMax > 60 ) throw new ArgumentException( "The maximum age of a Person must be 60 or less." );

			string RandomFirstName = FirstNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ];
			string RandomLastName = LastNames[ RandomNumberGenerator.Next( 0, FirstNames.Count ) ];
			int RandomAge = RandomNumberGenerator.Next( ageMin, ageMax );

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
