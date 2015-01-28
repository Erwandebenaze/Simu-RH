using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	[Serializable]
	public class Ambitious : Behavior
	{
		internal Ambitious( Person p )
            : base( p )
        {
        }

        internal override void SkillsReaction()
        {
            // Checks only every 3 months
            if( _person.Lb.Game.TimeGame.AreMonthsPassed( _lastDateSkillsReactionCheck, 3 ) )
            {
                // If the employee doesn't have any CompaSkill, he wants to train one
                if( !_person.Skills.Any( s => s is CompaSkill ) )
                {
					if( _person.Employee.SkillInTraining == null || _person.Employee.SkillInTraining.IsProjSkill() )
                        _person.Employee.Happiness.ChangeHappinessScore( -2 );
                }
				// If the employee hasn't used a CompaSkill recently (set in Behavior method CheckSkillsUsed) he loses happiness
                else if( !_skillsUsed.Any( s => !s.Key.IsProjSkill() ) )
                    _person.Employee.Happiness.ChangeHappinessScore( -2 );
                else
                    _person.Employee.Happiness.ChangeHappinessScore( 2 );

                _lastDateSkillsReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
            }
        }
	}
}
