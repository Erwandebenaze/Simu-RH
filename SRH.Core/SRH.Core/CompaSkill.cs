using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    class CompaSkill : Skill
    {
        enum CompaSkillName
        {
            SalesRep, // Commercial, increase 20 projects earnings.
            HumansRessources, // Ressources humaines, descrease recruting and laying off cost.
            ProjDirection, // Directeur de projets, decrease the duration of 20 projects.
            ContractManagement, // Gestion de contrat, decrease the duration of 30 projects.
            Animation // Animation, inscrease 30 employees hapiness
        }
    }
}
