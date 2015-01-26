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
            System.Windows.Forms.Label PlayersEmployeeTitle;
            System.Windows.Forms.Label LabourMarketTitle;
            this._infoListPersons = new System.Windows.Forms.ToolTip(this.components);
            this._infoEmployee = new System.Windows.Forms.ToolTip(this.components);
            this._infoPerson = new System.Windows.Forms.ToolTip(this.components);
            this._infoHappiness = new System.Windows.Forms.ToolTip(this.components);
            this._infoSalaryExpected = new System.Windows.Forms.ToolTip(this.components);
            this._infoTraining = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.hirePerson = new System.Windows.Forms.Button();
            this.personName = new System.Windows.Forms.Label();
            this.personAge = new System.Windows.Forms.Label();
            this.ucSkillsDisplayPerson = new SRH.Interface.UcSkillsDisplay();
            this.personExpectedSalary = new System.Windows.Forms.Label();
            this.hiringCost = new System.Windows.Forms.Label();
            this.PersonList = new System.Windows.Forms.ListView();
            this.PersonLastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonFirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonBestSkillHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonBestSkillLevelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ucSkillsDisplayEmployee = new SRH.Interface.UcSkillsDisplay();
            this.employeeName = new System.Windows.Forms.Label();
            this.employeeAge = new System.Windows.Forms.Label();
            this.employeeOccupation = new System.Windows.Forms.Label();
            this.employeeSalary = new System.Windows.Forms.Label();
            this.increaseSalary = new System.Windows.Forms.Button();
            this.decreaseSalary = new System.Windows.Forms.Button();
            this.currentTrainingPanel = new System.Windows.Forms.Panel();
            this.trainingProgress = new System.Windows.Forms.ProgressBar();
            this.trainingTimeLeftTitle = new System.Windows.Forms.Label();
            this.cancelTraining = new System.Windows.Forms.Button();
            this.timeLeft = new System.Windows.Forms.Label();
            this.trainingPanel = new System.Windows.Forms.Panel();
            this.SelectedEmployeeSkillsToTrain = new System.Windows.Forms.ComboBox();
            this.SelectedSkillTrainTimeTitle = new System.Windows.Forms.Label();
            this.SelectedSkillTrainCostTitle = new System.Windows.Forms.Label();
            this.SelectedSkillToTrainTime = new System.Windows.Forms.Label();
            this.SelectedSkillToTrainCost = new System.Windows.Forms.Label();
            this.fireEmployee = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Button();
            this.firingCost = new System.Windows.Forms.Label();
            this.SalaryAdjustmentIndication = new System.Windows.Forms.Label();
            this.happinessBar = new System.Windows.Forms.ProgressBar();
            this.happinessValues = new System.Windows.Forms.Label();
            this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            PlayersEmployeeTitle = new System.Windows.Forms.Label();
            LabourMarketTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.currentTrainingPanel.SuspendLayout();
            this.trainingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer3.Size = new System.Drawing.Size(578, 561);
            this.splitContainer3.SplitterDistance = 276;
            this.splitContainer3.TabIndex = 0;
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
            // ucSkillsDisplayPerson
            // 
            this.ucSkillsDisplayPerson.CurrentPerson = null;
            this.ucSkillsDisplayPerson.Location = new System.Drawing.Point(138, 157);
            this.ucSkillsDisplayPerson.Margin = new System.Windows.Forms.Padding(4);
            this.ucSkillsDisplayPerson.Name = "ucSkillsDisplayPerson";
            this.ucSkillsDisplayPerson.Size = new System.Drawing.Size(440, 140);
            this.ucSkillsDisplayPerson.TabIndex = 23;
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
            // hiringCostTitle
            // 
            hiringCostTitle.AutoSize = true;
            hiringCostTitle.Location = new System.Drawing.Point(334, 83);
            hiringCostTitle.Name = "hiringCostTitle";
            hiringCostTitle.Size = new System.Drawing.Size(35, 13);
            hiringCostTitle.TabIndex = 33;
            hiringCostTitle.Text = "Coût :";
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
            this.PersonList.Location = new System.Drawing.Point(3, 308);
            this.PersonList.MultiSelect = false;
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(425, 250);
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
            // ucSkillsDisplayEmployee
            // 
            this.ucSkillsDisplayEmployee.CurrentPerson = null;
            this.ucSkillsDisplayEmployee.Location = new System.Drawing.Point(140, 114);
            this.ucSkillsDisplayEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.ucSkillsDisplayEmployee.Name = "ucSkillsDisplayEmployee";
            this.ucSkillsDisplayEmployee.Size = new System.Drawing.Size(438, 140);
            this.ucSkillsDisplayEmployee.TabIndex = 22;
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
            // employeeAgeTitle
            // 
            employeeAgeTitle.AutoSize = true;
            employeeAgeTitle.Location = new System.Drawing.Point(14, 58);
            employeeAgeTitle.Name = "employeeAgeTitle";
            employeeAgeTitle.Size = new System.Drawing.Size(35, 13);
            employeeAgeTitle.TabIndex = 8;
            employeeAgeTitle.Text = "Age : ";
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
            // employeeOcupationTitle
            // 
            employeeOcupationTitle.AutoSize = true;
            employeeOcupationTitle.Location = new System.Drawing.Point(14, 84);
            employeeOcupationTitle.Name = "employeeOcupationTitle";
            employeeOcupationTitle.Size = new System.Drawing.Size(68, 13);
            employeeOcupationTitle.TabIndex = 25;
            employeeOcupationTitle.Text = "Occupation :";
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
            // employeeSalaryTitle
            // 
            employeeSalaryTitle.AutoSize = true;
            employeeSalaryTitle.Location = new System.Drawing.Point(14, 114);
            employeeSalaryTitle.Name = "employeeSalaryTitle";
            employeeSalaryTitle.Size = new System.Drawing.Size(45, 13);
            employeeSalaryTitle.TabIndex = 27;
            employeeSalaryTitle.Text = "Salaire :";
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
            // trainingProgress
            // 
            this.trainingProgress.Location = new System.Drawing.Point(16, 18);
            this.trainingProgress.Name = "trainingProgress";
            this.trainingProgress.Size = new System.Drawing.Size(212, 16);
            this.trainingProgress.TabIndex = 0;
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
            // SelectedEmployeeSkillsToTrain
            // 
            this.SelectedEmployeeSkillsToTrain.FormattingEnabled = true;
            this.SelectedEmployeeSkillsToTrain.Location = new System.Drawing.Point(3, 3);
            this.SelectedEmployeeSkillsToTrain.Name = "SelectedEmployeeSkillsToTrain";
            this.SelectedEmployeeSkillsToTrain.Size = new System.Drawing.Size(160, 21);
            this.SelectedEmployeeSkillsToTrain.TabIndex = 15;
            this.SelectedEmployeeSkillsToTrain.SelectedIndexChanged += new System.EventHandler(this.SelectedEmployeeSkillsToTrain_SelectedIndexChanged);
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
            // SelectedSkillTrainCostTitle
            // 
            this.SelectedSkillTrainCostTitle.AutoSize = true;
            this.SelectedSkillTrainCostTitle.Location = new System.Drawing.Point(3, 37);
            this.SelectedSkillTrainCostTitle.Name = "SelectedSkillTrainCostTitle";
            this.SelectedSkillTrainCostTitle.Size = new System.Drawing.Size(38, 13);
            this.SelectedSkillTrainCostTitle.TabIndex = 16;
            this.SelectedSkillTrainCostTitle.Text = "Coût : ";
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
            // SelectedSkillToTrainCost
            // 
            this.SelectedSkillToTrainCost.AutoSize = true;
            this.SelectedSkillToTrainCost.Location = new System.Drawing.Point(37, 37);
            this.SelectedSkillToTrainCost.Name = "SelectedSkillToTrainCost";
            this.SelectedSkillToTrainCost.Size = new System.Drawing.Size(14, 13);
            this.SelectedSkillToTrainCost.TabIndex = 17;
            this.SelectedSkillToTrainCost.Text = "X";
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
            // firingCostTitle
            // 
            firingCostTitle.AutoSize = true;
            firingCostTitle.Location = new System.Drawing.Point(265, 37);
            firingCostTitle.Name = "firingCostTitle";
            firingCostTitle.Size = new System.Drawing.Size(35, 13);
            firingCostTitle.TabIndex = 31;
            firingCostTitle.Text = "Coût :";
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
            // happinessBar
            // 
            this.happinessBar.ForeColor = System.Drawing.Color.Lime;
            this.happinessBar.Location = new System.Drawing.Point(11, 206);
            this.happinessBar.Name = "happinessBar";
            this.happinessBar.Size = new System.Drawing.Size(107, 10);
            this.happinessBar.TabIndex = 32;
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
            // UcEmployeeList1
            // 
            this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcEmployeeList1.Location = new System.Drawing.Point(3, 28);
            this.UcEmployeeList1.Name = "UcEmployeeList1";
            this.UcEmployeeList1.Size = new System.Drawing.Size(425, 249);
            this.UcEmployeeList1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1013, 561);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PersonList, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UcEmployeeList1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(PlayersEmployeeTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(LabourMarketTitle, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlayersEmployeeTitle
            // 
            PlayersEmployeeTitle.AutoSize = true;
            PlayersEmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PlayersEmployeeTitle.Location = new System.Drawing.Point(3, 0);
            PlayersEmployeeTitle.Name = "PlayersEmployeeTitle";
            PlayersEmployeeTitle.Size = new System.Drawing.Size(120, 20);
            PlayersEmployeeTitle.TabIndex = 35;
            PlayersEmployeeTitle.Text = "Vos employés";
            // 
            // LabourMarketTitle
            // 
            LabourMarketTitle.AutoSize = true;
            LabourMarketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabourMarketTitle.Location = new System.Drawing.Point(3, 280);
            LabourMarketTitle.Name = "LabourMarketTitle";
            LabourMarketTitle.Size = new System.Drawing.Size(146, 20);
            LabourMarketTitle.TabIndex = 36;
            LabourMarketTitle.Text = "Marché du travail";
            // 
            // UcEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcEmployeePage";
            this.Size = new System.Drawing.Size(1013, 561);
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
	}
}
