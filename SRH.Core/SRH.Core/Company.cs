using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    public abstract class Company
    {
        readonly string _name;
        int _companyLevel;
        int _maxEmployees;
        int _maxProjectDifficulty;
        int _wealth;
        readonly Dictionary<string,Employee> _employees;


        public Company( string name )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "name" );
            //TODO : Check if the name is already existing
            _name = name;
            _companyLevel = 1;
            _maxEmployees = 10;
            _maxProjectDifficulty = 1;
            _wealth = 15000;
        }
    }
}
