﻿using System;
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
        int interval;
        readonly Options _optionsForm;
        GameTime _timeOfGame;

        public SimuRH()
        {
            InitializeComponent();
            _myGame = new Game( 1, "SimuRH" );
            //_myGame = GameLoader.Load("SimuRH");
            _optionsForm = new Options();
            _timeOfGame = _myGame.TimeGame;
            _timer = new Timer();
            interval = 2000;
            _timer.Interval = interval;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }


        void _timer_Tick( object sender, EventArgs e )
        {
            BarProgress();
            _timeOfGame.newDay();
            _myGame.PlayerCompany.EndProjectIfItsFinish();
            _dateOfGame.Text = GameTime.TimeOfGame.ToString("d");
            _day.Text = _timeOfGame.FrenchDayOfWeek;
        }

        private void BarProgress()
        {
            _currentCompanyLevel.Text = CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel.ToString();
            _nextCompanyLevel.Text = (CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel+1).ToString();
            _companyProgressBar.Minimum = 0;
            _companyProgressBar.Maximum = CurrentGame.PlayerCompany.CompanyLevel.XpRequired / CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel;
            _companyProgressBar.Value = CurrentGame.PlayerCompany.CompanyLevel.CurrentXp %_companyProgressBar.Maximum;
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



        private void EnabledButtons()
        {
            _playButton.Enabled = true;
            _pauseButton.Enabled = true;
            _x2Button.Enabled = true;
            _x5Button.Enabled = true;
            _x10Button.Enabled = true;
        }
        private void _pauseButton_Click( object sender, EventArgs e )
        {
            EnabledButtons();
            _timer.Stop();
            _pauseButton.Enabled = false;
        }


        private void _playButton_Click( object sender, EventArgs e )
        {
            EnabledButtons();
            _timer.Start();
            _timer.Interval = interval;
            _playButton.Enabled = false;
        }

        private void _x2Button_Click( object sender, EventArgs e )
        {
            EnabledButtons();
            _x2Button.Enabled = false;
            _timer.Interval = interval/2;
        }

        private void _x5Button_Click( object sender, EventArgs e )
        {
            EnabledButtons();

            _x5Button.Enabled = false;
            _timer.Interval = interval/5;
        }

        private void _x10Button_Click( object sender, EventArgs e )
        {
            EnabledButtons();
            _x10Button.Enabled = false;
            _timer.Interval = interval/10;
        }
    }
}
