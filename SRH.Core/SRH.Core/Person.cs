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
        readonly DateTime _birthDate;
		// TODO : Implémenter création aléatoire de skill
		List<Skill> _skills;
		LaborMarket _lb;
        Random rand;


		internal Person( LaborMarket lb, string firstName, string lastName, int age )
		{
			_skills = new List<Skill>();
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
		#endregion

		/// <summary>
		/// Adds a <see cref="ProjSkill"/> to the Person's skills List
		/// </summary>
		/// <param name="skillName">The name of the skill, must be an enumerator of ProjSkill.SkillName</param>
		/// <returns>The ProjSkill added</returns>
		public Skill AddSkill( ProjSkill.SkillName skillName, int level = 1)
		{
			string skillNameString = skillName.ToString();
			ProjSkill ps = new ProjSkill( skillNameString, level );

			_skills.Add(ps );

			return ps;
		}

		/// <summary>
		/// Adds a <see cref="CompaSkill"/> to the Person's skills List
		/// </summary>
		/// <param name="skillName">The name of the skill, must be an enumerator of CompaSkill.SkillName</param>
		/// <returns>The CompaSkill added</returns>
		public Skill AddSkill( CompaSkill.SkillName skillName, int level = 1)
		{
			string skillNameString = skillName.ToString();
			CompaSkill cs = new CompaSkill( skillNameString );

			_skills.Add(cs );

			return cs;
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
