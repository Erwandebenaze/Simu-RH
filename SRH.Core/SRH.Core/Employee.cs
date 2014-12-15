using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    [Serializable]
    public class Employee
    {
		private Person _worker;
        private readonly Company _comp;
		private int _salary;
		private int _salaryAdjustment;
        private bool _busy;
		private Skill _skillAffectedToCompany;
		private string _skillInTraining;
		private DateTime _traininigBegginingDate;
		private int _trainingDuration;

        /// <summary>
		/// Creates an <see cref="Employee"/>
        /// </summary>
        /// <param name="name"></param>
		/// <param name="firstName"></param>
		/// <param name="age">Cannot inferior to 18 or superiror to 62</param>
        internal Employee(Company comp, Person worker )
        {
            if( comp == null ) throw new ArgumentNullException( "Company is null" );
            if( worker == null ) throw new ArgumentNullException( "worker is null" );

            _busy = false;
            _comp = comp;
			_worker = worker;
			_salary = GenerateSalary();
        }

		#region Getters setters
		public Person Worker
		{
			get { return _worker; }
		}
        public bool Busy
        {
            get { return _busy; }
            internal set { _busy = value; }
        }
        public Company Comp
        {
            get { return _comp; }
        }

		public Skill SkillAffectedToCompany
		{
			get { return _skillAffectedToCompany; }
			set { _skillAffectedToCompany = value; }
		}

		public string SkillInTraining
		{
			get { return _skillInTraining; }
			set { _skillInTraining = value; }
		}

		public DateTime TraininigBegginingDate
		{
			get { return _traininigBegginingDate; }
			set { _traininigBegginingDate = value; }
		}

		public int TrainingDuration
		{
			get { return _trainingDuration; }
			set { _trainingDuration = value; }
		}

		public int Salary
		{
			get { return GenerateSalary(); }
		}

		public int SalaryAdjustment
		{
			get { return _salaryAdjustment; }
			set { _salaryAdjustment = value; }
		}
		#endregion

		internal int GenerateSalary()
		{
			int salary = _worker.ExpectedSalary;
			salary += _salaryAdjustment;

			return salary;
		}

		/// <summary>
		/// Adds a Skill if the Employee doesn't have it, or increases it by 1 level.
		/// </summary>
		/// <param name="skillName"></param>
		/// <returns>False if the Company has inadequate wealth</returns>
		public bool Train( string skillName )
		{
			// Check if skillName is valid
			_comp.Game.ValidateSkillName( skillName );

			// Set a candidate skill to test
			Skill candidate = null;
			if( skillName.IsProjSkill() ) candidate = new ProjSkill( skillName );
			else candidate = new CompaSkill( skillName );

			if( _worker.Skills.Contains( candidate ) )
			{
				Skill skillToTrain = _worker.Skills.Where( s => s.SkillName == skillName ).Single();
				int xpToNextLevel = skillToTrain.Level.NextXpRequired - skillToTrain.Level.CurrentXp;
				skillToTrain.Level.IncreaseXp( xpToNextLevel );
				_comp.Wealth -= skillToTrain.UpgradePrice;

				_skillInTraining = null;
				_busy = false;
				_worker.GenerateExpectedSalary();
				return true;
			}
			else
			{
				Skill newSkill = _worker.AddSkill( skillName );
				_busy = false;
				_worker.GenerateExpectedSalary();
				return true;
			}
		}

		/// <summary>
		/// Checks if Employee in training is finished, if he is, the skill is added/upgraded
		/// </summary>
		/// <returns>The time left </returns>
		public int UpdateEmployeeTraining()
		{
			if( _comp.Game.TimeGame.intervalOfTimeInDays( _traininigBegginingDate ) == _trainingDuration )
			{
				Train( _skillInTraining );
			}

			int timeLeft = _trainingDuration - _comp.Game.TimeGame.intervalOfTimeInDays( _traininigBegginingDate );
			return timeLeft;
		}

		public bool StartTraining( string skillName )
		{
			_skillInTraining = skillName;
			_traininigBegginingDate = _comp.Game.TimeGame.CurrentTimeOfGame;

			// Set a candidate skill to test
			Skill candidate = null;
			if( skillName.IsProjSkill() ) candidate = new ProjSkill( skillName );
			else candidate = new CompaSkill( skillName );
			
			Skill currentSkill = _worker.Skills.Where( s => s.SkillName == skillName ).SingleOrDefault();

			if( currentSkill == null )
			{
				if( _comp.Wealth >= candidate.BaseCostToTrain )
				{
					_trainingDuration = candidate.BaseTimeToTrain;
					_comp.Wealth -= candidate.BaseCostToTrain;
					_busy = true;
					return true;
				}
				else
					return false;
			}
			else
			{
				if( _comp.Wealth >= currentSkill.BaseCostToTrain )
				{
					_trainingDuration = currentSkill.TimeToUpgrade;
					_comp.Wealth -= currentSkill.BaseCostToTrain;
					_busy = true;
					return true;
				}
				else
					return false;
			}
		}
    }
}
