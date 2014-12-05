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
		List<Employee> _employees;
		ListView _employeeList;
		Employee _currentEmployee;
		string _selectedEmployeeName;
		string _selectedEmployeeAge;

		public delegate void SelectedIndexChanged();
		public event SelectedIndexChanged Changed;

		public void OnIndexChanged()
		{
			if( Changed != null )
			{
				Changed();
			}
		}

		//public event EventHandler SelectedIndexChanged
		//{
		//	add { employeeList.SelectedIndexChanged += value; }
		//	remove { employeeList.SelectedIndexChanged -= value; }
		//}

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
			get { return _employeeList = employeeList; }
		}

		internal Employee CurrentEmployee
		{
			get 
			{ return _currentEmployee; }
			set
			{
				if( Changed != null )
				{
					Changed();
				}
				_currentEmployee = value;

			}
		}

		internal string SelectedEmployeeName
		{
			get { return _selectedEmployeeName; }
		}

		public string SelectedEmployeeAge
		{
			get { return _selectedEmployeeAge; }
		}
		#endregion
		protected override void OnLoad( EventArgs e )
		{
			if( this.IsInRuntimeMode() )
			{
				base.OnLoad( e );
				_employees = GameContext.CurrentGame.PlayerCompany.Employees;
				employeeList.Items.AddRange( _employees.Select( employee => CreateEmployee( employee ) ).ToArray() );
			}
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

		static ListViewItem CreateEmployee( Employee e )
		{
			ListViewItem i = new ListViewItem( e.Worker.LastName );
			i.Tag = e;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.Age.ToString() ) );
			return i;
		}
	}
}
