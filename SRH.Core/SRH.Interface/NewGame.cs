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
    public partial class NewGameForm : Form
    {

        public NewGameForm()
        {
            InitializeComponent();
        }

        public string GameName
        {
            get { return _gameNameText.Text; }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            if (String.IsNullOrWhiteSpace(_gameNameText.Text))
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            } else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }
}
    }
