﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRH.Core
{
    public abstract class Skill
    {
        public Level _level;
        string _skillName;
        protected int _upgradePrice;
        protected int _timeToUpgrade;

        public void Initialize( string skillName, int startLevel = 1 )
        {
            _level = new Level();
            _skillName = skillName;
            _level._currentLevel = startLevel;
        }


        //public void Initialize(string skillName)
        //    : this (skillName, 1)
        //{ }

        public enum ProjSkillName
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
        public enum CompaSkillName
        {
            SalesRep, // Commercial, increase 20 projects earnings.
            HumansRessources, // Ressources humaines, descrease recruting and laying off cost.
            ProjDirection, // Directeur de projets, decrease the duration of 20 projects.
            ContractManagement, // Gestion de contrat, decrease the duration of 30 projects.
            Animation // Animation, inscrease 30 employees hapiness
        }

        //public string skillName
        //{
        //    get {  ;}
        //}


    }
}
