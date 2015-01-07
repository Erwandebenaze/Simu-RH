using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	 [Serializable]
	public class Happiness
	{
		int _happinessScore;

		internal Happiness()
		{
			_happinessScore = 50;
		}

		public int HappinessScore
		{
			get { return _happinessScore; }
		}

		public int ChangeHappinessScore ( int i )
		{
			if( _happinessScore + i > 100 ) _happinessScore = 100;
			else if( _happinessScore + i < 0 ) _happinessScore = 0;
			else _happinessScore += i;
			return _happinessScore;
		}
	}
}
