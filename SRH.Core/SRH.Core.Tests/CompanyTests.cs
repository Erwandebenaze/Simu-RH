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
    class CompanyTests
    {
        [Test]
        public void Create_company()
        {
            MyCompany c = new MyCompany("SimuRH");
            Assert.That( c, Is.Not.Null);
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
            mc.CompanyLevel.IncreaseXp( 100 );
			Assert.That( mc.CompanyLevel.CurrentLevel, Is.EqualTo( 2 ) );
        }
    }
}
