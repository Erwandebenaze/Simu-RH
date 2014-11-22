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

        public Project Create_project()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>(); 
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

            Project iz = new Project( "SimuRH", 1, 2, 1000, requiredSkills );
            return iz;
            
        }

        [Test]
        [ExpectedException( typeof( ArgumentNullException ) )]
        public void Create_project_with_white_space_throw_argument_null_exeption()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>();
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

            Project p = new Project( " ", 1, 2, 2000, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_negative_difficulty_throw_argument_exeption()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>();
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

            Project p = new Project( "SimuRh", -1, 2, 2000, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_negative_numberOfWorkers_throw_argument_exeption()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>();
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

            Project p = new Project( "SimuRh", -1, -2, 2000, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_earnings_inferior_than_100_throw_argument_exeption()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>();
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

            Project p = new Project( "SimuRh", -1, -2, 10, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_duration_inferior_than_2_throw_argument_null_exeption()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>();
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

            Project p = new Project( "SimuRh", -1, -2, 10, requiredSkills, 1 );
        }

        [Test]
        [ExpectedException( typeof( InvalidOperationException ) )]
        public void Begin_a_project_who_is_already_begin_throw_invalidOperationException()
        {
            Project iz = Create_project();

            iz.BeginProject();
            iz.BeginProject();
        }

		[Test]
		public void Create_the_possible_projects_list_from_CSV()
		{
			CSV csv = new CSV();
			List<Project> list = new List<Project>();

            list = csv.ReadCsv( "../../../Data/data.csv" );

			Assert.That( list[ 0 ].Difficulty == 1.0 );
			Assert.That( list[ 0 ].Earnings == 2000 );
		}
    }
}
