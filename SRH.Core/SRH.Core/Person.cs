using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class Person
	{

		string _firstName;
		string _lastName;
		int _age;
        DateTime _birthDate;
		readonly List<Skill> _skills;
		int _expectedSalary;
		LaborMarket _lb;
        Random rand;
        Employee _employee;
        Behavior _behavior;

		internal Person( LaborMarket lb, string firstName, string lastName, int age )
		{
			_skills = new List<Skill>();
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
			rand = new Random();
			int month = rand.Next( 1, 13 );
            int day = GetRandomDay( month );
			int year = 2015 - age;
            _birthDate = new DateTime(year,month,day);
			_lb = lb;
			GenerateExpectedSalary();

            _behavior = new Behavior( this );
		}

        private int GetRandomDay( int month )
        {
            if( month == 2 )
            {
                return rand.Next( 1, 29 );
            }
            else if( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 )
            {
                return rand.Next( 1, 32 );
            }
            else
            {
                return rand.Next( 1, 31 );
            }
        }
		#region Getters Setters
		public string FirstName
		{
			get { return _firstName; }
		}

		public string LastName
		{
			get { return _lastName; }
		}
		public DateTime BirthDate
		{
			get { return _birthDate; }
            internal set { _birthDate = value; }
		}
		public int Age
		{
			get { return _age; }
			private set { _age = value; }
		}

		public List<Skill> Skills
		{
			get { return _skills; }
		}

		internal LaborMarket Lb
		{
			get { return _lb; }
		}

		public int ExpectedSalary
		{
			get { return _expectedSalary; }
		}

		public int HiringCost
		{
			get
			{
				double cost = _expectedSalary * 0.1;
				return Lb.Game.PlayerCompany.EstimateRecrutingAndLayingOffCost((int)cost);
			}
		}

        internal Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        public Behavior Behavior
        {
            get { return _behavior; }
        }
		#endregion

		/// <summary>
		/// Adds a <see cref="Skill"/> to the Person's skills List
		/// </summary>
		/// <param name="skillName">The name of the skill, must be present in the SkillList</param>
		/// <returns>The Skill added</returns>
		public Skill AddSkill( string skillName, int level = 1)
		{
			_lb.Game.ValidateSkillName( skillName );

			foreach( Skill s in _skills )
			{
				if( skillName == s.SkillName )
					throw new ArgumentException( "The Person already has this Skill." );
			}

			Skill newSkill = null;
			if( skillName.IsProjSkill() )
				newSkill = new ProjSkill( this, skillName );
			else newSkill = new CompaSkill( this, skillName );

			newSkill.Level.CurrentLevel = level;
			_skills.Add( newSkill );
			GenerateExpectedSalary();
			return newSkill;
		}

        /// <summary>
        /// Add a year in the first January of the new year.
        /// </summary>
        /// <returns></returns>
        public void AddAYear()
        {
            this.Age += 1;
        }

		internal void GenerateExpectedSalary()
		{
			int totalLevelsCost = 0;
			foreach( Skill s in _skills )
			{
				if( s is CompaSkill ) 
					totalLevelsCost += s.Level.CurrentLevel * 200;
				else
					totalLevelsCost += s.Level.CurrentLevel * 100;
			}
			_expectedSalary = 1000 + totalLevelsCost;
		}
	}
}
