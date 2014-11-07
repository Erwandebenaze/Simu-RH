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
			_market = new LaborMarket();
			_possibleProjects = new List<Project>();
			_competitors = new List<Competitor>();
			_randomNumberGenerator = new Random( seed );
			_randomSerie = _randomNumberGenerator.Next();
			_playerCompany = new MyCompany( companyName );
		}

        public MyCompany PlayerCompany
        {
            get { return _playerCompany; }
        }
		public static int RandomSerie
		{
			get { return _randomSerie; }
		}

		/// <summary>
		/// Static method to get a <see cref="RandomGenerator"/>
		/// </summary>
		/// <returns>An instance of <see cref="RandomGenerator"/></returns>
		internal static RandomGenerator GetRandomGenerator()
		{
			return new RandomGenerator( _randomNumberGenerator );
		}
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
