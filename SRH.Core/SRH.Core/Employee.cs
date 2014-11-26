using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    [Serializable]
    public class Employee
    {
        Person _worker;
        readonly MyCompany _myComp;


        /// <summary>
		/// Creates an <see cref="Employee"/>
        /// </summary>
        /// <param name="name"></param>
		/// <param name="firstName"></param>
		/// <param name="age">Cannot inferior to 18 or superiror to 62</param>
        internal Employee(MyCompany myComp, Person Worker )
        {
            //exeptions
            _myComp = myComp;
			_worker = Worker;
        }

		#region Getters setters
		public Person Worker
		{
			get { return _worker; }
		}
        public MyCompany MyComp
        {
            get { return _myComp; }
        }
		#endregion
        public bool Training()
        {
            // TODO : En fonction de la formation et de son niveau, augmenter le niveau, 
            // si l'employé n'a pas la compétence, il doit l'ajouter, sinon il l'augmente.

            throw new NotImplementedException();
            //Retourne true ou false si la compétence a été augmenté (problème d'argent, la compétence n'est ps instanciée (exeption)
        }
    }
}
