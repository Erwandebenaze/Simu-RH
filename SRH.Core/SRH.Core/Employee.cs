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
		private DateTime? _trainingBegginingDate;
		private int? _trainingDuration;
        DateTime? _begginningCompanyWork;

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
        internal DateTime? BegginningCompanyWork
        {
            get { return (DateTime)_begginningCompanyWork; }
            set { _begginningCompanyWork = value; }
        }
		public string SkillInTraining
		{
			get { return _skillInTraining; }
		}

		public int TrainingDuration
		{
			get { return _trainingDuration.Value; }
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

		public int LayingOffCost
		{
			get
			{
				double cost = Salary * 0.5;
				return (int)cost;
			}
		}
		#endregion

		internal int GenerateSalary()
		{
			int salary = _worker.ExpectedSalary;
			salary += _salaryAdjustment;
			if( salary < 600 )
				throw new InvalidOperationException( "An Employee's salary cannot be under 600€, check SalaryAdjustment." );

			return salary;
		}

		/// <summary>
		/// Adds a Skill if the Employee doesn't have it, or increases it by 1 level.
		/// </summary>
		/// <param name="skillName"></param>
		/// <returns>False if the Company has inadequate wealth</returns>
		public void Train( string skillName )
		{
			// Check if skillName is valid
			_comp.Game.ValidateSkillName( skillName );
			Skill candidate = _comp.Game.GetSkillCandidate( skillName );

			Skill skillToTrain = _worker.Skills.Where( s => s.SkillName == skillName ).SingleOrDefault();

			if( skillToTrain == null )
			{
				Skill newSkill = _worker.AddSkill( _worker, skillName );
			}
			else
			{
				int xpToNextLevel = skillToTrain.Level.NextXpRequired - skillToTrain.Level.CurrentXp;
				skillToTrain.Level.IncreaseXp( xpToNextLevel );
                
			}

			_skillInTraining = null;
			_busy = false;
		}

		/// <summary>
		/// Checks if Employee in training is finished, if he is, the skill is added/upgraded
		/// </summary>
		/// <returns>The time left</returns>
		public int UpdateEmployeeTraining()
		{
			if( _comp.Game.TimeGame.intervalOfTimeInDays( _trainingBegginingDate ) == _trainingDuration )
			{
				Train( _skillInTraining );
			}

			int timeLeft = _trainingDuration.Value - _comp.Game.TimeGame.intervalOfTimeInDays( _trainingBegginingDate );
			return timeLeft;
		}

		public bool StartTraining( string skillName )
		{
			_skillInTraining = skillName;
			_trainingBegginingDate = _comp.Game.TimeGame.CurrentTimeOfGame;

			// Set a candidate skill to test
			Skill candidate = _comp.Game.GetSkillCandidate( skillName );
			
			Skill skillToTrain = _worker.Skills.Where( s => s.SkillName == skillName ).SingleOrDefault();

			if( skillToTrain == null )
			{
				if( _comp.Wealth >= candidate.BaseCostToTrain )
				{
					_trainingDuration = candidate.BaseTimeToTrain;
					_comp.Wealth -= candidate.BaseCostToTrain;
                    _comp.Game.PlayerCompany.AddTrainingCost( candidate.BaseCostToTrain );
					_busy = true;
					return true;
				}
				else
					return false;
			}
			else
			{
				if( _comp.Wealth >= skillToTrain.UpgradePrice )
				{
					_trainingDuration = skillToTrain.TimeToUpgrade;
					_comp.Wealth -= skillToTrain.UpgradePrice;
                    _comp.Game.PlayerCompany.AddTrainingCost( skillToTrain.UpgradePrice );

					_busy = true;
					return true;
				}
				else
					return false;
			}
		}

		public void CancelTraining()
		{
			_busy = false;
			_skillInTraining = null;
			_trainingDuration = null;
			_trainingBegginingDate = null;
		}
	}
}
