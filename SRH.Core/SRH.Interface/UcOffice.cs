using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRH.Core;

namespace SRH.Interface
{
    public partial class UcOffice : UserControl
    {
        DateTime _lastRefreshEvent;
         IGameContext GameContext
        {
            get { return (IGameContext)TopLevelControl; }
        } 
        public UcOffice()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad( EventArgs e )
        {
            if( this.IsInRuntimeMode() )
            {
                base.OnLoad( e );
                LoadPage();
            }

        }
        internal void LoadPage()
        {
            if( _lastRefreshEvent  == null )
            {
               _lastRefreshEvent = GameContext.CurrentGame.TimeGame.CurrentTimeOfGame;
            }
            AffectOfficeFields();
            GenerateListOfEvents();
            GenerateOfficeToolTip();

        }

        private void GenerateOfficeToolTip()
        {
            _infoEvents.SetToolTip( this._listViewEvents, "Liste des événements se produisant dans l'entreprise." );
            _infoEvents.InitialDelay = 1700;
            _infoEvents.AutoPopDelay = 3000;
            _infoMonEntreprise.SetToolTip( this.groupBox1, "État de mon entreprise." );
            _infoMouvMensuels.SetToolTip( this.groupBox2, "Mouvements mensuels de l'entreprise." );
            _infoMouvAnnuels.SetToolTip( this.groupBox3, "Mouvements annuels de l'entreprise." );
        }

        internal void GenerateListOfEvents()
        {
            if( GameContext.CurrentGame.TimeGame.AreMonthsPassed( _lastRefreshEvent, 1 ) ) 
            {
                _listViewEvents.Items.Clear();
                _lastRefreshEvent = GameContext.CurrentGame.TimeGame.CurrentTimeOfGame;
                if( GameContext.CurrentGame.Events.Count != 0 )
                {
                    _listViewEvents.Items.AddRange( GameContext.CurrentGame.Events
                            .Select( ev => CreateListItemViewEvents( ev ) ).ToArray() );
                }
            }
            
            if( GameContext.CurrentGame.Events.Count != 0 && _listViewEvents.Items.Count < GameContext.CurrentGame.Events.Count)
            {
                _listViewEvents.Items.AddRange( GameContext.CurrentGame.Events
                    .Where( et => et.Value != "Retraite" )
                    .Where( et => et.Value != "Raz-le-bol" )
                    .Select( ev => CreateListItemViewEvents( ev ) )
                    .ToArray() );
            }
        }
        private ListViewItem CreateListItemViewEvents( KeyValuePair<Employee,string> dico )
        {
            ListViewItem i;
            if( dico.Value == "Retraite")
            {
                if( dico.Key.SkillInProject != null )
                {
                    i = new ListViewItem( "[" + dico.Key.TimeOfEvent.ToString( "d" ) + "] Votre employé(e) " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " est parti(e) à la retraite, le projet : " + dico.Key.Project.Name + " a été ralenti. " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " avait la compétence " + dico.Key.SkillInProject.SkillName + "." );
                }
                else
                {
                    i = new ListViewItem( "[" + dico.Key.TimeOfEvent.ToString( "d" ) + "] Votre employé(e) " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " est parti(e) à la retraite." );
                }
            }
            else if( dico.Value == "Raz-le-bol" )
            {
                if( dico.Key.SkillInProject != null )
                {
                    i = new ListViewItem( "[" + dico.Key.TimeOfEvent.ToString( "d" ) + "] Votre employé(e) " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " est parti(e) de votre entreprise, il (elle) était trop malheureu(se)x. Le projet : " + dico.Key.Project.Name + " a été ralenti. " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " avait la compétence " + dico.Key.SkillInProject.SkillName + "." );
                }
                else
                {
                    i = new ListViewItem( "[" + dico.Key.TimeOfEvent.ToString( "d" ) + "] Votre employé(e) " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " est parti(e) de votre entreprise." );
                }
               

            }
            else if( dico.Value == "Vacances" )
            {
                i = new ListViewItem( "[" + dico.Key.TimeOfEvent.ToString( "d" ) + "] Votre employé(e) " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " est parti(e) en vacances, il (elle) sera bientôt de retour." );

            }
            else if( dico.Value == "Maladie" )
            {
                i = new ListViewItem( "[" + dico.Key.TimeOfEvent.ToString( "d" ) + "] Votre employé(e) " + dico.Key.Worker.FirstName + " " + dico.Key.Worker.LastName + " est tombé(e) malade, il (elle) sera bientôt de retour." );

            } 
            
            
            else 
            {
                i = new ListViewItem();
            }
               
            GroupItem( dico.Value, i );
            return i;
        }
        void GroupItem( String eventName, ListViewItem i )
        {
            ListViewGroup groupToAffect = new ListViewGroup();
            switch( eventName )
            {
                case "Retraite":
                    groupToAffect = _listViewEvents.Groups[0];
                    break;
                case "Raz-le-bol":
                    groupToAffect = _listViewEvents.Groups[1];
                    break;
                case "Vacances":
                    groupToAffect = _listViewEvents.Groups[2];
                    break;
                case "Maladie":
                    groupToAffect = _listViewEvents.Groups[3];
                    break;
                default:
                    throw new InvalidOperationException( "This event as an invalid Name." );
            }


            if( !groupToAffect.Items.Contains( i ) )
                i.Group = groupToAffect;
        }

