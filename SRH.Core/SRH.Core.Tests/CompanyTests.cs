﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SRH.Core;

namespace SRH.Core.Tests
{
    [TestFixture]
    class CompanyTests
    {

        [Test]
        public void Create_company_with_name_and_Level()
        {
            MyCompany c = new MyCompany("SimuRH");
            Assert.That( c.Name == "SimuRH" );
            Assert.That( c.CompanyLevel.CurrentLevel == 1 );
        }

        [Test]
        public void Create_competitor()
        {
            Competitor c = new Competitor("Danone");
            Assert.That( c, Is.Not.Null );
        }

        [Test]
        [ExpectedException( typeof( ArgumentNullException ) )]
        public void Create_mycompany_with_white_space_throw_argument_null_exeption()
        {
            MyCompany mc = new MyCompany( " " );
        }

        [Test]
        public void New_company_have_10_max_employees()
        {
            MyCompany mc = new MyCompany( "Danone" );
            Assert.That( mc.MaxEmployees, Is.EqualTo(10) );
        }

        [Test]
        public void New_company_have_1_max_project_difficulty()
        {
            MyCompany mc = new MyCompany( "Danone" );
            Assert.That( mc.MaxProjectDifficulty, Is.EqualTo( 1 ) );
        }

        [Test]
        public void Our_company_takes_experience_and_upgrade_his_level()
        {
            MyCompany mc = new MyCompany( "Danone" );
            mc.CompanyLevel.IncreaseXp( 101 );
			Assert.That( mc.CompanyLevel.CurrentLevel, Is.EqualTo( 2 ) );
        }

        [Test]
        public void Create_game_with_a_random_LabourMarket_and_a_company()
        {
            Game myGame = new Game( 1, "IziProj" );

            Assert.That( myGame.Market.JoblessPersons.Count == 100 );
            Assert.That( myGame.PlayerCompany.Name == "IziProj" );
            Assert.That( myGame.PlayerCompany.MaxEmployees == 10 );
            Assert.That( myGame.PlayerCompany.MaxProjectDifficulty == 1 );
            Assert.That( myGame.PlayerCompany.Wealth == 15000 );
        }

        [Test]
        public void Add_a_Person_to_LabourMarket()
        {
            Game myGame = new Game( 1, "SimuRH" );

            Person p = myGame.Market.PersonMaker.CreatePerson( 18, 60 );

            Assert.That( p.Age >= 18 && p.Age <= 60 );
            Assert.That( myGame.Market.AddPerson( p ) );
            Assert.That( myGame.Market.JoblessPersons.Contains( p ) );
        }

        [Test]
        public void Add_employee_to_mycompany()
        {
            Game myGame = new Game( 1, "Danone" );

            Person p = myGame.Market.PersonMaker.CreatePerson( 18, 60 );
			myGame.Market.AddPerson( p );

            Assert.That( myGame.PlayerCompany.AddEmployee( p ) );
        }
    }
}