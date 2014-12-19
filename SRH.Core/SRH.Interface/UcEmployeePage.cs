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
        Person _currentPerson;
		Employee _currentEmployee;
		Skill _currentSkillToTrain;
		string _newSkillToAddName;
		int _currentTrainingProgress;
		int _maximumTrainingProgress;
		int _trainingTimeLeft;
        
        public UcEmployeePage()
        {
            InitializeComponent();
        }

		#region Getters Setters
		IGameContext GameContext
		{
			get { return (IGameContext)TopLevelControl; }
		}

		public Employee CurrentEmployee
		{
			get { return _currentEmployee; }
		}

		public int CurrentTrainingProgress
		{
			get { return _currentTrainingProgress; }
			set { _currentTrainingProgress = value; }
		}

		public int MaximumTrainingProgress
		{
			get { return _maximumTrainingProgress; }
			set { _maximumTrainingProgress = value; }
		}

		public int TrainingTimeLeft
		{
			get { return _trainingTimeLeft; }
			set { _trainingTimeLeft = value; }
		}
		#endregion

		protected override void OnLoad( EventArgs e )
		{
			if( this.IsInRuntimeMode() )
			{
				base.OnLoad( e );
				UcEmployeeList1.Changed += UpdateEmployeeDisplay;
				LoadPage();
			}
		}

		/// <summary>
		/// Loads the User Control
		/// </summary>
		internal void LoadPage()
		{
			_joblessPersons = GameContext.CurrentGame.Market.JoblessPersons;
			PersonList.Items.Clear();
			PersonList.Items.AddRange( _joblessPersons.Select( p => CreatePerson( p ) ).ToArray() );
			UcEmployeeList1.LoadUc();
		}

		internal void LoadEmployeeList()
		{
			UcEmployeeList1.LoadUc();
		}

		internal void UpdateEmployeeDisplay()
		{
			// UcEmployeeList1.LoadUc();
			_currentEmployee = UcEmployeeList1.CurrentEmployee;

			ucSkillsDisplayEmployee.CurrentPerson = _currentEmployee.Worker;
			employeeName.Text = _currentEmployee.Worker.FirstName + " " + _currentEmployee.Worker.LastName;
			employeeAge.Text = _currentEmployee.Worker.Age.ToString();
			employeeOccupation.Text = GetCurrentOccupationText( _currentEmployee );
			firingCost.Text = _currentEmployee.LayingOffCost.ToString();
			GetSalaryDisplay();

			if( !_currentEmployee.Busy )
			{
				EnableEmployeeInfo();
				trainingPanel.Visible = true;
				currentTrainingPanel.Visible = false;
				CreateSkillsToTrainComboBox();
			}
			else if( _currentEmployee.Busy && ( _currentEmployee.SkillInTraining != null ) )
			{
				EnableEmployeeInfo();
				trainingPanel.Visible = false;
				currentTrainingPanel.Visible = true;
			}
			else
			{
				trainingPanel.Visible = false;
				Train.Enabled = false;
			}
			ucSkillsDisplayEmployee.LoadUc();
		}

		private void GetSalaryDisplay()
		{
			employeeSalary.Text = _currentEmployee.Salary.ToString();
			if( _currentEmployee.Salary == _currentEmployee.Worker.ExpectedSalary )
				employeeSalary.ForeColor = Color.Black;
			else if( _currentEmployee.Salary < _currentEmployee.Worker.ExpectedSalary )
				employeeSalary.ForeColor = Color.Red;
			else
				employeeSalary.ForeColor = Color.Green;

		}

		internal void SetTrainingProgress( Employee e )
		{
			timeLeft.Visible = true;
			timeLeft.Text = _trainingTimeLeft.ToString();
			trainingProgress.Minimum = 0;
			trainingProgress.Maximum = _currentEmployee.TrainingDuration;
			trainingProgress.Value = _currentEmployee.TrainingDuration - _trainingTimeLeft;
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
                personName.Text = _currentPerson.FirstName + " " + _currentPerson.LastName;
                personAge.Text = _currentPerson.Age.ToString();
				personExpectedSalary.Text = _currentPerson.ExpectedSalary.ToString();
				hiringCost.Text = _currentPerson.HiringCost.ToString();
				ucSkillsDisplayPerson.CurrentPerson = _currentPerson;
				ucSkillsDisplayPerson.LoadUc();
            }
			if( _currentPerson != null )
			{
				hirePerson.Enabled = true;
				personName.Visible = true;
				personAge.Visible = true;
				hiringCost.Visible = true;
				personExpectedSalary.Visible = true;
			}
        }

		private void EnableEmployeeInfo()
		{
			fireEmployee.Enabled = true;
			employeeName.Visible = true;
			employeeAge.Visible = true;
			employeeOccupation.Visible = true;
			employeeSalary.Visible = true;
			firingCost.Visible = true;
			decreaseSalary.Visible = true;
			increaseSalary.Visible = true;

			if( ( _currentEmployee.Salary - ( _currentEmployee.Worker.ExpectedSalary * 0.05 ) ) < 600 )
				decreaseSalary.Enabled = false;
			else
				decreaseSalary.Enabled = true;
			if( ( _currentEmployee.Salary + ( _currentEmployee.Worker.ExpectedSalary * 0.05 ) ) > ( 2 * _currentEmployee.Worker.ExpectedSalary ) )
				increaseSalary.Enabled = false;
			else
				increaseSalary.Enabled = true;
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
				if( _currentSkillToTrain.Level.CurrentLevel < 5 && !( _currentEmployee.Busy ) )
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
			// TODO : deny/prevent hiring if MyCompany doesn't have enough money
            GameContext.CurrentGame.PlayerCompany.HireEmployee( _currentPerson );
			var PersonItem = PersonList.Items.Cast<ListViewItem>().Where( item => item.Tag == _currentPerson ).Single();
			PersonList.Items.Remove( PersonItem );

			UcEmployeeList1.LoadUc();
			hirePerson.Enabled = false;
        }

		/// <summary>
		/// Fires the selected Employee, who becomes a Person in the LabourMarket and is no longer available in MyCompany
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fireEmployee_Click( object sender, EventArgs e )
		{
			// TODO : deny/prevent firing if MyCompany doesn't have enough money
			GameContext.CurrentGame.PlayerCompany.LayingOffEmployee( _currentEmployee );
			PersonList.Items.Add( CreatePerson( _currentEmployee.Worker ) );

			var EmployeeItem = UcEmployeeList1.EmployeeList.Items.Cast<ListViewItem>().Where( item => item.Tag == _currentEmployee ).Single();
			UcEmployeeList1.EmployeeList.Items.Remove( EmployeeItem );

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
				_currentEmployee.StartTraining( _newSkillToAddName );
				Train.Enabled = false;
				UpdateEmployeeDisplay();
			}
			else
			{
				if( _currentSkillToTrain.Level.CurrentLevel < 5 )
				{
					_currentEmployee.StartTraining( _currentSkillToTrain.SkillName );
					SetTrainingValuesInForm( _currentSkillToTrain );
					Train.Enabled = false;
					UpdateEmployeeDisplay();
				}
				else
					Train.Enabled = false;
			}
			LoadPage();
		}

		private void cancelTraining_Click( object sender, EventArgs e )
		{
			_currentEmployee.CancelTraining();
			UpdateEmployeeDisplay();
		}

		private void increaseSalary_Click( object sender, EventArgs e )
		{
			double salaryIncrease = _currentEmployee.Worker.ExpectedSalary * 0.05;
			_currentEmployee.SalaryAdjustment += (int)salaryIncrease;
			UpdateEmployeeDisplay();
		}

		private void decreaseSalary_Click( object sender, EventArgs e )
		{
			double salaryDecrease = _currentEmployee.Worker.ExpectedSalary * 0.05;
			_currentEmployee.SalaryAdjustment -= (int)salaryDecrease;
			UpdateEmployeeDisplay();
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

			Skill personBestSkill = p.Skills
				.Where( s => s.Level.CurrentXp == p.Skills.Max( sk => sk.Level.CurrentXp ) )
				.FirstOrDefault();

			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, personBestSkill.SkillName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, personBestSkill.Level.CurrentLevel.ToString() ) );

			return i;
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
			if( skillName.IsProjSkill() )
			{
				SelectedSkillToTrainCost.Text = "1000";
				SelectedSkillToTrainTime.Text = "15";
			}
			else
			{
				SelectedSkillToTrainCost.Text = "1500";
				SelectedSkillToTrainTime.Text = "20";
			}
		}

		private void CreateSkillsToTrainComboBox()
		{
			SelectedEmployeeSkillsToTrain.Items.Clear();

			// Add the Employee's already present Skills
			SelectedEmployeeSkillsToTrain.Items.AddRange( _currentEmployee.Worker.Skills
				.Where( s => s.Level.CurrentLevel < 5 )
				.Select( s => s.SkillName ).ToArray() );
			// Add the other Skills, without the Employee's already present Skills
			SelectedEmployeeSkillsToTrain.Items.AddRange( Game.SkillNames
				.Select( s => s.Value )
				.Where( s => !( _currentEmployee.Worker.Skills.Any( ps => ps.SkillName == s ) ) )
				.ToArray() );
			SelectedEmployeeSkillsToTrain.SelectedIndex = 0;
		}

		private string GetCurrentOccupationText( Employee e )
		{
			string currentOccupation;

			if( e.Busy && ( e.SkillAffectedToCompany != null ) )
				currentOccupation = "En poste Fixe (" + e.SkillAffectedToCompany.SkillName + ")";
			else if( e.Busy && ( e.SkillInTraining != null ) )
				currentOccupation = "En formation (" + e.SkillInTraining + ")";
			else if( e.Busy )
				currentOccupation = "En projet";
			else
				currentOccupation = "Aucune";

			return currentOccupation;

		}
    }
}
