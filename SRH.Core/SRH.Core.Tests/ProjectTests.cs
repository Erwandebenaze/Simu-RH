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
        Game myGame = new Game( 1, "Dannone" );
		public Dictionary<Skill, int> Create_skills()
        {
            Skill skill1 = new ProjSkill( "WebDevelopment" );
            Skill skill2 = new ProjSkill( "GUInterface" );

            Dictionary<Skill, int> requiredSkills = new Dictionary<Skill, int>(); 
            requiredSkills.Add( skill1, 1 );
            requiredSkills.Add( skill2, 2 );

			return requiredSkills;
        }

		[Test]
		public void begin_a_project_makes_adds_employees_skillInProject()
		{
			Game myGame = new Game( 1, "Simu\'RH" );
			Project p = myGame.PlayerCompany.PossibleCompanyProjects[ 0 ];
			Person Tristan = new Person( myGame.Market, "Tristan", "Letrou", 25 );
			Person Erwan = new Person( myGame.Market, "Erwan", "dB", 21 );
			Person Olivier = new Person( myGame.Market, "Olivier", "Spinelli", 39 );

			Tristan.AddSkill( "Management de projet" );
			Erwan.AddSkill( "Interface graphique" );
			Olivier.AddSkill( "Développement" );
			myGame.Market.AddPerson( Tristan );
			myGame.Market.AddPerson( Erwan );
			myGame.Market.AddPerson( Olivier );

			Employee Tristann = myGame.PlayerCompany.AddEmployee( Tristan );
			Employee Erwann = myGame.PlayerCompany.AddEmployee( Erwan );
			Employee Olivierr = myGame.PlayerCompany.AddEmployee( Olivier );
			Skill man = new ProjSkill( "Management de projet" );
			Skill inte = new ProjSkill( "Interface graphique" );
			Skill dev = new ProjSkill( "Développement" );
			Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals( man ) ).Single();
			Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals( inte ) ).Single();
			Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals( dev ) ).Single();



			p.AffectEmployeeToAJob( Tristann, mana );
			p.AffectEmployeeToAJob( Erwann, inter );
			p.AffectEmployeeToAJob( Olivierr, deve );
			myGame.PlayerCompany.BeginAProject( p );

			Assert.That( Tristann.SkillInProject.Equals( man) );
			Assert.That( Erwann.SkillInProject.Equals( inte ) );
			Assert.That( Olivierr.SkillInProject.Equals( dev ) );
		}

		[Test]
		public void End_a_project_makes_employees_skillInProject_null()
		{
			Game myGame = new Game( 1, "Simu\'RH" );
			Project p = myGame.PlayerCompany.PossibleCompanyProjects[ 0 ];
			Person Tristan = new Person( myGame.Market, "Tristan", "Letrou", 25 );
			Person Erwan = new Person( myGame.Market, "Erwan", "dB", 21 );
			Person Olivier = new Person( myGame.Market, "Olivier", "Spinelli", 39 );

			Tristan.AddSkill( "Management de projet" );
			Erwan.AddSkill( "Interface graphique" );
			Olivier.AddSkill( "Développement" );
			myGame.Market.AddPerson( Tristan );
			myGame.Market.AddPerson( Erwan );
			myGame.Market.AddPerson( Olivier );

			Employee Tristann = myGame.PlayerCompany.AddEmployee( Tristan );
			Employee Erwann = myGame.PlayerCompany.AddEmployee( Erwan );
			Employee Olivierr = myGame.PlayerCompany.AddEmployee( Olivier );
			Skill man = new ProjSkill( "Management de projet" );
			Skill inte = new ProjSkill( "Interface graphique" );
			Skill dev = new ProjSkill( "Développement" );
			Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals( man ) ).Single();
			Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals( inte ) ).Single();
			Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals( dev ) ).Single();



			p.AffectEmployeeToAJob( Tristann, mana );
			p.AffectEmployeeToAJob( Erwann, inter );
			p.AffectEmployeeToAJob( Olivierr, deve );
			myGame.PlayerCompany.BeginAProject( p );
			myGame.PlayerCompany.EndAProject( p );

			Assert.That( Tristann.SkillInProject == null );
			Assert.That( Erwann.SkillInProject == null );
			Assert.That( Olivierr.SkillInProject == null );
		}

        [Test]
        [ExpectedException( typeof( ArgumentNullException ) )]
        public void Create_project_with_white_space_throw_argument_null_exeption()
        {
			Dictionary<Skill, int> requiredSkills = Create_skills();

            Project p = new Project(myGame.PlayerCompany, " ", 1, 2, 2000, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_negative_difficulty_throw_argument_exeption()
        {
			Dictionary<Skill, int> requiredSkills = Create_skills();

            Project p = new Project( myGame.PlayerCompany, "SimuRh", -1, 2, 2000, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_negative_numberOfWorkers_throw_argument_exeption()
        {
			Dictionary<Skill, int> requiredSkills = Create_skills();

            Project p = new Project( myGame.PlayerCompany, "SimuRh", -1, -2, 2000, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_earnings_inferior_than_100_throw_argument_exeption()
		{
			Dictionary<Skill, int> requiredSkills = Create_skills();

            Project p = new Project( myGame.PlayerCompany, "SimuRh", -1, -2, 10, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( ArgumentException ) )]
        public void Create_project_with_duration_inferior_than_2_throw_argument_null_exeption()
		{
			Dictionary<Skill, int> requiredSkills = Create_skills();

            Project p = new Project( myGame.PlayerCompany, "SimuRh", -1, -2, 10, requiredSkills );
        }

        [Test]
        [ExpectedException( typeof( InvalidOperationException ) )]
        public void Begin_a_project_who_is_already_begin_throw_invalidOperationException()
        {
			Dictionary<Skill, int> requiredSkills = Create_skills();
            Project p = new Project( myGame.PlayerCompany, "SimuRh", 1, 2, 2000, requiredSkills );

            p.BeginProject();
            p.BeginProject();
        }

		[Test]
		public void Create_the_possible_projects_list_from_CSV()
		{
			CSV csv = new CSV();
			List<Project> list = new List<Project>();

            list = csv.ReadCsv( myGame.PlayerCompany, "../../../Data/data.csv" );

			Assert.That( list[ 0 ].Difficulty == 1.0 );
			Assert.That( list[ 0 ].Earnings == 18000 );
		}

        [Test]
		public void Someone_go_in_retirement_when_he_is_62()
		{
            Game myGame = new Game( 1, "Simu\'RH" );
            myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 01, 01 );
            Project p = myGame.PlayerCompany.PossibleCompanyProjects[0];
            Person Tristan = new Person( myGame.Market, "Tristan", "Letrou", 25 );
            Person Erwan = new Person( myGame.Market, "Erwan", "dB", 61 );
            Person Olivier = new Person( myGame.Market, "Olivier", "Spinelli", 39 );

            Tristan.AddSkill( "Management de projet" );
            Erwan.AddSkill( "Interface graphique" );
            Olivier.AddSkill( "Développement" );
            Erwan.BirthDate = new DateTime( 2015, 01, 02 );
            myGame.Market.AddPerson( Tristan );
            myGame.Market.AddPerson( Erwan );
            myGame.Market.AddPerson( Olivier );

            Employee Tristann = myGame.PlayerCompany.AddEmployee( Tristan );
            Employee Erwann = myGame.PlayerCompany.AddEmployee( Erwan );
            Employee Olivierr = myGame.PlayerCompany.AddEmployee( Olivier );
            Skill man = new ProjSkill( "Management de projet" );
            Skill inte = new ProjSkill( "Interface graphique" );
            Skill dev = new ProjSkill( "Développement" );
            Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals( man ) ).Single();
            Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals( inte ) ).Single();
            Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals( dev ) ).Single();

            p.AffectEmployeeToAJob( Tristann, mana );
            p.AffectEmployeeToAJob( Erwann, inter );
            p.AffectEmployeeToAJob( Olivierr, deve );
            myGame.PlayerCompany.BeginAProject( p );
            myGame.TimeGame.newDay();
            myGame.TryToAddYear();


            Assert.That( myGame.Events.Count == 1 );

		}

        [Test]
        public void Someone_goes_in_holidays()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 01, 01 );
            Project p = myGame.PlayerCompany.PossibleCompanyProjects[0];
            Person Tristan = new Person( myGame.Market, "Tristan", "Letrou", 25 );
            Person Erwan = new Person( myGame.Market, "Erwan", "dB", 22 );
            Person Olivier = new Person( myGame.Market, "Olivier", "Spinelli", 39 );

            Tristan.AddSkill( "Management de projet" );
            Erwan.AddSkill( "Interface graphique" );
            Olivier.AddSkill( "Développement" );
            myGame.Market.AddPerson( Tristan );
            myGame.Market.AddPerson( Erwan );
            myGame.Market.AddPerson( Olivier );

            Employee Tristann = myGame.PlayerCompany.AddEmployee( Tristan );
            Employee Erwann = myGame.PlayerCompany.AddEmployee( Erwan );
            Employee Olivierr = myGame.PlayerCompany.AddEmployee( Olivier );
            Skill man = new ProjSkill( "Management de projet" );
            Skill inte = new ProjSkill( "Interface graphique" );
            Skill dev = new ProjSkill( "Développement" );
            Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals( man ) ).Single();
            Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals( inte ) ).Single();
            Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals( dev ) ).Single();

            p.AffectEmployeeToAJob( Tristann, mana );
            p.AffectEmployeeToAJob( Erwann, inter );
            p.AffectEmployeeToAJob( Olivierr, deve );
            myGame.PlayerCompany.BeginAProject( p );
            myGame.TimeGame.newDay();

            myGame.OnHolidays += new Game.SomeoneGoInHolidays( myGame.SomeoneHolidays );
            myGame.Holidays( Erwann );

            Assert.That( myGame.Events.Count == 1 );

        }

        [Test]
        public void Someone_is_seek()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 01, 01 );
            Project p = myGame.PlayerCompany.PossibleCompanyProjects[0];
            Person Tristan = new Person( myGame.Market, "Tristan", "Letrou", 25 );
            Person Erwan = new Person( myGame.Market, "Erwan", "dB", 22 );
            Person Olivier = new Person( myGame.Market, "Olivier", "Spinelli", 39 );

            Tristan.AddSkill( "Management de projet" );
            Erwan.AddSkill( "Interface graphique" );
            Olivier.AddSkill( "Développement" );
            myGame.Market.AddPerson( Tristan );
            myGame.Market.AddPerson( Erwan );
            myGame.Market.AddPerson( Olivier );

            Employee Tristann = myGame.PlayerCompany.AddEmployee( Tristan );
            Employee Erwann = myGame.PlayerCompany.AddEmployee( Erwan );
            Employee Olivierr = myGame.PlayerCompany.AddEmployee( Olivier );
            Skill man = new ProjSkill( "Management de projet" );
            Skill inte = new ProjSkill( "Interface graphique" );
            Skill dev = new ProjSkill( "Développement" );
            Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals( man ) ).Single();
            Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals( inte ) ).Single();
            Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals( dev ) ).Single();

            p.AffectEmployeeToAJob( Tristann, mana );
            p.AffectEmployeeToAJob( Erwann, inter );
            p.AffectEmployeeToAJob( Olivierr, deve );
            myGame.PlayerCompany.BeginAProject( p );
            myGame.OnSeek += new Game.SomeoneIsSeek( myGame.SomeoneSeek );
            myGame.Seek( Erwann );

            Assert.That( myGame.Events.Count == 1 );

        }

        [Test]
        public void Someone_leaves_the_project_and_comebacks_into()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 01, 01 );
            Project p = myGame.PlayerCompany.PossibleCompanyProjects[0];
            Person Tristan = new Person( myGame.Market, "Tristan", "Letrou", 25 );
            Person Erwan = new Person( myGame.Market, "Erwan", "dB", 22 );
            Person Olivier = new Person( myGame.Market, "Olivier", "Spinelli", 39 );

            Tristan.AddSkill( "Management de projet" );
            Erwan.AddSkill( "Interface graphique" );
            Olivier.AddSkill( "Développement" );
            myGame.Market.AddPerson( Tristan );
            myGame.Market.AddPerson( Erwan );
            myGame.Market.AddPerson( Olivier );

            Employee Tristann = myGame.PlayerCompany.AddEmployee( Tristan );
            Employee Erwann = myGame.PlayerCompany.AddEmployee( Erwan );
            Employee Olivierr = myGame.PlayerCompany.AddEmployee( Olivier );
            Skill man = new ProjSkill( "Management de projet" );
            Skill inte = new ProjSkill( "Interface graphique" );
            Skill dev = new ProjSkill( "Développement" );
            Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals( man ) ).Single();
            Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals( inte ) ).Single();
            Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals( dev ) ).Single();

            p.AffectEmployeeToAJob( Tristann, mana );
            p.AffectEmployeeToAJob( Erwann, inter );
            p.AffectEmployeeToAJob( Olivierr, deve );

            myGame.PlayerCompany.BeginAProject( p );

            p.RefreshActualsTasks();
            Console.WriteLine( p.ActualTasks );
            p.RemoveEmployeeFromTheProject( Erwann );
            p.RefreshActualsTasks();

            Console.WriteLine( p.ActualTasks );
            p.AffectEmployeeToAJob( Erwann, Erwann.SkillInProject );
            p.RefreshActualsTasks();

            Console.WriteLine( p.ActualTasks );
            Assert.That( Erwann == p.EmployeesAffectedWithSkill.Select( s => s.Key ).Where( emp => emp.SkillInProject.SkillName == "Interface graphique").Single());

        }

        			
    }
}
