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
			System.Windows.Forms.Label employeeOcupationTitle;
			System.Windows.Forms.Label employeeSalaryTitle;
			System.Windows.Forms.Label personExpectedSalaryTitle;
			System.Windows.Forms.Label firingCostTitle;
			System.Windows.Forms.Label hiringCostTitle;
			System.Windows.Forms.Label happinessTtile;
			this.SelectedSkillTrainCostTitle = new System.Windows.Forms.Label();
			this.SelectedSkillTrainTimeTitle = new System.Windows.Forms.Label();
			this.PersonList = new System.Windows.Forms.ListView();
			this.PersonLastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonFirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonBestSkillHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonBestSkillLevelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.happinessValues = new System.Windows.Forms.Label();
			this.happinessBar = new System.Windows.Forms.ProgressBar();
			this.SalaryAdjustmentIndication = new System.Windows.Forms.Label();
			this.trainingPanel = new System.Windows.Forms.Panel();
			this.firingCost = new System.Windows.Forms.Label();
			this.Train = new System.Windows.Forms.Button();
			this.fireEmployee = new System.Windows.Forms.Button();
			this.SelectedSkillToTrainCost = new System.Windows.Forms.Label();
			this.SelectedSkillToTrainTime = new System.Windows.Forms.Label();
			this.SelectedEmployeeSkillsToTrain = new System.Windows.Forms.ComboBox();
			this.currentTrainingPanel = new System.Windows.Forms.Panel();
			this.timeLeft = new System.Windows.Forms.Label();
			this.cancelTraining = new System.Windows.Forms.Button();
			this.trainingTimeLeftTitle = new System.Windows.Forms.Label();
			this.trainingProgress = new System.Windows.Forms.ProgressBar();
			this.decreaseSalary = new System.Windows.Forms.Button();
			this.increaseSalary = new System.Windows.Forms.Button();
			this.employeeSalary = new System.Windows.Forms.Label();
			this.employeeOccupation = new System.Windows.Forms.Label();
			this.employeeAge = new System.Windows.Forms.Label();
			this.employeeName = new System.Windows.Forms.Label();
			this.ucSkillsDisplayEmployee = new SRH.Interface.UcSkillsDisplay();
			this.hiringCost = new System.Windows.Forms.Label();
			this.personExpectedSalary = new System.Windows.Forms.Label();
			this.ucSkillsDisplayPerson = new SRH.Interface.UcSkillsDisplay();
			this.personAge = new System.Windows.Forms.Label();
			this.personName = new System.Windows.Forms.Label();
			this.hirePerson = new System.Windows.Forms.Button();
			SelectedPersonTitle = new System.Windows.Forms.Label();
			personNameTitle = new System.Windows.Forms.Label();
			personAgeTitle = new System.Windows.Forms.Label();
			employeeAgeTitle = new System.Windows.Forms.Label();
			employeeNameTitle = new System.Windows.Forms.Label();
			SelectedEmployeeTitle = new System.Windows.Forms.Label();
			employeeOcupationTitle = new System.Windows.Forms.Label();
			employeeSalaryTitle = new System.Windows.Forms.Label();
			personExpectedSalaryTitle = new System.Windows.Forms.Label();
			firingCostTitle = new System.Windows.Forms.Label();
			hiringCostTitle = new System.Windows.Forms.Label();
			happinessTtile = new System.Windows.Forms.Label();
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
			this.trainingPanel.SuspendLayout();
			this.currentTrainingPanel.SuspendLayout();
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
			// employeeOcupationTitle
			// 
			employeeOcupationTitle.AutoSize = true;
			employeeOcupationTitle.Location = new System.Drawing.Point(14, 84);
			employeeOcupationTitle.Name = "employeeOcupationTitle";
			employeeOcupationTitle.Size = new System.Drawing.Size(68, 13);
			employeeOcupationTitle.TabIndex = 25;
			employeeOcupationTitle.Text = "Occupation :";
			// 
			// employeeSalaryTitle
			// 
			employeeSalaryTitle.AutoSize = true;
			employeeSalaryTitle.Location = new System.Drawing.Point(14, 114);
			employeeSalaryTitle.Name = "employeeSalaryTitle";
			employeeSalaryTitle.Size = new System.Drawing.Size(45, 13);
			employeeSalaryTitle.TabIndex = 27;
			employeeSalaryTitle.Text = "Salaire :";
			// 
			// personExpectedSalaryTitle
			// 
			personExpectedSalaryTitle.AutoSize = true;
			personExpectedSalaryTitle.Location = new System.Drawing.Point(14, 112);
			personExpectedSalaryTitle.Name = "personExpectedSalaryTitle";
			personExpectedSalaryTitle.Size = new System.Drawing.Size(84, 13);
			personExpectedSalaryTitle.TabIndex = 31;
			personExpectedSalaryTitle.Text = "Salaire attendu :";
			// 
			// firingCostTitle
			// 
			firingCostTitle.AutoSize = true;
			firingCostTitle.Location = new System.Drawing.Point(265, 37);
			firingCostTitle.Name = "firingCostTitle";
			firingCostTitle.Size = new System.Drawing.Size(35, 13);
			firingCostTitle.TabIndex = 31;
			firingCostTitle.Text = "Coût :";
			// 
			// hiringCostTitle
			// 
			hiringCostTitle.AutoSize = true;
			hiringCostTitle.Location = new System.Drawing.Point(334, 83);
			hiringCostTitle.Name = "hiringCostTitle";
			hiringCostTitle.Size = new System.Drawing.Size(35, 13);
			hiringCostTitle.TabIndex = 33;
			hiringCostTitle.Text = "Coût :";
			// 
			// happinessTtile
			// 
			happinessTtile.AutoSize = true;
			happinessTtile.Location = new System.Drawing.Point(14, 219);
			happinessTtile.Name = "happinessTtile";
			happinessTtile.Size = new System.Drawing.Size(79, 13);
			happinessTtile.TabIndex = 33;
			happinessTtile.Text = "Contentement :";
			// 
			// SelectedSkillTrainCostTitle
			// 
			this.SelectedSkillTrainCostTitle.AutoSize = true;
			this.SelectedSkillTrainCostTitle.Location = new System.Drawing.Point(3, 37);
			this.SelectedSkillTrainCostTitle.Name = "SelectedSkillTrainCostTitle";
			this.SelectedSkillTrainCostTitle.Size = new System.Drawing.Size(38, 13);
			this.SelectedSkillTrainCostTitle.TabIndex = 16;
			this.SelectedSkillTrainCostTitle.Text = "Coût : ";
			// 
			// SelectedSkillTrainTimeTitle
			// 
			this.SelectedSkillTrainTimeTitle.AutoSize = true;
			this.SelectedSkillTrainTimeTitle.Location = new System.Drawing.Point(115, 37);
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
            this.PersonAgeHeader,
            this.PersonBestSkillHeader,
            this.PersonBestSkillLevelHeader});
			this.PersonList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PersonList.FullRowSelect = true;
			this.PersonList.Location = new System.Drawing.Point(0, 0);
			this.PersonList.MultiSelect = false;
			this.PersonList.Name = "PersonList";
			this.PersonList.Size = new System.Drawing.Size(432, 298);
			this.PersonList.TabIndex = 0;
			this.PersonList.UseCompatibleStateImageBehavior = false;
			this.PersonList.View = System.Windows.Forms.View.Details;
			this.PersonList.SelectedIndexChanged += new System.EventHandler(this.PersonList_SelectedIndexChanged);
			this.PersonList.DoubleClick += new System.EventHandler(this.hirePerson_Click);
			// 
			// PersonLastnameHeader
			// 
			this.PersonLastnameHeader.Text = "Nom";
			this.PersonLastnameHeader.Width = 114;
			// 
			// PersonFirstnameHeader
			// 
			this.PersonFirstnameHeader.Text = "Prénom";
			this.PersonFirstnameHeader.Width = 109;
			// 
			// PersonAgeHeader
			// 
			this.PersonAgeHeader.Text = "Age";
			// 
			// PersonBestSkillHeader
			// 
			this.PersonBestSkillHeader.Text = "Meilleure compétence";
			this.PersonBestSkillHeader.Width = 235;
			// 
			// PersonBestSkillLevelHeader
			// 
			this.PersonBestSkillLevelHeader.Text = "Niveau";
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
			this.splitContainer1.Size = new System.Drawing.Size(1013, 561);
			this.splitContainer1.SplitterDistance = 432;
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
			this.splitContainer2.Size = new System.Drawing.Size(432, 561);
			this.splitContainer2.SplitterDistance = 259;
			this.splitContainer2.TabIndex = 1;
			// 
			// UcEmployeeList1
			// 
			this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcEmployeeList1.Location = new System.Drawing.Point(0, 0);
			this.UcEmployeeList1.Name = "UcEmployeeList1";
			this.UcEmployeeList1.Size = new System.Drawing.Size(432, 259);
			this.UcEmployeeList1.TabIndex = 1;
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
			this.splitContainer3.Panel1.Controls.Add(this.happinessValues);
			this.splitContainer3.Panel1.Controls.Add(happinessTtile);
			this.splitContainer3.Panel1.Controls.Add(this.happinessBar);
			this.splitContainer3.Panel1.Controls.Add(this.SalaryAdjustmentIndication);
			this.splitContainer3.Panel1.Controls.Add(this.trainingPanel);
			this.splitContainer3.Panel1.Controls.Add(this.currentTrainingPanel);
			this.splitContainer3.Panel1.Controls.Add(this.decreaseSalary);
			this.splitContainer3.Panel1.Controls.Add(this.increaseSalary);
			this.splitContainer3.Panel1.Controls.Add(this.employeeSalary);
			this.splitContainer3.Panel1.Controls.Add(employeeSalaryTitle);
			this.splitContainer3.Panel1.Controls.Add(this.employeeOccupation);
			this.splitContainer3.Panel1.Controls.Add(employeeOcupationTitle);
			this.splitContainer3.Panel1.Controls.Add(this.employeeAge);
			this.splitContainer3.Panel1.Controls.Add(this.employeeName);
			this.splitContainer3.Panel1.Controls.Add(SelectedEmployeeTitle);
			this.splitContainer3.Panel1.Controls.Add(employeeAgeTitle);
			this.splitContainer3.Panel1.Controls.Add(employeeNameTitle);
			this.splitContainer3.Panel1.Controls.Add(this.ucSkillsDisplayEmployee);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.hiringCost);
			this.splitContainer3.Panel2.Controls.Add(this.personExpectedSalary);
			this.splitContainer3.Panel2.Controls.Add(hiringCostTitle);
			this.splitContainer3.Panel2.Controls.Add(personExpectedSalaryTitle);
			this.splitContainer3.Panel2.Controls.Add(this.ucSkillsDisplayPerson);
			this.splitContainer3.Panel2.Controls.Add(this.personAge);
			this.splitContainer3.Panel2.Controls.Add(this.personName);
			this.splitContainer3.Panel2.Controls.Add(personAgeTitle);
			this.splitContainer3.Panel2.Controls.Add(personNameTitle);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonTitle);
			this.splitContainer3.Panel2.Controls.Add(this.hirePerson);
			this.splitContainer3.Size = new System.Drawing.Size(577, 561);
			this.splitContainer3.SplitterDistance = 257;
			this.splitContainer3.TabIndex = 0;
			// 
			// happinessValues
			// 
			this.happinessValues.AutoSize = true;
			this.happinessValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.happinessValues.Location = new System.Drawing.Point(24, 232);
			this.happinessValues.Name = "happinessValues";
			this.happinessValues.Size = new System.Drawing.Size(14, 13);
			this.happinessValues.TabIndex = 34;
			this.happinessValues.Text = "X";
			// 
			// happinessBar
			// 
			this.happinessBar.ForeColor = System.Drawing.Color.Lime;
			this.happinessBar.Location = new System.Drawing.Point(11, 206);
			this.happinessBar.Name = "happinessBar";
			this.happinessBar.Size = new System.Drawing.Size(107, 10);
			this.happinessBar.TabIndex = 32;
			// 
			// SalaryAdjustmentIndication
			// 
			this.SalaryAdjustmentIndication.AutoSize = true;
			this.SalaryAdjustmentIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SalaryAdjustmentIndication.Location = new System.Drawing.Point(14, 167);
			this.SalaryAdjustmentIndication.Name = "SalaryAdjustmentIndication";
			this.SalaryAdjustmentIndication.Size = new System.Drawing.Size(110, 26);
			this.SalaryAdjustmentIndication.TabIndex = 31;
			this.SalaryAdjustmentIndication.Text = "Ajustement du salaire \r\nde l\'employé.";
			// 
			// trainingPanel
			// 
			this.trainingPanel.Controls.Add(this.firingCost);
			this.trainingPanel.Controls.Add(this.Train);
			this.trainingPanel.Controls.Add(firingCostTitle);
			this.trainingPanel.Controls.Add(this.fireEmployee);
			this.trainingPanel.Controls.Add(this.SelectedSkillToTrainCost);
			this.trainingPanel.Controls.Add(this.SelectedSkillToTrainTime);
			this.trainingPanel.Controls.Add(this.SelectedSkillTrainCostTitle);
			this.trainingPanel.Controls.Add(this.SelectedSkillTrainTimeTitle);
			this.trainingPanel.Controls.Add(this.SelectedEmployeeSkillsToTrain);
			this.trainingPanel.Location = new System.Drawing.Point(206, 34);
			this.trainingPanel.Name = "trainingPanel";
			this.trainingPanel.Size = new System.Drawing.Size(371, 74);
			this.trainingPanel.TabIndex = 23;
			this.trainingPanel.Visible = false;
			// 
			// firingCost
			// 
			this.firingCost.AutoSize = true;
			this.firingCost.Location = new System.Drawing.Point(301, 37);
			this.firingCost.Name = "firingCost";
			this.firingCost.Size = new System.Drawing.Size(14, 13);
			this.firingCost.TabIndex = 32;
			this.firingCost.Text = "X";
			this.firingCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.firingCost.Visible = false;
			// 
			// Train
			// 
			this.Train.Enabled = false;
			this.Train.Location = new System.Drawing.Point(185, 3);
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
			this.fireEmployee.Location = new System.Drawing.Point(293, 3);
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
			this.SelectedSkillToTrainCost.Location = new System.Drawing.Point(37, 37);
			this.SelectedSkillToTrainCost.Name = "SelectedSkillToTrainCost";
			this.SelectedSkillToTrainCost.Size = new System.Drawing.Size(14, 13);
			this.SelectedSkillToTrainCost.TabIndex = 17;
			this.SelectedSkillToTrainCost.Text = "X";
			// 
			// SelectedSkillToTrainTime
			// 
			this.SelectedSkillToTrainTime.AutoSize = true;
			this.SelectedSkillToTrainTime.Location = new System.Drawing.Point(160, 37);
			this.SelectedSkillToTrainTime.Name = "SelectedSkillToTrainTime";
			this.SelectedSkillToTrainTime.Size = new System.Drawing.Size(14, 13);
			this.SelectedSkillToTrainTime.TabIndex = 19;
			this.SelectedSkillToTrainTime.Text = "X";
			// 
			// SelectedEmployeeSkillsToTrain
			// 
			this.SelectedEmployeeSkillsToTrain.FormattingEnabled = true;
			this.SelectedEmployeeSkillsToTrain.Location = new System.Drawing.Point(3, 3);
			this.SelectedEmployeeSkillsToTrain.Name = "SelectedEmployeeSkillsToTrain";
			this.SelectedEmployeeSkillsToTrain.Size = new System.Drawing.Size(160, 21);
			this.SelectedEmployeeSkillsToTrain.TabIndex = 15;
			this.SelectedEmployeeSkillsToTrain.SelectedIndexChanged += new System.EventHandler(this.SelectedEmployeeSkillsToTrain_SelectedIndexChanged);
			// 
			// currentTrainingPanel
			// 
			this.currentTrainingPanel.Controls.Add(this.timeLeft);
			this.currentTrainingPanel.Controls.Add(this.cancelTraining);
			this.currentTrainingPanel.Controls.Add(this.trainingTimeLeftTitle);
			this.currentTrainingPanel.Controls.Add(this.trainingProgress);
			this.currentTrainingPanel.Location = new System.Drawing.Point(206, 34);
			this.currentTrainingPanel.Name = "currentTrainingPanel";
			this.currentTrainingPanel.Size = new System.Drawing.Size(368, 74);
			this.currentTrainingPanel.TabIndex = 25;
			this.currentTrainingPanel.Visible = false;
			// 
			// timeLeft
			// 
			this.timeLeft.AutoSize = true;
			this.timeLeft.Location = new System.Drawing.Point(100, 55);
			this.timeLeft.Name = "timeLeft";
			this.timeLeft.Size = new System.Drawing.Size(14, 13);
			this.timeLeft.TabIndex = 4;
			this.timeLeft.Text = "X";
			this.timeLeft.Visible = false;
			// 
			// cancelTraining
			// 
			this.cancelTraining.Location = new System.Drawing.Point(245, 11);
			this.cancelTraining.Name = "cancelTraining";
			this.cancelTraining.Size = new System.Drawing.Size(103, 23);
			this.cancelTraining.TabIndex = 3;
			this.cancelTraining.Text = "Annuler formation";
			this.cancelTraining.UseVisualStyleBackColor = true;
			this.cancelTraining.Click += new System.EventHandler(this.cancelTraining_Click);
			// 
			// trainingTimeLeftTitle
			// 
			this.trainingTimeLeftTitle.AutoSize = true;
			this.trainingTimeLeftTitle.Location = new System.Drawing.Point(13, 55);
			this.trainingTimeLeftTitle.Name = "trainingTimeLeftTitle";
			this.trainingTimeLeftTitle.Size = new System.Drawing.Size(80, 13);
			this.trainingTimeLeftTitle.TabIndex = 1;
			this.trainingTimeLeftTitle.Text = "Temps restant :";
			// 
			// trainingProgress
			// 
			this.trainingProgress.Location = new System.Drawing.Point(16, 18);
			this.trainingProgress.Name = "trainingProgress";
			this.trainingProgress.Size = new System.Drawing.Size(212, 16);
			this.trainingProgress.TabIndex = 0;
			// 
			// decreaseSalary
			// 
			this.decreaseSalary.Enabled = false;
			this.decreaseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decreaseSalary.Location = new System.Drawing.Point(27, 141);
			this.decreaseSalary.Name = "decreaseSalary";
			this.decreaseSalary.Size = new System.Drawing.Size(22, 23);
			this.decreaseSalary.TabIndex = 30;
			this.decreaseSalary.Text = "-";
			this.decreaseSalary.UseVisualStyleBackColor = true;
			this.decreaseSalary.Visible = false;
			this.decreaseSalary.Click += new System.EventHandler(this.decreaseSalary_Click);
			// 
			// increaseSalary
			// 
			this.increaseSalary.Enabled = false;
			this.increaseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.increaseSalary.Location = new System.Drawing.Point(76, 141);
			this.increaseSalary.Name = "increaseSalary";
			this.increaseSalary.Size = new System.Drawing.Size(22, 23);
			this.increaseSalary.TabIndex = 29;
			this.increaseSalary.Text = "+";
			this.increaseSalary.UseVisualStyleBackColor = true;
			this.increaseSalary.Visible = false;
			this.increaseSalary.Click += new System.EventHandler(this.increaseSalary_Click);
			// 
			// employeeSalary
			// 
			this.employeeSalary.AutoSize = true;
			this.employeeSalary.Location = new System.Drawing.Point(88, 114);
			this.employeeSalary.Name = "employeeSalary";
			this.employeeSalary.Size = new System.Drawing.Size(14, 13);
			this.employeeSalary.TabIndex = 28;
			this.employeeSalary.Text = "X";
			this.employeeSalary.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.employeeSalary.Visible = false;
			// 
			// employeeOccupation
			// 
			this.employeeOccupation.AutoSize = true;
			this.employeeOccupation.Location = new System.Drawing.Point(88, 84);
			this.employeeOccupation.Name = "employeeOccupation";
			this.employeeOccupation.Size = new System.Drawing.Size(14, 13);
			this.employeeOccupation.TabIndex = 26;
			this.employeeOccupation.Text = "X";
			this.employeeOccupation.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.employeeOccupation.Visible = false;
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
			// ucSkillsDisplayEmployee
			// 
			this.ucSkillsDisplayEmployee.CurrentPerson = null;
			this.ucSkillsDisplayEmployee.Location = new System.Drawing.Point(140, 114);
			this.ucSkillsDisplayEmployee.Name = "ucSkillsDisplayEmployee";
			this.ucSkillsDisplayEmployee.Size = new System.Drawing.Size(438, 140);
			this.ucSkillsDisplayEmployee.TabIndex = 22;
			// 
			// hiringCost
			// 
			this.hiringCost.AutoSize = true;
			this.hiringCost.Location = new System.Drawing.Point(370, 83);
			this.hiringCost.Name = "hiringCost";
			this.hiringCost.Size = new System.Drawing.Size(14, 13);
			this.hiringCost.TabIndex = 34;
			this.hiringCost.Text = "X";
			this.hiringCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.hiringCost.Visible = false;
			// 
			// personExpectedSalary
			// 
			this.personExpectedSalary.AutoSize = true;
			this.personExpectedSalary.Location = new System.Drawing.Point(104, 112);
			this.personExpectedSalary.Name = "personExpectedSalary";
			this.personExpectedSalary.Size = new System.Drawing.Size(14, 13);
			this.personExpectedSalary.TabIndex = 32;
			this.personExpectedSalary.Text = "X";
			this.personExpectedSalary.Visible = false;
			// 
			// ucSkillsDisplayPerson
			// 
			this.ucSkillsDisplayPerson.CurrentPerson = null;
			this.ucSkillsDisplayPerson.Location = new System.Drawing.Point(138, 157);
			this.ucSkillsDisplayPerson.Name = "ucSkillsDisplayPerson";
			this.ucSkillsDisplayPerson.Size = new System.Drawing.Size(440, 140);
			this.ucSkillsDisplayPerson.TabIndex = 23;
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
			// UcEmployeePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcEmployeePage";
			this.Size = new System.Drawing.Size(1013, 561);
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
			this.trainingPanel.ResumeLayout(false);
			this.trainingPanel.PerformLayout();
			this.currentTrainingPanel.ResumeLayout(false);
			this.currentTrainingPanel.PerformLayout();
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
		private System.Windows.Forms.Label employeeOccupation;
		private System.Windows.Forms.Label employeeSalary;
		private System.Windows.Forms.Button decreaseSalary;
		private System.Windows.Forms.Button increaseSalary;
		private System.Windows.Forms.Label personExpectedSalary;
		private System.Windows.Forms.ColumnHeader PersonBestSkillHeader;
		private System.Windows.Forms.ColumnHeader PersonBestSkillLevelHeader;
		private System.Windows.Forms.Label firingCost;
		private System.Windows.Forms.Panel currentTrainingPanel;
		private System.Windows.Forms.Label timeLeft;
		private System.Windows.Forms.Button cancelTraining;
		private System.Windows.Forms.Label trainingTimeLeftTitle;
		private System.Windows.Forms.ProgressBar trainingProgress;
		private System.Windows.Forms.Label hiringCost;
		private System.Windows.Forms.Label SalaryAdjustmentIndication;
		private System.Windows.Forms.ProgressBar happinessBar;
		private System.Windows.Forms.Label happinessValues;
	}
}
