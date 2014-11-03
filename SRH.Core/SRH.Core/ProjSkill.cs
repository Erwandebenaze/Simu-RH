using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    class ProjSkill : Skill
    {
        enum ProjSkillName 
        {
            Development, // Développement
            Design, //  Conception
            ProjManagement, // Management de projet
            SystemsAnalyst, // Analyste fonctionnel
            TechSupport, // Technicien d'infrastucture
            BetaTest, // Béta testeur
            DataBase, // Base de données
            GUInterface, // Interface graphique
            WebDevelopment, // Développement web
            Networking, // Réseau
            Security // Sécurité
        }
    }
}
