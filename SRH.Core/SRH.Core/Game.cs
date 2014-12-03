using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SRH.Core
{
    [Serializable]
	public class Game
	{
        readonly LaborMarket _market;
        readonly MyCompany _playerCompany;
        readonly List<Competitor> _competitors;
        readonly GameTime _timeGame;
        readonly Random _randomNumberGenerator;
        readonly List<Project> _possibleProjects;
        

		public Game( int seed, string companyName )
		{
            _randomNumberGenerator = new Random( seed );
			_market = new LaborMarket(this);
            _timeGame = new GameTime( this );

			_competitors = new List<Competitor>();

            _playerCompany = new MyCompany( this, companyName );
            CSV csvImport = new CSV();
			_possibleProjects = csvImport.ReadCsv(_playerCompany, "../../../Data/data.csv" );
            AddCompetitors();

		}

        private void AddCompetitors()
        {
            _competitors.Add( new Competitor( this, "Capgemini", 50000, 100 ) );
            _competitors.Add( new Competitor( this, "Atos", 40000, 80 ) );
            _competitors.Add( new Competitor( this, "Sopra", 30000, 60 ) );
            _competitors.Add( new Competitor( this, "Altran", 20000, 40 ) );
            _competitors.Add( new Competitor( this, "Steria", 10000, 20 ) );
        }

        #region Getters Setters
        public GameTime TimeGame
        {
            get { return _timeGame; }
        }
        public LaborMarket Market
        {
            get { return _market; }
        }

        public MyCompany PlayerCompany
        {
            get { return _playerCompany; }
        }

        public IReadOnlyList<Competitor> Competitors
        {
            get { return _competitors; }
        }

        /// <summary>
        /// Static method to get a <see cref="RandomGenerator"/>
        /// </summary>
        /// <returns>A static instance of <see cref="RandomGenerator"/></returns>
		internal RandomGenerator GetRandomGenerator()
		{
			return new RandomGenerator( _randomNumberGenerator );
		}

        internal IReadOnlyList<Project> PossibleProjects
		{
			get { return _possibleProjects; }
		}
        #endregion
        public void SaveGame()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream( @"..\..\..\Sauvegardes\" + this._playerCompany.Name + ".bin", FileMode.Create, FileAccess.Write, FileShare.None );
            formatter.Serialize( stream, this );

            stream.Close();
        }


	}
}
