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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label SelectedPersonTitle;
            System.Windows.Forms.Label personNameTitle;
            System.Windows.Forms.Label personAgeTitle;
            System.Windows.Forms.Label personExpectedSalaryTitle;
            System.Windows.Forms.Label hiringCostTitle;
            System.Windows.Forms.Label employeeNameTitle;
            System.Windows.Forms.Label employeeAgeTitle;
            System.Windows.Forms.Label SelectedEmployeeTitle;
            System.Windows.Forms.Label employeeOcupationTitle;
            System.Windows.Forms.Label employeeSalaryTitle;
            System.Windows.Forms.Label firingCostTitle;
            System.Windows.Forms.Label happinessTtile;
            this.playersEmployeeTitle = new System.Windows.Forms.Label();
            this.labourMarketTitle = new System.Windows.Forms.Label();
            this._infoListPersons = new System.Windows.Forms.ToolTip(this.components);
            this._infoEmployee = new System.Windows.Forms.ToolTip(this.components);
            this._infoPerson = new System.Windows.Forms.ToolTip(this.components);
            this._infoHappiness = new System.Windows.Forms.ToolTip(this.components);
            this._infoSalaryExpected = new System.Windows.Forms.ToolTip(this.components);
            this._infoTraining = new System.Windows.Forms.ToolTip(this.components);
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
            this.SelectedSkillTrainCostTitle = new System.Windows.Forms.Label();
            this.SelectedSkillTrainTimeTitle = new System.Windows.Forms.Label();
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
            this.hiringCost = new System.Windows.Forms.Label();
            this.personExpectedSalary = new System.Windows.Forms.Label();
            this.personAge = new System.Windows.Forms.Label();
            this.personName = new System.Windows.Forms.Label();
            this.hirePerson = new System.Windows.Forms.Button();
            this.PersonList = new System.Windows.Forms.ListView();
            this.PersonLastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonFirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonBestSkillHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonBestSkillLevelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
            this.ucSkillsDisplayEmployee = new SRH.Interface.UcSkillsDisplay();
            this.ucSkillsDisplayPerson = new SRH.Interface.UcSkillsDisplay();
            this._infoListEmployees = new System.Windows.Forms.ToolTip(this.components);
            SelectedPersonTitle = new System.Windows.Forms.Label();
            personNameTitle = new System.Windows.Forms.Label();
            personAgeTitle = new System.Windows.Forms.Label();
            personExpectedSalaryTitle = new System.Windows.Forms.Label();
            hiringCostTitle = new System.Windows.Forms.Label();
            employeeNameTitle = new System.Windows.Forms.Label();
            employeeAgeTitle = new System.Windows.Forms.Label();
            SelectedEmployeeTitle = new System.Windows.Forms.Label();
            employeeOcupationTitle = new System.Windows.Forms.Label();
            employeeSalaryTitle = new System.Windows.Forms.Label();
            firingCostTitle = new System.Windows.Forms.Label();
            happinessTtile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.trainingPanel.SuspendLayout();
            this.currentTrainingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedPersonTitle
            // 
            SelectedPersonTitle.AutoSize = true;
            SelectedPersonTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SelectedPersonTitle.Location = new System.Drawing.Point(219, 16);
            SelectedPersonTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SelectedPersonTitle.Name = "SelectedPersonTitle";
            SelectedPersonTitle.Size = new System.Drawing.Size(132, 25);
            SelectedPersonTitle.TabIndex = 1;
            SelectedPersonTitle.Text = "Le Postulant";
            // 
            // personNameTitle
            // 
            personNameTitle.AutoSize = true;
            personNameTitle.Location = new System.Drawing.Point(19, 73);
            personNameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personNameTitle.Name = "personNameTitle";
            personNameTitle.Size = new System.Drawing.Size(49, 17);
            personNameTitle.TabIndex = 2;
            personNameTitle.Text = "Nom : ";
            // 
            // personAgeTitle
            // 
            personAgeTitle.AutoSize = true;
            personAgeTitle.Location = new System.Drawing.Point(19, 102);
            personAgeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personAgeTitle.Name = "personAgeTitle";
            personAgeTitle.Size = new System.Drawing.Size(45, 17);
            personAgeTitle.TabIndex = 3;
            personAgeTitle.Text = "Age : ";
            // 
            // personExpectedSalaryTitle
            // 
            personExpectedSalaryTitle.AutoSize = true;
            personExpectedSalaryTitle.Location = new System.Drawing.Point(19, 138);
            personExpectedSalaryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personExpectedSalaryTitle.Name = "personExpectedSalaryTitle";
            personExpectedSalaryTitle.Size = new System.Drawing.Size(112, 17);
            personExpectedSalaryTitle.TabIndex = 31;
            personExpectedSalaryTitle.Text = "Salaire attendu :";
            // 
            // hiringCostTitle
            // 
            hiringCostTitle.AutoSize = true;
            hiringCostTitle.Location = new System.Drawing.Point(445, 102);
            hiringCostTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hiringCostTitle.Name = "hiringCostTitle";
            hiringCostTitle.Size = new System.Drawing.Size(45, 17);
            hiringCostTitle.TabIndex = 33;
            hiringCostTitle.Text = "Coût :";
            // 
            // employeeNameTitle
            // 
            employeeNameTitle.AutoSize = true;
            employeeNameTitle.Location = new System.Drawing.Point(19, 42);
            employeeNameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeNameTitle.Name = "employeeNameTitle";
            employeeNameTitle.Size = new System.Drawing.Size(49, 17);
            employeeNameTitle.TabIndex = 7;
            employeeNameTitle.Text = "Nom : ";
            // 
            // employeeAgeTitle
            // 
            employeeAgeTitle.AutoSize = true;
            employeeAgeTitle.Location = new System.Drawing.Point(19, 71);
            employeeAgeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeAgeTitle.Name = "employeeAgeTitle";
            employeeAgeTitle.Size = new System.Drawing.Size(45, 17);
            employeeAgeTitle.TabIndex = 8;
            employeeAgeTitle.Text = "Age : ";
            // 
            // SelectedEmployeeTitle
            // 
            SelectedEmployeeTitle.AutoSize = true;
            SelectedEmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SelectedEmployeeTitle.Location = new System.Drawing.Point(219, 14);
            SelectedEmployeeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SelectedEmployeeTitle.Name = "SelectedEmployeeTitle";
            SelectedEmployeeTitle.Size = new System.Drawing.Size(110, 25);
            SelectedEmployeeTitle.TabIndex = 6;
            SelectedEmployeeTitle.Text = "L\'employé";
            // 
            // employeeOcupationTitle
            // 
            employeeOcupationTitle.AutoSize = true;
            employeeOcupationTitle.Location = new System.Drawing.Point(19, 103);
            employeeOcupationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeOcupationTitle.Name = "employeeOcupationTitle";
            employeeOcupationTitle.Size = new System.Drawing.Size(88, 17);
            employeeOcupationTitle.TabIndex = 25;
            employeeOcupationTitle.Text = "Occupation :";
            // 
            // employeeSalaryTitle
            // 
            employeeSalaryTitle.AutoSize = true;
            employeeSalaryTitle.Location = new System.Drawing.Point(19, 140);
            employeeSalaryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeSalaryTitle.Name = "employeeSalaryTitle";
            employeeSalaryTitle.Size = new System.Drawing.Size(60, 17);
            employeeSalaryTitle.TabIndex = 27;
            employeeSalaryTitle.Text = "Salaire :";
            // 
            // firingCostTitle
            // 
            firingCostTitle.AutoSize = true;
            firingCostTitle.Location = new System.Drawing.Point(353, 46);
            firingCostTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firingCostTitle.Name = "firingCostTitle";
            firingCostTitle.Size = new System.Drawing.Size(45, 17);
            firingCostTitle.TabIndex = 31;
            firingCostTitle.Text = "Coût :";
            // 
            // happinessTtile
            // 
            happinessTtile.AutoSize = true;
            happinessTtile.Location = new System.Drawing.Point(19, 270);
            happinessTtile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            happinessTtile.Name = "happinessTtile";
            happinessTtile.Size = new System.Drawing.Size(104, 17);
            happinessTtile.TabIndex = 33;
            happinessTtile.Text = "Contentement :";
            // 
            // playersEmployeeTitle
            // 
            this.playersEmployeeTitle.AutoSize = true;
            this.playersEmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersEmployeeTitle.Location = new System.Drawing.Point(4, 0);
            this.playersEmployeeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playersEmployeeTitle.Name = "playersEmployeeTitle";
            this.playersEmployeeTitle.Size = new System.Drawing.Size(148, 25);
            this.playersEmployeeTitle.TabIndex = 35;
            this.playersEmployeeTitle.Text = "Vos employés";
            // 
            // labourMarketTitle
            // 
            this.labourMarketTitle.AutoSize = true;
            this.labourMarketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labourMarketTitle.Location = new System.Drawing.Point(4, 345);
            this.labourMarketTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labourMarketTitle.Name = "labourMarketTitle";
            this.labourMarketTitle.Size = new System.Drawing.Size(178, 25);
            this.labourMarketTitle.TabIndex = 36;
            this.labourMarketTitle.Text = "Marché du travail";
            // 
            // _infoListPersons
            // 
            this._infoListPersons.AutoPopDelay = 3000;
            this._infoListPersons.InitialDelay = 1700;
            this._infoListPersons.IsBalloon = true;
            this._infoListPersons.ReshowDelay = 100;
            this._infoListPersons.ToolTipTitle = "Liste des postulants";
            // 
            // _infoEmployee
            // 
            this._infoEmployee.AutoPopDelay = 3000;
            this._infoEmployee.InitialDelay = 1700;
            this._infoEmployee.IsBalloon = true;
            this._infoEmployee.ReshowDelay = 100;
            this._infoEmployee.ToolTipTitle = "Employé";
            // 
            // _infoPerson
            // 
            this._infoPerson.AutoPopDelay = 3000;
            this._infoPerson.InitialDelay = 1700;
            this._infoPerson.IsBalloon = true;
            this._infoPerson.ReshowDelay = 100;
            this._infoPerson.ToolTipTitle = "Postulant";
            // 
            // _infoHappiness
            // 
            this._infoHappiness.AutoPopDelay = 5000;
            this._infoHappiness.InitialDelay = 1700;
            this._infoHappiness.IsBalloon = true;
            this._infoHappiness.ReshowDelay = 100;
            this._infoHappiness.ToolTipTitle = "Le bonheur";
            // 
            // _infoSalaryExpected
            // 
            this._infoSalaryExpected.AutoPopDelay = 3000;
            this._infoSalaryExpected.InitialDelay = 1700;
            this._infoSalaryExpected.IsBalloon = true;
            this._infoSalaryExpected.ReshowDelay = 100;
            this._infoSalaryExpected.ToolTipTitle = "Le salaire";
            // 
            // _infoTraining
            // 
            this._infoTraining.AutoPopDelay = 3000;
            this._infoTraining.InitialDelay = 1700;
            this._infoTraining.IsBalloon = true;
            this._infoTraining.ReshowDelay = 100;
            this._infoTraining.ToolTipTitle = "Les formations";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer3.Size = new System.Drawing.Size(772, 690);
            this.splitContainer3.SplitterDistance = 339;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // happinessValues
            // 
            this.happinessValues.AutoSize = true;
            this.happinessValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happinessValues.Location = new System.Drawing.Point(32, 286);
            this.happinessValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.happinessValues.Name = "happinessValues";
            this.happinessValues.Size = new System.Drawing.Size(15, 15);
            this.happinessValues.TabIndex = 34;
            this.happinessValues.Text = "X";
            // 
            // happinessBar
            // 
            this.happinessBar.ForeColor = System.Drawing.Color.Lime;
            this.happinessBar.Location = new System.Drawing.Point(15, 254);
            this.happinessBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.happinessBar.Name = "happinessBar";
            this.happinessBar.Size = new System.Drawing.Size(143, 12);
            this.happinessBar.TabIndex = 32;
            // 
            // SalaryAdjustmentIndication
            // 
            this.SalaryAdjustmentIndication.AutoSize = true;
            this.SalaryAdjustmentIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryAdjustmentIndication.Location = new System.Drawing.Point(19, 206);
            this.SalaryAdjustmentIndication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalaryAdjustmentIndication.Name = "SalaryAdjustmentIndication";
            this.SalaryAdjustmentIndication.Size = new System.Drawing.Size(128, 30);
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
            this.trainingPanel.Location = new System.Drawing.Point(275, 42);
            this.trainingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trainingPanel.Name = "trainingPanel";
            this.trainingPanel.Size = new System.Drawing.Size(495, 91);
            this.trainingPanel.TabIndex = 23;
            this.trainingPanel.Visible = false;
            // 
            // firingCost
            // 
            this.firingCost.AutoSize = true;
            this.firingCost.Location = new System.Drawing.Point(401, 46);
            this.firingCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firingCost.Name = "firingCost";
            this.firingCost.Size = new System.Drawing.Size(17, 17);
            this.firingCost.TabIndex = 32;
            this.firingCost.Text = "X";
            this.firingCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.firingCost.Visible = false;
            // 
            // Train
            // 
            this.Train.Enabled = false;
            this.Train.Location = new System.Drawing.Point(247, 4);
            this.Train.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(100, 28);
            this.Train.TabIndex = 14;
            this.Train.Text = "Former";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // fireEmployee
            // 
            this.fireEmployee.Enabled = false;
            this.fireEmployee.Location = new System.Drawing.Point(391, 4);
            this.fireEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fireEmployee.Name = "fireEmployee";
            this.fireEmployee.Size = new System.Drawing.Size(100, 28);
            this.fireEmployee.TabIndex = 0;
            this.fireEmployee.Text = "Renvoyer";
            this.fireEmployee.UseVisualStyleBackColor = true;
            this.fireEmployee.Click += new System.EventHandler(this.fireEmployee_Click);
            // 
            // SelectedSkillToTrainCost
            // 
            this.SelectedSkillToTrainCost.AutoSize = true;
            this.SelectedSkillToTrainCost.Location = new System.Drawing.Point(49, 46);
            this.SelectedSkillToTrainCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedSkillToTrainCost.Name = "SelectedSkillToTrainCost";
            this.SelectedSkillToTrainCost.Size = new System.Drawing.Size(17, 17);
            this.SelectedSkillToTrainCost.TabIndex = 17;
            this.SelectedSkillToTrainCost.Text = "X";
            // 
            // SelectedSkillToTrainTime
            // 
            this.SelectedSkillToTrainTime.AutoSize = true;
            this.SelectedSkillToTrainTime.Location = new System.Drawing.Point(213, 46);
            this.SelectedSkillToTrainTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedSkillToTrainTime.Name = "SelectedSkillToTrainTime";
            this.SelectedSkillToTrainTime.Size = new System.Drawing.Size(17, 17);
            this.SelectedSkillToTrainTime.TabIndex = 19;
            this.SelectedSkillToTrainTime.Text = "X";
            // 
            // SelectedSkillTrainCostTitle
            // 
            this.SelectedSkillTrainCostTitle.AutoSize = true;
            this.SelectedSkillTrainCostTitle.Location = new System.Drawing.Point(4, 46);
            this.SelectedSkillTrainCostTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedSkillTrainCostTitle.Name = "SelectedSkillTrainCostTitle";
            this.SelectedSkillTrainCostTitle.Size = new System.Drawing.Size(49, 17);
            this.SelectedSkillTrainCostTitle.TabIndex = 16;
            this.SelectedSkillTrainCostTitle.Text = "Coût : ";
            // 
            // SelectedSkillTrainTimeTitle
            // 
            this.SelectedSkillTrainTimeTitle.AutoSize = true;
            this.SelectedSkillTrainTimeTitle.Location = new System.Drawing.Point(153, 46);
            this.SelectedSkillTrainTimeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedSkillTrainTimeTitle.Name = "SelectedSkillTrainTimeTitle";
            this.SelectedSkillTrainTimeTitle.Size = new System.Drawing.Size(63, 17);
            this.SelectedSkillTrainTimeTitle.TabIndex = 18;
            this.SelectedSkillTrainTimeTitle.Text = "Temps : ";
            // 
            // SelectedEmployeeSkillsToTrain
            // 
            this.SelectedEmployeeSkillsToTrain.FormattingEnabled = true;
            this.SelectedEmployeeSkillsToTrain.Location = new System.Drawing.Point(4, 4);
            this.SelectedEmployeeSkillsToTrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedEmployeeSkillsToTrain.Name = "SelectedEmployeeSkillsToTrain";
            this.SelectedEmployeeSkillsToTrain.Size = new System.Drawing.Size(212, 24);
            this.SelectedEmployeeSkillsToTrain.TabIndex = 15;
            this.SelectedEmployeeSkillsToTrain.SelectedIndexChanged += new System.EventHandler(this.SelectedEmployeeSkillsToTrain_SelectedIndexChanged);
            // 
            // currentTrainingPanel
            // 
            this.currentTrainingPanel.Controls.Add(this.timeLeft);
            this.currentTrainingPanel.Controls.Add(this.cancelTraining);
            this.currentTrainingPanel.Controls.Add(this.trainingTimeLeftTitle);
            this.currentTrainingPanel.Controls.Add(this.trainingProgress);
            this.currentTrainingPanel.Location = new System.Drawing.Point(275, 42);
            this.currentTrainingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentTrainingPanel.Name = "currentTrainingPanel";
            this.currentTrainingPanel.Size = new System.Drawing.Size(491, 91);
            this.currentTrainingPanel.TabIndex = 25;
            this.currentTrainingPanel.Visible = false;
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Location = new System.Drawing.Point(133, 68);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(17, 17);
            this.timeLeft.TabIndex = 4;
            this.timeLeft.Text = "X";
            this.timeLeft.Visible = false;
            // 
            // cancelTraining
            // 
            this.cancelTraining.Location = new System.Drawing.Point(327, 14);
            this.cancelTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelTraining.Name = "cancelTraining";
            this.cancelTraining.Size = new System.Drawing.Size(137, 28);
            this.cancelTraining.TabIndex = 3;
            this.cancelTraining.Text = "Annuler formation";
            this.cancelTraining.UseVisualStyleBackColor = true;
            this.cancelTraining.Click += new System.EventHandler(this.cancelTraining_Click);
            // 
            // trainingTimeLeftTitle
            // 
            this.trainingTimeLeftTitle.AutoSize = true;
            this.trainingTimeLeftTitle.Location = new System.Drawing.Point(17, 68);
            this.trainingTimeLeftTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trainingTimeLeftTitle.Name = "trainingTimeLeftTitle";
            this.trainingTimeLeftTitle.Size = new System.Drawing.Size(107, 17);
            this.trainingTimeLeftTitle.TabIndex = 1;
            this.trainingTimeLeftTitle.Text = "Temps restant :";
            // 
            // trainingProgress
            // 
            this.trainingProgress.Location = new System.Drawing.Point(21, 22);
            this.trainingProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trainingProgress.Name = "trainingProgress";
            this.trainingProgress.Size = new System.Drawing.Size(283, 20);
            this.trainingProgress.TabIndex = 0;
            // 
            // decreaseSalary
            // 
            this.decreaseSalary.Enabled = false;
            this.decreaseSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseSalary.Location = new System.Drawing.Point(36, 174);
            this.decreaseSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decreaseSalary.Name = "decreaseSalary";
            this.decreaseSalary.Size = new System.Drawing.Size(29, 28);
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
            this.increaseSalary.Location = new System.Drawing.Point(101, 174);
            this.increaseSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.increaseSalary.Name = "increaseSalary";
            this.increaseSalary.Size = new System.Drawing.Size(29, 28);
            this.increaseSalary.TabIndex = 29;
            this.increaseSalary.Text = "+";
            this.increaseSalary.UseVisualStyleBackColor = true;
            this.increaseSalary.Visible = false;
            this.increaseSalary.Click += new System.EventHandler(this.increaseSalary_Click);
            // 
            // employeeSalary
            // 
            this.employeeSalary.AutoSize = true;
            this.employeeSalary.Location = new System.Drawing.Point(117, 140);
            this.employeeSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(17, 17);
            this.employeeSalary.TabIndex = 28;
            this.employeeSalary.Text = "X";
            this.employeeSalary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.employeeSalary.Visible = false;
            // 
            // employeeOccupation
            // 
            this.employeeOccupation.AutoSize = true;
            this.employeeOccupation.Location = new System.Drawing.Point(117, 103);
            this.employeeOccupation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeOccupation.Name = "employeeOccupation";
            this.employeeOccupation.Size = new System.Drawing.Size(17, 17);
            this.employeeOccupation.TabIndex = 26;
            this.employeeOccupation.Text = "X";
            this.employeeOccupation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.employeeOccupation.Visible = false;
            // 
            // employeeAge
            // 
            this.employeeAge.AutoSize = true;
            this.employeeAge.Location = new System.Drawing.Point(73, 71);
            this.employeeAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeAge.Name = "employeeAge";
            this.employeeAge.Size = new System.Drawing.Size(17, 17);
            this.employeeAge.TabIndex = 10;
            this.employeeAge.Text = "X";
            this.employeeAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.employeeAge.Visible = false;
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(73, 42);
            this.employeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(17, 17);
            this.employeeName.TabIndex = 9;
            this.employeeName.Text = "X";
            this.employeeName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.employeeName.Visible = false;
            // 
            // hiringCost
            // 
            this.hiringCost.AutoSize = true;
            this.hiringCost.Location = new System.Drawing.Point(493, 102);
            this.hiringCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiringCost.Name = "hiringCost";
            this.hiringCost.Size = new System.Drawing.Size(17, 17);
            this.hiringCost.TabIndex = 34;
            this.hiringCost.Text = "X";
            this.hiringCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hiringCost.Visible = false;
            // 
            // personExpectedSalary
            // 
            this.personExpectedSalary.AutoSize = true;
            this.personExpectedSalary.Location = new System.Drawing.Point(139, 138);
            this.personExpectedSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personExpectedSalary.Name = "personExpectedSalary";
            this.personExpectedSalary.Size = new System.Drawing.Size(17, 17);
            this.personExpectedSalary.TabIndex = 32;
            this.personExpectedSalary.Text = "X";
            this.personExpectedSalary.Visible = false;
            // 
            // personAge
            // 
            this.personAge.AutoSize = true;
            this.personAge.Location = new System.Drawing.Point(73, 102);
            this.personAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personAge.Name = "personAge";
            this.personAge.Size = new System.Drawing.Size(17, 17);
            this.personAge.TabIndex = 5;
            this.personAge.Text = "X";
            this.personAge.Visible = false;
            // 
            // personName
            // 
            this.personName.AutoSize = true;
            this.personName.Location = new System.Drawing.Point(73, 73);
            this.personName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(17, 17);
            this.personName.TabIndex = 4;
            this.personName.Text = "X";
            this.personName.Visible = false;
            // 
            // hirePerson
            // 
            this.hirePerson.Enabled = false;
            this.hirePerson.Location = new System.Drawing.Point(443, 66);
            this.hirePerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hirePerson.Name = "hirePerson";
            this.hirePerson.Size = new System.Drawing.Size(100, 28);
            this.hirePerson.TabIndex = 0;
            this.hirePerson.Text = "Engager";
            this.hirePerson.UseVisualStyleBackColor = true;
            this.hirePerson.Click += new System.EventHandler(this.hirePerson_Click);
            // 
            // PersonList
            // 
            this.PersonList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PersonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PersonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonLastnameHeader,
            this.PersonFirstnameHeader,
            this.PersonAgeHeader,
            this.PersonBestSkillHeader,
            this.PersonBestSkillLevelHeader});
            this.PersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PersonList.FullRowSelect = true;
            this.PersonList.Location = new System.Drawing.Point(4, 380);
            this.PersonList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonList.MultiSelect = false;
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(566, 306);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1351, 690);
            this.splitContainer1.SplitterDistance = 574;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.PersonList, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UcEmployeeList1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playersEmployeeTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labourMarketTitle, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UcEmployeeList1
            // 
            this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcEmployeeList1.Location = new System.Drawing.Point(5, 36);
            this.UcEmployeeList1.Margin = new System.Windows.Forms.Padding(5);
            this.UcEmployeeList1.Name = "UcEmployeeList1";
            this.UcEmployeeList1.Size = new System.Drawing.Size(564, 304);
            this.UcEmployeeList1.TabIndex = 0;
            // 
            // ucSkillsDisplayEmployee
            // 
            this.ucSkillsDisplayEmployee.CurrentPerson = null;
            this.ucSkillsDisplayEmployee.Location = new System.Drawing.Point(187, 140);
            this.ucSkillsDisplayEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.ucSkillsDisplayEmployee.Name = "ucSkillsDisplayEmployee";
            this.ucSkillsDisplayEmployee.Size = new System.Drawing.Size(584, 172);
            this.ucSkillsDisplayEmployee.TabIndex = 22;
            // 
            // ucSkillsDisplayPerson
            // 
            this.ucSkillsDisplayPerson.CurrentPerson = null;
            this.ucSkillsDisplayPerson.Location = new System.Drawing.Point(184, 193);
            this.ucSkillsDisplayPerson.Margin = new System.Windows.Forms.Padding(5);
            this.ucSkillsDisplayPerson.Name = "ucSkillsDisplayPerson";
            this.ucSkillsDisplayPerson.Size = new System.Drawing.Size(587, 172);
            this.ucSkillsDisplayPerson.TabIndex = 23;
            // 
            // _infoListEmployees
            // 
            this._infoListEmployees.AutoPopDelay = 3000;
            this._infoListEmployees.InitialDelay = 1700;
            this._infoListEmployees.IsBalloon = true;
            this._infoListEmployees.ReshowDelay = 100;
            this._infoListEmployees.ToolTipTitle = "Liste des employés";
            // 
            // UcEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcEmployeePage";
            this.Size = new System.Drawing.Size(1351, 690);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.ToolTip _infoListPersons;
        private System.Windows.Forms.ToolTip _infoEmployee;
        private System.Windows.Forms.ToolTip _infoPerson;
        private System.Windows.Forms.ToolTip _infoHappiness;
        private System.Windows.Forms.ToolTip _infoSalaryExpected;
        private System.Windows.Forms.ToolTip _infoTraining;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label happinessValues;
        private System.Windows.Forms.ProgressBar happinessBar;
        private System.Windows.Forms.Label SalaryAdjustmentIndication;
        private System.Windows.Forms.Panel trainingPanel;
        private System.Windows.Forms.Label firingCost;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.Button fireEmployee;
        private System.Windows.Forms.Label SelectedSkillToTrainCost;
        private System.Windows.Forms.Label SelectedSkillToTrainTime;
        private System.Windows.Forms.Label SelectedSkillTrainCostTitle;
        private System.Windows.Forms.Label SelectedSkillTrainTimeTitle;
        private System.Windows.Forms.ComboBox SelectedEmployeeSkillsToTrain;
        private System.Windows.Forms.Panel currentTrainingPanel;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Button cancelTraining;
        private System.Windows.Forms.Label trainingTimeLeftTitle;
        private System.Windows.Forms.ProgressBar trainingProgress;
        private System.Windows.Forms.Button decreaseSalary;
        private System.Windows.Forms.Button increaseSalary;
        private System.Windows.Forms.Label employeeSalary;
        private System.Windows.Forms.Label employeeOccupation;
        private System.Windows.Forms.Label employeeAge;
        private System.Windows.Forms.Label employeeName;
        private UcSkillsDisplay ucSkillsDisplayEmployee;
        private System.Windows.Forms.ListView PersonList;
        private System.Windows.Forms.ColumnHeader PersonLastnameHeader;
        private System.Windows.Forms.ColumnHeader PersonFirstnameHeader;
        private System.Windows.Forms.ColumnHeader PersonAgeHeader;
        private System.Windows.Forms.ColumnHeader PersonBestSkillHeader;
        private System.Windows.Forms.ColumnHeader PersonBestSkillLevelHeader;
        private System.Windows.Forms.Label hiringCost;
        private System.Windows.Forms.Label personExpectedSalary;
        private UcSkillsDisplay ucSkillsDisplayPerson;
        private System.Windows.Forms.Label personAge;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.Button hirePerson;
        private UcEmployeeList UcEmployeeList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label playersEmployeeTitle;
        private System.Windows.Forms.Label labourMarketTitle;
        private System.Windows.Forms.ToolTip _infoListEmployees;
	}
}
