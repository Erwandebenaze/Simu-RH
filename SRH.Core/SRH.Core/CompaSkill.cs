using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    class CompaSkill : Skill
    {
        public void FixPriceAndTime()
        {
            switch( Level.CurrentLevel )
            {
                case 1:
                    _upgradePrice = 1500;
                    _timeToUpgrade = 4;
                    break;
                case 2:
                    _upgradePrice = 1750;
                    _timeToUpgrade = 5;
                    break;
                case 3:
                    _upgradePrice = 2000;
                    _timeToUpgrade = 6;
                    break;
                case 4:
                    _upgradePrice = 2250;
                    _timeToUpgrade = 7;
                    break;
                default:
                    throw new InvalidOperationException();
            }

        }
    }
}
