using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    [Serializable]
    public abstract class Skill
    {
        Level _level;
		private string _skillName;
        protected int _upgradePrice;
        protected int _timeToUpgrade;

        internal Skill( string skillName, int startLevel = 1 )
		{
			_level = new Level( this );
			_skillName = skillName;
			_level.CurrentLevel = startLevel;
		}

        public Level Level
        {
            get { return _level;}
        }
		public string SkillNameString
		{
			get { return _skillName; }
		}
    }
}
