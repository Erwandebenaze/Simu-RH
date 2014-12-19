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
            AffectOfficeFields();
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
            _maxWealthText.Text = GameContext.CurrentGame.PlayerCompany.MaxWealth.ToString();
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

            _trainingMonth.Text = GameContext.CurrentGame.PlayerCompany.GetTrainingCostMonth().ToString();
            _trainingYear.Text = GameContext.CurrentGame.PlayerCompany.GetTrainingCostYear().ToString();

            _recrutingMonth.Text = GameContext.CurrentGame.PlayerCompany.GetRecrutingCostMonth().ToString();
            _recrutingYear.Text = GameContext.CurrentGame.PlayerCompany.GetRecrutingCostYear().ToString();

            _layingOffMonth.Text = GameContext.CurrentGame.PlayerCompany.GetLayingOffCostMonth().ToString();
            _layingOffYear.Text = GameContext.CurrentGame.PlayerCompany.GetLayingOffCostYear().ToString();

            _totalDepMonth.Text = (GameContext.CurrentGame.PlayerCompany.GetTrainingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetLayingOffCostMonth() + GameContext.CurrentGame.PlayerCompany.GetInterest() + i ).ToString();
            _totalDepYear.Text = (GameContext.CurrentGame.PlayerCompany.GetTrainingCostYear() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostYear() + (GameContext.CurrentGame.PlayerCompany.GetInterest() * 12) + (i*12)).ToString();
            
            _projectsMonth.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsMonth().ToString();
            _projectsYear.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsYear().ToString();

            _totalRecMonth.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsMonth().ToString();
            _totalRecYear.Text = GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsYear().ToString();

            _resMonth.Text = (GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsMonth() - ((GameContext.CurrentGame.PlayerCompany.GetTrainingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostMonth() + GameContext.CurrentGame.PlayerCompany.GetLayingOffCostMonth() + GameContext.CurrentGame.PlayerCompany.GetInterest() + i ))).ToString();
            _resYear.Text = (GameContext.CurrentGame.PlayerCompany.GetProjectsEarningsYear() - (GameContext.CurrentGame.PlayerCompany.GetTrainingCostYear() + GameContext.CurrentGame.PlayerCompany.GetRecrutingCostYear() + GameContext.CurrentGame.PlayerCompany.GetLayingOffCostYear() + (GameContext.CurrentGame.PlayerCompany.GetInterest() * 12) + (i * 12))).ToString();
        }

    }
}
