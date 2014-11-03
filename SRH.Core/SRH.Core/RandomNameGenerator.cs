using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
	class RandomNameGenerator
	{

		class RandomNameGenerator
	{

		readonly List<string> _firstNames;
		readonly List<string> _lastNames;

		public RandomNameGenerator ()
		{
            _firstNames = new List<string>();
            _lastNames = new List<string>();
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"\Data\FirstNames.txt" ) )
            {
                _firstNames.Add( line );
            }
            foreach( string line in File.ReadLines( Directory.GetCurrentDirectory() + @"\Data\LastNames.txt" ) )
            {
                _lastNames.Add( line );
            }
		}

		public List<string> FirstNames
		{
			get { return _firstNames; }
		}
		public List<string> LastNames
		{
			get { return _lastNames; }
		}

	}
}
