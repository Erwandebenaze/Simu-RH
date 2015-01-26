using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	[Serializable]
	//TODO : make the class abstract and add 3 sub-classes of different behaviors
	public class Behavior
	{
		Person _person;
		Dictionary<string, DateTime> _skillsUsed;
		DateTime _lastDateSkillsReactionCheck;
		DateTime _lastDateSalaryReactionCheck;


		internal Behavior( Person p )
		{
            _person = p;
			_skillsUsed = new Dictionary<string, DateTime>();
            _lastDateSkillsReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
            _lastDateSalaryReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
		}


		#region Getters Setters
		public Dictionary<string, DateTime> SkillsUsed
		{
			get { return _skillsUsed; }
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

		internal void SkillsReaction()
		{
			// Checks only every 3 months
            if( _person.Lb.Game.TimeGame.AreMonthsPassed( _lastDateSkillsReactionCheck, 3 ) )
			{
				//If the employee has less than 4 skills, he wants to train more
                if( _person.Employee.Worker.Skills.Count < 4 ) 
				{
                    if( _person.Employee.SkillInTraining == null )
                        _person.Employee.Happiness.ChangeHappinessScore( -2 );
				}
				else if( _skillsUsed.Count < 3 )
                    _person.Employee.Happiness.ChangeHappinessScore( -2 );
				else if( _skillsUsed.Count > 3 )
                    _person.Employee.Happiness.ChangeHappinessScore( 2 );

                _lastDateSkillsReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
			}
		}

		public void UpdateHappiness()
		{
			AddOrUpdateEmployeeSkillInUse();
			CheckSkillsUsed();
			SalaryReaction();
			SkillsReaction();
		}

	}
}