        internal void AffectOfficeFields()
        {
            _currentLevelCompany.Text = GameContext.CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel.ToString();
            _nextLevelCompany.Text = (GameContext.CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel + 1).ToString();
            if( GameContext.CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel == 1 ) _progressBarCompany.Minimum = 0;
            else _progressBarCompany.Minimum = GameContext.CurrentGame.PlayerCompany.CompanyLevel.LastXpRequired;

            _progressBarCompany.Maximum = GameContext.CurrentGame.PlayerCompany.CompanyLevel.XpRequired;
            _progressBarCompany.Value = GameContext.CurrentGame.PlayerCompany.CompanyLevel.CurrentXp;
            _limitEmployees.Text = GameContext.CurrentGame.PlayerCompany.MaxEmployees.ToString();
            _nextLimitEmployees.Text = (10 + (2 * (GameContext.CurrentGame.PlayerCompany.CompanyLevel.CurrentLevel + 1))).ToString();
            _maxDifficultyProject.Text = GameContext.CurrentGame.PlayerCompany.MaxProjectDifficulty.ToString();
            //_maxWealthText.Text = GameContext.CurrentGame.PlayerCompany.MaxWealth.ToString();
            _actualWealth.Text = GameContext.CurrentGame.PlayerCompany.Wealth.ToString();
            int i = 0;
            foreach( Employee emp in GameContext.CurrentGame.PlayerCompany.Employees )
            {
                i += emp.Salary; 
            }

            _salaryMonth.Text = (i).ToString();
            _salaryYear.Text = (i * 12).ToString();

            _interestMonth.Text = GameContext.CurrentGame.PlayerCompany.GetInterest().ToString();
            _interestYear.Text = (GameContext.CurrentGame.PlayerCompany.GetInterest()*12).ToString();

            _chargesMonth.Text = GameContext.CurrentGame.PlayerCompany.GetCharges().ToString();
            _chargesYear.Text = (GameContext.CurrentGame.PlayerCompany.GetCharges() * 12).ToString();

            _trainingMonth.Text = GameContext.CurrentGame.PlayerCompany.GetTrainingCostMonth().ToString();
            _trainingYear.Text = GameContext.CurrentGame.PlayerCompany.GetTrainingCostYear().ToString();

            _recrutingMonth.Text = GameContext.CurrentGame.PlayerCompany.GetRecrutingCostMonth().ToString();
            _recrutingYear.Text = GameContext.CurrentGame.PlayerCompany.GetRecrutingCostYear().ToString();

            _layingOffMonth.Text = GameContext.CurrentGame.PlayerCompany.GetLayingOffCostMonth().ToString();
            _layingOffYear.Text = GameContext.CurrentGame.PlayerCompany.GetLayingOffCostYear().ToString();

            _totalDepMonth.Text = (GameContext.CurrentGame.PlayerCompany.GetTrainingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetLayingOffCostMonth() + GameContext.CurrentGame.PlayerCompany.GetInterest() + GameContext.CurrentGame.PlayerCompany.GetCharges() + i).ToString();
            _totalDepYear.Text = (GameContext.CurrentGame.PlayerCompany.GetTrainingCostYear() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostYear() + (GameContext.CurrentGame.PlayerCompany.GetInterest() * 12) + (GameContext.CurrentGame.PlayerCompany.GetCharges() * 12) + (i * 12)).ToString();
            
            _projectsMonth.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsMonth().ToString();
            _projectsYear.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsYear().ToString();

            _totalRecMonth.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsMonth().ToString();
            _totalRecYear.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsYear().ToString();

            _resMonth.Text = (GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsMonth() - ((GameContext.CurrentGame.PlayerCompany.GetTrainingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetLayingOffCostMonth() + GameContext.CurrentGame.PlayerCompany.GetInterest() + GameContext.CurrentGame.PlayerCompany.GetCharges() + i))).ToString();
            _resYear.Text = (GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsYear() - (GameContext.CurrentGame.PlayerCompany.GetTrainingCostYear() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostYear() + GameContext.CurrentGame.PlayerCompany.GetLayingOffCostYear() + (GameContext.CurrentGame.PlayerCompany.GetInterest() * 12) + (GameContext.CurrentGame.PlayerCompany.GetCharges() * 12) + (i * 12))).ToString();
        }

    }
}
