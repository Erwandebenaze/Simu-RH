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
    public partial class SimuRH : Form, IGameContext
    {
        Game _myGame;
        readonly Options _optionsForm;

        public SimuRH()
        {
            InitializeComponent();
            _myGame = new Game( 1, "INTECH" );
            _optionsForm = new Options();
        }

        public Game CurrentGame
        {
            get { return _myGame; }
        }

        internal void LoadOrCreateGame(string name)
        {
            try
            {
                _myGame = GameLoader.Load( name );
                MessageBox.Show( "La partie est déjà existante. Celle-ci a été chargée." );
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show( "La partie a été créé." );
                _myGame = new Game( 1,name );
            }

            ShowOptions( false );
        }

        private void SaveGame( )
        {
            if( _myGame == null ) throw new InvalidOperationException( "No CurrentGame to save!" );
            _myGame.SaveGame();
        }

        public void ShowOptions(bool show = true)
        {
            if (show && !_optionsForm.Visible)
            {
                _optionsForm.Show( this );
            } 
            else
            {
                _optionsForm.Hide();
            }
        }

        private void mainForm_KeyDown( object sender, KeyEventArgs e )
        {
            if (e.KeyCode == Keys.Escape)
            {
                ShowOptions();
            }
        }
    }
}
