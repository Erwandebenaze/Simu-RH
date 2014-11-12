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
        public void FixPriceAndTime()
        {

            switch( Level.CurrentLevel )
            {
                case 1 : 
                    _upgradePrice = 1000;
                    _timeToUpgrade = 3;
                    break;
                case 2 : 
                    _upgradePrice = 1250;
                    _timeToUpgrade = 4;
                    break;
                case 3 : 
                    _upgradePrice = 1500;
                    _timeToUpgrade = 5;
                    break;
                case 4 : 
                    _upgradePrice = 1750;
                    _timeToUpgrade = 6;
                    break;
                default :
                    throw new InvalidOperationException();
            }

        }
        //readonly string _name;
        //Level _lvlSkill;
        //public ProjSkill(string skillName, int startLevel)
        //{
        //    // Exeption
        //    //_lvlSkill = new Level();
        //    _name = skillName;
        //    _level.currentLevel = startLevel;
            
        //}

        //public ProjSkill( string skillName ) 
        //    : this( skillName, 1)
        //{
        //}
    }
}
