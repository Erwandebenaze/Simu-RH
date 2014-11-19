using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SRH.Core;

namespace SRH.Core.Tests
{
    [TestFixture]
    class GameTimeTests
    {
        [Test]
        public void Create_GameTime()
        {
            GameTime myGameTime = new GameTime();
        }

        [Test]
        public void Create_GameTime_with_no_paramaters_create_a_2015_01_25_date_time()
        {
            GameTime myGameTime = new GameTime();
            Assert.That( GameTime.TimeOfGame == new DateTime( 2015, 01, 26 ) );
        }

        [Test]
        public void Create_GameTime_with_no_paramaters_is_lundi()
        {
            GameTime myGameTime = new GameTime();
            Assert.That( myGameTime.FrenchDayOfWeek == "Lundi" );
        }

        [Test]
        public void Add_1_day_become_the_day_after()
        {
            GameTime myGameTime = new GameTime();
            myGameTime.newDay();
            Assert.That( GameTime.TimeOfGame == new DateTime( 2015, 01, 27 ) );
        }

        [Test]
        public void Add_1_day_become_mardi()
        {
            GameTime myGameTime = new GameTime();
            myGameTime.newDay();
            Assert.That( myGameTime.FrenchDayOfWeek == "Mardi" );
        }
        [Test]
        public void Add_4_days_become_lundi()
        {
            GameTime myGameTime = new GameTime();
            myGameTime.newDay();
            myGameTime.newDay();
            myGameTime.newDay();
            myGameTime.newDay();
            Assert.That( myGameTime.FrenchDayOfWeek == "Vendredi" );
        }
        [Test]
        public void Add_5_days_become_lundi()
        {
            GameTime myGameTime = new GameTime();
            myGameTime.newDay();
            myGameTime.newDay();
            myGameTime.newDay();
            myGameTime.newDay();
            myGameTime.newDay();

            Assert.That( myGameTime.FrenchDayOfWeek == "Lundi" );
        }

        [Test]
        public void five_days_before_days_return_interval_of_3_days_worked()
        {
            GameTime myGameTime = new GameTime();
            Assert.That( myGameTime.intervalOfTimeInDays( new DateTime( 2015, 01, 21 ) ) == 3 );
        }


        [Test]
        public void one_month_before_days_return_interval_of_20_days_worked()
        {
            GameTime myGameTime = new GameTime();
            Assert.That( myGameTime.intervalOfTimeInDays( new DateTime( 2014, 12, 26 ) ) == 21 );
        }
    }
}
