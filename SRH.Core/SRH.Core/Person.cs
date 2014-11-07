using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	public class Person
	{

		string _firstName;
		string _lastName;
		int _age;
        readonly DateTime _birthDate;
		// TODO : Implémenter création aléatoire de skill
		Dictionary<string, Skill> _skills;
		LaborMarket _lb;
        Random rand;


		internal Person( LaborMarket lb, string firstName, string lastName, int age )
		{
			_skills = new Dictionary<string, Skill>();
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
            rand = new Random();
            int month = rand.Next( 1, 12 );
            GetRandomDay( month );
            int year = 2015 - age;
            _birthDate = new DateTime(year,month,01);
            _lb = lb;
		}

        private int GetRandomDay( int month )
        {
            if( month == 2 )
            {
                return rand.Next( 1, 28 );
            }
            else if( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 )
            {
                return rand.Next( 1, 31 );
            }
            else
            {
                return rand.Next( 1, 30 );
            }
        }
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
        } 
		public int Age
		{
			get { return _age; }
            private set { _age = value; }
		}

		public Dictionary<string, Skill> Skills
		{
			get { return _skills; }
		}
		
		internal LaborMarket Lb
		{
			get { return _lb; }
		}

		public T AddSkill<T>( string skillName ) where T : Skill, new()
		{
			T s = new T();
			s.Initialize( skillName );
			Skills.Add( skillName, s );

			return s;
		}

        /// <summary>
        /// Add a year in the first January of the new year.
        /// </summary>
        /// <returns></returns>
        public int AddAYear()
        {
            this.Age += 1;
            return this.Age;
        }
	}
}
