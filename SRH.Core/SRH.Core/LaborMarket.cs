using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	class LaborMarket
	{
		List<Person> _joblessPersons;
		Helper _personMaker;
		public LaborMarket()
		{
			_joblessPersons = new List<Person>();
			_personMaker = new Helper();
			for( int i = 0; i <= 100; i++ )
			{
				Person p = _personMaker.CreatePerson( 18, 60 );
				_joblessPersons.Add( p );
			}
		}
	}
}
