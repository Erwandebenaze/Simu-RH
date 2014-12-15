namespace SRH.Interface
{
	partial class UcEmployeePage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label SelectedPersonTitle;
			System.Windows.Forms.Label personNameTitle;
			System.Windows.Forms.Label personAgeTitle;
			System.Windows.Forms.Label employeeAgeTitle;
			System.Windows.Forms.Label employeeNameTitle;
			System.Windows.Forms.Label SelectedEmployeeTitle;
			System.Windows.Forms.Label occupationTitle;
			System.Windows.Forms.Label salaryTitle;
			this.SelectedSkillTrainCostTitle = new System.Windows.Forms.Label();
			this.SelectedSkillTrainTimeTitle = new System.Windows.Forms.Label();
			this.PersonList = new System.Windows.Forms.ListView();
			this.PersonLastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonFirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.occupation = new System.Windows.Forms.Label();
			this.currentTrainingPanel = new System.Windows.Forms.Panel();
			this.timeLeft = new System.Windows.Forms.Label();
			this.cancelTraining = new System.Windows.Forms.Button();
			this.trainingTimeLeftTitle = new System.Windows.Forms.Label();
			this.trainingProgress = new System.Windows.Forms.ProgressBar();
			this.employeeAge = new System.Windows.Forms.Label();
			this.employeeName = new System.Windows.Forms.Label();
			this.trainingPanel = new System.Windows.Forms.Panel();
			this.Train = new System.Windows.Forms.Button();
			this.fireEmployee = new System.Windows.Forms.Button();
			this.SelectedSkillToTrainCost = new System.Windows.Forms.Label();
			this.SelectedSkillToTrainTime = new System.Windows.Forms.Label();
			this.SelectedEmployeeSkillsToTrain = new System.Windows.Forms.ComboBox();
			this.personAge = new System.Windows.Forms.Label();
			this.personName = new System.Windows.Forms.Label();
			this.hirePerson = new System.Windows.Forms.Button();
			this.salary = new System.Windows.Forms.Label();
			this.increaseSalary = new System.Windows.Forms.Button();
			this.decreaseSalary = new System.Windows.Forms.Button();
			this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
			this.ucSkillsDisplayEmployee = new SRH.Interface.UcSkillsDisplay();
			this.ucSkillsDisplayPerson = new SRH.Interface.UcSkillsDisplay();
			SelectedPersonTitle = new System.Windows.Forms.Label();
			personNameTitle = new System.Windows.Forms.Label();
			personAgeTitle = new System.Windows.Forms.Label();
			employeeAgeTitle = new System.Windows.Forms.Label();
			employeeNameTitle = new System.Windows.Forms.Label();
			SelectedEmployeeTitle = new System.Windows.Forms.Label();
			occupationTitle = new System.Windows.Forms.Label();
			salaryTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.currentTrainingPanel.SuspendLayout();
			this.trainingPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// SelectedPersonTitle
			// 
			SelectedPersonTitle.AutoSize = true;
			SelectedPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			SelectedPersonTitle.Location = new System.Drawing.Point(164, 13);
			SelectedPersonTitle.Name = "SelectedPersonTitle";
			SelectedPersonTitle.Size = new System.Drawing.Size(110, 20);
			SelectedPersonTitle.TabIndex = 1;
			SelectedPersonTitle.Text = "Le Postulant";
			// 
			// personNameTitle
			// 
			personNameTitle.AutoSize = true;
			personNameTitle.Location = new System.Drawing.Point(14, 59);
			personNameTitle.Name = "personNameTitle";
			personNameTitle.Size = new System.Drawing.Size(38, 13);
			personNameTitle.TabIndex = 2;
			personNameTitle.Text = "Nom : ";
			// 
			// personAgeTitle
			// 
			personAgeTitle.AutoSize = true;
			personAgeTitle.Location = new System.Drawing.Point(14, 83);
			personAgeTitle.Name = "personAgeTitle";
			personAgeTitle.Size = new System.Drawing.Size(35, 13);
			personAgeTitle.TabIndex = 3;
			personAgeTitle.Text = "Age : ";
			// 
			// employeeAgeTitle
			// 
			employeeAgeTitle.AutoSize = true;
			employeeAgeTitle.Location = new System.Drawing.Point(14, 58);
			employeeAgeTitle.Name = "employeeAgeTitle";
			employeeAgeTitle.Size = new System.Drawing.Size(35, 13);
			employeeAgeTitle.TabIndex = 8;
			employeeAgeTitle.Text = "Age : ";
			// 
			// employeeNameTitle
			// 
			employeeNameTitle.AutoSize = true;
			employeeNameTitle.Location = new System.Drawing.Point(14, 34);
			employeeNameTitle.Name = "employeeNameTitle";
			employeeNameTitle.Size = new System.Drawing.Size(38, 13);
			employeeNameTitle.TabIndex = 7;
			employeeNameTitle.Text = "Nom : ";
			// 
			// SelectedEmployeeTitle
			// 
			SelectedEmployeeTitle.AutoSize = true;
			SelectedEmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			SelectedEmployeeTitle.Location = new System.Drawing.Point(164, 11);
			SelectedEmployeeTitle.Name = "SelectedEmployeeTitle";
			SelectedEmployeeTitle.Size = new System.Drawing.Size(89, 20);
			SelectedEmployeeTitle.TabIndex = 6;
			SelectedEmployeeTitle.Text = "L\'employé";
			// 
			// occupationTitle
			// 
			occupationTitle.AutoSize = true;
			occupationTitle.Location = new System.Drawing.Point(14, 84);
			occupationTitle.Name = "occupationTitle";
			occupationTitle.Size = new System.Drawing.Size(68, 13);
			occupationTitle.TabIndex = 25;
			occupationTitle.Text = "Occupation :";
			// 
			// SelectedSkillTrainCostTitle
			// 
			this.SelectedSkillTrainCostTitle.AutoSize = true;
			this.SelectedSkillTrainCostTitle.Location = new System.Drawing.Point(133, 11);
			this.SelectedSkillTrainCostTitle.Name = "SelectedSkillTrainCostTitle";
			this.SelectedSkillTrainCostTitle.Size = new System.Drawing.Size(38, 13);
			this.SelectedSkillTrainCostTitle.TabIndex = 16;
			this.SelectedSkillTrainCostTitle.Text = "Coût : ";
			// 
			// SelectedSkillTrainTimeTitle
			// 
			this.SelectedSkillTrainTimeTitle.AutoSize = true;
			this.SelectedSkillTrainTimeTitle.Location = new System.Drawing.Point(133, 45);
			this.SelectedSkillTrainTimeTitle.Name = "SelectedSkillTrainTimeTitle";
			this.SelectedSkillTrainTimeTitle.Size = new System.Drawing.Size(48, 13);
			this.SelectedSkillTrainTimeTitle.TabIndex = 18;
			this.SelectedSkillTrainTimeTitle.Text = "Temps : ";
			// 
			// PersonList
			// 
			this.PersonList.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.PersonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonLastnameHeader,
            this.PersonFirstnameHeader,
            this.PersonAgeHeader});
			this.PersonList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PersonList.FullRowSelect = true;
			this.PersonList.Location = new System.Drawing.Point(0, 0);
			this.PersonList.MultiSelect = false;
			this.PersonList.Name = "PersonList";
			this.PersonList.Size = new System.Drawing.Size(449, 286);
			this.PersonList.TabIndex = 0;
			this.PersonList.UseCompatibleStateImageBehavior = false;
			this.PersonList.View = System.Windows.Forms.View.Details;
			this.PersonList.SelectedIndexChanged += new System.EventHandler(this.PersonList_SelectedIndexChanged);
			this.PersonList.DoubleClick += new System.EventHandler(this.hirePerson_Click);
			// 
			// PersonLastnameHeader
			// 
			this.PersonLastnameHeader.Text = "Nom";
			// 
			// PersonFirstnameHeader
			// 
			this.PersonFirstnameHeader.Text = "Prénom";
			// 
			// PersonAgeHeader
			// 
			this.PersonAgeHeader.Text = "Age";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(967, 539);
			this.splitContainer1.SplitterDistance = 449;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.UcEmployeeList1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.PersonList);
			this.splitContainer2.Size = new System.Drawing.Size(449, 539);
			this.splitContainer2.SplitterDistance = 249;
			this.splitContainer2.TabIndex = 1;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.decreaseSalary);
			this.splitContainer3.Panel1.Controls.Add(this.increaseSalary);
			this.splitContainer3.Panel1.Controls.Add(this.salary);
			this.splitContainer3.Panel1.Controls.Add(salaryTitle);
			this.splitContainer3.Panel1.Controls.Add(this.occupation);
			this.splitContainer3.Panel1.Controls.Add(occupationTitle);
			this.splitContainer3.Panel1.Controls.Add(this.currentTrainingPanel);
			this.splitContainer3.Panel1.Controls.Add(this.employeeAge);
			this.splitContainer3.Panel1.Controls.Add(this.employeeName);
			this.splitContainer3.Panel1.Controls.Add(SelectedEmployeeTitle);
			this.splitContainer3.Panel1.Controls.Add(employeeAgeTitle);
			this.splitContainer3.Panel1.Controls.Add(employeeNameTitle);
			this.splitContainer3.Panel1.Controls.Add(this.ucSkillsDisplayEmployee);
			this.splitContainer3.Panel1.Controls.Add(this.trainingPanel);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.ucSkillsDisplayPerson);
			this.splitContainer3.Panel2.Controls.Add(this.personAge);
			this.splitContainer3.Panel2.Controls.Add(this.personName);
			this.splitContainer3.Panel2.Controls.Add(personAgeTitle);
			this.splitContainer3.Panel2.Controls.Add(personNameTitle);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonTitle);
			this.splitContainer3.Panel2.Controls.Add(this.hirePerson);
			this.splitContainer3.Size = new System.Drawing.Size(514, 539);
			this.splitContainer3.SplitterDistance = 247;
			this.splitContainer3.TabIndex = 0;
			// 
			// occupation
			// 
			this.occupation.AutoSize = true;
			this.occupation.Location = new System.Drawing.Point(88, 84);
			this.occupation.Name = "occupation";
			this.occupation.Size = new System.Drawing.Size(14, 13);
			this.occupation.TabIndex = 26;
			this.occupation.Text = "X";
			this.occupation.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.occupation.Visible = false;
			// 
			// currentTrainingPanel
			// 
			this.currentTrainingPanel.Controls.Add(this.timeLeft);
			this.currentTrainingPanel.Controls.Add(this.cancelTraining);
			this.currentTrainingPanel.Controls.Add(this.trainingTimeLeftTitle);
			this.currentTrainingPanel.Controls.Add(this.trainingProgress);
			this.currentTrainingPanel.Location = new System.Drawing.Point(165, 35);
			this.currentTrainingPanel.Name = "currentTrainingPanel";
			this.currentTrainingPanel.Size = new System.Drawing.Size(341, 68);
			this.currentTrainingPanel.TabIndex = 24;
			this.currentTrainingPanel.Visible = false;
			// 
			// timeLeft
			// 
			this.timeLeft.AutoSize = true;
			this.timeLeft.Location = new System.Drawing.Point(104, 52);
			this.timeLeft.Name = "timeLeft";
			this.timeLeft.Size = new System.Drawing.Size(14, 13);
			this.timeLeft.TabIndex = 4;
			this.timeLeft.Text = "X";
			this.timeLeft.Visible = false;
			// 
			// cancelTraining
			// 
			this.cancelTraining.Location = new System.Drawing.Point(257, 11);
			this.cancelTraining.Name = "cancelTraining";
			this.cancelTraining.Size = new System.Drawing.Size(75, 23);
			this.cancelTraining.TabIndex = 3;
			this.cancelTraining.Text = "Annuler";
			this.cancelTraining.UseVisualStyleBackColor = true;
			// 
			// trainingTimeLeftTitle
			// 
			this.trainingTimeLeftTitle.AutoSize = true;
			this.trainingTimeLeftTitle.Location = new System.Drawing.Point(17, 52);
			this.trainingTimeLeftTitle.Name = "trainingTimeLeftTitle";
			this.trainingTimeLeftTitle.Size = new System.Drawing.Size(80, 13);
			this.trainingTimeLeftTitle.TabIndex = 1;
			this.trainingTimeLeftTitle.Text = "Temps restant :";
			// 
			// trainingProgress
			// 
			this.trainingProgress.Location = new System.Drawing.Point(3, 16);
			this.trainingProgress.Name = "trainingProgress";
			this.trainingProgress.Size = new System.Drawing.Size(212, 16);
			this.trainingProgress.TabIndex = 0;
			// 
			// employeeAge
			// 
			this.employeeAge.AutoSize = true;
			this.employeeAge.Location = new System.Drawing.Point(55, 58);
			this.employeeAge.Name = "employeeAge";
			this.employeeAge.Size = new System.Drawing.Size(14, 13);
			this.employeeAge.TabIndex = 10;
			this.employeeAge.Text = "X";
			this.employeeAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.employeeAge.Visible = false;
			// 
			// employeeName
			// 
			this.employeeName.AutoSize = true;
			this.employeeName.Location = new System.Drawing.Point(55, 34);
			this.employeeName.Name = "employeeName";
			this.employeeName.Size = new System.Drawing.Size(14, 13);
			this.employeeName.TabIndex = 9;
			this.employeeName.Text = "X";
			this.employeeName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.employeeName.Visible = false;
			// 
			// trainingPanel
			// 
			this.trainingPanel.Controls.Add(this.Train);
			this.trainingPanel.Controls.Add(this.fireEmployee);
			this.trainingPanel.Controls.Add(this.SelectedSkillToTrainCost);
			this.trainingPanel.Controls.Add(this.SelectedSkillToTrainTime);
			this.trainingPanel.Controls.Add(this.SelectedSkillTrainCostTitle);
			this.trainingPanel.Controls.Add(this.SelectedSkillTrainTimeTitle);
			this.trainingPanel.Controls.Add(this.SelectedEmployeeSkillsToTrain);
			this.trainingPanel.Location = new System.Drawing.Point(168, 35);
			this.trainingPanel.Name = "trainingPanel";
			this.trainingPanel.Size = new System.Drawing.Size(341, 68);
			this.trainingPanel.TabIndex = 23;
			this.trainingPanel.Visible = false;
			// 
			// Train
			// 
			this.Train.Enabled = false;
			this.Train.Location = new System.Drawing.Point(257, 6);
			this.Train.Name = "Train";
			this.Train.Size = new System.Drawing.Size(75, 23);
			this.Train.TabIndex = 14;
			this.Train.Text = "Former";
			this.Train.UseVisualStyleBackColor = true;
			this.Train.Click += new System.EventHandler(this.Train_Click);
			// 
			// fireEmployee
			// 
			this.fireEmployee.Enabled = false;
			this.fireEmployee.Location = new System.Drawing.Point(257, 45);
			this.fireEmployee.Name = "fireEmployee";
			this.fireEmployee.Size = new System.Drawing.Size(75, 23);
			this.fireEmployee.TabIndex = 0;
			this.fireEmployee.Text = "Renvoyer";
			this.fireEmployee.UseVisualStyleBackColor = true;
			this.fireEmployee.Click += new System.EventHandler(this.fireEmployee_Click);
			// 
			// SelectedSkillToTrainCost
			// 
			this.SelectedSkillToTrainCost.AutoSize = true;
			this.SelectedSkillToTrainCost.Location = new System.Drawing.Point(167, 11);
			this.SelectedSkillToTrainCost.Name = "SelectedSkillToTrainCost";
			this.SelectedSkillToTrainCost.Size = new System.Drawing.Size(14, 13);
			this.SelectedSkillToTrainCost.TabIndex = 17;
			this.SelectedSkillToTrainCost.Text = "X";
			// 
			// SelectedSkillToTrainTime
			// 
			this.SelectedSkillToTrainTime.AutoSize = true;
			this.SelectedSkillToTrainTime.Location = new System.Drawing.Point(178, 45);
			this.SelectedSkillToTrainTime.Name = "SelectedSkillToTrainTime";
			this.SelectedSkillToTrainTime.Size = new System.Drawing.Size(14, 13);
			this.SelectedSkillToTrainTime.TabIndex = 19;
			this.SelectedSkillToTrainTime.Text = "X";
			// 
			// SelectedEmployeeSkillsToTrain
			// 
			this.SelectedEmployeeSkillsToTrain.FormattingEnabled = true;
			this.SelectedEmployeeSkillsToTrain.Location = new System.Drawing.Point(12, 8);
			this.SelectedEmployeeSkillsToTrain.Name = "SelectedEmployeeSkillsToTrain";
			this.SelectedEmployeeSkillsToTrain.Size = new System.Drawing.Size(106, 21);
			this.SelectedEmployeeSkillsToTrain.TabIndex = 15;
			this.SelectedEmployeeSkillsToTrain.SelectedIndexChanged += new System.EventHandler(this.SelectedEmployeeSkillsToTrain_SelectedIndexChanged);
			// 
			// personAge
			// 
			this.personAge.AutoSize = true;
			this.personAge.Location = new System.Drawing.Point(55, 83);
			this.personAge.Name = "personAge";
			this.personAge.Size = new System.Drawing.Size(14, 13);
			this.personAge.TabIndex = 5;
			this.personAge.Text = "X";
			this.personAge.Visible = false;
			// 
			// personName
			// 
			this.personName.AutoSize = true;
			this.personName.Location = new System.Drawing.Point(55, 59);
			this.personName.Name = "personName";
			this.personName.Size = new System.Drawing.Size(14, 13);
			this.personName.TabIndex = 4;
			this.personName.Text = "X";
			this.personName.Visible = false;
			// 
			// hirePerson
			// 
			this.hirePerson.Enabled = false;
			this.hirePerson.Location = new System.Drawing.Point(332, 54);
			this.hirePerson.Name = "hirePerson";
			this.hirePerson.Size = new System.Drawing.Size(75, 23);
			this.hirePerson.TabIndex = 0;
			this.hirePerson.Text = "Engager";
			this.hirePerson.UseVisualStyleBackColor = true;
			this.hirePerson.Click += new System.EventHandler(this.hirePerson_Click);
			// 
			// salary
			// 
			this.salary.AutoSize = true;
			this.salary.Location = new System.Drawing.Point(88, 129);
			this.salary.Name = "salary";
			this.salary.Size = new System.Drawing.Size(14, 13);
			this.salary.TabIndex = 28;
			this.salary.Text = "X";
			this.salary.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.salary.Visible = false;
			// 
			// salaryTitle
			// 
			salaryTitle.AutoSize = true;
			salaryTitle.Location = new System.Drawing.Point(14, 129);
			salaryTitle.Name = "salaryTitle";
			salaryTitle.Size = new System.Drawing.Size(45, 13);
			salaryTitle.TabIndex = 27;
			salaryTitle.Text = "Salaire :";
			// 
			// increaseSalary
			// 
			this.increaseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.increaseSalary.Location = new System.Drawing.Point(17, 155);
			this.increaseSalary.Name = "increaseSalary";
			this.increaseSalary.Size = new System.Drawing.Size(22, 23);
			this.increaseSalary.TabIndex = 29;
			this.increaseSalary.Text = "+";
			this.increaseSalary.UseVisualStyleBackColor = true;
			this.increaseSalary.Click += new System.EventHandler(this.increaseSalary_Click);
			// 
			// decreaseSalary
			// 
			this.decreaseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decreaseSalary.Location = new System.Drawing.Point(60, 155);
			this.decreaseSalary.Name = "decreaseSalary";
			this.decreaseSalary.Size = new System.Drawing.Size(22, 23);
			this.decreaseSalary.TabIndex = 30;
			this.decreaseSalary.Text = "-";
			this.decreaseSalary.UseVisualStyleBackColor = true;
			this.decreaseSalary.Click += new System.EventHandler(this.decreaseSalary_Click);
			// 
			// UcEmployeeList1
			// 
			this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcEmployeeList1.Location = new System.Drawing.Point(0, 0);
			this.UcEmployeeList1.Name = "UcEmployeeList1";
			this.UcEmployeeList1.Size = new System.Drawing.Size(449, 249);
			this.UcEmployeeList1.TabIndex = 1;
			// 
			// ucSkillsDisplayEmployee
			// 
			this.ucSkillsDisplayEmployee.CurrentPerson = null;
			this.ucSkillsDisplayEmployee.Location = new System.Drawing.Point(147, 104);
			this.ucSkillsDisplayEmployee.Name = "ucSkillsDisplayEmployee";
			this.ucSkillsDisplayEmployee.Size = new System.Drawing.Size(364, 140);
			this.ucSkillsDisplayEmployee.TabIndex = 22;
			// 
			// ucSkillsDisplayPerson
			// 
			this.ucSkillsDisplayPerson.CurrentPerson = null;
			this.ucSkillsDisplayPerson.Location = new System.Drawing.Point(147, 145);
			this.ucSkillsDisplayPerson.Name = "ucSkillsDisplayPerson";
			this.ucSkillsDisplayPerson.Size = new System.Drawing.Size(367, 140);
			this.ucSkillsDisplayPerson.TabIndex = 23;
			// 
			// UcEmployeePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcEmployeePage";
			this.Size = new System.Drawing.Size(967, 539);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.currentTrainingPanel.ResumeLayout(false);
			this.currentTrainingPanel.PerformLayout();
			this.trainingPanel.ResumeLayout(false);
			this.trainingPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView PersonList;
		private System.Windows.Forms.ColumnHeader PersonLastnameHeader;
		private System.Windows.Forms.ColumnHeader PersonFirstnameHeader;
        private System.Windows.Forms.ColumnHeader PersonAgeHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button hirePerson;
        private System.Windows.Forms.Label personAge;
		private System.Windows.Forms.Label personName;
		private System.Windows.Forms.Button fireEmployee;
		private System.Windows.Forms.Label employeeAge;
		private System.Windows.Forms.Label employeeName;
		private System.Windows.Forms.Label SelectedSkillToTrainCost;
		private System.Windows.Forms.ComboBox SelectedEmployeeSkillsToTrain;
		private System.Windows.Forms.Button Train;
		private System.Windows.Forms.Label SelectedSkillToTrainTime;
		private System.Windows.Forms.Label SelectedSkillTrainCostTitle;
		private System.Windows.Forms.Label SelectedSkillTrainTimeTitle;
		private UcEmployeeList UcEmployeeList1;
		private UcSkillsDisplay ucSkillsDisplayEmployee;
		private UcSkillsDisplay ucSkillsDisplayPerson;
		private System.Windows.Forms.Panel trainingPanel;
		private System.Windows.Forms.Panel currentTrainingPanel;
		private System.Windows.Forms.Label trainingTimeLeftTitle;
		private System.Windows.Forms.ProgressBar trainingProgress;
		private System.Windows.Forms.Button cancelTraining;
		private System.Windows.Forms.Label occupation;
		private System.Windows.Forms.Label timeLeft;
		private System.Windows.Forms.Label salary;
		private System.Windows.Forms.Button decreaseSalary;
		private System.Windows.Forms.Button increaseSalary;
	}
}
