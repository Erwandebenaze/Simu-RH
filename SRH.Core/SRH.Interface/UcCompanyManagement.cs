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
    public partial class UcCompanyManagement : UserControl
    {
        public UcCompanyManagement()
        {
            InitializeComponent();
			UcEmployeeList1.ShowProj = false;
			UcSkillsDisplay1.ShowProj = false;
        }

		protected override void OnLoad( EventArgs e )
		{
			if( this.IsInRuntimeMode() )
			{
				base.OnLoad( e );
				UcEmployeeList1.Changed += UpdateSkillsDisplay;
				LoadPage();
			}
		}

		internal void LoadPage()
		{
			UcEmployeeList1.LoadUc();
		}

		private void UpdateSkillsDisplay()
		{
			Employee e = UcEmployeeList1.CurrentEmployee;

			UcSkillsDisplay1.CurrentPerson = e.Worker;
			//SelectedEmployeeName.Text = e.Worker.FirstName + " " + e.Worker.LastName;
			//SelectedEmployeeAge.Text = e.Worker.Age.ToString();

			//if( !e.Busy )
			//{
			//	IsBusy.Text = "Non";
			//	EnableEmployeeInfo();
			//}
			//else
			//{
			//	IsBusy.Text = "Oui";
			//}
			UcSkillsDisplay1.LoadUc();
		}
    }
}
