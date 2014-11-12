using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRH.Interface
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
            
        }

        private void button1_KeyDown( object sender, KeyEventArgs e )
        {
                 
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        
        }
    }
}
