using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    public class Project
    {
        readonly string _name;
        readonly int _difficulty;
        readonly int _numberOfWorkers;
        readonly int _duration;
        readonly int _earnings;
        bool _activated;
        readonly Dictionary<string, int> _skillsRequired;
        Dictionary<Employee, string> _employeesAffectedWithSkill;


        public bool Activated
        {
            get { return _activated; }
            set { _activated = value; }
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
            _skillsRequired = new Dictionary<string, int>();
            _employeesAffectedWithSkill = new Dictionary<Employee, string>();
            GenerateSkillsRequired(numberOfWorkers);
        }
        
        private void GenerateSkillsRequired(int numberOfWorkers)
        {
            // TODO : Générer aléatoirement les compétences requises pour faire un projet
            // selon le nombre de travailleurs.
            _skillsRequired.Add( "Development", 1 );
            _skillsRequired.Add( "ProjManagment", 1 );
        }

        public void AffectEmployeeToAJob(Employee e, string skill)
        {
            if( _skillsRequired.ContainsKey( skill ) && e.Skills.ContainsKey( skill ) ) 
            _employeesAffectedWithSkill.Add( e, skill );
            _skillsRequired.Remove( skill );
        }

        public void RemoveEmployeeFromAJob( Employee e, string skill )
        {
            if( !_skillsRequired.ContainsKey( skill ) && e.Skills.ContainsKey( skill ) )
                _employeesAffectedWithSkill.Remove( e );
            // 1 à mettre en variable
            _skillsRequired.Add( skill, 1 );
        }

        public bool BeginProject()
        {
            if( Activated ) throw new InvalidOperationException( "A project can not be lunched if he has been already begin." );
            if (_skillsRequired.Count == 0)
                Activated = true;

            return Activated;
        }

        public bool StopProject()
        {
            if( !Activated ) throw new InvalidOperationException( "A project can not be stoped if he is not begun." );
            Activated = false;
            return Activated;
        }
    }
}
