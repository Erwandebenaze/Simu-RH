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
        int _pourcentCommerciaux = 0;
        int _decreaseRecruting = 0;


		internal MyCompany( Game game, string name ) : base( game, name )
        {
			if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "The company name cannot be null or a whitespace" );
            _wealth = 15000;
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
			if( ( this.CompanyLevel.CurrentLevel +1 ) % 10 == 0 ) _maxProjectDifficulty += 0.5;
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
                    if( p.ActualTasks > 0 )
                    {
                        //p.TimeSpent = _myGame.TimeGame.intervalOfTimeInDays( p.BegginingDate );
                        p.RefreshDuration();
                        p.TimeLeft = p.Duration;
                        if( p.TimeLeft < 0 ) p.TimeLeft = 0;
                        p.RefreshActualsTasks();
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

        public int ApplyInterests()
        {
            int interest = 0;
            if( _wealth < 0 )
            {
                interest = (int)(-(_wealth * 3.5));
            }
            _wealth -= interest;
            return interest;
        }
        /// <summary>
        /// End a project and give the earnings. XP/Person, XP/Company and earnings. Free the employees of the project.
        /// </summary>
        /// <param name="p"></param>
        public void EndAProject( Project p )
        {
            p.StopProject();
            Wealth += p.Earnings;
            _companyLevel.IncreaseXp( p.XpPerCompany, this );
            foreach( Employee e in p.EmployeesAffectedWithSkill.Keys )
            {
                foreach( Skill s in p.EmployeesAffectedWithSkill.Values )
                {
                    s.Level.IncreaseXp(p.XpPerPerson);
                    
                }
                e.Busy = false;
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
        /// Affect the differents managers to their own task.
        /// </summary>
        public void AffectManagers()
        {
            if( _managers.Count != 0 )
            {
                foreach( KeyValuePair<Employee, Skill> dico in _managers)
                {
                    if( dico.Value.SkillName == "Commercial" ) _commerciaux.Add(dico.Key);
                    if( dico.Value.SkillName == "Animation" ) _animation.Add( dico.Key );
                    if( dico.Value.SkillName == "Recruteur" ) _recruteur.Add( dico.Key );
                    if( dico.Value.SkillName == "Directeur de projets" ) _directeursProjets.Add( dico.Key );
                    if( dico.Value.SkillName == "Ressources humaines" ) _ressourcesHumaines.Add( dico.Key );
                }
            }
        }

		public void AddManager(Employee e, Skill s)
		{
			_managers.Add( e, s );
			e.SkillAffectedToCompany = s;
			e.Busy = true;
		}

		public void RemoveManager( Employee e )
		{
			if( _managers.ContainsKey( e ) )
			{
				_managers.Remove( e );
				e.Busy = false;
				e.SkillAffectedToCompany = null;
			}
			else
				throw new ArgumentException( "You connot remove a manager that is not in the Disctionnary." );
		}

        /// <summary>
        /// Use the different skill of the managers.
        /// </summary>
        private void UseManagers()
        {
            int newPourcentCommerciaux = 0;
            int newDecreaseRecruting = 0;
            if( _commerciaux.Count > 0)
            {
                foreach( Employee emp in _commerciaux )
                {
                    newPourcentCommerciaux += ( emp.Worker.Skills.Where( e => e.SkillName == "Commercial" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }
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
                    default :
                        throw new InvalidOperationException("Error in the switch.");
                }
                if( newPourcentCommerciaux != _pourcentCommerciaux )
                {
                    _pourcentCommerciaux = newPourcentCommerciaux;
                    _possibleCompanyProjects = GetPossibleCompanyProjects();
                    AddPourcentCommerciaux();
                }

            }
            if( _ressourcesHumaines.Count > 0 )
            {
                foreach( Employee emp in _ressourcesHumaines )
                {
                    newDecreaseRecruting += (emp.Worker.Skills.Where( e => e.SkillName == "Ressources humaines" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }

                if(newDecreaseRecruting > _decreaseRecruting )
                {
                    _decreaseRecruting = newDecreaseRecruting;
                    // TODO : Implémentation lorsqu'il y aura un coût de recrutement et de renvoi.
                }
            }
            if( _directeursProjets.Count > 0 )
            {
                foreach( Employee emp in _directeursProjets )
                {
                    newDecreaseRecruting += (emp.Worker.Skills.Where( e => e.SkillName == "Ressources humaines" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }

                if( newDecreaseRecruting > _decreaseRecruting )
                {
                    _decreaseRecruting = newDecreaseRecruting;
                    // TODO : Implémentation lorsqu'il y aura un coût de recrutement et de renvoi.
                }
            }
        }

        /// <summary>
        /// Use the commerciaux skill. Add a pourcent on every projects of the company.
        /// </summary>
        private void AddPourcentCommerciaux()
        {
            foreach( Project p in _projects )
            {
                _projects.Remove( p );
                _projects.Add( p.Clone( _pourcentCommerciaux ) );

            }
        }
	}
}
