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
		static Random _randomNumberGenerator;
		static int _randomSerie;
        List<Project> _possibleProjects;
        

		public Game( int seed, string companyName )
		{
            _randomNumberGenerator = new Random( seed );
			_market = new LaborMarket();
			_possibleProjects = new List<Project>();
			_competitors = new List<Competitor>();
			_randomSerie = _randomNumberGenerator.Next();
			_playerCompany = new MyCompany( companyName );
            _possibleProjects.Add( new Project( "Danone", 1, 2, 1000, 3 ) );
            _possibleProjects.Add( new Project( "Nestle", 1, 2, 2000, 4 ) );
            _possibleProjects.Add( new Project( "Accord", 1, 2, 3000, 5 ) );
		}

        #region Getters Setters
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

        public List<Project> PossibleProjects
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
