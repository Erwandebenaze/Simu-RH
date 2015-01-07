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
		DateTime _lastDateSkillsUsedCheck;
		DateTime _lastDateSkillsReactionCheck;

		internal Behavior( Employee e )
		{
			_employee = e;
			_skillsUsed = new Dictionary<string, DateTime>();
		}


		#region Getters Setters
		public Dictionary<string, DateTime> SkillsUsed
		{
			get { return _skillsUsed; }
		}

		public DateTime LastDateSkillsUsedCheck
		{
			get { return _lastDateSkillsUsedCheck; }
			set { _lastDateSkillsUsedCheck = value; }
		}

		public DateTime LastDateSkillsReactionCheck
		{
			get { return _lastDateSkillsReactionCheck; }
			set { _lastDateSkillsReactionCheck = value; }
		}
		#endregion

		public void AddOrUpdateSkillsUsed( string s )
		{
			_skillsUsed.Remove( s );
			_skillsUsed.Add( s, _employee.Comp.Game.TimeGame.CurrentTimeOfGame );
		}

		private void AddOrUpdateManagersSkillsUsed()
		{
			if( _employee.SkillAffectedToCompany != null )
				AddOrUpdateSkillsUsed( _employee.SkillAffectedToCompany.SkillName );
		}

		public void CheckSkillsUsed()
		{
			List<string> flagged = new List<string>();
			foreach( KeyValuePair<string, DateTime> kvp in _skillsUsed )
			{
				if( _employee.Comp.Game.TimeGame.AreMonthsPassed( kvp.Value, 6 ) )
					flagged.Add( kvp.Key );
			}
			foreach( string s in flagged )
			{
				_skillsUsed.Remove( s );
			}

			AddOrUpdateManagersSkillsUsed();
			_lastDateSkillsUsedCheck = _employee.Comp.Game.TimeGame.CurrentTimeOfGame;
		}

		public void SalaryReaction()
		{
			// 1 point every 5% above the expected Salary, -1 every 5% under
			int happinessAdjustment = (int)( _employee.SalaryAdjustment / ( _employee.Worker.ExpectedSalary * 0.05 ) );
			_employee.Happiness.ChangeHappinessScore( happinessAdjustment );
		}

		public void SkillsReaction()
		{
			// Checks only every 3 months
			if( _employee.Comp.Game.TimeGame.AreMonthsPassed( _lastDateSkillsReactionCheck, 3 ) )
			{
				if( _employee.Worker.Skills.Count < 4 )
					_employee.Happiness.ChangeHappinessScore( -2 );
				else if( _skillsUsed.Count < 3 )
					_employee.Happiness.ChangeHappinessScore( -2 );
				else if( _skillsUsed.Count > 3 )
					_employee.Happiness.ChangeHappinessScore( 2 );

				_lastDateSkillsReactionCheck = _employee.Comp.Game.TimeGame.CurrentTimeOfGame;
			}
		}

	}
}
