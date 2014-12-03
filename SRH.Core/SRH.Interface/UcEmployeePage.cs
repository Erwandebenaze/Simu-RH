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
        IReadOnlyList<Person> _joblessPersons;
        List<Employee> _employees;
        Person _currentPerson;
		Employee _currentEmployee;
		Skill _currentSkillToTrain;
        
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
				LoadPage();
			}
		}

		/// <summary>
		/// Loads the User Control
		/// </summary>
		internal void LoadPage()
		{
			_employees = GameContext.CurrentGame.PlayerCompany.Employees;
			_joblessPersons = (List<Person>)GameContext.CurrentGame.Market.JoblessPersons;

			PersonList.Items.Clear();
			EmployeeList.Items.Clear();
			PersonList.Items.AddRange( _joblessPersons.Select( p => CreatePerson( p ) ).ToArray() );
			EmployeeList.Items.AddRange( _employees.Select( employee => CreateEmployee( employee ) ).ToArray() );
			
		}

		/// <summary>
		/// Displays the information about the selected Person
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void PersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( PersonList.SelectedItems.Count > 0 )
            {
                _currentPerson = (Person)PersonList.SelectedItems[ PersonList.SelectedItems.Count - 1 ].Tag;
                SelectedPersonName.Text = _currentPerson.FirstName + " " + _currentPerson.LastName;
                SelectedPersonAge.Text = _currentPerson.Age.ToString();

				SetSkillsInForm( _currentPerson, SelectedPersonSkillList );

            }
			if( _currentPerson != null )
			{
				hirePerson.Enabled = true;
				SelectedPersonName.Visible = true;
				SelectedPersonAge.Visible = true;
			}
        }

		/// <summary>
		/// Displays the information about the selected Employee
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EmployeeList_SelectedIndexChanged( object sender, EventArgs e )
		{
			if( EmployeeList.SelectedItems.Count > 0 )
			{
				_currentEmployee = (Employee)EmployeeList.SelectedItems[ EmployeeList.SelectedItems.Count - 1 ].Tag;
				SelectedEmployeeName.Text = _currentEmployee.Worker.FirstName + " " + _currentEmployee.Worker.LastName;
				SelectedEmployeeAge.Text = _currentEmployee.Worker.Age.ToString();

				SetSkillsInForm( _currentEmployee.Worker, SelectedEmployeeSkillList );

				SelectedEmployeeSkillsToTrain.Items.Clear();
				SelectedEmployeeSkillsToTrain.Items.AddRange( _currentEmployee.Worker.Skills
					.Where( s => s.Level.CurrentLevel < 5 )
					.Select( s => (object)s.FrenchSkillName )
					.ToArray() );
			}

			if( _currentEmployee != null )
			{
				fireEmployee.Enabled = true;
				SelectedEmployeeName.Visible = true;
				SelectedEmployeeAge.Visible = true;
			}
		}

		/// <summary>
		/// Displays the information about the selected Skill to train (Cost and Time)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectedEmployeeSkillsToTrain_SelectedIndexChanged( object sender, EventArgs e )
		{
			_currentSkillToTrain = _currentEmployee.Worker.Skills
				.Where( s => s.FrenchSkillName == (string)SelectedEmployeeSkillsToTrain.SelectedItem )
				.Single();
			SetTrainingValuesInForm( _currentSkillToTrain );
			Train.Enabled = true;
		}

		/// <summary>
		/// Hires the selected Person, who becomes an Employee available in MyCompany
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void hirePerson_Click( object sender, EventArgs e )
        {
            Employee emp = GameContext.CurrentGame.PlayerCompany.AddEmployee( _currentPerson );
			EmployeeList.Items.Add( CreateEmployee( emp ) );

			var PersonItem = PersonList.Items.Cast<ListViewItem>().Where( item => item.Tag == _currentPerson ).Single();
			PersonList.Items.Remove( PersonItem );
		
			hirePerson.Enabled = false;
        }

		/// <summary>
		/// Fires the selected Employee, who becomes a Person in the LabourMarket and is no longer available in MyCompany
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fireEmployee_Click( object sender, EventArgs e )
		{
			Person p = GameContext.CurrentGame.PlayerCompany.RemoveEmployee( _currentEmployee );
			PersonList.Items.Add( CreatePerson( p ) );

			var EmployeeItem = EmployeeList.Items.Cast<ListViewItem>().Where( item => item.Tag == _currentEmployee ).Single();
			EmployeeList.Items.Remove( EmployeeItem );

			fireEmployee.Enabled = false;
		}

		/// <summary>
		/// The selected Employee gains a level in the selected Skill
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Train_Click( object sender, EventArgs e )
		{
			int xpToNextLevel = _currentSkillToTrain.Level.NextXpRequired - _currentSkillToTrain.Level.CurrentXp;
			_currentSkillToTrain.Level.IncreaseXp( xpToNextLevel );

			SetTrainingValuesInForm( _currentSkillToTrain );
			SetSkillsInForm( _currentEmployee.Worker, SelectedEmployeeSkillList );

		}

		/// <summary>
		/// Creates a List
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		static ListViewItem CreatePerson( Person p )
		{
			ListViewItem i = new ListViewItem( p.LastName );
			i.Tag = p;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Age.ToString() ) );
			return i;
		}

		static ListViewItem CreateEmployee( Employee e )
		{
			ListViewItem i = new ListViewItem( e.Worker.LastName );
			i.Tag = e;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.Age.ToString() ) );
			return i;
		}

		static ListViewItem AddSkills( Skill s )
		{
			ListViewItem i = new ListViewItem( s.FrenchSkillName );
			i.Tag = s;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.Level.CurrentLevel.ToString() ) );
			return i;
		}

		private void SetSkillsInForm( Person p, ListView l )
		{
			l.Items.Clear();
			l.Items.AddRange( p.Skills.Select( s => AddSkills( s ) ).ToArray() );
		}

		private void SetTrainingValuesInForm( Skill s )
		{
			s.FixPriceAndTime();

			SelectedSkillToTrainCost.Text = s.UpgradePrice.ToString();
			SelectedSkillToTrainTime.Text = s.TimeToUpgrade.ToString();
		}
    }
}
