using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRH.Core;

namespace SRH.Interface
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Form1 form = new Form1();
            Options opt = new Options();
            form.WindowState = FormWindowState.Maximized;
            opt.Show();
            Application.Run(opt);
            

        }
    }
}
