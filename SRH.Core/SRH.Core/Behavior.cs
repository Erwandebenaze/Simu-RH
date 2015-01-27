using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	[Serializable]
	//TODO : make the class abstract and add 3 sub-classes of different behaviors
	public abstract class Behavior
	{
		protected Person _person;
        protected Dictionary<string, DateTime> _skillsUsed;
        protected DateTime _lastDateSkillsReactionCheck;
        protected DateTime _lastDateSalaryReactionCheck;


		protected Behavior( Person p )
		{
            _person = p;
			_skillsUsed = new Dictionary<string, DateTime>();
		}


		#region Getters Setters
		public Dictionary<string, DateTime> SkillsUsed
		{
			get { return _skillsUsed; }
		}

        internal DateTime LastDateSkillsReactionCheck
        {
            set { _lastDateSkillsReactionCheck = value; }
        }
		#endregion

		internal void AddOrUpdateSkillsUsed( string s )
		{
			_skillsUsed.Remove( s );
            _skillsUsed.Add( s, _person.Lb.Game.TimeGame.CurrentTimeOfGame );
		}

		private void AddOrUpdateEmployeeSkillInUse()
		{
			// Puts the skill in project in the SkillsUsed list
            if( _person.Employee.SkillInProject != null )
                AddOrUpdateSkillsUsed( _person.Employee.SkillInProject.SkillName );
			// Puts the compaSkill affected in the SkillsUsed list
            if( _person.Employee.SkillAffectedToCompany != null )
                AddOrUpdateSkillsUsed( _person.Employee.SkillAffectedToCompany.SkillName );
			// Puts the skill in training in the SkillsUsed list
            if( _person.Employee.SkillInTraining != null )
                AddOrUpdateSkillsUsed( _person.Employee.SkillInTraining );
		}

		internal void CheckSkillsUsed()
		{
			List<string> flagged = new List<string>();
			foreach( KeyValuePair<string, DateTime> kvp in _skillsUsed )
			{
                if( _person.Lb.Game.TimeGame.AreMonthsPassed( kvp.Value, 12 ) )
					flagged.Add( kvp.Key );
			}		
			foreach( string s in flagged )
			{
				_skillsUsed.Remove( s );
			}
		}

		internal void SalaryReaction()
		{
			// Checks only every month
            if( _person.Lb.Game.TimeGame.AreMonthsPassed( _lastDateSalaryReactionCheck, 1 ) )
			{
				// 1 point every 5% above the expected Salary, -1 every 5% under
                int happinessAdjustment = (int)( _person.Employee.SalaryAdjustment / ( _person.Employee.Worker.ExpectedSalary * 0.05 ) );
                _person.Employee.Happiness.ChangeHappinessScore( happinessAdjustment );

                _lastDateSalaryReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
			}
		}

        internal abstract void SkillsReaction();

        public void UpdateHappiness()
		{
			AddOrUpdateEmployeeSkillInUse();
			CheckSkillsUsed();
			SalaryReaction();
			SkillsReaction();
		}

	}
}
