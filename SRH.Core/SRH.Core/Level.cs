using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    class Level
    {
        int _currentXp;
        int _xpRequired;
        int _currentLevel;

        public Level()
        {
            // TODO : Trouver le moyen de savoir qui appelle le constructeur pour savoir si c'est la company ou une skill.
            _currentXp = 0;
            _xpRequired = 100;
        }

        public int currentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }

        public void IncreaseXp(int xp)
        {
            if( xp < 1 ) throw new ArgumentException( "Xp must be positive" );
            // TODO : Si le currentXp+ xp supérieur ou égal à xpRequired, alors, on appelle le lvlup correspondant.
        }
        public void IncreaseLevelSkill()
        {
            throw new NotImplementedException();
        }
        public void IncreaseLevelCompany()
        {
            throw new NotImplementedException();
        }
    }
}
