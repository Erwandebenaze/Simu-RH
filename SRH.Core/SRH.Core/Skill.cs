using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    [Serializable]
    public abstract class Skill
    {
		Person _person;
        Level _level;
        private string _skillName;
		private int _upgradePrice;
		private int _timeToUpgrade;
		static protected int _baseCostToTrain;
		protected int _baseTimeToTrain;

		internal Skill( Person p, string skillName, int startLevel = 1 )
		{
			_person = p;
			_level = new Level( this, startLevel );
			_skillName = skillName;
		}

        internal Skill( string skillName, int startLevel = 1 )
			:this( null, skillName, startLevel )
		{
		}

		abstract public void FixPriceAndTime();

		#region Getters Setters
		public Person Person
		{
			get { return _person; }
		}

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

		public int BaseCostToTrain
		{
			get { return _baseCostToTrain; }
		}

		public int BaseTimeToTrain
		{
			get { return _baseTimeToTrain; }
			set { _baseTimeToTrain = value; }
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
        //    return SkillName.GetHashCode();
        //}
    }
}
