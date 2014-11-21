using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace SRH.Core
{
	public class CSV
	{
		public List<Project> ReadCsv()
		{
			List<Project> possibleProjects = new List<Project>();

			List<string> _list = new List<string>();
			using( CsvReader csv =
				   new CsvReader( new StreamReader( "../../../Data/data.csv" ), true, ';', '\'', '\0', '#', ValueTrimmingOptions.None ) )
			{
				csv.SupportsMultiline = true;
				csv.SkipEmptyLines = true;
				string[] headers = csv.GetFieldHeaders();
				int FieldCount = csv.FieldCount;

				while( csv.ReadNextRecord() )
				{
					for( int i = 0; i < FieldCount; i++ )
					{
						if( !String.IsNullOrEmpty( csv[ "Nom du projet" ] ) )
						{
							int index = (int)csv.CurrentRecordIndex;

							string projectName = "Bla";
							float projectDifficulty = 1;
							// int numberOfTasks; Not implemented yet
							int projectEarnings = 10;
							int projectNumberOfWorker = 10;
							Dictionary<Skill, int> projectRequiredSkill = new Dictionary<Skill, int>(); // TODO : trouver un moyen de lire une deuxième boucle (csv.CurrentRecordIndex)

							projectName = csv[ "Nom du projet" ];
							projectDifficulty = float.Parse( csv[ "Difficulté" ] );
							// numberOfTasks = int.Parse(csv[ "Nombre de tâches" ]);
							projectEarnings = int.Parse( csv[ "Gains" ] );
							projectNumberOfWorker = int.Parse( csv[ "Nombre de compétences" ] );

							for( int j = index; j < ( index + projectNumberOfWorker ); j++ )
							{
								string skillName = csv[ j, "Compétences demandées" ];
								int skillLevel = int.Parse( csv[ j, "Niveau Recommandé" ] );
								projectRequiredSkill.Add( new ProjSkill(skillName) , skillLevel );
							}

							Project p = new Project( projectName, projectDifficulty, projectNumberOfWorker, projectEarnings, projectRequiredSkill );
							possibleProjects.Add( p );
						}
					}
				}
				return possibleProjects;
			}
		}
	}
}
