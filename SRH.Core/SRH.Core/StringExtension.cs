using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	public static class StringExtension
	{
		public static bool IsProjSkill( this String skillName )
		{
			bool isProjSkill = true;
			foreach( KeyValuePair<string, string> kvp in Game.SkillNames )
			{
				if( kvp.Value == skillName )
				{
					if( kvp.Key == "compa" )
						isProjSkill = false;
					break;
				}
			}
			return isProjSkill;
		}
	}
}
