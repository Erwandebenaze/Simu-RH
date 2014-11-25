﻿using System;
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
            SimuRH gameForm = new SimuRH();
            //gameForm.ShowOptions();
            gameForm.WindowState = FormWindowState.Maximized;
            
            Application.Run(gameForm);
            

        }
    }
}
