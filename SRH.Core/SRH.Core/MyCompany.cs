using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
	public class MyCompany
	{
		readonly string _name;
        int _wealth;
        int _maxEmployees;
		readonly List<Employee> _employees;
        List<Project> _possibleCompanyProjects;
        readonly List<Project> _projects;
        readonly Game _myGame;
        readonly Level _companyLevel;
        double _maxProjectDifficulty;


		internal MyCompany( Game game, string name )
        {
			if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "The company name cannot be null or a whitespace" );
			//TODO : Check if the name is already existing (saved)
			_name = name;
            _myGame = game;
			_employees = new List<Employee>();
            _wealth = 15000;
			_companyLevel = new Level( this );
			_maxProjectDifficulty = 1;
			_maxEmployees = 10;
            _projects = new List<Project>();
        }

        #region Getters Setters
        public string Name
        {
            get { return _name; }
        }
        public int Wealth
        {
            get { return _wealth; }
            internal set { _wealth = value; }
        }
        public int MaxEmployees
        {
            get { return _maxEmployees; }
        }
        public Game MyGame
        {
            get { return _myGame; }
        }
        public List<Project> Projects
        {
            get { return _projects; }
        }
        public List<Employee> Employees
        {
            get { return _employees; }
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

		/// <summary>
		/// Adds an <see cref="Employee"/> to <see cref="MyCompany"/>
		/// </summary>
		/// <param name="p">The Worker to add, it becomes an <see cref="Employee"/> when added</param>
		/// <returns>Returns True if the <see cref="Employee"/> was added</returns>
        public Employee AddEmployee( Person p )
		{
			Employee e = new Employee(this, p );
			_employees.Add( e );
			
			if( !( _employees.Exists( x => x.Equals( e ) ) ) ) throw new InvalidOperationException("The Employee wasn't properly added to the List.");
			if( !( p.Lb.RemovePerson( p ) ) ) throw new InvalidOperationException("The Person wasn't properly removed from the List.");
			return e;
		}
		/// <summary>
		/// Removes an <see cref="Employee"/> from <see cref="MyCompany"/>
		/// </summary>
		/// <param name="e">The <see cref="Employee"/> to remove</param>
		/// <returns>Returns True id the <see cref="Employee"/> was removes</returns>
        public Person RemoveEmployee( Employee e )
		{
			_employees.Remove( e );
			if( _employees.Exists( x => x.Equals( e ) ) )
				throw new InvalidOperationException( "The Employee was not removed properly from the List." );
			if( !( e.Worker.Lb.AddPerson( e.Worker ) ) )
				throw new InvalidOperationException( "The Person was not added properly to te List." );

			return e.Worker;
		}

        public void MoveProject( Project p )
        {
            if (p.Activated)
            {
                _projects.Add( p );
                _possibleCompanyProjects.Remove( p );
            } else
            {
                _possibleCompanyProjects.Add( p );
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
            }
        }
        public Project BeginAProject( Project p )
        {
            _possibleCompanyProjects.Remove( p );
            _projects.Add( p );
            p.BeginProject();
            return p;
        }

        public Project StopAProject( Project p )
        {
            _possibleCompanyProjects.Add( p );
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
	}
}
