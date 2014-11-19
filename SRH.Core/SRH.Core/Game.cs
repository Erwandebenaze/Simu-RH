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


		static Random _randomNumberGenerator;
		static int _randomSerie;
        //public List<Project> _possibleProjects;
        

		public Game( int seed, string companyName )
		{
            _randomNumberGenerator = new Random( seed );
			_market = new LaborMarket();
			_competitors = new List<Competitor>();
			_randomSerie = _randomNumberGenerator.Next();
			_playerCompany = new MyCompany( companyName );
            _timeGame = new GameTime();
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

        internal List<Competitor> Competitors
        {
            get { return _competitors; }
        }
        public static int RandomSerie
        {
            get { return _randomSerie; }
        }

        /// <summary>
        /// Static method to get a <see cref="RandomGenerator"/>
        /// </summary>
        /// <returns>A static instance of <see cref="RandomGenerator"/></returns>
        internal static RandomGenerator GetRandomGenerator()
        {
            return new RandomGenerator( _randomNumberGenerator );
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
