using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	[Serializable]
	public class Specialist : Behavior
	{
		List<Skill> _preferedSkills;

		internal Specialist( Person p )
            : base( p )
        {
			CreateFavoriteSkills();
        }

		internal List<Skill> PreferedSkills
		{
			get { return _preferedSkills; }
		}

		internal void CreateFavoriteSkills()
		{
			List<Skill> prefSkills = new List<Skill>();
			foreach( Skill s in _person.Skills.Where( skill => skill is ProjSkill ).OrderByDescending( s => s.Level.CurrentXp ) )
			{
				if( prefSkills.Count < 2 )
				{
					prefSkills.Add( s );
				}
			}

			_preferedSkills = prefSkills;
		}

		internal override void SkillsReaction()
		{
			// Checks only every 3 months
			if( _person.Lb.Game.TimeGame.AreMonthsPassed( _lastDateSkillsReactionCheck, 3 ) )
			{
				// If the employee hasn't used one of his favorite skills recently (set in Behavior method CheckSkillsUsed) he loses happiness
				if( !_person.Skills.Any( s => _skillsUsed.Any( kvp => s.SkillName == kvp.Key ) ) )
					_person.Employee.Happiness.ChangeHappinessScore( -2 );
				else
					_person.Employee.Happiness.ChangeHappinessScore( 2 );
				// Add a desire to upgrade prefered skills until maxed

				_lastDateSkillsReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
			}
		}
	}
}
