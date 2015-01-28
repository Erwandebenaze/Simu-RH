using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core.Tests
{
	[TestFixture]
	class BehaviorTests
	{
		Game myGame = new Game( 1, "Simu'RH" );

		/// <summary>
		/// Basic happiness management tests
		/// </summary>

		[Test]
		public void decreasing_happiness_under_0_stays_0()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			Happiness h = new Happiness();

			h.ChangeHappinessScore( -51 );

			Assert.That( h.HappinessScore == 0 );
		}

		[Test]
		public void increasing_happiness_over_100_stays_100()
		{
			Happiness h = new Happiness();

			h.ChangeHappinessScore( 51 );

			Assert.That( h.HappinessScore == 100 );
		}

		/// <summary>
		/// Salary and happiness
		/// </summary>
 
		[Test]
		public void incresing_salary_increses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.SalaryAdjustment += 100;
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 04, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SalaryReaction();

			Assert.That( e.Happiness.HappinessScore == 52 );
		}

		[Test]
		public void decresing_salary_decreses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.SalaryAdjustment -= 100;
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 04, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SalaryReaction();

			Assert.That( e.Happiness.HappinessScore == 48 );
		}

		/// <summary>
		/// Used skills list management tests
		/// </summary>
		///

		[Test]
		public void add_an_element_to_skills_used()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Développement" );

			Assert.That( e.Worker.Behavior.SkillsUsed.Count == 1 );
		}

		[Test]
		public void adding_an_already_present_skill_to_skills_used_updates_it()
		{
			Game myGame = new Game( 1, "Simu'RH" );
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Interface graphique" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 26 );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Interface graphique" );

			Assert.That( e.Worker.Behavior.SkillsUsed.Count == 1 );
			Assert.That( e.Worker.Behavior.SkillsUsed[ "Interface graphique" ] == new DateTime( 2016, 01, 26 ) );
		}

		[Test]
		public void a_skill_not_used_for_12_months_is_removed_from_skillsUsed()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Développement" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.CheckSkillsUsed();

			Assert.That( e.Worker.Behavior.SkillsUsed.Count == 0 );
		}

		[Test]
		public void a_skill_used_in_a_project_is_added_to_skillsUsed()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.SkillInProject = new ProjSkill( "Développement" );
			e.Worker.Behavior.AddOrUpdateEmployeeSkillInUse();

			Assert.That( e.Worker.Behavior.SkillsUsed.Count == 1 );
		}

		[Test]
		public void a_manager_skill_affected_to_company_is_added_to_the_used_skills_list()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );

			Employee e = new Employee( myGame.PlayerCompany, p );
			Skill s = e.Worker.AddSkill( "Commercial" );
			myGame.PlayerCompany.AddManager( e, s );

			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 07, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.UpdateHappiness();

			Assert.That( e.Worker.Behavior.SkillsUsed.Count == 1 );
		}

		[Test]
		public void an_eclectic_employee_with_less_than_4_skills_loses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.Behavior = new Eclectic( p );

			Skill s = p.AddSkill( "Développement" );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Développement" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2015, 04, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SkillsReaction();

			Assert.That( e.Happiness.HappinessScore == 48 );
		}

		[Test]
		public void an_eclectic_employee_who_used_less_than_3_skills_int_the_last_12_months_loses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.Behavior = new Eclectic( p );

			Skill s = p.AddSkill( "Développement" );
			Skill s2 = p.AddSkill( "Conception" );
			Skill s3 = p.AddSkill( "Réseau" );
			Skill s4 = p.AddSkill( "Sécurité" );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( s.SkillName );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( s2.SkillName );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SkillsReaction();

			Assert.That( e.Happiness.HappinessScore == 48 );
		}

		[Test]
		public void an_eclectic_employee_who_used_3_skills_in_the_last_12_months_doesnt_change_his_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.Behavior = new Eclectic( p );

			Skill s = p.AddSkill( "Développement" );
			Skill s2 = p.AddSkill( "Conception" );
			Skill s3 = p.AddSkill( "Réseau" );
			Skill s4 = p.AddSkill( "Sécurité" );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( s.SkillName );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( s2.SkillName );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( s3.SkillName );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SkillsReaction();

			Assert.That( e.Happiness.HappinessScore == 50 );
		}

		[Test]
		public void an_eclectic_employee_who_used_more_than_3_skills_in_the_last_12_months_gains_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.Behavior = new Eclectic( p );

			Skill s = p.AddSkill( "Développement" );
			Skill s2 = p.AddSkill( "Conception" );
			Skill s3 = p.AddSkill( "Réseau" );
			Skill s4 = p.AddSkill( "Sécurité" );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( s.SkillName );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( s2.SkillName );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( s3.SkillName );
			e.Worker.Behavior.AddOrUpdateSkillsUsed( s4.SkillName );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SkillsReaction();

			Assert.That( e.Happiness.HappinessScore == 52 );
		}

		[Test]
		public void an_ambitious_employee_who_doesnt_have_a_compaSKill_loses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Développement" );
			p.Behavior = new Ambitious( p );
			Employee e = new Employee( myGame.PlayerCompany, p );

			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 26 ); // New default date is 26/01/2015
			e.Worker.Behavior.SkillsReaction();

			Assert.That( e.Happiness.HappinessScore == 48 );
		}

		[Test]
		public void an_ambitious_employee_who_didnt_use_any_compaSkill_in_the_last_12_months_loses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Commercial" );
			p.Behavior = new Ambitious( p );

			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Développement" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 25 ); // New default date is 26/01/2015

			e.Worker.Behavior.UpdateHappiness();

			Assert.That( e.Happiness.HappinessScore == 48 );
		}

		[Test]
		public void an_ambitious_employee_who_used_a_compaSkill_in_the_last_12_months_gains_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Commercial" );
			p.Behavior = new Ambitious( p );

			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Commercial" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 25 ); // New default date is 26/01/2015

			e.Worker.Behavior.UpdateHappiness();

			Assert.That( e.Happiness.HappinessScore == 52 );
		}

		[Test]
		public void a_specialist_employee_fills_his_prefered_skills_list()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Développement" );
			p.AddSkill( "Interface graphique" );
			p.Behavior = new Specialist( p );
			Specialist spe = (Specialist)p.Behavior;
			
			spe.CreateFavoriteSkills();

			Employee e = new Employee( myGame.PlayerCompany, p );

			Assert.That( spe.PreferedSkills.Count == 2 );
		}

		[Test]
		public void the_prefered_skills_list_doesnt_go_over_2_elements()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Développement" );
			p.AddSkill( "Interface graphique" );
			p.AddSkill( "Réseau" );
			p.Behavior = new Specialist( p );
			Specialist spe = (Specialist)p.Behavior;

			spe.CreateFavoriteSkills();

			Employee e = new Employee( myGame.PlayerCompany, p );

			Assert.That( spe.PreferedSkills.Count == 2 );
		}

		[Test]
		public void the_prefered_skills_list_is_updated_when_a_new_skill_is_added()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Développement" );
			p.AddSkill( "Interface graphique" );
			p.AddSkill( "Réseau" );
			
			p.Behavior = new Specialist( p );
			Specialist spe = (Specialist)p.Behavior;

			Employee e = new Employee( myGame.PlayerCompany, p );

			Assert.That( spe.PreferedSkills.Count == 2 );
		}

		//
		// TODO : add a condition where a specialist wants to upgrade his prefered skills util maxed
		//
		//[Test]
		//public void a_specialist_employee_who_didnt_upgrade_one_of_his_prefered_skills_or_maxed_it_loses_happiness()
		//{
		//	Game myGame = new Game( 1, "Simu'RH" );

		//	Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
		//	p.AddSkill( "Développement" );
		//	p.AddSkill( "Interface graphique" );
		//	p.Behavior = new Specialist( p );
		//	Employee e = new Employee( myGame.PlayerCompany, p );

		//	e.Worker.Behavior.AddOrUpdateSkillsUsed( "Commercial" );
		//	myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 25 ); // New default date is 26/01/2015
		//	e.Worker.Behavior.UpdateHappiness();

		//	Assert.That( e.Happiness.HappinessScore == 48 );
		//}

		[Test]
		public void a_specialist_employee_who_didnt_use_a_prefered_skill_in_the_last_12_months_loses_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Développement" );
			p.AddSkill( "Interface graphique" );
			p.Behavior = new Specialist( p );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Commercial" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 25 ); // New default date is 26/01/2015
			e.Worker.Behavior.UpdateHappiness();

			Assert.That( e.Happiness.HappinessScore == 48 );
		}

		[Test]
		public void a_specialist_employee_who_used_a_prefered_skill_in_the_last_12_months_gains_happiness()
		{
			Game myGame = new Game( 1, "Simu'RH" );

			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			p.AddSkill( "Développement" );
			p.AddSkill( "Interface graphique" );
			p.Behavior = new Specialist( p );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.SkillInProject = p.Skills[ 0 ];
			e.Worker.Behavior.AddOrUpdateSkillsUsed( "Commercial" );
			myGame.TimeGame.CurrentTimeOfGame = new DateTime( 2016, 01, 25 ); // New default date is 26/01/2015
			e.Worker.Behavior.UpdateHappiness();

			Assert.That( e.Happiness.HappinessScore == 52);
		}
	}
}
