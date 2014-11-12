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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            if ( String.IsNullOrWhiteSpace(textBox1.Text))
            {
                // TODO : Mettre un contrôle d'erreur pour vérification
                throw new ArgumentException( "Textbox is null" );
            }
            else
            {
                Game myGame = new Game( 1, textBox1.Text );
                // TODO : Vérifier que le nom est unique.
                myGame.SaveGame();
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }
}
    }
