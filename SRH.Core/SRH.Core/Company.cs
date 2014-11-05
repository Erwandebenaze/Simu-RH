using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    public class Company
    {
        protected string _name;
        protected int _wealth;
        protected readonly Dictionary<Guid,Employee> _employees;
		internal RandomGenerator _randomEmployee;

        public Company()
        {   
			//TODO : Check if the name is already existing
			_employees = new Dictionary<Guid, Employee>();
            // TODO : get a random company name (in RandomGenerator)
			// _name = GetRandomCompanyName;
            _wealth = 15000;
			_randomEmployee = new RandomGenerator();
        }

		/// <summary>
		/// Adds a random <see cref="Employee"/> to the <see cref="Company"/>
		/// </summary>
		/// 
		
		// TODO : if list is empty (starting company) =>  add young employee, if 5 employees or more, add normal
		public void AddEmployee()
		{
			Dictionary<string, string> randomName = _randomEmployee.GetRandomName();
			
			string LastName;
			string FirstName;
			randomName.TryGetValue( "FirstName", out FirstName );
			randomName.TryGetValue( "LastName", out LastName );
			int Age = _randomEmployee.GetRandomAge(18, 60);

			Employee e = new Employee(this, LastName, FirstName, Age );
			_employees.Add( e.Id, e );
		}
    }
}
