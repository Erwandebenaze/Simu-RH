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
                if( r == System.Windows.Forms.DialogResult.OK )
                {
                    MainForm.LoadOrCreateGame( newGameform.GameName );
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
    }
}
