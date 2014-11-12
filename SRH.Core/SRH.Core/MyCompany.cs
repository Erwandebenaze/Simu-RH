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
        List<Project> _project;
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
            _project = new List<Project>();
        }

        #region Getters Setters
        public string Name
        {
            get { return _name; }
        }
        public int Wealth
        {
            get { return _wealth; }
            private set { _wealth = value; }
        }
        public int MaxEmployees
        {
            get { return _maxEmployees; }
            private set { _maxEmployees = value; }
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
		internal bool AddEmployee( Person p )
		{
			Employee e = new Employee( p );
			_employees.Add( e );
			return ( _employees.Exists( x => x.Equals( e ) ) ) && ( p.Lb.RemovePerson( p ) );
		}
		/// <summary>
		/// Removes an <see cref="Employee"/> from <see cref="MyCompany"/>
		/// </summary>
		/// <param name="e">The <see cref="Employee"/> to remove</param>
		/// <returns>Returns True id the <see cref="Employee"/> was removes</returns>
		internal bool RemoveEmployee( Employee e )
		{
			_employees.Remove( e );
			return !( _employees.Exists( x => x.Equals( e ) ) ) && ( e.Worker.Lb.AddPerson( e.Worker ) );
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
	}
}
