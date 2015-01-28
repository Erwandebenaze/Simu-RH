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
		Game myGame = new Game( 1, "Simu'RH" );

		[Test]
		public void Create_employee()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee(myGame.PlayerCompany, p);

			Assert.That( e.Worker.FirstName == "André" );
			Assert.That( e.Worker.LastName == "LeGéant" );
			Assert.That( e.Worker.Age == 20 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void Creating_an_employee_with_a_null_company_throws_an_ArgumentNullException()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( null, p );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void Creating_an_employee_with_a_null_person_throws_an_ArgumentNullException()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, null );
		}

		[Test]
		public void Add_an_employee_to_a_company()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			myGame.Market.AddPerson( p );
			Employee e = myGame.PlayerCompany.AddEmployee( p );

			Assert.That( myGame.PlayerCompany.Employees.Contains( e ) );
		}

		[Test]
		public void Add_skill_to_a_person()
		{
			Person p = new Person( myGame.Market, "Jack", "Lang", 50 );

			Skill s = p.AddSkill( "Développement" );

			Assert.That( p.Skills.Contains( s ) );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void Adding_a_skill_with_an_invalid_name_throws_an_ArgumentException()
		{
			Person p = new Person( myGame.Market, "Jack", "Lang", 50 );

			Skill s = p.AddSkill( "invalidName" );
		}


		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void Adding_a_skill_to_a_person_that_already_has_it_throws_an_ArgumentException()
		{
			Person p = new Person( myGame.Market, "Jack", "Lang", 50 );

			Skill s = p.AddSkill( "Développement" );
			Skill s2 = p.AddSkill( "Développement" );
		}

		[Test]
		public void Upgrade_a_skill_for_a_person()
		{
			Person p = new Person( myGame.Market, "Jack", "Lang", 50 );
			myGame.Market.AddPerson( p );
			Skill s = p.AddSkill( "Développement" );

			s.Level.CurrentLevel += 1;

			Assert.That( p.Skills[ 0 ].Level.CurrentLevel == 2 );

		}

		[Test]
		public void An_Employee_can_be_trained()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			myGame.Market.AddPerson( p );
			Skill s = p.AddSkill( "Animation" );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.Train( "Animation" );

			Assert.That( e.Worker.Skills[ 0 ].Level.CurrentLevel == 2 );
		}

		[Test]
		public void hire_an_employee_substracts_the_hiring_cost_from_company_wealth()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			myGame.Market.AddPerson( p );
			int hiringCost = p.HiringCost;
			int companyWealth = myGame.PlayerCompany.Wealth;

			Employee e = myGame.PlayerCompany.HireEmployee( p );

			Assert.That( myGame.PlayerCompany.Wealth == ( companyWealth - hiringCost ) );
		}

		[Test]
		public void laying_off_an_employee_substracts_the_hiring_cost_from_company_wealth()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			myGame.Market.AddPerson( p );
			Employee e = myGame.PlayerCompany.AddEmployee( p );
			int layingOffCost = e.LayingOffCost;
			int companyWealth = myGame.PlayerCompany.Wealth;

			myGame.PlayerCompany.LayingOffEmployee( e );

			Assert.That( myGame.PlayerCompany.Wealth == ( companyWealth - layingOffCost ) );
		}

		[Test]
		public void an_employee_can_have_his_salary_adjusted()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );
			int baseSalary = e.Worker.ExpectedSalary;

			e.SalaryAdjustment -= 100;
			e.SalaryAdjustment += 200;

			Assert.That( e.Salary == baseSalary + 100 );
		}

		[Test]
		[ExpectedException( typeof( InvalidOperationException ) )]
		public void decresing_a_salary_under_600_throws_an_InvalidOperationException()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.SalaryAdjustment -= 2000;

			int salary = e.Salary;
		}

		[Test]
		[ExpectedException( typeof( InvalidOperationException ) )]
		public void increasing_a_salary_over_twice_the_expected_salary_throws_an_InvalidOperationException()
		{
			Person p = new Person( myGame.Market, "André", "LeGéant", 20 );
			Employee e = new Employee( myGame.PlayerCompany, p );

			e.SalaryAdjustment += 2000;

			int salary = e.Salary;
		}
	}
}
