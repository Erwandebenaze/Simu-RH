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
			ExperienceProgress();
			WealthProgress();
            _timeOfGame.newDay();
            _myGame.PlayerCompany.EndProjectIfItsFinish();
            ClearListsProjects();
            _dateOfGame.Text = GameTime.TimeOfGame.ToString("d");
            _day.Text = _timeOfGame.FrenchDayOfWeek;
        }
        static ListViewItem CreateListItemViewProjects( Project p )
        {
            ListViewItem i = new ListViewItem( p.Name );
            i.Tag = p;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Difficulty.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Earnings.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Duration.ToString() ) );
            return i;
        }
        private void ClearListsProjects()
        {

            if (ucProjectPage.Projects != null)
            {
                ucProjectPage.listCurrentProjects.Items.Clear();
                ucProjectPage.listPossibleProjects.Items.Clear();
                ucProjectPage.listCurrentProjects.Items.AddRange( ucProjectPage.Projects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
                ucProjectPage.listPossibleProjects.Items.AddRange( ucProjectPage.PossibleProjects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
            }
        }

		private void ExperienceProgress()
		{
			string companyCurrentXp = CurrentGame.PlayerCompany.CompanyLevel.CurrentXp.ToString();
			string companyNextXP = CurrentGame.PlayerCompany.CompanyLevel.XpRequired.ToString();
			companyExperience.Text = companyCurrentXp + " / " + companyNextXP;
			companyExperience.Visible = true;
		}

		private void WealthProgress()
		{
			CompanyWealth.Text = CurrentGame.PlayerCompany.Wealth.ToString();
			CompanyWealth.Visible = true;
		}

        private void BarProgress()
        {
            _currentCompanyLevel.Text = CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel.ToString();
            _nextCompanyLevel.Text = (CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel+1).ToString();
            
			if( _myGame.PlayerCompany.CompanyLevel.CurrentLevel == 1 )_companyProgressBar.Minimum = 0;
            else _companyProgressBar.Minimum = CurrentGame.PlayerCompany.CompanyLevel.LastXpRequired;

			_companyProgressBar.Maximum = CurrentGame.PlayerCompany.CompanyLevel.XpRequired;
			_companyProgressBar.Value = CurrentGame.PlayerCompany.CompanyLevel.CurrentXp;

			_currentCompanyLevel.Visible = true;
			_nextCompanyLevel.Visible = true;
        }

        public Game CurrentGame
        {
            get { return _myGame; }
        }

        internal void LoadOrCreateGame(string name)
        {
            try
            {
                this.Refresh();
                _myGame = GameLoader.Load( name );
                MessageBox.Show( "La partie est déjà existante. Celle-ci a été chargée." );
                this.Refresh();
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
            this.Refresh();
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
