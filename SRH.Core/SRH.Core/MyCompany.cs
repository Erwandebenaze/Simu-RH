using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	public class MyCompany : Company
	{
		int _maxEmployees;
		double _maxProjectDifficulty;
		Level _companyLevel;

		// TODO : implémenter la liste de projets en cours
		//List<Project> _currentProjects;
		public MyCompany( string name )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "name" );
            
			//TODO : Check if the name is already existing
			_companyLevel = new Level(this);
			
			// TODO : implémenter la liste de projets en cours
			//_currentProjects = new List<Project>();
            
			_name = name;
            _maxEmployees = 10;
            _maxProjectDifficulty = 1;
            _wealth = 15000;
        }

        public Level Level
        {
            get { return _companyLevel; }
        }
		public int MaxEmployees
		{
			get { return _maxEmployees; }
			internal set { _maxEmployees = value; }
		}

		public double MaxProjectDifficulty
		{
			get { return _maxProjectDifficulty; }
			internal set { _maxProjectDifficulty = value; }
		}

        public void AdjustValuesCompany()
        {
            if( this.Level.CurrentLevel == 1 ) this.MaxEmployees = 10;
            this.MaxEmployees = 10 + (2 * (this.Level.CurrentLevel - 1));

            if( this.Level.CurrentLevel == 1 ) this.MaxProjectDifficulty = 0.5;
            if( this.Level.CurrentLevel % 10 == 0 ) this.MaxProjectDifficulty += 0.5;
        }
	}
}
