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
		Employee _currentEmployee;
		Skill _currentSkillToAffect;

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

		// TODO : find a better name for this method
		private void UpdateSkillsDisplay()
		{
			_currentEmployee = UcEmployeeList1.CurrentEmployee;
			UcSkillsDisplay1.CurrentPerson = _currentEmployee.Worker;
			
			Affect_Manager.Enabled = false;
			if( !_currentEmployee.Busy )
			{
				IsBusy.Text = "Non";
				Affect_Manager.Enabled = true;
			}
			else
				IsBusy.Text = "Oui";

			UcSkillsDisplay1.LoadUc();
			CreateSkillsToAffectComboBox();
			EnbableAffectDisplay( true );
		}

		private void EnbableAffectDisplay( bool enable )
		{
			IsBusyTitle.Visible = enable;
			IsBusy.Visible = enable;
			SelectedManagerAffectTitle.Visible = enable;
			SkillsToAffect.Visible = enable;
			Affect_Manager.Visible = enable;
		}

		private void SkillsToAffect_SelectedIndexChanged( object sender, EventArgs e )
		{
			Affect_Manager.Enabled = true;
			string selectedSkill = (string)SkillsToAffect.SelectedItem;
			_currentSkillToAffect = UcEmployeeList1.CurrentEmployee.Worker.Skills
				.Where( s => s.SkillName == selectedSkill )
				.SingleOrDefault();
		}

		private void CreateSkillsToAffectComboBox()
		{
			SkillsToAffect.Items.Clear();

			SkillsToAffect.Items.AddRange( UcEmployeeList1.CurrentEmployee.Worker.Skills
				.Select( s => s.SkillName ).ToArray() );
		}

		private void Affect_Manager_Click( object sender, EventArgs e )
		{
			MyCompany playerCompany = (MyCompany)_currentEmployee.Comp;
			playerCompany.AddManager( _currentEmployee, _currentSkillToAffect );
		}
    }
}
