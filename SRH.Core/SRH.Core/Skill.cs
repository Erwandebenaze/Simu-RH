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
		private int _upgradePrice;
		private int _timeToUpgrade;
		protected int _basePriceToTrain;

        internal Skill( string skillName, int startLevel = 1 )
		{
			_level = new Level( this, startLevel );
			_skillName = skillName;
		}

		abstract public void FixPriceAndTime();

		#region Getters Setters
		public Level Level
		{
			get { return _level; }
		}
		public int UpgradePrice
		{
			get { return _upgradePrice; }
			protected set { _upgradePrice = value; }
		}
		public int TimeToUpgrade
		{
			get { return _timeToUpgrade; }
			protected set { _timeToUpgrade = value; }
		}

		public string SkillName
		{
			get { return _skillName; }
			set { _skillName = value; }
		}
		#endregion

		internal int BasePriceToTrain
		{
			get { return _basePriceToTrain; }
		} 

        public override bool Equals( object obj )
        {
            if( obj == null ) throw new ArgumentNullException("obj == null");
            Skill other = obj as Skill;
            if( other == null) throw new ArgumentException( "obj != skill" );
                
            return( this.SkillName == other.SkillName );

        }

        //public override int GetHashCode()
        //{
        //    return SkillNameEnglish.GetHashCode();
        //}
    }
}
