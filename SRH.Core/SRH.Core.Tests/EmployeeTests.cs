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
    public class EmployeeTests
    {
        [Test]
        public void Create_employee()
        {
            Employee e = new Employee( "Dupont", "Jack", 18 );
        }
        [Test]
        public void Add_skill_to_an_employee()
        {
            Employee e = new Employee( "Dupont", "Jack", 18 );
            Skill s = e.AddSkill<ProjSkill>( "Development" );
            Assert.That(e.Skills.ContainsKey("Development")) ;
        }
    }
}
