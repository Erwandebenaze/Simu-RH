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
    static public class Load
    {
        static public Game LoadGame( string companyName )
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream( @"..\..\..\Sauvegardes\" + companyName + ".bin", FileMode.Open, FileAccess.Read, FileShare.Read );
            Game obj = (Game)formatter.Deserialize( stream );
            stream.Close();
            return obj;
        }
    }
}
