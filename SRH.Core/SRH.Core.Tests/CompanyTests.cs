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
        Game myGame = new Game( 1, "Dannone" );

        [Test]
        public void Create_company_with_name_and_Level()
        {
			MyCompany c = new MyCompany( myGame, "SimuRH" );

            Assert.That( c.Name == "SimuRH" );
            Assert.That( c.CompanyLevel.CurrentLevel == 1 );
        }

        [Test]
        [ExpectedException( typeof( ArgumentNullException ) )]
        public void Create_mycompany_with_white_space_throw_argument_null_exeption()
        {
            MyCompany mc = new MyCompany(myGame, " " );
        }

        [Test]
        public void New_company_have_10_max_employees()
        {
            MyCompany mc = new MyCompany(myGame, "Danone" );
            Assert.That( mc.MaxEmployees, Is.EqualTo(10) );
        }

        [Test]
        public void New_company_have_1_max_project_difficulty()
        {
            MyCompany mc = new MyCompany( myGame, "Danone" );
            Assert.That( mc.MaxProjectDifficulty, Is.EqualTo( 1 ) );
        }

        [Test]
        public void Our_company_takes_experience_and_upgrade_his_level()
        {
            MyCompany mc = new MyCompany( myGame, "Danone" );
            mc.CompanyLevel.IncreaseXp( 101, mc );
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
            Assert.That( myGame.PlayerCompany.Wealth == 1000000 );
        }

        [Test]
        public void Add_a_Person_to_LabourMarket()
        {
            Game myGame = new Game( 1, "SimuRH" );
			Person p = new Person( myGame.Market, "André", "LeGéant", 30 );

			bool success = myGame.Market.AddPerson( p );

            Assert.That( p.Age == 30 );
            Assert.That( success );
            Assert.That( myGame.Market.JoblessPersons.Contains( p ) );
        }

        [Test]
        public void Save_game()
        {
            Game myGame = new Game( 1, "Danone" );
            myGame.SaveGame();
        }

        [Test]
        public void Load_game()
        {
            Game myGame = GameLoader.Load( "Danone" );
			Person p = new Person( myGame.Market, "André", "LeGéant", 50 );
			myGame.Market.AddPerson( p );

			Employee e = myGame.PlayerCompany.AddEmployee( p );

			Assert.That( e.Worker.LastName == p.LastName );
			Assert.That( e.Worker.FirstName == p.FirstName );
			Assert.That( e.Worker.Age == p.Age );
        }

        [Test]
        public void Our_company_takes_experience_and_upgrade_his_level_and_can_be_save()
        {
            Game myGame = new Game(1, "Nestle" );
            myGame.PlayerCompany.CompanyLevel.IncreaseXp( 101, myGame.PlayerCompany );
            myGame.SaveGame();
            Game mySavedGame = GameLoader.Load( "Nestle" );
            Assert.That( mySavedGame.PlayerCompany.CompanyLevel.CurrentLevel, Is.EqualTo( 2 ) );
        }

        [Test]
        public void One_save_replace_the_previous_save()
        {
            Game myGame = new Game( 1, "Nestle" );
            myGame.PlayerCompany.CompanyLevel.CurrentLevel += 3;
            myGame.SaveGame();

            Game mySavedGame = GameLoader.Load( "Nestle" );
            Assert.That( mySavedGame.PlayerCompany.CompanyLevel.CurrentLevel, Is.EqualTo( 4 ) );
        }

		[Test]
		public void A_randomly_created_Person_has_2_random_skills()
		{
			Game myGame = new Game( 1, "Simu\'RH" );

			RandomGenerator random = myGame.GetRandomGenerator();
			Person p = random.GetRandomPerson(myGame.Market, 18, 60);

			Assert.That( p.Skills.Count == 2 );
		}

        [Test]
        public void End_a_project_give_money()
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
            Skill mana = p.SkillsRequired.Keys.Where( s => s.Equals(man) ).Single();
            Skill inter = p.SkillsRequired.Keys.Where( s => s.Equals(inte) ).Single();
            Skill deve = p.SkillsRequired.Keys.Where( s => s.Equals(dev) ).Single();
            
            p.AffectEmployeeToAJob( Tristann, mana );
            p.AffectEmployeeToAJob( Erwann, inter );
            p.AffectEmployeeToAJob( Olivierr, deve);
            myGame.PlayerCompany.BeginAProject(p);
            myGame.PlayerCompany.EndAProject(p);

            Assert.That( myGame.PlayerCompany.Wealth == 1018000);
        }

        [Test]
        public void End_a_project_give_xp()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Project p = myGame.PlayerCompany.PossibleCompanyProjects[0];
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
            
            Assert.That( myGame.PlayerCompany.CompanyLevel.CurrentXp == 45 );
        }

		[Test]
		public void Get_the_previous_required_xp()
		{
			Game myGame = new Game( 1, "Simu\'RH" );
			myGame.PlayerCompany.CompanyLevel.IncreaseXp( 100, myGame.PlayerCompany );
			
			int lastXpRequired = myGame.PlayerCompany.CompanyLevel.LastXpRequired;

			Assert.That( myGame.PlayerCompany.CompanyLevel.CurrentLevel == 2 );
			Assert.That( myGame.PlayerCompany.CompanyLevel.XpRequired == 200 );
			Assert.That( lastXpRequired == 100 );
		}

        [Test]
        public void Add_a_manager()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Commercial" );

            myGame.PlayerCompany.AddManager( e, s );
            Assert.That( myGame.PlayerCompany.Managers.ContainsKey( e ) );
            Assert.That( myGame.PlayerCompany.Managers.ContainsValue( s ) );
        }

        [Test]
        public void Remove_a_manager()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Commercial" );

            myGame.PlayerCompany.AddManager( e, s );
            myGame.PlayerCompany.RemoveManager( e);
            Assert.That( !myGame.PlayerCompany.Managers.ContainsKey( e ) );
        }

        [Test]
        public void Affect_commerciaux()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Commercial" );

            myGame.PlayerCompany.AddManager( e, s );
            Assert.That( myGame.PlayerCompany.Commerciaux.Contains( e ) );
            Assert.That( myGame.PlayerCompany.Managers.ContainsValue( s ) );
        }

        [Test]
        public void Affect_animation()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Animation" );

            myGame.PlayerCompany.AddManager( e, s );
            Assert.That( myGame.PlayerCompany.Animation.Contains( e ) );
            Assert.That( myGame.PlayerCompany.Managers.ContainsValue( s ) );
        }

        [Test]
        public void Affect_recruteur()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Recruteur" );

            myGame.PlayerCompany.AddManager( e, s );
            Assert.That( myGame.PlayerCompany.Recruteur.Contains( e ) );
            Assert.That( myGame.PlayerCompany.Managers.ContainsValue( s ) );
        }

        [Test]
        public void Affect_directeur_de_projet()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Directeur de projets" );

            myGame.PlayerCompany.AddManager( e, s );
            Assert.That( myGame.PlayerCompany.DirecteursProjets.Contains( e ) );
            Assert.That( myGame.PlayerCompany.Managers.ContainsValue( s ) );
        }

        [Test]
        public void Affect_ressources_humaines()
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Ressources humaines" );

            myGame.PlayerCompany.AddManager( e, s );
            Assert.That( myGame.PlayerCompany.RessourcesHumaines.Contains( e ) );
            Assert.That( myGame.PlayerCompany.Managers.ContainsValue( s ) );
        }

        [Test]
        public void Use_recruteur() 
        {
            Game myGame = new Game( 1, "Simu\'RH" );
            Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
            Employee e = new Employee( myGame.PlayerCompany, p );

            Skill s = p.AddSkill( "Recruteur" );
           // if( _recruteur.Count != 0 ) return (int)(cost - (cost * (_decreaseRecruting / 100)));

            myGame.PlayerCompany.AddManager( e, s );
            // 1 recruteur avec un niveau d'entreprise inférieur à 10 = pourcent de baisse cout = à 2
            Assert.That( myGame.PlayerCompany.EstimateRecrutingAndLayingOffCost(1000) == 980 );
        }
    }
}
