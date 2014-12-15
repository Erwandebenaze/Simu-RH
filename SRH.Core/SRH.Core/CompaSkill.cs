using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class CompaSkill : Skill
    {
        internal CompaSkill( string skillName, int startLevel = 1 )
			: base( skillName, startLevel )
		{
			_baseCostToTrain = 1500;
			_baseTimeToTrain = 20;
		}

        public override void FixPriceAndTime()
        {
            switch( Level.CurrentLevel )
            {
                case 1:
					UpgradePrice = 1750;
                    TimeToUpgrade = 25;
                    break;
                case 2:
					UpgradePrice = 2000;
                    TimeToUpgrade = 30;
                    break;
                case 3:
					UpgradePrice = 2250;
                    TimeToUpgrade = 35;
                    break;
                case 4:
                    UpgradePrice = 2500;
                    TimeToUpgrade = 40;
                    break;
                default:
                    throw new InvalidOperationException();
            }

        }
    }
}
