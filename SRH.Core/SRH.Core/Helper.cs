using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
		public class Helper
		{
			RandomGenerator _randomPersonGenerator = new RandomGenerator();

			/// <summary>
			/// Creates a random <see cref="Person"/>
			/// </summary>
			/// <param name="minAge">Must superior or equal to 18</param>
			/// <param name="maxAge">Must be inferior or equal to 60</param>
			/// <returns></returns>
			public Person CreatePerson( int ageMin, int ageMax )
			{
				return _randomPersonGenerator.GetRandomPerson( ageMin, ageMax);
			}
		}
}
