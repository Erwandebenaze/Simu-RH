using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
		public class Helper
		{
			RandomGenerator _randomPersonGenerator;
			LaborMarket _lb;

			public Helper( LaborMarket Lb)
			{
				_randomPersonGenerator = Lb.Game.GetRandomGenerator();
                // TODO : Enlever gamegenerator static
				_lb = Lb;
			}

			/// <summary>
			/// Creates a random <see cref="Person"/>
			/// </summary>
			/// <param name="minAge">Must superior or equal to 18</param>
			/// <param name="maxAge">Must be inferior or equal to 60</param>
			/// <returns></returns>
			public Person CreatePerson( int ageMin, int ageMax )
			{
				return _randomPersonGenerator.GetRandomPerson( _lb, ageMin, ageMax);
			}
		}
}
