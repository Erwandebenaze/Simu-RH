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
        List<Employee> _gestionnairesContrat;



		internal MyCompany( Game game, string name ) : base( game, name )
        {
			if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "The company name cannot be null or a whitespace" );
            _wealth = 15000;
			_companyLevel = new Level( this, 1 );
			_maxProjectDifficulty = 1;
            _projects = new List<Project>();
            _managers = new Dictionary<Employee,Skill>();
            _commerciaux = new List<Employee>();
            _animation = new List<Employee>();
            _ressourcesHumaines = new List<Employee>();
            _directeursProjets = new List<Employee>();
            _gestionnairesContrat = new List<Employee>();

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
            {
                _projects.Add( p );
                //_possibleCompanyProjects.Remove( p );
            } else
            {
               // _possibleCompanyProjects.Add( p );
                _projects.Remove( p );
            }
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

        public void EndProjectIfItsFinish()
        {
            if (_projects.Count > 0 )
            {
                foreach (Project p in _projects)
                {
                    if( _myGame.TimeGame.intervalOfTimeInDays( p.BegginingDate ) == p.Duration )
                    {
                        EndAProject( p );
                        p.TimeLeft = 0;
                        MoveProject( p );
                        break;
                    } else
                    {
                        p.TimeSpent = _myGame.TimeGame.intervalOfTimeInDays( p.BegginingDate );
                        p.TimeLeft = p.Duration - p.TimeSpent;            
                    }
                }
            }
        }

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
        public Project BeginAProject( Project p )
        {
            //_possibleCompanyProjects.Remove( p );
            _projects.Add( p );
            p.BeginProject();
            return p;
        }

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

        public void AffectManagers()
        {

            if( _managers.Count != 0 )
            {
                foreach( KeyValuePair<Employee, Skill> dico in _managers)
                {
                    if( dico.Value.SkillName == "Commercial" ) _commerciaux.Add(dico.Key);
                    if( dico.Value.SkillName == "Animation" ) _animation.Add( dico.Key );
                    if( dico.Value.SkillName == "Gestion de contrat" ) _gestionnairesContrat.Add( dico.Key );
                    if( dico.Value.SkillName == "Directeur de projets" ) _directeursProjets.Add( dico.Key );
                    if( dico.Value.SkillName == "Ressources humaines" ) _ressourcesHumaines.Add( dico.Key );
                }
            }
        }

        public void UseManagers()
        {
            int pourcentCommerciaux = 0;
            if( _commerciaux.Count > 0)
            {
                foreach( Employee emp in _commerciaux )
                {
                    pourcentCommerciaux += (emp.Worker.Skills.Where( e => e.SkillName == "Commercial" ).Select( e => e.Level.CurrentLevel ).Single()) * 2;
                }
            }
        }
	}
}
