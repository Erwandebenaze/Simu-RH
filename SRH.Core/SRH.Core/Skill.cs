using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    [Serializable]
    public abstract class Skill
    {
        Level _level;
        private string _skillName;
		private string _frenchSkillName;
		private int _upgradePrice;
		private int _timeToUpgrade;

        internal Skill( string skillName, int startLevel = 1 )
		{
			_level = new Level( this, startLevel );
			_skillName = skillName;
		}

		abstract public void FixPriceAndTime();

		#region Getters Setters
		public Level Level
		{
			get { return _level; }
		}
		public int UpgradePrice
		{
			get { return _upgradePrice; }
			protected set { _upgradePrice = value; }
		}
		public int TimeToUpgrade
		{
			get { return _timeToUpgrade; }
			protected set { _timeToUpgrade = value; }
		}

		public string SkillNameEnglish
		{
			get { return _skillName; }
			set { _skillName = value; }
		}
		public string FrenchSkillName
		{
			get
			{
				switch( _skillName )
				{
					case "Development":
						_frenchSkillName = "Développement";
						break;
					case "Design":
						_frenchSkillName = "Design";
						break;
					case "ProjManagement":
						_frenchSkillName = "Management de projet";
						break;
					case "SystemsAnalyst":
						_frenchSkillName = "Analyste fonctionnel";
						break;
					case "TechSupport":
						_frenchSkillName = "Infrastucture";
						break;
					case "BetaTest":
						_frenchSkillName = "Béta testeur";
						break;
					case "DataBase":
						_frenchSkillName = "Base de données";
						break;
					case "GUInterface":
						_frenchSkillName = "Interface graphique";
						break;
					case "WebDevelopment":
						_frenchSkillName = "Développement web";
						break;
					case "Networking":
						_frenchSkillName = "Réseau";
						break;
					case "Security":
						_frenchSkillName = "Sécurité";
						break;
					case "SalesRep":
						_frenchSkillName = "Commercial";
						break;
					case "HumansRessources":
						_frenchSkillName = "Ressources humaines";
						break;
					case "ProjDirection":
						_frenchSkillName = "Directeur de projets";
						break;
					case "ContractManagement":
						_frenchSkillName = "Gestion de contrat";
						break;
					default:
						_frenchSkillName = "Animation";
						break;
				}
				return _frenchSkillName;
			}
		} 
		#endregion
    }
}
