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
		}
        public enum SkillName
		{
			SalesRep, // *Commercial*, increase 20 projects earnings.
			HumansRessources, // *Ressources humaines*, descrease recruting and laying off cost.
			ProjDirection, // *Directeur de projets*, decrease the duration of 20 projects.
			ContractManagement, // *Gestion de contrat*, decrease the duration of 30 projects.
			Animation // *Animation*, inscrease 30 employees hapiness
		}

        public override void FixPriceAndTime()
        {
            switch( Level.CurrentLevel )
            {
                case 1:
                    UpgradePrice = 1500;
                    TimeToUpgrade = 4;
                    break;
                case 2:
                    UpgradePrice = 1750;
                    TimeToUpgrade = 5;
                    break;
                case 3:
                    UpgradePrice = 2000;
                    TimeToUpgrade = 6;
                    break;
                case 4:
                    UpgradePrice = 2250;
                    TimeToUpgrade = 7;
                    break;
                default:
                    throw new InvalidOperationException();
            }

        }
    }
}
