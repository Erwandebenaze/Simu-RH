﻿using System;
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
        private bool _skill;

        public Level( Skill s )
        {
            // TODO : Trouver le moyen de savoir qui appelle le constructeur pour savoir si c'est la company ou une skill.
			_currentXp = 0;
            _currentLevel = 1;
            _skill = true;
            _xpRequired = FixNextXpRequired( _currentLevel);
        }

        public Level( MyCompany c )
        {
            // TODO : Trouver le moyen de savoir qui appelle le constructeur pour savoir si c'est la company ou une skill.
            _currentXp = 0;
            _currentLevel = 1;
            _skill = false;
			_xpRequired = FixNextXpRequired( _currentLevel );
        }
        public int CurrentXp
        {
            get { return _currentXp; }
        }
        public int XpRequired
        {
            get { return _xpRequired; }
        }
        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }

		public int LastXpRequired
		{
			get { return FixNextXpRequired( (_currentLevel - 1) ); }
		}

        public void IncreaseXp( int xp, MyCompany mc = null) 
        {
            #region Exceptions
            if( xp < 1 ) throw new ArgumentException( "Xp must be positive" );
            if( this._currentLevel == 2 && xp > 100 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 3 && xp > 250 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 4 && xp > 600 ) throw new ArgumentException( "Xp is too big for the level" );
            if( this._currentLevel == 5 && xp > 1000 ) throw new ArgumentException( "Xp is too big for the level" );
            #endregion
            if (xp + CurrentXp >= XpRequired)
			{
				this.IncreaseLevel( mc );
				_xpRequired = FixNextXpRequired( _currentLevel );
			}

			_currentXp += xp;
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

        private int FixNextXpRequired( int level)
        {
			int NextXpRequired = 0;

            if( _skill )
            {
                #region switch
                switch( level )
                {
                    case 1:
						NextXpRequired = 50;
                        break;
                    case 2:
						NextXpRequired = 100;
                        break;
                    case 3:
						NextXpRequired = 250;
                        break;
                    case 4:
						NextXpRequired = 600;
                        break;
                    case 5:
						NextXpRequired = 1000;
                        break;
                    default:
                        throw new InvalidOperationException("Skill can be only level 1 to 5");
                }
            }
                #endregion
            else if( !_skill )
            {
				if( level == 1 )
					NextXpRequired = 100;
				else
					NextXpRequired = ( 100 * ( level -1 ) ) * level;
					
            }

			return NextXpRequired;
        }
        private void IncreaseLevel( MyCompany mc = null)
        {
             if( !_skill )
             {
                mc.AdjustValuesCompany();
             }
			 _currentLevel += 1;
        }
    }
}
