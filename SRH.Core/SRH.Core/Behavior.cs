using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	//TODO : make the class abstract and add 3 sub-classes of different behaviors
	public class Behavior
	{
		Employee _employee;
		Dictionary<Skill, DateTime> _skillsUsed;
		DateTime _lastDateSkillsUsedCheck;
		DateTime _lastDateSkillsReactionCheck;

		internal Behavior( Employee e )
		{
			_employee = e;
			_skillsUsed = new Dictionary<Skill, DateTime>();
		}

		#region Getters Setters
		public Dictionary<Skill, DateTime> SkillsUsed
		{
			get { return _skillsUsed; }
			set { _skillsUsed = value; }
		}  
		#endregion

		public void AddOrUpdateSkillUsed( Skill s )
		{
			_skillsUsed.Remove( s );
			_skillsUsed.Add( s, _employee.Comp.Game.TimeGame.CurrentTimeOfGame );
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

			}
		}

	}
}
