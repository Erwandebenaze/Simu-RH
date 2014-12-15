using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class ProjSkill : Skill
    {
        internal ProjSkill( string skillName, int startLevel = 1 )
			: base( skillName, startLevel )
		{
			_baseCostToTrain = 1000;
			_baseTimeToTrain = 15;
		}

		public override void FixPriceAndTime()
        {
            switch( Level.CurrentLevel )
            {
                case 1 :
					UpgradePrice = 1250;
                    TimeToUpgrade = 20;
                    break;
                case 2 :
					UpgradePrice = 1500;
                    TimeToUpgrade = 25;
                    break;
                case 3 :
					UpgradePrice = 1750;
                    TimeToUpgrade = 30;
                    break;
                case 4 : 
                    UpgradePrice = 2000;
                    TimeToUpgrade = 35;
                    break;
                default :
                    throw new InvalidOperationException();
            }
        }
    }
}
