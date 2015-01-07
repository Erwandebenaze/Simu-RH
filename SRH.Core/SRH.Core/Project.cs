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
        #region Initialisation
        readonly string _name;
        readonly float _difficulty;
        readonly int _numberOfWorkers;
        int _duration;
        private int _timeSpent;
        private int _timeLeft;
        DateTime? _begginingDate;
        int _earnings;
        readonly int _xpPerCompany;
        readonly int _xpPerPerson;
        bool _activated;
        readonly Dictionary<Skill, int> _skillsRequired;
        Dictionary<Employee, Skill> _employeesAffectedWithSkill;
        readonly MyCompany _myComp;
        readonly int _initialTasks;
        int _projectTasks;
        int _actualTasks;
        #endregion

        #region Getter
        public string Name
        {
            get { return _name; }
        }
        public float Difficulty
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
            internal set { _earnings = value; }
        }
        public int ProjectTasks
        {
            get { return _projectTasks; }
            internal set { _projectTasks = value; }
        }
        public int Duration
        {
            get { return _duration; }
        }
        public int XpPerPerson
        {
            get { return _xpPerPerson; }
        }
        public int XpPerCompany
        {
            get { return _xpPerCompany; }
        }
        public DateTime? BegginingDate
        {
            get { return _begginingDate; }
        }
        public MyCompany MyComp
        {
            get { return _myComp; }
        } 
        public Dictionary<Skill, int> SkillsRequired
        {
            get { return _skillsRequired; }
        }
        public int ActualTasks
        {
            get { return _actualTasks; }
        }
        #endregion
        #region GetterSetter
        public int TimeSpent
        {
            get { return _timeSpent; }
            set { _timeSpent = value; }
        }
        public int TimeLeft
        {
            get { return _timeLeft; }
            set { _timeLeft = value; }
        }
        public bool Activated
        {
            get { return _activated; }
            set { _activated = value; }
        }

        public Dictionary<Employee, Skill> EmployeesAffectedWithSkill
        {
            get { return _employeesAffectedWithSkill; }
            //set { _employeesAffectedWithSkill = value; }
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
        internal Project(MyCompany myComp, string name, float difficulty, int numberOfWorkers, int earnings, Dictionary<Skill,int> skillsRequired)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "name" );
            if( difficulty <= 0 ) throw new ArgumentException( "difficulty must be superior than 0." );
            if( numberOfWorkers <= 1 ) throw new ArgumentException( "numberOfWorkers must be superior than 1." );
            if( earnings <= 100 ) throw new ArgumentException( "earnings must be superior than 100." );
            if( myComp == null ) throw new ArgumentException( "myComp == null." );
            _myComp = myComp;
            _name = name;
            _difficulty = difficulty;
            _numberOfWorkers = numberOfWorkers;
            _earnings = earnings;
            _activated = false;
            _xpPerCompany = 45;
            _xpPerPerson = 25;
			_skillsRequired = skillsRequired;
            _employeesAffectedWithSkill = new Dictionary<Employee, Skill>();
            _initialTasks = GenerateNumberOfTasks();
            _projectTasks = _initialTasks;
            _actualTasks  = _projectTasks;
            GenerateDuration();

        }
        internal void GenerateDuration()
        {
            int duration = 0;
            foreach( int i in _skillsRequired.Values )
            {
                duration += i;
            }
            duration *= 10;
            if( duration != 0 ) _duration = (_actualTasks / duration);
        }
        internal void RefreshDuration()
        {
            int duration = 0;
            foreach( Skill s in _employeesAffectedWithSkill.Values)
            {
                duration += s.Level.CurrentLevel;
            }
            duration *= 10;
            _duration = ( _actualTasks / duration );
        }

        private int GenerateNumberOfTasks()
        {
            int initialTasks = 0;
            foreach( int i in _skillsRequired.Values)
            {
                int j = i * i * 1000;
                initialTasks += j;
            }

            return initialTasks;
        }
        internal void RefreshActualsTasks()
        {
            if( Activated == false ) throw new InvalidOperationException( "You can't actualize tasks of a project which isn't begin." );
            foreach( Skill s in _employeesAffectedWithSkill.Values )
            {
                _actualTasks -= s.Level.CurrentLevel * 10;
            }
        }
        /// <summary>
        /// Affect an employee to a job. That method remove the skillRequired who is passed in parameter. The project is not activated
        /// </summary>
        /// <param name="p"></param>
        /// <param name="skill"></param>
        public void AffectEmployeeToAJob( Employee e, Skill s )
        {
            if( SkillsRequired.ContainsKey( s ) && e.Worker.Skills.Contains( s ) && !this.Activated )
            {
                _employeesAffectedWithSkill.Add( e, e.Worker.Skills.Where( sk => sk.Equals( s ) ).Single() );
                e.Busy = true;
                _skillsRequired.Remove( s );
            } else
            {
                throw new InvalidOperationException( "The employee hasn't been affected." );
            }

        }
        /// <summary>
        /// Remove an Employee from a job if the project is not activated. 
        /// TODO : Put again the skill in skillsRequired  with the good difficulty
        /// </summary>
        /// <param name="e"></param>
        /// <param name="skill"></param>
        public void RemoveEmployeeFromAJob( Employee e, Skill s )
        {
            if( !SkillsRequired.ContainsKey(s) && e.Worker.Skills.Contains(s) && !this.Activated )
                _employeesAffectedWithSkill.Remove( e );
            int nb = 0;
            e.Busy = false;
            foreach (Skill sk in e.Worker.Skills)
            {
                if (sk.SkillName == s.SkillName)
                    nb = sk.Level.CurrentLevel; 
            }
            _skillsRequired.Add( s, nb );
        }
        /// <summary>
        /// Free every employees of the project.
        /// </summary>
        public void AnBusyEmployees()
        {
            foreach( Employee emplo in this.EmployeesAffectedWithSkill.Keys )
            {
                emplo.Busy = false;
            }
        }
        /// <summary>
        /// Begin the project if he is not activated yet and skillsRequired is empty. 
        /// Activated become true.
        /// </summary>
        /// <returns>Activated</returns>
        internal bool BeginProject()
        {
			// TODO : ajouter le skillrequired
            if( Activated ) throw new InvalidOperationException( "A project can not be lunched if he has been already begin." );
			if( _skillsRequired.Count == 0 )
			{
                Activated = true;
                _begginingDate = _myComp.MyGame.TimeGame.CurrentTimeOfGame;
				AddEmployeeSkillInProject();
            }
			else
			{
				throw new InvalidOperationException( "Every skills must be taken before begin a project" );
			}
            return Activated;
        }
        /// <summary>
        /// Stop the project if he is activated.
        /// Activated become fakse.
        /// </summary>
        /// <returns>Activated</returns>
        internal void StopProject()
        {
            if( !Activated ) throw new InvalidOperationException( "A project can not be stoped if he is not begun." );
            Activated = false;
            _begginingDate = null;
        }
        /// <summary>
        /// Return the same project with differents references.
        /// Add a int parameter to upgrade the earnings of X pourcent.
        /// </summary>
        /// <param name="pourcentCommerciaux">Int</param>
        /// <returns>The new Projetc</returns>
        public Project Clone()
        {
          Project project = new Project( _myComp, _name, _difficulty, _numberOfWorkers, _earnings , new Dictionary<Skill, int>( _skillsRequired ) );
          return project;
        }

		private void AddEmployeeSkillInProject()
		{
			foreach( KeyValuePair<Employee, Skill> kvp in _employeesAffectedWithSkill )
			{
				kvp.Key.SkillInProject = kvp.Value;
			}
		}
    }
}
