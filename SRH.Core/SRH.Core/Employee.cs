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
        readonly Company _comp;
        private bool busy;

        /// <summary>
		/// Creates an <see cref="Employee"/>
        /// </summary>
        /// <param name="name"></param>
		/// <param name="firstName"></param>
		/// <param name="age">Cannot inferior to 18 or superiror to 62</param>
        internal Employee(Company comp, Person worker )
        {
            if( comp == null ) throw new ArgumentNullException( "Company is null" );
            if( worker == null ) throw new ArgumentNullException( "worker is null" );

            busy = false;
            _comp = comp;
			_worker = worker;
        }

		#region Getters setters
		public Person Worker
		{
			get { return _worker; }
		}
        public bool Busy
        {
            get { return busy; }
            internal set { busy = value; }
        }
        public Company Comp
        {
            get { return _comp; }
        }
		#endregion

		/// <summary>
		/// Adds a Skill if the Employee doesn't have it, or increases it by 1 level.
		/// </summary>
		/// <param name="skillName"></param>
		/// <returns>False if the Company has inadequate wealth</returns>
		public bool Train( string skillName )
		{
			// Check if skillName is valid
			_comp.Game.ValidateSkillName( skillName );

			// Set a candidate skill to test
			Skill candidate = null;
			if( _comp.Game.IsProjSkill( skillName ) ) candidate = new ProjSkill( skillName );
			else candidate = new CompaSkill( skillName );

			if( _worker.Skills.Contains( candidate ) )
			{
				Skill skillToTrain = _worker.Skills.Where( s => s.SkillName == skillName ).Single();

				if( _comp.Wealth >= skillToTrain.UpgradePrice )
				{
					int xpToNextLevel = skillToTrain.Level.NextXpRequired - skillToTrain.Level.CurrentXp;
					skillToTrain.Level.IncreaseXp( xpToNextLevel );
					_comp.Wealth -= skillToTrain.UpgradePrice;
					return true;
				}
				else 
					return false;
			}
			else
			{
				if( _comp.Wealth >= candidate.BaseCostToTrain )
				{
					Skill newSkill = _worker.AddSkill( skillName );
					_comp.Wealth -= newSkill.BaseCostToTrain;
					return true;
				}
				else
					return false;
			}
		}
    }
}
