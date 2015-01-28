using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
	public class MyCompany : Company
	{
        List<Project> _possibleCompanyProjects;
        readonly List<Project> _projects;
        double _maxProjectDifficulty;
        readonly Level _companyLevel;
        Dictionary<Employee, Skill> _managers;
        List<Employee> _commerciaux;
        List<Employee> _animation;
        List<Employee> _ressourcesHumaines;
        List<Employee> _directeursProjets;
        List<Employee> _recruteur;
        double _pourcentCommerciaux = 0;
        double _decreaseRecruting = 0;
        double _decreaseSalary = 0;
        double _decreaseTasks = 0;
        double _increaseHappiness = 0;
        int _trainingCost = 0;
        int _trainingCostYear = 0;
        int _layingOffCost = 0;
        int _layingOffCostYear = 0;
        int _recrutingCost = 0;
        int _recrutingCostYear = 0;
        int _projectsEarnings = 0;
        int _projectsEarningsYear = 0;
        RandomGenerator _random;
        DateTime _lastUpdateHappiness = new DateTime( 2015, 1, 1 );


		internal MyCompany( Game game, string name ) : base( game, name )
        {
			if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "The company name cannot be null or a whitespace" );
            _wealth = 1000000;
            _maxWealth = _wealth;
			_companyLevel = new Level( this, 1 );
			_maxProjectDifficulty = 1;
            _projects = new List<Project>();
            _managers = new Dictionary<Employee,Skill>();
            _commerciaux = new List<Employee>();
            _animation = new List<Employee>();
            _ressourcesHumaines = new List<Employee>();
            _directeursProjets = new List<Employee>();
            _recruteur = new List<Employee>();
            _random = game.GetRandomGenerator();
        }

        #region Getters Setters

        public Game MyGame
        {
            get { return _myGame; }
        }
        public Dictionary<Employee, Skill> Managers
        {
			get { return _managers; }
        }
        public List<Project> Projects
        {
            get { return _projects; }
        }

        public Level CompanyLevel
        {
            get { return _companyLevel; }
        }
        public double MaxProjectDifficulty
        {
            get { return _maxProjectDifficulty; }
        }
        public List<Project> PossibleCompanyProjects
        {
            get 
			{
				_possibleCompanyProjects = GetPossibleCompanyProjects();
				return _possibleCompanyProjects;
			}
        }
        internal int TrainingCost
        {
            get { return _trainingCost; }
            set { _trainingCost = value; }
        }

        internal int RecrutingCost
        {
             get { return _recrutingCost; }
        }

        internal int LayingOffCost
        {
             get { return _layingOffCost; }
        }
        internal int ProjectsEarnings
        {
             get { return _projectsEarnings; }
        }
        internal List<Employee> Commerciaux
        {
            get { return _commerciaux; }
        }
        internal List<Employee> Animation
        {
            get { return _animation; }
        }
        internal List<Employee> RessourcesHumaines
        {
            get { return _ressourcesHumaines; }
        }
        internal double DecreaseSalary
        {
            get { return SwitchRessourcesHumaines( _decreaseSalary ); }
        }
        internal List<Employee> DirecteursProjets
        {
            get { return _directeursProjets; }
        }
        internal List<Employee> Recruteur
        {
            get { return _recruteur; }
        }
        #endregion
        public void MoveProject( Project p )
        {
            if (p.Activated)  
                _projects.Add( p );
            else 
                _projects.Remove( p );
        }

		/// <summary>
		/// Adjust the number of <see cref="MaxEmployees"/> and the <see cref="MaxDifficulty"/> of <see cref="MyCompany"/> depending on its <see cref="Level"/>
		/// </summary>
        public void AdjustValuesCompany()
        {
			if( this.CompanyLevel.CurrentLevel == 1 ) _maxEmployees = 10;
            _maxEmployees = 10 + (2 * (this.CompanyLevel.CurrentLevel));

			if( this.CompanyLevel.CurrentLevel == 1 ) _maxProjectDifficulty = 1.0;
			if( ( this.CompanyLevel.CurrentLevel +1 ) % 5 == 0 ) _maxProjectDifficulty += 0.5;
        }

        /// <summary>
        ///  Check if the interval of days equals the duration of every projects. If a project is over, call the EndAProject function.
        ///  If the project isn't over, it up to date the TimeLeft variable.
        /// </summary>
        public void EndProjectIfItsFinish()
        {
            if (_projects.Count > 0 )
            {
                foreach (Project p in _projects)
                {
                    p.RefreshActualsTasks();
                    if( p.ActualTasks > 0 )
                    {
                        //p.TimeSpent = _myGame.TimeGame.intervalOfTimeInDays( p.BegginingDate );
                        p.RefreshDuration();
                        p.TimeLeft = p.Duration;
                        if( p.TimeLeft < 0 ) p.TimeLeft = 0;
                        
                    } else
                    {
                        EndAProject( p );
                        p.TimeLeft = 0;
                        MoveProject( p );
                        break;
                    }
                }
            }
        }
        internal void AddTrainingCost( int cost )
        {
            if( cost <= 0 ) throw new ArgumentException( "Cost must be superior than 0." );
            _trainingCost += cost;
            _trainingCostYear += cost;
        }
        internal void AddRecrutingCost( int cost )
        {
            if( cost <= 0 ) throw new ArgumentException( "Cost must be superior than 0." );
            _recrutingCost += cost;
            _recrutingCostYear += cost;
        }
        internal void AddLayingOffCost( int cost )
        {
            if( cost <= 0 ) throw new ArgumentException( "Cost must be superior than 0." );
            _layingOffCost += cost;
            _layingOffCostYear += cost;
        }
        internal void AddProjectEarnings( int earnings )
        {
            if( earnings <= 0 ) throw new ArgumentException( "Earnings must be superior than 0." );
            _projectsEarnings += earnings;
            _projectsEarningsYear += earnings;
        }
        public int GetTrainingCostMonth()
        {
            if( _myGame.TimeGame.NextDayIsNewMonth() )
            {
                _trainingCost = 0;
            }
            return _trainingCost;
        }
        public int GetTrainingCostYear()
        {
            if( _myGame.TimeGame.NextDayIsNewYear() )
            {
                _trainingCostYear = 0;
            }
            return _trainingCostYear;
        }
        public int GetRecrutingCostMonth()
        {
            if( _myGame.TimeGame.NextDayIsNewMonth() )
            {
                _recrutingCost = 0;
            }
            return _recrutingCost;
        }
        public int GetRecrutingCostYear()
        {
            if( _myGame.TimeGame.NextDayIsNewYear() )
            {
                _recrutingCostYear = 0;
            }
            return _recrutingCostYear;
        }
        public int GetLayingOffCostMonth()
        {
            if( _myGame.TimeGame.NextDayIsNewMonth() )
            {
                _layingOffCost = 0;
            }
            return _layingOffCost;
        }
        public int GetLayingOffCostYear()
        {
            if( _myGame.TimeGame.NextDayIsNewYear() )
            {
                _layingOffCostYear = 0;
            }
            return _layingOffCostYear;
        }
        public int GetProjectsEarningsMonth()
        {
            if( _myGame.TimeGame.NextDayIsNewMonth() )
            {
                _projectsEarnings = 0;
            }
            return _projectsEarnings;
        }
        public int GetProjectsEarningsYear()
        {
            if( _myGame.TimeGame.NextDayIsNewYear() )
            {
                _projectsEarningsYear = 0;
            }
            return _projectsEarningsYear;
        }
        public void ApplyInterests()
        {
            _wealth -= GetInterest();
            
        }
        public int GetInterest()
        {
            int interest = 0;
            if( _wealth < 0 )
            {
                interest = (int)(-(_wealth * (5 / 100)));
            }
            
            return interest;
        }
        public int GetCharges()
        {
            if( this.Employees.Count == 0 )
                return 250;
            else
            {
                return 500 * this.Employees.Count;
            }
        }

        public void ApplyCharges()
        {
            _wealth -= GetCharges();

        }
        /// <summary>
        /// End a project and give the earnings. XP/Person, XP/Company and earnings. Free the employees of the project.
        /// </summary>
        /// <param name="p"></param>
        public void EndAProject( Project p )
        {
            p.StopProject();
            AddPourcentCommerciaux( p );
            Wealth += p.Earnings;
            AddProjectEarnings( p.Earnings );
            _companyLevel.IncreaseXp( p.XpPerCompany, this );
            foreach( KeyValuePair<Employee, Skill> dico in p.EmployeesAffectedWithSkill )
            {
                dico.Value.Level.IncreaseXp( p.XpPerPerson );
                dico.Key.Busy = false;
				dico.Key.SkillInProject = null;
            }
        }
        /// <summary>
        /// Begin a project
        /// </summary>
        /// <param name="p"></param>
        public void BeginAProject( Project p )
        {
            //_possibleCompanyProjects.Remove( p );
            _projects.Add( p );
            p.BeginProject();
        }

        /// <summary>
        /// Stop a project. Free the employees of the project
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Project StopAProject( Project p )
        {
            //_possibleCompanyProjects.Add( p );
            foreach( Employee e in p.EmployeesAffectedWithSkill.Keys )
            {
                e.Busy = false;
				e.SkillInProject = null;
            }
            _projects.Remove( p );
            p.StopProject();
            return p;
        }

        /// <summary>
        /// Get the list of possible project of the company
        /// </summary>
        /// <returns>The List of project available for the company</returns>
		List<Project> GetPossibleCompanyProjects()
		{
			List<Project> possible = (List<Project>)_myGame.PossibleProjects;
			List<Project> finalList = new List<Project>();
			foreach( Project p in possible )
			{
				if( p.Difficulty <= _maxProjectDifficulty ) finalList.Add( p ); 
			}

			return finalList;
		}

        /// <summary>
        /// Randomly sends employee's to vacation or sick leave and updates the status of employees that are in vacation or sick
        /// </summary>
		public void UpdateEmployeesAbsence()
		{
            foreach( Employee e in _employees )
            {
                _random.EmployeeGetsSick(e);
                _random.EmployeeGoesInVacation(e);
                if( e.IsSick.Value != 0 )
                {
                    e.UpdateSickStatus();
					if( !e.Busy )
						ReaffectEmployeeToProject( e );
                }
                if( e.InVacation.Value != 0 )
                {
                    e.UpdateVacationStatus();
					if( !e.Busy )
						ReaffectEmployeeToProject( e );
                }
            }

		}

		/// <summary>
		/// Checks if an employee's project is over or not, if it is no, the employee is reaffected to it
		/// </summary>
		/// <param name="e"> The employee to reaffect </param>
		private void ReaffectEmployeeToProject( Employee e )
		{
			if( e.Project != null && e.Project.Activated )
			{
                e.Busy = true;
				e.Project.AffectEmployeeToAJob( e, e.SkillInProject );
			}
		}

		public void ResetVacationDays()
		{
			if( _game.TimeGame.NextDayIsNewYear() )
			{
				foreach( Employee e in _employees )
				{
					e.VacationDays = 30;
				}
			}
		}

        #region Gestion des managers
        /// <summary>
        /// Affect the differents managers to their own task.
        /// </summary>
        public void AffectManagers()
        {
            _commerciaux.Clear();
            _animation.Clear();
            _recruteur.Clear();
            _directeursProjets.Clear();
            _ressourcesHumaines.Clear();
            if( _managers.Count != 0 )
            {
                foreach( KeyValuePair<Employee, Skill> dico in _managers )
                {
                    if( dico.Value.SkillName == "Commercial" ) _commerciaux.Add( dico.Key );
                    if( dico.Value.SkillName == "Animation" ) _animation.Add( dico.Key );
                    if( dico.Value.SkillName == "Recruteur" ) _recruteur.Add( dico.Key );
                    if( dico.Value.SkillName == "Directeur de projets" ) _directeursProjets.Add( dico.Key );
                    if( dico.Value.SkillName == "Ressources humaines" ) _ressourcesHumaines.Add( dico.Key );
                }
            }
        }
        public void AddManager( Employee e, Skill s )
        {
            _managers.Add( e, s );
            e.SkillAffectedToCompany = s;
            e.Busy = true;
            e.BegginningCompanyWork = Game.TimeGame.CurrentTimeOfGame;
            AffectManagers();
            UseManagers();
        }
        public void RemoveManager( Employee e )
        {
            if( _managers.ContainsKey( e ) )
            {
                _managers.Remove( e );
                e.Busy = false;
                e.BegginningCompanyWork = null;
                e.SkillAffectedToCompany = null;
                DesaffectManager( e );
            }
            else
                throw new ArgumentException( "You cannot remove a manager that is not in the Dictionnary." );
        }

        private void DesaffectManager( Employee e )
        {
            AffectManagers();
            UseManagers();
        }

        /// <summary>
        /// Use the different skill of the managers.
        /// </summary>
        private void UseManagers()
        {
            double newPourcentCommerciaux = 0;
            double newDecreaseRecruting = 0;
            double newDecreaseSalary = 0;
            double newDecreaseTasks = 0;
            double newIncreaseHappiness = 0;

            #region Commerciaux
            if( _commerciaux.Count > 0 )
            {
                // Commerciaux increase the earnings of projects.
                foreach( Employee emp in _commerciaux )
                {
                    newPourcentCommerciaux += (emp.Worker.Skills.Where( e => e.SkillName == "Commercial" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }
                if( _pourcentCommerciaux != SwitchCommerciaux( newPourcentCommerciaux ) )
                {
                    _pourcentCommerciaux = SwitchCommerciaux( newPourcentCommerciaux );
                }

            }
            #endregion

            #region Ressources humaines
            if( _ressourcesHumaines.Count > 0 )
            {
                // Ressources humaines, descrease the salary of employees.
                foreach( Employee emp in _ressourcesHumaines )
                {
                    newDecreaseSalary += (emp.Worker.Skills.Where( e => e.SkillName == "Ressources humaines" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }

                if( _decreaseSalary != SwitchRessourcesHumaines( newDecreaseSalary ) )
                {
                    _decreaseSalary = SwitchRessourcesHumaines( newDecreaseSalary );
                    foreach( Employee emp in _employees )
                    {
                        UseRessourcesHumaines( emp );
                    }
                }
            } else if (_ressourcesHumaines.Count == 0 )
            {
                _decreaseSalary = 1;
                foreach( Employee emp in _employees )
                {
                    UseRessourcesHumaines( emp );
                }

            }
            #endregion

            if( _directeursProjets.Count > 0 )
            {
                // Directeur de projets decrease the number of tasks of the projects.
                foreach( Employee emp in _directeursProjets )
                {
                    newDecreaseTasks += (emp.Worker.Skills.Where( e => e.SkillName == "Directeur de projets" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }

                if( _decreaseTasks != SwitchDirecteursProjets( newDecreaseTasks ) )
                {
                    _decreaseTasks = SwitchDirecteursProjets( newDecreaseTasks );
                    UseDirecteursProjets();
                }
            }
            else if( _directeursProjets.Count == 0 )
            {
                _decreaseTasks = 1;
                UseDirecteursProjets();
                
            }

            if( _recruteur.Count > 0 )
            {
                // Recruteur decrease the cost of hiring and laying off.
                foreach( Employee emp in _recruteur )
                {
                    newDecreaseRecruting += (emp.Worker.Skills.Where( e => e.SkillName == "Recruteur" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }

                if( _decreaseRecruting != SwitchRecruteur( newDecreaseRecruting ) )
                {
                    _decreaseRecruting = SwitchRecruteur( newDecreaseRecruting );
                }
            }
            else if( _recruteur.Count == 0 )
                _decreaseRecruting = 1;

            if( _animation.Count > 0 )
            {
                // Animation increase the happiness of the employees.
                foreach( Employee emp in _animation )
                {
                    newIncreaseHappiness += (emp.Worker.Skills.Where( e => e.SkillName == "Animation" ).Select( e => e.Level.CurrentLevel ).Single());
                }

                if( newIncreaseHappiness != _increaseHappiness )
                {
                    _increaseHappiness = SwitchAnimateur( newIncreaseHappiness );
                    UseAnimateurs();
                    
                }
            }

        }

        

        internal void UseAnimateurs()
        {
            if( MyGame.TimeGame.AreMonthsPassed( _lastUpdateHappiness, 3 ) )
            {
                foreach( Employee emp in _employees )
                {
                    emp.Happiness.ChangeHappinessScore( (int)_increaseHappiness );
                }
                _lastUpdateHappiness = MyGame.TimeGame.CurrentTimeOfGame;
            }

        }
        private void UseDirecteursProjets()
        {
            foreach( Project p in PossibleCompanyProjects )
            {
                p.ProjectTasks -= (int)(p.ProjectTasks * (_decreaseTasks / 100));
            }

        }
        internal void UseRessourcesHumaines( Employee emp )
        {
            _decreaseSalary = SwitchRessourcesHumaines( _decreaseSalary );
            emp.Worker.GenerateExpectedSalary();
        }
        private double SwitchAnimateur( double increaseHappiness )
        {
            switch( _employees.Count / 10 )
            {
                case 0:
                    if( increaseHappiness > 2 ) increaseHappiness = 2;
                    break;
                case 1:
                    if( increaseHappiness > 5 ) increaseHappiness = 5;
                    break;
                case 2:
                    if( increaseHappiness > 10 ) increaseHappiness = 10;
                    break;
                case 3:
                    if( increaseHappiness > 15 ) increaseHappiness = 15;
                    break;
                case 4:
                    if( increaseHappiness > 20 ) increaseHappiness = 20;
                    break;
                case 5:
                    if( increaseHappiness > 25 ) increaseHappiness = 25;
                    break;
                default:
                    increaseHappiness = 25;
                    break;
            }
            return increaseHappiness;
        }
        private double SwitchRecruteur( double decreaseRecruting )
        {
            switch( this.CompanyLevel.CurrentLevel / 10 )
            {
                case 0:
                    if( decreaseRecruting > 2 ) decreaseRecruting = 2;
                    break;
                case 1:
                    if( decreaseRecruting > 5 ) decreaseRecruting = 5;
                    break;
                case 2:
                    if( decreaseRecruting > 10 ) decreaseRecruting = 10;
                    break;
                case 3:
                    if( decreaseRecruting > 15 ) decreaseRecruting = 15;
                    break;
                case 4:
                    if( decreaseRecruting > 20 ) decreaseRecruting = 20;
                    break;
                case 5:
                    if( decreaseRecruting > 25 ) decreaseRecruting = 25;
                    break;
                default:
                    decreaseRecruting = 25;
                    break;
            }
            return decreaseRecruting;
        }
        private double SwitchCommerciaux( double newPourcentCommerciaux )
        {
            switch( PossibleCompanyProjects.Count / 3 )
            {
                case 1:
                    if( newPourcentCommerciaux > 5 ) newPourcentCommerciaux = 5;
                    break;
                case 2:
                    if( newPourcentCommerciaux > 10 ) newPourcentCommerciaux = 10;
                    break;
                case 3:
                    if( newPourcentCommerciaux > 15 ) newPourcentCommerciaux = 15;
                    break;
                case 4:
                    if( newPourcentCommerciaux > 20 ) newPourcentCommerciaux = 20;
                    break;
                case 5:
                    if( newPourcentCommerciaux > 25 ) newPourcentCommerciaux = 25;
                    break;
                default:
                    throw new InvalidOperationException( "Error in the switch." );
            }
            return newPourcentCommerciaux;
        }
        private double SwitchRessourcesHumaines( double descreaseSalary )
        {
            switch( _employees.Count / 10 )
            {
                // Un seuil est établi pour tous les 10 employés dans l'entreprise.
                case 0:
                    if( descreaseSalary > 2 ) descreaseSalary = 2;
                    break;
                case 1:
                    if( descreaseSalary > 5 ) descreaseSalary = 5;
                    break;
                case 2:
                    if( descreaseSalary > 10 ) descreaseSalary = 10;
                    break;
                case 3:
                    if( descreaseSalary > 15 ) descreaseSalary = 15;
                    break;
                case 4:
                    if( descreaseSalary > 20 ) descreaseSalary = 20;
                    break;
                case 5:
                    if( descreaseSalary > 25 ) descreaseSalary = 25;
                    break;
                default:
                    if( descreaseSalary > 30 ) descreaseSalary = 30;
                    break;
            }
            return descreaseSalary;
        }
        private double SwitchDirecteursProjets( double decreaseTasks )
        {
            switch( PossibleCompanyProjects.Count / 3 )
            {
                case 1:
                    if( decreaseTasks > 5 ) decreaseTasks = 5;
                    break;
                case 2:
                    if( decreaseTasks > 10 ) decreaseTasks = 10;
                    break;
                case 3:
                    if( decreaseTasks > 15 ) decreaseTasks = 15;
                    break;
                case 4:
                    if( decreaseTasks > 20 ) decreaseTasks = 20;
                    break;
                case 5:
                    if( decreaseTasks > 25 ) decreaseTasks = 25;
                    break;
                default:
                    throw new InvalidOperationException( "Error in the switch." );
            }
            return decreaseTasks;
        }
        /// <summary>
        /// Use the commerciaux skill. Add a pourcent on every projects of the company.
        /// </summary>
        private void AddPourcentCommerciaux( Project p )
        {
            if( _commerciaux.Count != 0 )
            {
                p.Earnings = (int)(p.Earnings + (p.Earnings * (_pourcentCommerciaux / 100)));
            }
        }
        public int EstimatePourcentCommerciaux( Project p )
        {
            if( _commerciaux.Count != 0 ) return (int)(p.Earnings + (p.Earnings * (_pourcentCommerciaux / 100)));
            else return p.Earnings;
        }
        public int EstimateRecrutingAndLayingOffCost( int cost )
        {
            if( cost < 0 ) throw new ArgumentException( "cost can't be = 0 " );
            if( _recruteur.Count != 0 ) return (int)(cost - (cost * (_decreaseRecruting / 100)));
            else return cost;
        }
        public void AddXpToManagers()
        {
            if( _managers.Count != 0 )
            {
                foreach( Employee emp in _managers.Keys )
                {
                    if( Game.TimeGame.intervalOfTimeInDays( emp.BegginningCompanyWork ) == 30 )
                    {
                        emp.SkillAffectedToCompany.Level.IncreaseXp( 5 );
                        emp.BegginningCompanyWork = Game.TimeGame.CurrentTimeOfGame;
                    }
                }
            }
        } 
        #endregion


    }
}
