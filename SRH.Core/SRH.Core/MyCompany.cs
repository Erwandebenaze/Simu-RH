using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	class MyCompany : Company
	{
		int _maxEmployees;
		double _maxProjectDifficulty;
		Level _companyLevel;

		// TODO : add current projects list
		//List<Project> _currentProjects;
		public MyCompany( string name )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "name" );
            
			//TODO : Check if the name is already existing
			_name = name;
			_companyLevel = new Level( this );
            _maxEmployees = 10;
            _maxProjectDifficulty = 1;
            _wealth = 15000;

			_employees.Add()
        }

		public int MaxEmployees
		{
			get { return _maxEmployees; }
			internal set { _maxEmployees = value; }
		}

		public double MaxProjectDifficulty
		{
			get { return _maxProjectDifficulty; }
			internal set { _maxProjectDifficulty = value; }
		}

		public Level CompanyLevel
		{
			get { return _companyLevel; }
		}

		/// <summary>
		/// Adds a young random <see cref="Employee"/>s to <see cref="MyCompany"/>
		/// </summary>
		public void AddEmployee()
		{
			Dictionary<string, string> randomName = _randomEmployee.GetRandomName();

			string LastName;
			string FirstName;
			randomName.TryGetValue( "FirstName", out FirstName );
			randomName.TryGetValue( "LastName", out LastName );
			int Age = _randomEmployee.GetRandomAge();

			Employee e = new Employee( this, LastName, FirstName, Age );
			_employees.Add( e.Id, e );
		}

	}
}
