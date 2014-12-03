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
    public partial class UcStatistics : UserControl
    {
        public UcStatistics()
        {
            InitializeComponent();
        }
        IGameContext GameContext
        {
            get { return (IGameContext)TopLevelControl; }
        }

        private void _myCompanyLogo_Click( object sender, EventArgs e )
        {
            Company comp = GameContext.CurrentGame.PlayerCompany;
            AffectCompFields( comp );
        }

        private void _capgeminiLogo_Click( object sender, EventArgs e )
        {
            Company comp = GameContext.CurrentGame.Competitors.Where( compet => compet.Name == "Capgemini" ).Single();
            AffectCompFields( comp );

        }

        private void _altranLogo_Click( object sender, EventArgs e )
        {
            Competitor comp = GameContext.CurrentGame.Competitors.Where( compet => compet.Name == "Altran" ).Single();
            AffectCompFields( comp );
        }

        private void _atosLogo_Click( object sender, EventArgs e )
        {
            Competitor comp = GameContext.CurrentGame.Competitors.Where( compet => compet.Name == "Atos" ).Single();
            AffectCompFields( comp );
        }

        private void _sopraLogo_Click( object sender, EventArgs e )
        {
            Competitor comp = GameContext.CurrentGame.Competitors.Where( compet => compet.Name == "Sopra" ).Single();
            AffectCompFields( comp );
        }

        private void _steriaLogo_Click( object sender, EventArgs e )
        {
            Competitor comp = GameContext.CurrentGame.Competitors.Where( compet => compet.Name == "Steria" ).Single();
            AffectCompFields( comp );
        }
     
        private void AffectCompFields( Company comp )
        {
            _companyNameText.Text = comp.Name;
            _wealthText.Text = comp.Wealth.ToString();
            _nbEmployeeText.Text = comp.Employees.Count.ToString();
        }
    }
}
