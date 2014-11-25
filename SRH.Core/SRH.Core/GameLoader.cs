using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SRH.Core
{
    static public class GameLoader
    {
        static public Game Load( string companyName )
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;

            if (companyName.Contains(".bin"))
            {
                stream = new FileStream( companyName, FileMode.Open, FileAccess.Read, FileShare.Read );
            } else
            {
                stream = new FileStream( @"..\..\..\Sauvegardes\" + companyName + ".bin", FileMode.Open, FileAccess.Read, FileShare.Read );
            }
           
            Game myGame = (Game)formatter.Deserialize( stream );
            stream.Close();
            return myGame;
        }


        //IReadOnlyList<string>
    }
}
