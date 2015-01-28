using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class LaborMarket
	{
		readonly List<Person> _joblessPersons;
        readonly Game _game;
        RandomGenerator _random;

        internal LaborMarket( Game myGame )
		{
			_joblessPersons = new List<Person>();
            _game = myGame;
            _random = Game.GetRandomGenerator();

			for( int i = 0; i < 100; i++ )
			{
				Person p = _random.GetRandomPerson(this, 18, 60);
				if( !( this.AddPerson( p ) ) ) throw new Exception( "A person wasn't added proprely to LaborMarket." );
			}
		}

		#region Getters
        public Game Game
        {
            get { return _game; }
        }
        public IReadOnlyList<Person> JoblessPersons
		{
			get { return _joblessPersons; }
		} 
		#endregion

		/// <summary>
		/// Adds a <see cref="Person"/> to the <see cref="LabourMarket"/>
		/// </summary>
		/// <param name="p">The <see cref="Person"/>  to add</param>
		/// <returns>Returns true if the <see cref="Person"/> is in the <see cref="LabourMarket"/></returns>
        public bool AddPerson( Person p )
		{
			_joblessPersons.Add( p );
			return ( _joblessPersons.Exists( x => x.Equals( p ) ) );
		}

		/// <summary>
		/// Removes a <see cref="Person"/> from the <see cref="LabourMarket"/>
		/// </summary>
		/// <param name="p">The <see cref="Person"/>  to remove</param>
		/// <returns></returns>
        public bool RemovePerson( Person p )
		{
			if ( !_joblessPersons.Exists( x => x.Equals( p ) ) ) throw new ArgumentException( "The Person to remove must be in the LabourMarket" );
			_joblessPersons.Remove( p );
			return !( _joblessPersons.Exists( x => x.Equals( p ) ) );
		}


	}
}
