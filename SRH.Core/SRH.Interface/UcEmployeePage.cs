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
        
        public UcEmployeePage()
        {
            InitializeComponent();
        }

        IGameContext GameContext
        {
            get { return (IGameContext)TopLevelControl; }
        }

        private void UcEmployeePage_Load( object sender, EventArgs e )
        {

        }
        protected override void OnLoad( EventArgs e )
        {
            if( this.IsInRuntimeMode() )
            {
                base.OnLoad( e );
				_employees = GameContext.CurrentGame.PlayerCompany.Employees;
				_joblessPersons = GameContext.CurrentGame.Market.JoblessPersons;

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

        private void PersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( PersonList.SelectedItems.Count > 0 )
            {
                _currentPerson = (Person)PersonList.SelectedItems[ PersonList.SelectedItems.Count - 1 ].Tag;
                SelectedPersonName.Text = _currentPerson.FirstName + " " + _currentPerson.LastName;
                SelectedPersonAge.Text = _currentPerson.Age.ToString();
            }
            if( !( _currentPerson == null ) ) hirePerson.Enabled = true;
        }

        private void hirePerson_Click( object sender, EventArgs e )
        {
            Employee emp = GameContext.CurrentGame.PlayerCompany.AddEmployee( _currentPerson );



			EmployeeList.Items.Add( CreateEmployee( emp ) );
        }
    }
}
