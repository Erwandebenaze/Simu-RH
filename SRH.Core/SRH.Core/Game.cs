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

		public Game( int Seed, string CompanyName )
		{
			_randomNumberGenerator = new Random( Seed );
			_randomSerie = _randomNumberGenerator.Next();
			_playerCompany = new MyCompany( CompanyName );
		}

		public Random RandomNumberGenerator
		{
			get { return _randomNumberGenerator; }
		}
		public static int RandomSerie
		{
			get { return _randomSerie; }
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
