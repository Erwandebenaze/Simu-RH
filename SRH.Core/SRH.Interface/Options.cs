using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRH.Core;

namespace SRH.Interface
{
    public partial class Options : Form
    {

        public Options()
        {  
            InitializeComponent();
        }

        SimuRH MainForm
        {
            get { return (SimuRH)Owner; }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            using( NewGameForm newGameform = new NewGameForm() )
            {
                DialogResult r = newGameform.ShowDialog( this );
                if( r == DialogResult.OK )
                {
                    MainForm.LoadOrCreateGame( newGameform.GameName );
                } else
                {
                    MessageBox.Show( "La partie n'a pas été chargée. Nom de partie invalide." );
                }
            }
        }

        private void button1_KeyDown( object sender, KeyEventArgs e )
        {
                 
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        
        }

        private void SaveGameButton_Click( object sender, EventArgs e )
        {
            MainForm.CurrentGame.SaveGame();
            MessageBox.Show( "La partie a été sauvegardée." );
        }

        private void LoadGameButton_Click( object sender, EventArgs e )
        {
            //System.Diagnostics.Process.Start( @"..\..\..\Sauvegardes" );
            OpenFileDialog d = new OpenFileDialog();
            d.InitialDirectory = @"C:\Dev\Simu-RH\SRH.Core\Sauvegardes";
            d.Filter = "bin files (*.bin)|*.bin";
            d.ShowDialog();

            //if( openFileDialog1.ShowDialog() == DialogResult.OK )
            //{
            //    try
            //    {
            //        if( (myStream = openFileDialog1.OpenFile()) != null )
            //        {
            //            using( myStream )
            //            {
            //                // Insert code to read the stream here.
            //            }
            //        }
            //    }
            //    catch( Exception ex )
            //    {
            //        MessageBox.Show( "Error: Could not read file from disk. Original error: " + ex.Message );
            //    }
            //}

        }
    }
}
