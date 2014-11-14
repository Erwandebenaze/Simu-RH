using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class Project
    {
        readonly string _name;
        readonly int _difficulty;
        readonly int _numberOfWorkers;
        readonly int _duration;
        private int _timeSpent;
        readonly int _earnings;
        readonly int _xpPerCompany;
        readonly int _xpPerPerson;

        bool _activated;
        readonly Dictionary<string, int> _skillsRequired;
        Dictionary<Employee, string> _employeesAffectedWithSkill;

        #region Getter
        public string Name
        {
            get { return _name; }
        }
        public int Difficulty
        {
            get { return _difficulty; }
        }
        public int NumberOfWorkers
        {
            get { return _numberOfWorkers; }
        }
        public int Earnings
        {
            get { return _earnings; }
        }

        public int Duration
        {
            get { return _duration; }
        } 
        #endregion
        #region GetterSetter
        public int TimeSpent
        {
            get { return _timeSpent; }
            set { _timeSpent = value; }
        }
        public bool Activated
        {
            get { return _activated; }
            set { _activated = value; }
        }
        public int XpPerPerson
        {
            get { return _xpPerPerson; }
        }

        public int XpPerCompany
        {
            get { return _xpPerCompany; }
        } 
        #endregion

        /// <summary>
        /// Initialises a new Project.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="difficulty">1 to 5</param>
        /// <param name="numberOfWorkers"> Superior than 1</param>
        /// <param name="earnings"> Superior than 100</param>
        /// <param name="duration">In month. Superior than 1 month</param>
        public Project(string name, int difficulty, int numberOfWorkers, int earnings, int duration)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "name" );
            if( difficulty <= 0 ) throw new ArgumentException( "difficulty must be superior than 0." );
            if( numberOfWorkers <= 1 ) throw new ArgumentException( "numberOfWorkers must be superior than 1." );
            if( earnings <= 100 ) throw new ArgumentException( "earnings must be superior than 100." );
            if( duration <= 1 ) throw new ArgumentException( "duration must be superior than 0." );

            _name = name;
            _difficulty = difficulty;
            _numberOfWorkers = numberOfWorkers;
            _earnings = earnings;
            _duration = duration;
            _activated = false;
            _xpPerCompany = 15;
            _xpPerPerson = 10;
            _skillsRequired = new Dictionary<string, int>();
            _employeesAffectedWithSkill = new Dictionary<Employee, string>();
            GenerateSkillsRequired(numberOfWorkers);
        }
        
        /// <summary>
        /// For the moment, add 2 skills Development and ProjMangment. 
        /// TODO : Random generation of skill which depends of numberOfWorkers
        /// </summary>
        /// <param name="numberOfWorkers"></param>
        private void GenerateSkillsRequired(int numberOfWorkers)
        {
            // TODO : Générer aléatoirement les compétences requises pour faire un projet
            // selon le nombre de travailleurs.
            _skillsRequired.Add( "Development", 1 );
            _skillsRequired.Add( "ProjManagment", 1 );
        }

        /// <summary>
        /// Affect an employee to a job. That method remove the skillRequired who is passed in parameter. The project is not activated
        /// </summary>
        /// <param name="e"></param>
        /// <param name="skill"></param>
        public void AffectEmployeeToAJob(Employee e, string skill)
        {
            if( _skillsRequired.ContainsKey( skill ) && e.Worker.Skills.ContainsKey( skill ) && !this.Activated) 
            _employeesAffectedWithSkill.Add( e, skill );
            _skillsRequired.Remove( skill );
        }

        /// <summary>
        /// Remove an Employee from a job if the project is not activated. 
        /// TODO : Put again the skill in skillsRequired  with the good difficulty
        /// </summary>
        /// <param name="e"></param>
        /// <param name="skill"></param>
        public void RemoveEmployeeFromAJob( Employee e, string skill )
        {
            if( !_skillsRequired.ContainsKey( skill ) && e.Worker.Skills.ContainsKey( skill ) && !this.Activated )
                _employeesAffectedWithSkill.Remove( e );
            // 1 à mettre en variable
            _skillsRequired.Add( skill, 1 );
        }

        /// <summary>
        /// Begin the project if he is not activated yet and skillsRequired is empty. 
        /// Activated become true.
        /// </summary>
        /// <returns>Activated</returns>
        public bool BeginProject()
        {
            if( Activated ) throw new InvalidOperationException( "A project can not be lunched if he has been already begin." );
            if( _skillsRequired.Count == 0 )
                Activated = true;
            else throw new InvalidOperationException( "Every skills must be taken before begin a project" );

            return Activated;
        }

        /// <summary>
        /// Stop the project if he is activated.
        /// Activated become fakse.
        /// </summary>
        /// <returns>Activated</returns>
        public bool StopProject()
        {
            if( !Activated ) throw new InvalidOperationException( "A project can not be stoped if he is not begun." );
            Activated = false;
            return Activated;
        }
    }
}
