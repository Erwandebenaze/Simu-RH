using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class WealthInYear
    {
        int _january;
        int _february;
        int _april;
        int _march; 
        int _may;
        int _june;
        int _july;
        int _august;
        int _september;
        int _october;
        int _november;
        int _december;
        Company _comp;

        public WealthInYear( Company comp )
        {
            if( comp == null ) throw new ArgumentNullException( "comp is null" );
            _comp = comp;
            _january = 0;
            _february = 0;
            _march = 0;
            _april = 0;
            _may = 0;
            _june = 0;
            _july = 0;
            _august = 0;
            _september = 0;
            _october = 0;
            _november = 0;
            _december = 0;

        }
        public int January
        {
            get { return _january; }
            set { _january = value; }
        }

        public int February
        {
            get { return _february; }
            set { _february = value; }
        }


        public int March
        {
            get { return _march; }
            set { _march = value; }
        }

        public int April
        {
            get { return _april; }
            set { _april = value; }
        }

        public int May
        {
            get { return _may; }
            set { _may = value; }
        }

        public int June
        {
            get { return _june; }
            set { _june = value; }
        }


        public int July
        {
            get { return _july; }
            set { _july = value; }
        }

        public int August
        {
            get { return _august; }
            set { _august = value; }
        }

        public int September
        {
            get { return _september; }
            set { _september = value; }
        }

        public int October
        {
            get { return _october; }
            set { _october = value; }
        }


        public int November
        {
            get { return _november; }
            set { _november = value; }
        }

        public int December
        {
            get { return _december; }
            set { _december = value; }
        }

        public void NewYear()
        {
            _february = 0;
            _march = 0;
            _april = 0;
            _may = 0;
            _june = 0;
            _july = 0;
            _august = 0;
            _september = 0;
            _october = 0;
            _november = 0;
            _december = 0;
        }
    }
}
