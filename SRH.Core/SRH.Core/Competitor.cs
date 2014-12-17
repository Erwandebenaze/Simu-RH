using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class Competitor : Company
    {
        DateTime _lastBenefitTime;
        int _moneyByMonth;
        internal Competitor(Game game, string name, int wealth, int maxEmployees )
            : base(game,  name )
        {
            _wealth = wealth;
            _maxEmployees = maxEmployees;
            _lastBenefitTime = _myGame.TimeGame.CurrentTimeOfGame;
            _moneyByMonth = maxEmployees * 100;
        }

        public bool TryToAddMoneyAndEmployee()
        {
            if( _myGame.TimeGame.intervalOfTimeInDays( _lastBenefitTime ) >= 30)
            {
                _wealth += _moneyByMonth;
                _maxEmployees++;
                _moneyByMonth = _maxEmployees * 100;
                _lastBenefitTime = _myGame.TimeGame.CurrentTimeOfGame;
                return true;
            }
            else
            {
                return false;
            }
           
        }


		
    }
}
