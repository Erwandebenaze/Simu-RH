﻿using System;
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
		Employee _currentEmployee; // the selected employee, NOT working as a manager
		Employee _currentManager; // the selected employee, working as a manager
		IEnumerable<Employee> _managers;
		Skill _currentSkillToAffect;

        public UcCompanyManagement()
        {
            InitializeComponent();
			UcEmployeeList1.ShowProj = false;
			UcSkillsDisplay1.ShowProj = false;
        }

		IGameContext GameContext
		{
			get { return (IGameContext)TopLevelControl; }
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

			managerList.Items.Clear();
			_managers = GameContext.CurrentGame.PlayerCompany.Employees.
				Where( e => e.SkillAffectedToCompany != null );
			managerList.Items.AddRange( _managers.Select( m => CreateManager( m ) ).ToArray() );

		}

		ListViewItem CreateManager( Employee e )
		{
			ListViewItem i = new ListViewItem( e.Worker.FirstName + " " + e.Worker.LastName );
			i.Tag = e;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.Age.ToString() ) );

			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.SkillAffectedToCompany.SkillName ) ) ;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.SkillAffectedToCompany.Level.CurrentLevel.ToString() ) );
			GroupItem( e, i );
			return i;
		}

		void GroupItem( Employee e, ListViewItem i )
		{
			ListViewGroup groupToAffect = new ListViewGroup();
			switch( e.SkillAffectedToCompany.SkillName )
			{
				case "Commercial":
					groupToAffect = managerList.Groups[ 0 ];
					break;
				case "Ressources humaines":
					groupToAffect = managerList.Groups[ 1 ];
					break;
				case "Directeur de projets":
					groupToAffect = managerList.Groups[ 2 ];
					break;
				case "Gestion de contrat":
					groupToAffect = managerList.Groups[ 3 ];
					break;
				case "Animation":
					groupToAffect = managerList.Groups[ 4 ];
					break; 
				default :
					throw new InvalidOperationException( "This manager as a skill whith an Invalid Name." );
			}


			if( !groupToAffect.Items.Contains( i ) )
				i.Group = groupToAffect;
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
			{
				IsBusy.Text = "Oui";
				Affect_Manager.Enabled = false;
			}

			UcSkillsDisplay1.LoadUc();
			CreateSkillsToAffectComboBox();
			EnbableAffectDisplay( true );
		}

		private void Affect_Manager_Click( object sender, EventArgs e )
		{
			MyCompany playerCompany = (MyCompany)_currentEmployee.Comp;
			playerCompany.AddManager( _currentEmployee, _currentSkillToAffect );
			Affect_Manager.Enabled = false;
			LoadPage();
		}

		private void DesaffectManager_Click( object sender, EventArgs e )
		{
			MyCompany playerCompany = (MyCompany)_currentManager.Comp;
			playerCompany.RemoveManager( _currentManager );
			DesaffectManager.Enabled = false;
			LoadPage();
		}

		private void managerList_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( managerList.SelectedItems.Count > 0 )
			{
				_currentManager = (Employee)managerList.SelectedItems[ 0 ].Tag;
			}
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
			string selectedSkill = (string)SkillsToAffect.SelectedItem;
			_currentSkillToAffect = UcEmployeeList1.CurrentEmployee.Worker.Skills
				.Where( s => s.SkillName == selectedSkill )
				.SingleOrDefault();
		}

		private void CreateSkillsToAffectComboBox()
		{
			SkillsToAffect.Items.Clear();

			SkillsToAffect.Items.AddRange( UcEmployeeList1.CurrentEmployee.Worker.Skills
				.Where( s => s is CompaSkill )
				.Select( s => s.SkillName ).ToArray() );
			SkillsToAffect.SelectedIndex = 0;
		}
    }
}
