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
            Game myGame = new Game( 1, "Dannone" );

            GameTime myGameTime = new GameTime( myGame );
        }

        [Test]
        public void Create_GameTime_with_no_paramaters_create_a_2015_01_25_date_time()
        {
            Game myGame = new Game( 1, "Dannone" );
            GameTime myGameTime = new GameTime( myGame );
            Assert.That( myGame.TimeGame.TimeOfGame == new DateTime( 2015, 01, 26 ) );
        }

        [Test]
        public void Create_GameTime_with_no_paramaters_is_lundi()
        {
            Game myGame = new Game( 1, "Dannone" );
            GameTime myGameTime = new GameTime( myGame );
            Assert.That( myGameTime.FrenchDayOfWeek == "Lundi" );
        }

        [Test]
        public void Add_1_day_become_the_day_after()
        {
            Game myGame = new Game( 1, "Dannone" );
            myGame.TimeGame.newDay();
            Assert.That( myGame.TimeGame.TimeOfGame == new DateTime( 2015, 01, 27 ) );
        }

        [Test]
        public void Add_1_day_become_mardi()
        {
            Game myGame = new Game( 1, "Dannone" );
            myGame.TimeGame.newDay();
            Assert.That( myGame.TimeGame.FrenchDayOfWeek == "Mardi" );
        }
        [Test]
        public void Add_4_days_become_lundi()
        {
            Game myGame = new Game( 1, "Dannone" );
            myGame.TimeGame.newDay();
            myGame.TimeGame.newDay();
            myGame.TimeGame.newDay();
            myGame.TimeGame.newDay();
            Assert.That( myGame.TimeGame.FrenchDayOfWeek == "Vendredi" );
        }
        [Test]
        public void Add_5_days_become_lundi()
        {
            Game myGame = new Game( 1, "Dannone" );
            GameTime myGameTime = new GameTime( myGame );
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
            Game myGame = new Game( 1, "Dannone" );
            GameTime myGameTime = new GameTime( myGame );
            Assert.That( myGame.TimeGame.intervalOfTimeInDays( new DateTime( 2015, 01, 21 ) ) == 3 );
        }


        [Test]
        public void one_month_before_days_return_interval_of_20_days_worked()
        {
            Game myGame = new Game( 1, "Dannone" );
            GameTime myGameTime = new GameTime( myGame );
            Assert.That( myGame.TimeGame.intervalOfTimeInDays( new DateTime( 2014, 12, 26 ) ) == 21 );
        }
    }
}
