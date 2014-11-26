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
    public partial class UcEmployeePage : UserControl
    {
        List<Person> _joblessPersons;
        List<Employee> _employees;
        Person _currentPerson;
		Employee _currentEmployee;
        
        public UcEmployeePage()
        {
            InitializeComponent();
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
				_employees = GameContext.CurrentGame.PlayerCompany.Employees;
				_joblessPersons = (List<Person>)GameContext.CurrentGame.Market.JoblessPersons;

                PersonList.Items.AddRange( _joblessPersons.Select( p => CreatePerson( p ) ).ToArray() );
                EmployeeList.Items.AddRange( _employees.Select( employee => CreateEmployee( employee ) ).ToArray() );
            }

        }

        static ListViewItem CreatePerson ( Person p )
        {
            ListViewItem i = new ListViewItem( p.LastName );
            i.Tag = p;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.FirstName ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Age.ToString() ) );
            return i;
        }
        static ListViewItem CreateEmployee ( Employee e )
        {
            ListViewItem i = new ListViewItem( e.Worker.LastName );
            i.Tag = e;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.FirstName ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.Age.ToString() ) );
            return i;
        }

		static ListViewItem AddSkills( Skill s )
		{
			ListViewItem i = new ListViewItem( s.SkillNameString );
			i.Tag = s;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.Level.CurrentLevel.ToString() ) );
			return i;
		}

        private void PersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( PersonList.SelectedItems.Count > 0 )
            {
                _currentPerson = (Person)PersonList.SelectedItems[ PersonList.SelectedItems.Count - 1 ].Tag;
                SelectedPersonName.Text = _currentPerson.FirstName + " " + _currentPerson.LastName;
                SelectedPersonAge.Text = _currentPerson.Age.ToString();

				SelectedPersonSkillList.Items.Clear();
				SelectedPersonSkillList.Items.AddRange( _currentPerson.Skills.Values.Select( s => AddSkills( s ) ).ToArray() );
            }
			if( _currentPerson != null )
			{
				hirePerson.Enabled = true;
				SelectedPersonName.Visible = true;
				SelectedPersonAge.Visible = true;
			}
        }

		private void EmployeeList_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( EmployeeList.SelectedItems.Count > 0 )
			{
				_currentEmployee = (Employee)EmployeeList.SelectedItems[ EmployeeList.SelectedItems.Count - 1 ].Tag;
				SelectedEmployeeName.Text = _currentEmployee.Worker.FirstName + " " + _currentEmployee.Worker.LastName;
				SelectedEmployeeAge.Text = _currentEmployee.Worker.Age.ToString();

				SelectedEmployeeSkillList.Items.Clear();
				SelectedEmployeeSkillList.Items.AddRange( _currentEmployee.Worker.Skills.Values.Select( s => AddSkills( s ) ).ToArray() );
			}

			if( _currentEmployee != null )
			{
				fireEmployee.Enabled = true;
				SelectedEmployeeName.Visible = true;
				SelectedEmployeeAge.Visible = true;
			}
		}

        private void hirePerson_Click( object sender, EventArgs e )
        {
            Employee emp = GameContext.CurrentGame.PlayerCompany.AddEmployee( _currentPerson );
			EmployeeList.Items.Add( CreateEmployee( emp ) );

			var PersonItem = PersonList.Items.Cast<ListViewItem>().Where( item => item.Tag == _currentPerson ).Single();
			PersonList.Items.Remove( PersonItem );
			
			hirePerson.Enabled = false;
        }

		private void fireEmployee_Click( object sender, EventArgs e )
		{
			Person p = GameContext.CurrentGame.PlayerCompany.RemoveEmployee( _currentEmployee );
			PersonList.Items.Add( CreatePerson( p ) );

			var EmployeeItem = EmployeeList.Items.Cast<ListViewItem>().Where( item => item.Tag == _currentEmployee ).Single();
			EmployeeList.Items.Remove( EmployeeItem );

			fireEmployee.Enabled = false;
		}
    }
}
