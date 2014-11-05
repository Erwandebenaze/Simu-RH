using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    public class Level
    {
        int _currentXp;
        int _xpRequired;
        int _currentLevel;

        public Level()
        {
            // TODO : Trouver le moyen de savoir qui appelle le constructeur pour savoir si c'est la company ou une skill.
			_currentLevel = 1;
			_currentXp = 0;
            this.FixNextXpRequired();
        }

        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }

        public void IncreaseXp(int xp)
        {
            if( xp < 1 ) throw new ArgumentException( "Xp must be positive" );
            if( this._currentLevel == 2 && xp > 100 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 3 && xp > 250 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 4 && xp > 600 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 5 && xp > 1000 ) throw new ArgumentException( "Xp is too big for the level" );

            if (xp + _currentXp >= _xpRequired)
            {
                this.IncreaseLevelSkill();
            }

            _currentXp += xp;
            this.FixNextXpRequired(); // À mettre variable
            // TODO : Si le currentXp+ xp supérieur ou égal à xpRequired, alors, on appelle le lvlup correspondant.
        }

        private void FixNextXpRequired()
        {
            switch( this.currentLevel )
            {
                case 1:
                    _xpRequired = 50;
                    break;
                case 2:
                    _xpRequired = 100;
                    break;
                case 3:
                    _xpRequired = 250;
                    break;
                case 4:
                    _xpRequired = 600;
                    break;
                case 5:
                    _xpRequired = 1000;
                    break;
            }

        }
        private void IncreaseLevelSkill()
        {
            _currentLevel += 1;
        }
        public void IncreaseLevelCompany()
        {
            throw new NotImplementedException();
        }

		// TODO : intégrer directement à IncreaseLevelCompany
		private void AdjustValuesCompany( Company c )
		{
			if( this.CurrentLevel == 1 ) c.MaxEmployees = 10;
			c.MaxEmployees = 10 + ( 2 * ( this.CurrentLevel - 1 ) );

			if(this.CurrentLevel == 1) c.MaxProjectDifficulty = 0.5;
			if(this.CurrentLevel % 10 == 0) c.MaxProjectDifficulty += 0.5;
		}

		// TODO : intégrer directement à IncreaseLevelSkill
		private void AdjustValuesSkill()
		{
			this.CurrentLevel += 1;
		}
    }
}
