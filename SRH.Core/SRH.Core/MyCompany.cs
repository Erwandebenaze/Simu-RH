using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
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
		 public void AdjustValuesCompany()
        {
			if( this.CompanyLevel.CurrentLevel == 1 ) this.MaxEmployees = 10;
			this.MaxEmployees = 10 + ( 2 * ( this.CompanyLevel.CurrentLevel - 1 ) );

			if( this.CompanyLevel.CurrentLevel == 1 ) this.MaxProjectDifficulty = 0.5;
			if( this.CompanyLevel.CurrentLevel % 10 == 0 ) this.MaxProjectDifficulty += 0.5;
        }
	}
}
