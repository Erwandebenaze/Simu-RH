using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    public class Employee
    {
        readonly string _name;
        readonly string _firstName;
        int _age;
        Dictionary<string, Skill> _skills;

        
        public Employee(string name, string firstName, int age)
        {
            //exeption
            _name = name;
            _firstName = firstName;
            _age = age;
            _skills = new Dictionary<string,Skill>();
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
