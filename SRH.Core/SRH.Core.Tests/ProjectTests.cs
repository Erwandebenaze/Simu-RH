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
    class ProjectTests
    {
        Project iz = new Project( "IziProj", 1, 2, 2000, 2 );

        [Test]
        public void Create_project()
        {
            Project p = new Project( "SimuRh", 1, 2, 2000, 2 );
            Assert.That( p, Is.Not.Null );
        }

        [Test]
        [ExpectedException( typeof( ArgumentNullException ) )]
        public void Create_project_with_white_space_throw_argument_null_exeption()
        {
            Project p = new Project( " ", 1, 2, 2000, 2 );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_negative_difficulty_throw_argument_exeption()
        {
            Project p = new Project( "SimuRh", -1, 2, 2000, 2 );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_negative_numberOfWorkers_throw_argument_exeption()
        {
            Project p = new Project( "SimuRh", 1, -2, 2000, 2 );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_earnings_inferior_than_100_throw_argument_exeption()
        {
            Project p = new Project( "SimuRh", 1, 2, 0, 2 );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_duration_inferior_than_2_throw_argument_null_exeption()
        {
            Project p = new Project( "SimuRh", 1, 2, 1000, 1 );
        }

        [Test]
        [ExpectedException( typeof( InvalidOperationException ) )]
        public void Begin_a_project_who_is_already_begin_throw_invalidOperationException()
        {
            iz.BeginProject();
            iz.BeginProject();
        }


    }
}
