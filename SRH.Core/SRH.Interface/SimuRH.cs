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
        DateTime? _begginingDebt;
        bool _debt;
        int _interest;

        public SimuRH()
        {
            InitializeComponent();
            //_myGame = new Game( 1, "Erwan" );
            _myGame = GameLoader.Load( "Erwan" );
            _optionsForm = new Options();
            _timeOfGame = _myGame.TimeGame;
            _timer = new Timer();
            interval = 2000;
            _timer.Interval = interval;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

		void Reload()
		{
			this.ucEmployeePage.LoadPage();
			this.ucProjectPage.LoadPage();
		}

		
        void _timer_Tick( object sender, EventArgs e )
        {
            if( _myGame.PlayerCompany.Wealth < -50000 )
            {
                _timer.Stop();

                MessageBox.Show( "Vous avez perdu. Votre dette a dépassé 50 000€ ! Retentez votre chance ou chargez une partie." );
                _optionsForm.SaveGameButton.Enabled = false;
                ShowOptions();
            } else
            {
				// Progress bars
                BarProgress();
                ExperienceProgress();
                WealthProgress();
                ucOffice.AffectOfficeFields();


                _timeOfGame.newDay();
                _myGame.PlayerCompany.EndProjectIfItsFinish();
                ClearListsProjects();

				// Current date display
                _dateOfGame.Text = _myGame.TimeGame.CurrentTimeOfGame.ToString( "d" );
                _day.Text = _timeOfGame.FrenchDayOfWeek;
                if( _myGame.PlayerCompany.Wealth < 0 && !_debt)
                {
                    _begginingDebt = _myGame.TimeGame.CurrentTimeOfGame;
                    _debt = true;
                }
                else if( _myGame.PlayerCompany.Wealth < 0 && _debt )
                {
                    if( _myGame.TimeGame.intervalOfTimeInDays( _begginingDebt ) % 20 == 0 ) 
                    {
                        
                        _myGame.PlayerCompany.Wealth -= _myGame.PlayerCompany.Wealth / 100 * 5 ;
                    }

                } else if (!_debt)
                {
                    _begginingDebt = null;
                }

                foreach( Competitor competitor in _myGame.Competitors )
                {
                    competitor.TryToAddMoneyAndEmployee();
                }
            }

            _interest = _myGame.PlayerCompany.ApplyInterests();

        }

        private void ClearListsProjects()
        {

            if( ucProjectPage.Projects != null )
            {
                ucProjectPage.listCurrentProjects.Items.Clear();
                ucProjectPage.listCurrentProjects.Items.AddRange( ucProjectPage.Projects.Select( p => ucProjectPage.CreateListItemViewCurrentProjects( p ) ).ToArray() );
                ucProjectPage.AffectVariableFields();
            }
        }

		private void ExperienceProgress()
		{
			string companyCurrentXp = CurrentGame.PlayerCompany.CompanyLevel.CurrentXp.ToString();
			string companyNextXP = CurrentGame.PlayerCompany.CompanyLevel.XpRequired.ToString();
			companyExperience.Text = companyCurrentXp + " / " + companyNextXP +" Exp";
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

        public void LoadOrCreateGame( string name )
        {
            try
            {
                _myGame = GameLoader.Load( name );
                MessageBox.Show( "La partie est déjà existante. Celle-ci a été chargée." );
				Reload();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show( "La partie a été créé." );
                _myGame = new Game( 1,name );
				Reload();
            }

            ShowOptions( false );
        }

        public void SaveGame()
        {
            if( _myGame == null ) throw new InvalidOperationException( "No CurrentGame to save!" );
            _myGame.SaveGame();
        }

        public void LoadGame( string game )
        {
            _myGame = GameLoader.Load( game );
			Reload();
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

		private void SimuRH_Load()
		{

		}

		private void tabControl1_SelectedIndexChanged( object sender, TabControlEventArgs e )
		{
			//
			// TODO : Add Load methods when Uc are implemented
			//
			//if( tabControl1.SelectedTab == tabControl1.TabPages[ "Board" ] )
			//{
			//	this.ucBoardPage.LoadPage();
			//}
			if( tabControl1.SelectedTab == tabControl1.TabPages[ "Employees" ] )
			{
				this.ucEmployeePage.LoadPage();
			}
			else if( tabControl1.SelectedTab == tabControl1.TabPages[ "Projects" ] )
			{
				this.ucProjectPage.LoadPage();
			}
			else if( tabControl1.SelectedTab == tabControl1.TabPages[ "CompanyManagement" ] )
			{
				this.ucCompanyManagement1.LoadPage();
			}
			//else if( tabControl1.SelectedTab == tabControl1.TabPages[ "Statistics" ] )
			//{
			//	this.ucStatistics.LoadPage();
			//}
		}
    }
}
