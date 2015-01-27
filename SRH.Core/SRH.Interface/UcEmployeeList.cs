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
	public partial class UcEmployeeList : UserControl
	{
		IEnumerable<Employee> _employeesToDisplay;
		Employee _currentEmployee;
		string _selectedEmployeeName;
		string _selectedEmployeeAge;
		bool _showProj = true;

		public delegate void SelectedIndexChanged();
		public event SelectedIndexChanged Changed;

		public void OnIndexChanged()
		{
			if( Changed != null )
			{
				Changed();
			}
		}

		#region Getters Setters
		public UcEmployeeList()
		{
			InitializeComponent();
		}

		IGameContext GameContext
		{
			get { return (IGameContext)TopLevelControl; }
		}

		internal ListView EmployeeList
		{
			get { return employeeList; }
		}

		internal Employee CurrentEmployee
		{
			get 
			{ return _currentEmployee; }
			set
			{ _currentEmployee = value; }
		}

		internal string SelectedEmployeeName
		{
			get { return _selectedEmployeeName; }
		}

		public string SelectedEmployeeAge
		{
			get { return _selectedEmployeeAge; }
		}

		public bool ShowProj
		{
			set { _showProj = value; }
		}
		#endregion
		protected override void OnLoad( EventArgs e )
		{
			if( this.IsInRuntimeMode() )
			{
				base.OnLoad( e );
				LoadUc();
			}
		}

		internal void LoadUc()
		{
			_employeesToDisplay = GetProjEmployees( _showProj );
			employeeList.Items.Clear();
			employeeList.Items.AddRange( _employeesToDisplay.Select( employee => CreateEmployee( employee ) )
				.OrderBy( employee => employee.Text)
				.ToArray() );
		}

		private IEnumerable<Employee> GetProjEmployees( bool showProj )
		{
			if( !showProj )
			{
				return GameContext.CurrentGame.PlayerCompany.Employees.Where(e => e.SkillAffectedToCompany == null)
					.Where( e => e.Worker.Skills.Any( s => s is CompaSkill ) );
			}
			else
				return GameContext.CurrentGame.PlayerCompany.Employees;
		}

		private void employeeList_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( employeeList.SelectedItems.Count > 0 )
			{
				_currentEmployee = (Employee)employeeList.SelectedItems[ employeeList.SelectedItems.Count - 1 ].Tag;
				
				_selectedEmployeeName = _currentEmployee.Worker.FirstName + " " + _currentEmployee.Worker.LastName;
				_selectedEmployeeAge = _currentEmployee.Worker.Age.ToString();

				OnIndexChanged();
			}
		}

		ListViewItem CreateEmployee( Employee e )
		{
			ListViewItem i = new ListViewItem( e.Worker.LastName );
			i.Tag = e;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.Age.ToString() ) );

			if( _showProj )
			{
				Skill employeeBestSkill = e.Worker.Skills
				.Where( s => s.Level.CurrentXp == e.Worker.Skills.Max( sk => sk.Level.CurrentXp ) )
				.FirstOrDefault();
				i.SubItems.Add( new ListViewItem.ListViewSubItem( i, employeeBestSkill.SkillName ) );
				i.SubItems.Add( new ListViewItem.ListViewSubItem( i, employeeBestSkill.Level.CurrentLevel.ToString() ) );
			}
			else
			{
				IEnumerable<Skill> compaSkillsOnly = e.Worker.Skills.Where( s => s is CompaSkill );
				Skill employeeBestSkill = compaSkillsOnly
				.Where( s => s.Level.CurrentXp == compaSkillsOnly.Max( sk => sk.Level.CurrentXp ) )
				.FirstOrDefault();

				i.SubItems.Add( new ListViewItem.ListViewSubItem( i, employeeBestSkill.SkillName ) );
				i.SubItems.Add( new ListViewItem.ListViewSubItem( i, employeeBestSkill.Level.CurrentLevel.ToString() ) );
			}
			
			return i;
		}
	}
}
