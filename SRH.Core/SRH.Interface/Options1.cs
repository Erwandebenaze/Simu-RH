using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRH.Interface
{
    public partial class Options1 : UserControl
    {
        public Options1()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
