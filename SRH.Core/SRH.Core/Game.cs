using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SRH.Core
{
    [Serializable]
	public class Game
	{
        readonly LaborMarket _market;
        readonly MyCompany _playerCompany;
        readonly List<Competitor> _competitors;
        readonly GameTime _timeGame;
        readonly Random _randomNumberGenerator;
        readonly List<Project> _possibleProjects;
		static List<KeyValuePair<string, string>> _skillNames = CreateSkillNames();

		public Game( int seed, string companyName )
		{
			_randomNumberGenerator = new Random( seed );
			_market = new LaborMarket(this);
            _timeGame = new GameTime( this );

			_competitors = new List<Competitor>();

            _playerCompany = new MyCompany( this, companyName );
            CSV csvImport = new CSV();
			_possibleProjects = csvImport.ReadCsv(_playerCompany, "../../../Data/data.csv" );
            AddCompetitors();

		}

        private void AddCompetitors()
        {
            _competitors.Add( new Competitor( this, "Capgemini", 50000, 100 ) );
            _competitors.Add( new Competitor( this, "Atos", 40000, 80 ) );
            _competitors.Add( new Competitor( this, "Sopra", 30000, 60 ) );
            _competitors.Add( new Competitor( this, "Altran", 20000, 40 ) );
            _competitors.Add( new Competitor( this, "Steria", 10000, 20 ) );
        }

        #region Getters Setters
        public GameTime TimeGame
        {
            get { return _timeGame; }
        }
        public LaborMarket Market
        {
            get { return _market; }
        }

        public MyCompany PlayerCompany
        {
            get { return _playerCompany; }
        }

        public IReadOnlyList<Competitor> Competitors
        {
            get { return _competitors; }
        }

		public static IReadOnlyList<KeyValuePair<string, string>> SkillNames
		{
			get { return _skillNames; }
		}
        /// <summary>
        /// Static method to get a <see cref="RandomGenerator"/>
        /// </summary>
        /// <returns>A static instance of <see cref="RandomGenerator"/></returns>
		internal RandomGenerator GetRandomGenerator()
		{
			return new RandomGenerator(this, _randomNumberGenerator );
		}

        internal IReadOnlyList<Project> PossibleProjects
		{
			get { return _possibleProjects; }
		}
        #endregion
        public void SaveGame()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream( @"..\..\..\Sauvegardes\" + this._playerCompany.Name + ".bin", FileMode.Create, FileAccess.Write, FileShare.None );
            formatter.Serialize( stream, this );

            stream.Close();
        }

		/// <summary>
		/// Sets the list of Ivariant skill names
		/// </summary>
		private static List<KeyValuePair<string, string>> CreateSkillNames()
		{
			List<KeyValuePair<string, string>> skillnames = new List<KeyValuePair<string, string>>();

			skillnames.Add( new KeyValuePair<string, string>( "proj", "Développement" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Conception" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Analyse fonctionnelle" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Technicien d'infrastucture" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Béta testeur" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Base de données" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Interface graphique" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Développement web" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Réseau" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Sécurité" ) );
			skillnames.Add( new KeyValuePair<string, string>( "proj", "Management de projet" ) );

			skillnames.Add( new KeyValuePair<string, string>( "compa", "Commercial" ) ); // *Commercial*, increase projects earnings.
			skillnames.Add( new KeyValuePair<string, string>( "compa", "Recruteur" ) ); // *Recruteur *, descrease recruting and laying off cost.
			skillnames.Add( new KeyValuePair<string, string>( "compa", "Directeur de projets" ) ); // *Directeur de projets*, decrease the duration of the projects.
            skillnames.Add( new KeyValuePair<string, string>( "compa", "Ressources humaines" ) ); // *Ressources humaines*, decrease the salary of employees.
			skillnames.Add( new KeyValuePair<string, string>( "compa", "Animation" ) ); // *Animation*, inscrease employees' hapiness.

			return skillnames;
		}
		
		/// <summary>
		/// Checks if a string is a proper Skill name, if not, throw an ArgumentException
		/// </summary>
		/// <param name="skillName">The string to test</param>
		internal void ValidateSkillName( string skillName )
		{
			bool valid = false;
			foreach(KeyValuePair<string, string> kvp in _skillNames)
			{
				if( kvp.Value == skillName ) valid = true;
			}
			if( !valid )
				throw new ArgumentException( "The skill name must exist in Game.SkillNames." );
		}

		/// <summary>
		/// Creates a new Skill whose type depends on the skillName
		/// </summary>
		/// <param name="skillName">The name of the skill to create</param>
		/// <returns>A new candidate Skill</returns>
		internal Skill GetSkillCandidate( string skillName )
		{
			Skill candidate = null;

			if( skillName.IsProjSkill() ) candidate = new ProjSkill( skillName );
			else candidate = new CompaSkill( skillName );
			
			return candidate;
		}
	}
}
