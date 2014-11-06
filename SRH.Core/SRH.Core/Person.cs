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
		// TODO : Implémenter le vieillissement des Persons
		// DateTime _birthDate;
		// TODO : Implémenter création aléatoire de skill
		Dictionary<string, Skill> _skills;

		internal Person( string FirstName, string LastName, int Age )
		{
			_skills = new Dictionary<string, Skill>();
			_firstName = FirstName;
			_lastName = LastName;
			_age = Age;
		}
		public string FirstName
		{
			get { return _firstName; }
		}

		public string LastName
		{
			get { return _lastName; }
		}

		public int Age
		{
			get { return _age; }
		}

		public Dictionary<string, Skill> Skills
		{
			get { return _skills; }
		}

		public T AddSkill<T>( string skillName ) where T : Skill, new()
		{
			T s = new T();
			s.Initialize( skillName );
			Skills.Add( skillName, s );

			return s;
		}
	}
}
