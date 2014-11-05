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

        public Company()
        {   
			//TODO : Check if the name is already existing
			_employees = new Dictionary<Guid, Employee>();
			
			// TODO : implémenter la liste de projets en cours
			//_currentProjects = new List<Project>();
            
			// _name = GetRandomCompanyName;
            _wealth = 15000;
        }
    }
}
