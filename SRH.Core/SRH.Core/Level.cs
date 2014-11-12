using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class Level
    {
        int _currentXp;
        int _xpRequired;
        int _currentLevel;
        Skill _sk;
        MyCompany _mc;
        private bool _skill;

        public Level( Skill s )
        {
            // TODO : Trouver le moyen de savoir qui appelle le constructeur pour savoir si c'est la company ou une skill.
			_currentXp = 0;
            _currentLevel = 1;
            _sk = s;
            _skill = true;
            this.FixNextXpRequired();
        }

        public Level( MyCompany c )
        {
            // TODO : Trouver le moyen de savoir qui appelle le constructeur pour savoir si c'est la company ou une skill.
            _currentXp = 0;
            _currentLevel = 1;
            _mc = c;
            _skill = false;
            this.FixNextXpRequired();
        }

        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }

        public void IncreaseXp( int xp ) 
        {
            #region Exceptions
            if( xp < 1 ) throw new ArgumentException( "Xp must be positive" );
            if( this._currentLevel == 2 && xp > 100 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 3 && xp > 250 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 4 && xp > 600 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 5 && xp > 1000 ) throw new ArgumentException( "Xp is too big for the level" );
            #endregion
            if (xp + _currentXp >= _xpRequired)
                this.IncreaseLevel();

            _currentXp += xp;
            this.FixNextXpRequired(); 
        }

        //public void IncreaseXp<Company>( int xp )
        //{
        //    #region Exceptions
        //    if( xp < 1 ) throw new ArgumentException( "Xp must be positive" );
        //    if( this._currentLevel == 2 && xp > 100 ) throw new ArgumentException( "Xp is too big for the level" );
        //    if( this._currentLevel == 3 && xp > 250 ) throw new ArgumentException( "Xp is too big for the level" );
        //    if( this._currentLevel == 4 && xp > 600 ) throw new ArgumentException( "Xp is too big for the level" );
        //    if( this._currentLevel == 5 && xp > 1000 ) throw new ArgumentException( "Xp is too big for the level" );
        //    #endregion
        //    if( xp + _currentXp >= _xpRequired )
        //        this.IncreaseLevel();

        //    _currentXp += xp;
        //    this.FixNextXpRequired();
        //}

        private void FixNextXpRequired()
        {

            if( _skill )
            {
                #region switch
                switch( this.CurrentLevel )
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
                    default:
                        throw new InvalidOperationException("Skill can be only level 1 to 5");
                }
            }
                #endregion
            if( !_skill )
            {
                if (this._currentLevel == 1)
                    _xpRequired = 100;
                else 
                    _xpRequired *=2;
            }
        }
        private void IncreaseLevel()
        {
             if( !_skill )
             {
                _mc.AdjustValuesCompany();
             }
			 _currentLevel += 1;
        }

		// TODO : intégrer directement à IncreaseLevelCompany


    }
}
