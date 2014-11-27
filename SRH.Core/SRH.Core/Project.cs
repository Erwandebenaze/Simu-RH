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
        readonly float _difficulty;
        readonly int _numberOfWorkers;
        readonly int _duration;
        private int _timeSpent;
        private int _timeLeft;
        DateTime? _begginingDate;
        readonly int _earnings;
        readonly int _xpPerCompany;
        readonly int _xpPerPerson;
        bool _activated;
        readonly Dictionary<Skill, int> _skillsRequired;
        Dictionary<Employee, Skill> _employeesAffectedWithSkill;
        readonly MyCompany _myComp;



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

        internal Dictionary<Employee, Skill> EmployeesAffectedWithSkill
        {
            get { return _employeesAffectedWithSkill; }
            set { _employeesAffectedWithSkill = value; }
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
        internal Project(MyCompany myComp, string name, float difficulty, int numberOfWorkers, int earnings, Dictionary<Skill,int> skillsRequired, int duration = 30)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "name" );
            if( difficulty <= 0 ) throw new ArgumentException( "difficulty must be superior than 0." );
            if( numberOfWorkers <= 1 ) throw new ArgumentException( "numberOfWorkers must be superior than 1." );
            if( earnings <= 100 ) throw new ArgumentException( "earnings must be superior than 100." );
            if( duration <= 1 ) throw new ArgumentException( "duration must be superior than 0." );
            if( myComp == null ) throw new ArgumentException( "myComp == null." );
            _myComp = myComp;
            _name = name;
            _difficulty = difficulty;
            _numberOfWorkers = numberOfWorkers;
            _earnings = earnings;
            _duration = duration;
            _activated = false;
            _xpPerCompany = 45;
            _xpPerPerson = 10;
			_skillsRequired = skillsRequired;
            _employeesAffectedWithSkill = new Dictionary<Employee, Skill>();
            GenerateSkillsRequired(numberOfWorkers );
            // TODO : Lier le game aux projets. Il faut connecter les différents projets entre eux
            // Constructeur internal, objet "parent" en param pour retrouver le contexte dans lequel
            // il est appelé.
            // Le projet pourrait ainsi savoir les meilleurs employees disponibles avec telle compétence
            // Si on connecte nos neurones on pourrait même dire qui il faut recruter pour accomplir le projet
            
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
            //_skillsRequired.Add( new Skill(), 1 );
            //_skillsRequired.Add( "ProjManagment", 1 );
        }

        /// <summary>
        /// Affect an employee to a job. That method remove the skillRequired who is passed in parameter. The project is not activated
        /// </summary>
        /// <param name="e"></param>
        /// <param name="skill"></param>
        public void AffectEmployeeToAJob(Employee e, Skill s)
        {
            if( SkillsRequired.ContainsKey( s ) && e.Worker.Skills.Contains(s) && !this.Activated) 
            _employeesAffectedWithSkill.Add( e, s );
            SkillsRequired.Remove( s );
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
            // 1 à mettre en variable
            SkillsRequired.Add( s, 1 );
        }

        /// <summary>
        /// Begin the project if he is not activated yet and skillsRequired is empty. 
        /// Activated become true.
        /// </summary>
        /// <returns>Activated</returns>
        public bool BeginProject()
        {
			// TODO : ajouter le skillrequired
            if( Activated ) throw new InvalidOperationException( "A project can not be lunched if he has been already begin." );
			//if( _skillsRequired.Count == 0 )
			//{
                Activated = true;
                _begginingDate = _myComp.MyGame.TimeGame.CurrentTimeOfGame;
            //}
			////else
			//{
			//	throw new InvalidOperationException( "Every skills must be taken before begin a project" );
			//}
            return Activated;
        }

        /// <summary>
        /// Stop the project if he is activated.
        /// Activated become fakse.
        /// </summary>
        /// <returns>Activated</returns>
        public void StopProject()
        {
            if( !Activated ) throw new InvalidOperationException( "A project can not be stoped if he is not begun." );
            Activated = false;
            _begginingDate = null;
            
        }

    }
}
