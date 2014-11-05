using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    class LaborMarket
    {
        Dictionary<Guid, Employee> _employeesInMarket;

        public LaborMarket()
        {
            _employeesInMarket = new Dictionary<Guid, Employee>();
            for( int i=0; i < 100; i++ )
            {
                Employee e = new Employee();
                //_employeesInMarket.Add( e.Id,e );
            }
        }
    }
}
