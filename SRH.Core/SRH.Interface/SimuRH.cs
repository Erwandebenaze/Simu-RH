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
        Timer _timer;
        readonly Options _optionsForm;
        GameTime _timeOfGame;
        string _frenchDayOfWeek;

        public SimuRH()
        {
            InitializeComponent();
            _timeOfGame = new GameTime();
            _optionsForm = new Options();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();

        }

        void _timer_Tick( object sender, EventArgs e )
        {
            _timeOfGame.newDay();
            _frenchDayOfWeek = _timeOfGame.FrenchDayOfWeek;
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

        internal void SaveGame( )
        {
            if( _myGame == null ) throw new InvalidOperationException( "No CurrentGame to save!" );
            _myGame.SaveGame();
        }

        internal void LoadGame(string game)
        {
            _myGame = GameLoader.Load( game );
            this.Refresh();
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
