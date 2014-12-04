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
		string _newSkillToAddName;
        
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

				if(!_currentEmployee.Busy)
				{
					SetSkillsInForm( _currentEmployee.Worker, SelectedEmployeeSkillList );
					CreateSkillsToTrainComboBox();
					EnableTrainingDisplay( true );
				}
				else
				{
					EnableTrainingDisplay( false );
				}
				
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
			Train.Enabled = true;
			string selectedSkill = (string)SelectedEmployeeSkillsToTrain.SelectedItem;
			_currentSkillToTrain = _currentEmployee.Worker.Skills
				.Where( s => s.SkillName == selectedSkill )
				.SingleOrDefault();
			if( _currentSkillToTrain == null )
			{
				_newSkillToAddName = selectedSkill;
				SetTrainingValuesInForm( selectedSkill );
			}
			else
				if( _currentSkillToTrain.Level.CurrentLevel < 5 )
				{
					SetTrainingValuesInForm( _currentSkillToTrain );
				}
				else
					Train.Enabled = false;
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
		/// The selected Employee gains a level in the selected Skill if he already has it, or gains a new Skill at level 1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Train_Click( object sender, EventArgs e )
		{
			Train.Enabled = true;
			if( _currentSkillToTrain == null ) 
			{
				_currentEmployee.Train( _newSkillToAddName );
				_currentSkillToTrain = _currentEmployee.Worker.Skills
				.Where( s => s.SkillName == _newSkillToAddName )
				.SingleOrDefault();
			}
			else
			{
				_currentEmployee.Train( _currentSkillToTrain.SkillName );
				if( _currentSkillToTrain.Level.CurrentLevel < 5 )
				{
					SetTrainingValuesInForm( _currentSkillToTrain );
				}
				else
					Train.Enabled = false;
			}

			CreateSkillsToTrainComboBox();
			SetSkillsInForm( _currentEmployee.Worker, SelectedEmployeeSkillList );
		}

		/// <summary>
		/// Creates a Person Item for the PersonList
		/// </summary>
		/// <param name="p">The Person to display</param>
		/// <returns>A ListViewItem containing the information to display about a Person</returns>
		static ListViewItem CreatePerson( Person p )
		{
			ListViewItem i = new ListViewItem( p.LastName );
			i.Tag = p;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Age.ToString() ) );
			return i;
		}

		/// <summary>
		/// Creates an Employee Item for the EmployeeList
		/// </summary>
		/// <param name="e">The Employee to display</param>
		/// <returns>A ListViewItem containing the information to display about an Employee</returns>
		static ListViewItem CreateEmployee( Employee e )
		{
			ListViewItem i = new ListViewItem( e.Worker.LastName );
			i.Tag = e;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, e.Worker.Age.ToString() ) );
			return i;
		}

		/// <summary>
		/// Creates a Skill Item for the SelectedPerson or SelectedEMployee
		/// </summary>
		/// <param name="s">The Skill to display</param>
		/// <returns>A ListViewItem containing the information to display about a Skill</returns>
		static ListViewItem AddSkills( Skill s )
		{
			ListViewItem i = new ListViewItem( s.SkillName );
			i.Tag = s;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.Level.CurrentLevel.ToString() ) );
			return i;
		}

		/// <summary>
		/// Sets the informations to display about a Person's Skills
		/// </summary>
		/// <param name="p">The Person who's Skill to display</param>
		/// <param name="l">The ListView to edit</param>
		private void SetSkillsInForm( Person p, ListView l )
		{
			l.Items.Clear();
			l.Items.AddRange( p.Skills.Select( s => AddSkills( s ) ).ToArray() );
		}

		/// <summary>
		/// Sets the Cost and Time to train a Skill and displays it
		/// </summary>
		/// <param name="s">The Skill to train</param>
		private void SetTrainingValuesInForm( Skill s )
		{
			s.FixPriceAndTime();

			SelectedSkillToTrainCost.Text = s.UpgradePrice.ToString();
			SelectedSkillToTrainTime.Text = s.TimeToUpgrade.ToString();
		}

		private void SetTrainingValuesInForm( string skillName )
		{
			// TODO : trouver le moyen de ne pas le mettre à la mimine !!!
			if( GameContext.CurrentGame.IsProjSkill( skillName ) )
			{
				SelectedSkillToTrainCost.Text = "1000";
				SelectedSkillToTrainTime.Text = "2";
			}
			else
			{
				SelectedSkillToTrainCost.Text = "1500";
				SelectedSkillToTrainTime.Text = "4";
			}
		}

		private void CreateSkillsToTrainComboBox()
		{
			SelectedEmployeeSkillsToTrain.Items.Clear();
			IEnumerable<string> presentSkills = _currentEmployee.Worker.Skills
				.Where( s => s.Level.CurrentLevel < 5 )
				.Select( s => s.SkillName );
			SelectedEmployeeSkillsToTrain.Items.AddRange( presentSkills.ToArray() );

			SelectedEmployeeSkillsToTrain.Items.AddRange( GameContext.CurrentGame.SkillNames
				.Select( s => s.Value )
				.Where( s => !( _currentEmployee.Worker.Skills.Any( ps => ps.SkillName == s ) ) )
				.ToArray() );
		}

		private void EnableTrainingDisplay( bool enabled )
		{
			if(enabled)
			{
				SelectedEmployeeSkillsToTrain.Visible = true;
				SelectedSkillTrainCostTitle.Visible = true;
				SelectedSkillToTrainCost.Visible = true;
				SelectedSkillTrainTimeTitle.Visible = true;
				SelectedSkillToTrainTime.Visible = true;
			}
			else
			{
				SelectedEmployeeSkillsToTrain.Visible = false;
				SelectedSkillTrainCostTitle.Visible = false;
				SelectedSkillToTrainCost.Visible = false;
				SelectedSkillTrainTimeTitle.Visible = false;
				SelectedSkillToTrainTime.Visible = false;
			}
		}
    }
}
