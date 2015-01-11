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
    public class PersonTests
    {
        Game myGame = new Game( 1, "Simu'RH" );

        [Test]
        public void Create_a_person()
        {
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );

            Assert.That( p.FirstName == "André" );
            Assert.That( p.LastName == "LeGéant" );
            Assert.That( p.Age == 20 );
        }

        [Test]
        public void Add_a_skill()
        {
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );

            p.AddSkill( "Management de projet" );
            Skill man = new ProjSkill( "Management de projet" );

            Assert.That( p.Skills.Contains( man ));
        }
        [Test]
        public void Add_a_year()
        {
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );

            p.AddAYear();

            Assert.That( p.Age == 21 );
        }

        [Test]
        public void A_person_generates_an_expected_salary_depending_on_its_skills()
        {
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            p.GenerateExpectedSalary();

            Assert.That( p.ExpectedSalary == 1000 );

            p.AddSkill( "Conception" );
            p.GenerateExpectedSalary();
            Assert.That( p.ExpectedSalary == 1100 );

            p.AddSkill( "Commercial" );
            p.GenerateExpectedSalary();
            Assert.That( p.ExpectedSalary == 1300 );

            p.Skills[1].Level.CurrentLevel += 1;
            p.GenerateExpectedSalary();
            Assert.That( p.ExpectedSalary == 1500 );
        }

    }
}
