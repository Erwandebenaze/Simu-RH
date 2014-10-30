using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    public class Company
    {
        readonly string _name;
        int _companyLevel;

        public Company( string name )
        {
            if( name == null ) throw new ArgumentNullException( "name" );
            //TODO : Check if the name is already existing
            _name = name;
            _companyLevel = 0;
        }
    }
}
