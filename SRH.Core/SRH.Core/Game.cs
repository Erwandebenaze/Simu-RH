using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SRH.Core
{
    [Serializable]
	public class Game
	{
        LaborMarket _market;
        MyCompany _playerCompany;
        List<Competitor> _competitors;
        GameTime _timeGame;

		Random _randomNumberGenerator;
        List<Project> _possibleProjects;
        

		public Game( int seed, string companyName )
		{
            _randomNumberGenerator = new Random( seed );
			_market = new LaborMarket(this);
			_competitors = new List<Competitor>();

            _playerCompany = new MyCompany( this, companyName );
            CSV csvImport = new CSV();
			_possibleProjects = csvImport.ReadCsv(_playerCompany, "../../../Data/data.csv" );

            _timeGame = new GameTime(this);
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

		internal List<Project> PossibleProjects
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
