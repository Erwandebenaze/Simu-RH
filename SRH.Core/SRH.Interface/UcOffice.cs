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

            _salaryMonth.Text = (i ).ToString();
            _salaryYear.Text = (i * 12).ToString();
            _interestMonth.Text = GameContext.CurrentGame.PlayerCompany.GetInterest().ToString();
            _interestYear.Text = (GameContext.CurrentGame.PlayerCompany.GetInterest()*12).ToString();

        }

    }
}
