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
		}
        public enum SkillName
		{
			Development, // *Développement*
			Design, //  *Conception*
			ProjManagement, // *Management de projet*
			SystemsAnalyst, // *Analyste fonctionnel*
			TechSupport, // *Technicien d'infrastucture*
			BetaTest, // *Béta testeur*
			DataBase, // *Base de données*
			GUInterface, // *Interface graphique*
			WebDevelopment, // *Développement web*
			Networking, // *Réseau*
			Security // *Sécurité*
		}
        public void FixPriceAndTime()
        {
            switch( Level.CurrentLevel )
            {
                case 1 : 
                    UpgradePrice = 1000;
                    TimeToUpgrade = 3;
                    break;
                case 2 : 
                    UpgradePrice = 1250;
                    TimeToUpgrade = 4;
                    break;
                case 3 : 
                    UpgradePrice = 1500;
                    TimeToUpgrade = 5;
                    break;
                case 4 : 
                    UpgradePrice = 1750;
                    TimeToUpgrade = 6;
                    break;
                default :
                    throw new InvalidOperationException();
            }
        }
    }
}
