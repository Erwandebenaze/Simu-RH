using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	namespace SRH.Core
	{
		public class Helper
		{
			/// <summary>
			/// Creates a random <see cref="Person"/>
			/// </summary>
			/// <param name="minAge">Must superior or equal to 18</param>
			/// <param name="maxAge">Must be inferior or equal to 60</param>
			/// <returns></returns>
			public Person CreatePerson( int minAge, int maxAge )
			{
				RandomGenerator r = new RandomGenerator();
				string FirsName;
				string LastName;

				Dictionary<string, string> RandomName = r.GetRandomName();
				RandomName.TryGetValue( "FirstName", out FirsName );
				RandomName.TryGetValue( "LastName", out LastName );

				int Age = r.GetRandomAge( minAge, maxAge );

				Person p = new Person( FirsName, LastName, Age );
				return p;
			}

			public Person CreatePerson()
			{
				RandomGenerator r = new RandomGenerator();
				string FirsName;
				string LastName;

				Dictionary<string, string> RandomName = r.GetRandomName();
				RandomName.TryGetValue( "FirstName", out FirsName );
				RandomName.TryGetValue( "LastName", out LastName );

				int Age = r.GetRandomAge( 18, 60 );

				Person p = new Person( FirsName, LastName, Age );
				return p;
			}

		}
	}
}
