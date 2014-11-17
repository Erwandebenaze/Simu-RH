using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    class Time
    {
        enum frenchDayOfWeek
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi
        }



        public Time()
        {
            DateTime t = new DateTime(2015,01,25);
            DayOfWeek d = t.DayOfWeek; 

        }

        public DateTime newDay(DateTime currentDate)
        {
            currentDate.AddDays( 1 );
            return currentDate;
        }
        
       
    }
}
