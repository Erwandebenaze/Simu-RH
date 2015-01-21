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
		Employee _employee;
		Dictionary<string, DateTime> _skillsUsed;
		DateTime _lastDateSkillsReactionCheck;
		DateTime _lastDateSalaryReactionCheck;


		internal Behavior( Employee e )
		{
			_employee = e;
			_skillsUsed = new Dictionary<string, DateTime>();
			_lastDateSkillsReactionCheck = _employee.Comp.Game.TimeGame.CurrentTimeOfGame;
			_lastDateSalaryReactionCheck = _employee.Comp.Game.TimeGame.CurrentTimeOfGame;
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
			_skillsUsed.Add( s, _employee.Comp.Game.TimeGame.CurrentTimeOfGame );
		}

		private void AddOrUpdateEmployeeSkillInUse()
		{
			// Puts the skill in project in the SkillsUsed list
			if( _employee.SkillInProject != null )
				AddOrUpdateSkillsUsed( _employee.SkillInProject.SkillName );
			// Puts the compaSkill affected in the SkillsUsed list
			if( _employee.SkillAffectedToCompany != null )
				AddOrUpdateSkillsUsed( _employee.SkillAffectedToCompany.SkillName );
			// Puts the skill in training in the SkillsUsed list
			if( _employee.SkillInTraining != null )
				AddOrUpdateSkillsUsed( _employee.SkillInTraining );
		}

		internal void CheckSkillsUsed()
		{
			List<string> flagged = new List<string>();
			foreach( KeyValuePair<string, DateTime> kvp in _skillsUsed )
			{
				if( _employee.Comp.Game.TimeGame.AreMonthsPassed( kvp.Value, 12 ) )
					flagged.Add( kvp.Key );
			}		
			foreach( string s in flagged )
			{
				_skillsUsed.Remove( s );
			}
		}

		internal void SalaryReaction()
		{
			// Checks only every 3 months
			if( _employee.Comp.Game.TimeGame.AreMonthsPassed( _lastDateSalaryReactionCheck, 1 ) )
			{
				// 1 point every 5% above the expected Salary, -1 every 5% under
				int happinessAdjustment = (int)( _employee.SalaryAdjustment / ( _employee.Worker.ExpectedSalary * 0.05 ) );
				_employee.Happiness.ChangeHappinessScore( happinessAdjustment );



				_lastDateSalaryReactionCheck = _employee.Comp.Game.TimeGame.CurrentTimeOfGame;
			}
		}

		internal void SkillsReaction()
		{
			// Checks only every 3 months
			if( _employee.Comp.Game.TimeGame.AreMonthsPassed( _lastDateSkillsReactionCheck, 3 ) )
			{
				//If the employee has less than 4 skills, he wants to train more
				if( _employee.Worker.Skills.Count < 4 ) 
				{
					if( _employee.SkillInTraining == null )
						_employee.Happiness.ChangeHappinessScore( -2 );
				}
				else if( _skillsUsed.Count < 3 )
					_employee.Happiness.ChangeHappinessScore( -2 );
				else if( _skillsUsed.Count > 3 )
					_employee.Happiness.ChangeHappinessScore( 2 );

				_lastDateSkillsReactionCheck = _employee.Comp.Game.TimeGame.CurrentTimeOfGame;
			}
		}

		public void UpdateHappiness()
		{
			AddOrUpdateEmployeeSkillInUse();
			CheckSkillsUsed();
			SalaryReaction();
			SkillsReaction();
		}


		internal void HandleSickEmployees()
		{

		}

	}
}
