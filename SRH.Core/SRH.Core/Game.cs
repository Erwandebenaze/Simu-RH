using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
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
		}

        #region Getters Setters
        internal LaborMarket Market
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
		public void LoadGame()
		{
			throw new NotImplementedException();
		}
		public void SaveGame()
		{
			throw new NotImplementedException();
		}
	}
}
