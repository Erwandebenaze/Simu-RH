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
		protected string _name;
		protected int _wealth;
		protected int _maxEmployees;
		protected readonly List<Employee> _employees;
        List<Project> _possibleProjects;

        public List<Project> PossibleProjects
        {
            get { return _possibleProjects; }
        }
        List<Project> _projects;


		Level _companyLevel;
		double _maxProjectDifficulty;

		public MyCompany( string Name )
        {
			if( String.IsNullOrWhiteSpace( Name ) ) throw new ArgumentNullException( "The company name cannot be null or a whitespace" );
			//TODO : Check if the name is already existing (saved)
			_name = Name;
			_employees = new List<Employee>();
            _wealth = 15000;
			_companyLevel = new Level( this );
			_maxProjectDifficulty = 1;
			_maxEmployees = 10;
            _projects = new List<Project>();
            _possibleProjects = new List<Project>();
            _possibleProjects.Add( new Project( "Danone", 1, 2, 1000, 15 ) );
            _possibleProjects.Add( new Project( "Nestle", 1, 2, 2000, 20 ) );
            _possibleProjects.Add( new Project( "Accord", 1, 2, 3000, 30) );

			//CSV csvImport = new CSV();
			//_possibleProjects = csvImport.ReadCsv();

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
            private set { _maxEmployees = value; }
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
            private set { _maxProjectDifficulty = value; }
        } 
        #endregion

		/// <summary>
		/// Adds an <see cref="Employee"/> to <see cref="MyCompany"/>
		/// </summary>
		/// <param name="p">The Worker to add, it becomes an <see cref="Employee"/> when added</param>
		/// <returns>Returns True if the <see cref="Employee"/> was added</returns>
		public Employee AddEmployee( Person p )
		{
			Employee e = new Employee( p );
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

        public void MoveProject(Project p)
        {
            if (p.Activated)
            {
                _projects.Add( p );
                _possibleProjects.Remove( p );
            } else
            {
                _possibleProjects.Add( p );
                _projects.Remove( p );
            }

        }

		/// <summary>
		/// Adjust the number of <see cref="MaxEmployees"/> and the <see cref="MaxDifficulty"/> of <see cref="MyCompany"/> depending on its <see cref="Level"/>
		/// </summary>
		public void AdjustValuesCompany()
        {
			if( this.CompanyLevel.CurrentLevel == 1 ) this.MaxEmployees = 10;
			this.MaxEmployees = 10 + ( 2 * ( this.CompanyLevel.CurrentLevel - 1 ) );

			if( this.CompanyLevel.CurrentLevel == 1 ) this.MaxProjectDifficulty = 0.5;
			if( this.CompanyLevel.CurrentLevel % 10 == 0 ) this.MaxProjectDifficulty += 0.5;
        }
           
        public void EndProjectIfItsFinish()
        {
            if (_projects.Count > 0 )
            {
                foreach (Project p in _projects)
                { 
                    if (GameTime.intervalOfTimeInDays( p.BegginingDate ) == p.Duration)
                    {
                        EndAProject( p );
                        p.TimeLeft = 0;
                        MoveProject( p );
                        break;
                    } else
                    {
                        p.TimeSpent = GameTime.intervalOfTimeInDays( p.BegginingDate );
                        p.TimeLeft = p.Duration - p.TimeSpent;            
                    }
                }
            }
        }

        public void EndAProject( Project p)
        {
            p.StopProject();
            Wealth += p.Earnings;
            _companyLevel.IncreaseXp( p.XpPerCompany, this );
            foreach (Employee e in p._employeesAffectedWithSkill.Keys)
            {
                foreach (Skill s in p._employeesAffectedWithSkill.Values)
                {
                    s.Level.IncreaseXp(p.XpPerPerson);
                }
            }
        }
        public Project BeginAProject( Project p )
        {
            _possibleProjects.Remove( p );
            _projects.Add( p );
            p.BeginProject();
            return p;
        }

        public Project StopAProject( Project p )
        {
            PossibleProjects.Add( p );
            _projects.Remove( p );
            p.StopProject();
            return p;
        }

	}
}
