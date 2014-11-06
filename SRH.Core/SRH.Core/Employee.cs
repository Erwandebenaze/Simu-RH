using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    public class Employee
    {
		Competitor _company;
		readonly Guid _id;
        readonly string _lastName;
        readonly string _firstName;
        int _age;
        Dictionary<string, Skill> _skills;

        /// <summary>
		/// Creates an <see cref="Employee"/>
        /// </summary>
        /// <param name="name"></param>
		/// <param name="firstName"></param>
		/// <param name="age">Cannot inferior to 18 or superiror to 62</param>
        public Employee(Competitor c, string name, string firstName, int age)
        {
            //exeptions
			_company = c;
			_id = Guid.NewGuid();
            _lastName = name;
            _firstName = firstName;
            _age = age;
            _skills = new Dictionary<string,Skill>();
        }

		public Guid Id
		{
			get { return _id; }
		}

        public bool Training()
        {
            // TODO : En fonction de la formation et de son niveau, augmenter le niveau, 
            // si l'employé n'a pas la compétence, il doit l'ajouter, sinon il l'augmente.

            throw new NotImplementedException();
            //Retourne true ou false si la compétence a été augmenté (problème d'argent, la compétence n'est ps instanciée (exeption)
            
        }
        public Dictionary<string,Skill> Skills
        {
            get { return _skills;}
        }
        public T AddSkill<T>(string skillName) where T : Skill, new()
        {
            T s = new T();
            s.Initialize( skillName );
            _skills.Add( skillName, s );
            return s;
        }
    }
}
