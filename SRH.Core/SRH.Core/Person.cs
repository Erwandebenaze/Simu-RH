using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	internal class Person
	{

		string _firstName;
		string _lastName;
		int _age;
		// TODO : Implémenter le vieillissement des Persons
		// DateTime _birthDate;
		// TODO : Implémenter création aléatoire de skill
		// List<Skill> _skills;

		internal Person( string FirstName, string LastName, int Age )
		{
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
	}
}
