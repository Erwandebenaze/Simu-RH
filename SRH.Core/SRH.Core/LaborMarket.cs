using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	internal class LaborMarket
	{
		List<Person> _joblessPersons;
		Helper _personMaker;

		internal LaborMarket()
		{
			_joblessPersons = new List<Person>();
			_personMaker = new Helper( this );
			for( int i = 0; i < 100; i++ )
			{
				Person p = _personMaker.CreatePerson( 18, 60 );
				if( !( this.AddPerson( p ) ) ) throw new Exception( "A person wasn't added proprely to LoborMarket." );
			}
		}

		public Helper PersonMaker
		{
			get { return _personMaker; }
		}
		public List<Person> JoblessPersons
		{
			get { return _joblessPersons; }
		}

		internal bool AddPerson(Person p)
		{
			_joblessPersons.Add( p );
			return ( _joblessPersons.Exists( x => x.Equals( p ) ) );
		}

		internal bool RemovePerson(Person p)
		{
			_joblessPersons.Remove( p );
			return !( _joblessPersons.Exists( x => x.Equals( p ) ) );
		}


	}
}
