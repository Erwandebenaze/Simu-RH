using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class Eclectic : Behavior
    {

        internal Eclectic( Person p )
            : base( p )
        {
        }

        internal override void SkillsReaction()
        {
            // Checks only every 3 months
            if( _person.Lb.Game.TimeGame.AreMonthsPassed( _lastDateSkillsReactionCheck, 3 ) )
            {
                //If the employee has less than 4 skills, he wants to train more
                if( _person.Employee.Worker.Skills.Count < 4 )
                {
                    if( _person.Employee.SkillInTraining == null )
                        _person.Employee.Happiness.ChangeHappinessScore( -2 );
                }
                else if( _skillsUsed.Count < 3 )
                    _person.Employee.Happiness.ChangeHappinessScore( -2 );
                else if( _skillsUsed.Count > 3 )
                    _person.Employee.Happiness.ChangeHappinessScore( 2 );

                _lastDateSkillsReactionCheck = _person.Lb.Game.TimeGame.CurrentTimeOfGame;
            }
        }


    }
}
