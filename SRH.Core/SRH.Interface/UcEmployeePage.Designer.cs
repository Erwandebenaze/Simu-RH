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
			System.Windows.Forms.Label SelectedPersonNameTitle;
			System.Windows.Forms.Label SelectedPersonAgeTitle;
			System.Windows.Forms.Label SelectedEmployeeAgeTitle;
			System.Windows.Forms.Label SelectedEmployeeNameTitle;
			System.Windows.Forms.Label SelectedEmployeeTitle;
			System.Windows.Forms.Label IsBusyTitle;
			this.SelectedSkillTrainCostTitle = new System.Windows.Forms.Label();
			this.SelectedSkillTrainTimeTitle = new System.Windows.Forms.Label();
			this.PersonList = new System.Windows.Forms.ListView();
			this.PersonLastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonFirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.IsBusy = new System.Windows.Forms.Label();
			this.SelectedSkillToTrainTime = new System.Windows.Forms.Label();
			this.SelectedSkillToTrainCost = new System.Windows.Forms.Label();
			this.SelectedEmployeeSkillsToTrain = new System.Windows.Forms.ComboBox();
			this.Train = new System.Windows.Forms.Button();
			this.SelectedEmployeeAge = new System.Windows.Forms.Label();
			this.fireEmployee = new System.Windows.Forms.Button();
			this.SelectedEmployeeName = new System.Windows.Forms.Label();
			this.SelectedPersonAge = new System.Windows.Forms.Label();
			this.SelectedPersonName = new System.Windows.Forms.Label();
			this.hirePerson = new System.Windows.Forms.Button();
			this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
			this.ucSkillsDisplayEmployee = new SRH.Interface.UcSkillsDisplay();
			this.ucSkillsDisplayPerson = new SRH.Interface.UcSkillsDisplay();
			SelectedPersonTitle = new System.Windows.Forms.Label();
			SelectedPersonNameTitle = new System.Windows.Forms.Label();
			SelectedPersonAgeTitle = new System.Windows.Forms.Label();
			SelectedEmployeeAgeTitle = new System.Windows.Forms.Label();
			SelectedEmployeeNameTitle = new System.Windows.Forms.Label();
			SelectedEmployeeTitle = new System.Windows.Forms.Label();
			IsBusyTitle = new System.Windows.Forms.Label();
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
			// SelectedPersonNameTitle
			// 
			SelectedPersonNameTitle.AutoSize = true;
			SelectedPersonNameTitle.Location = new System.Drawing.Point(14, 59);
			SelectedPersonNameTitle.Name = "SelectedPersonNameTitle";
			SelectedPersonNameTitle.Size = new System.Drawing.Size(38, 13);
			SelectedPersonNameTitle.TabIndex = 2;
			SelectedPersonNameTitle.Text = "Nom : ";
			// 
			// SelectedPersonAgeTitle
			// 
			SelectedPersonAgeTitle.AutoSize = true;
			SelectedPersonAgeTitle.Location = new System.Drawing.Point(14, 83);
			SelectedPersonAgeTitle.Name = "SelectedPersonAgeTitle";
			SelectedPersonAgeTitle.Size = new System.Drawing.Size(35, 13);
			SelectedPersonAgeTitle.TabIndex = 3;
			SelectedPersonAgeTitle.Text = "Age : ";
			// 
			// SelectedEmployeeAgeTitle
			// 
			SelectedEmployeeAgeTitle.AutoSize = true;
			SelectedEmployeeAgeTitle.Location = new System.Drawing.Point(14, 64);
			SelectedEmployeeAgeTitle.Name = "SelectedEmployeeAgeTitle";
			SelectedEmployeeAgeTitle.Size = new System.Drawing.Size(35, 13);
			SelectedEmployeeAgeTitle.TabIndex = 8;
			SelectedEmployeeAgeTitle.Text = "Age : ";
			// 
			// SelectedEmployeeNameTitle
			// 
			SelectedEmployeeNameTitle.AutoSize = true;
			SelectedEmployeeNameTitle.Location = new System.Drawing.Point(14, 40);
			SelectedEmployeeNameTitle.Name = "SelectedEmployeeNameTitle";
			SelectedEmployeeNameTitle.Size = new System.Drawing.Size(38, 13);
			SelectedEmployeeNameTitle.TabIndex = 7;
			SelectedEmployeeNameTitle.Text = "Nom : ";
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
			// IsBusyTitle
			// 
			IsBusyTitle.AutoSize = true;
			IsBusyTitle.Location = new System.Drawing.Point(165, 79);
			IsBusyTitle.Name = "IsBusyTitle";
			IsBusyTitle.Size = new System.Drawing.Size(45, 13);
			IsBusyTitle.TabIndex = 20;
			IsBusyTitle.Text = "Occupé";
			// 
			// SelectedSkillTrainCostTitle
			// 
			this.SelectedSkillTrainCostTitle.AutoSize = true;
			this.SelectedSkillTrainCostTitle.Location = new System.Drawing.Point(268, 43);
			this.SelectedSkillTrainCostTitle.Name = "SelectedSkillTrainCostTitle";
			this.SelectedSkillTrainCostTitle.Size = new System.Drawing.Size(38, 13);
			this.SelectedSkillTrainCostTitle.TabIndex = 16;
			this.SelectedSkillTrainCostTitle.Text = "Coût : ";
			// 
			// SelectedSkillTrainTimeTitle
			// 
			this.SelectedSkillTrainTimeTitle.AutoSize = true;
			this.SelectedSkillTrainTimeTitle.Location = new System.Drawing.Point(268, 79);
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
			this.PersonList.Size = new System.Drawing.Size(419, 273);
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
			this.splitContainer1.Size = new System.Drawing.Size(902, 515);
			this.splitContainer1.SplitterDistance = 419;
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
			this.splitContainer2.Size = new System.Drawing.Size(419, 515);
			this.splitContainer2.SplitterDistance = 238;
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
			this.splitContainer3.Panel1.Controls.Add(this.IsBusy);
			this.splitContainer3.Panel1.Controls.Add(IsBusyTitle);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedSkillToTrainTime);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedSkillTrainTimeTitle);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedSkillToTrainCost);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedSkillTrainCostTitle);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedEmployeeSkillsToTrain);
			this.splitContainer3.Panel1.Controls.Add(this.Train);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedEmployeeAge);
			this.splitContainer3.Panel1.Controls.Add(this.fireEmployee);
			this.splitContainer3.Panel1.Controls.Add(this.SelectedEmployeeName);
			this.splitContainer3.Panel1.Controls.Add(SelectedEmployeeTitle);
			this.splitContainer3.Panel1.Controls.Add(SelectedEmployeeAgeTitle);
			this.splitContainer3.Panel1.Controls.Add(SelectedEmployeeNameTitle);
			this.splitContainer3.Panel1.Controls.Add(this.ucSkillsDisplayEmployee);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.ucSkillsDisplayPerson);
			this.splitContainer3.Panel2.Controls.Add(this.SelectedPersonAge);
			this.splitContainer3.Panel2.Controls.Add(this.SelectedPersonName);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonAgeTitle);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonNameTitle);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonTitle);
			this.splitContainer3.Panel2.Controls.Add(this.hirePerson);
			this.splitContainer3.Size = new System.Drawing.Size(479, 515);
			this.splitContainer3.SplitterDistance = 243;
			this.splitContainer3.TabIndex = 0;
			// 
			// IsBusy
			// 
			this.IsBusy.AutoSize = true;
			this.IsBusy.Location = new System.Drawing.Point(216, 79);
			this.IsBusy.Name = "IsBusy";
			this.IsBusy.Size = new System.Drawing.Size(14, 13);
			this.IsBusy.TabIndex = 21;
			this.IsBusy.Text = "X";
			// 
			// SelectedSkillToTrainTime
			// 
			this.SelectedSkillToTrainTime.AutoSize = true;
			this.SelectedSkillToTrainTime.Location = new System.Drawing.Point(312, 79);
			this.SelectedSkillToTrainTime.Name = "SelectedSkillToTrainTime";
			this.SelectedSkillToTrainTime.Size = new System.Drawing.Size(14, 13);
			this.SelectedSkillToTrainTime.TabIndex = 19;
			this.SelectedSkillToTrainTime.Text = "X";
			// 
			// SelectedSkillToTrainCost
			// 
			this.SelectedSkillToTrainCost.AutoSize = true;
			this.SelectedSkillToTrainCost.Location = new System.Drawing.Point(303, 45);
			this.SelectedSkillToTrainCost.Name = "SelectedSkillToTrainCost";
			this.SelectedSkillToTrainCost.Size = new System.Drawing.Size(14, 13);
			this.SelectedSkillToTrainCost.TabIndex = 17;
			this.SelectedSkillToTrainCost.Text = "X";
			// 
			// SelectedEmployeeSkillsToTrain
			// 
			this.SelectedEmployeeSkillsToTrain.FormattingEnabled = true;
			this.SelectedEmployeeSkillsToTrain.Location = new System.Drawing.Point(147, 40);
			this.SelectedEmployeeSkillsToTrain.Name = "SelectedEmployeeSkillsToTrain";
			this.SelectedEmployeeSkillsToTrain.Size = new System.Drawing.Size(106, 21);
			this.SelectedEmployeeSkillsToTrain.TabIndex = 15;
			this.SelectedEmployeeSkillsToTrain.SelectedIndexChanged += new System.EventHandler(this.SelectedEmployeeSkillsToTrain_SelectedIndexChanged);
			// 
			// Train
			// 
			this.Train.Enabled = false;
			this.Train.Location = new System.Drawing.Point(392, 40);
			this.Train.Name = "Train";
			this.Train.Size = new System.Drawing.Size(75, 23);
			this.Train.TabIndex = 14;
			this.Train.Text = "Former";
			this.Train.UseVisualStyleBackColor = true;
			this.Train.Click += new System.EventHandler(this.Train_Click);
			// 
			// SelectedEmployeeAge
			// 
			this.SelectedEmployeeAge.AutoSize = true;
			this.SelectedEmployeeAge.Location = new System.Drawing.Point(55, 64);
			this.SelectedEmployeeAge.Name = "SelectedEmployeeAge";
			this.SelectedEmployeeAge.Size = new System.Drawing.Size(14, 13);
			this.SelectedEmployeeAge.TabIndex = 10;
			this.SelectedEmployeeAge.Text = "X";
			this.SelectedEmployeeAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.SelectedEmployeeAge.Visible = false;
			// 
			// fireEmployee
			// 
			this.fireEmployee.Enabled = false;
			this.fireEmployee.Location = new System.Drawing.Point(392, 79);
			this.fireEmployee.Name = "fireEmployee";
			this.fireEmployee.Size = new System.Drawing.Size(75, 23);
			this.fireEmployee.TabIndex = 0;
			this.fireEmployee.Text = "Renvoyer";
			this.fireEmployee.UseVisualStyleBackColor = true;
			this.fireEmployee.Click += new System.EventHandler(this.fireEmployee_Click);
			// 
			// SelectedEmployeeName
			// 
			this.SelectedEmployeeName.AutoSize = true;
			this.SelectedEmployeeName.Location = new System.Drawing.Point(55, 40);
			this.SelectedEmployeeName.Name = "SelectedEmployeeName";
			this.SelectedEmployeeName.Size = new System.Drawing.Size(14, 13);
			this.SelectedEmployeeName.TabIndex = 9;
			this.SelectedEmployeeName.Text = "X";
			this.SelectedEmployeeName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.SelectedEmployeeName.Visible = false;
			// 
			// SelectedPersonAge
			// 
			this.SelectedPersonAge.AutoSize = true;
			this.SelectedPersonAge.Location = new System.Drawing.Point(55, 83);
			this.SelectedPersonAge.Name = "SelectedPersonAge";
			this.SelectedPersonAge.Size = new System.Drawing.Size(14, 13);
			this.SelectedPersonAge.TabIndex = 5;
			this.SelectedPersonAge.Text = "X";
			this.SelectedPersonAge.Visible = false;
			// 
			// SelectedPersonName
			// 
			this.SelectedPersonName.AutoSize = true;
			this.SelectedPersonName.Location = new System.Drawing.Point(55, 59);
			this.SelectedPersonName.Name = "SelectedPersonName";
			this.SelectedPersonName.Size = new System.Drawing.Size(14, 13);
			this.SelectedPersonName.TabIndex = 4;
			this.SelectedPersonName.Text = "X";
			this.SelectedPersonName.Visible = false;
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
			// UcEmployeeList1
			// 
			this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcEmployeeList1.Location = new System.Drawing.Point(0, 0);
			this.UcEmployeeList1.Name = "UcEmployeeList1";
			this.UcEmployeeList1.Size = new System.Drawing.Size(419, 238);
			this.UcEmployeeList1.TabIndex = 1;
			// 
			// ucSkillsDisplayEmployee
			// 
			this.ucSkillsDisplayEmployee.CurrentPerson = null;
			this.ucSkillsDisplayEmployee.Location = new System.Drawing.Point(3, 100);
			this.ucSkillsDisplayEmployee.Name = "ucSkillsDisplayEmployee";
			this.ucSkillsDisplayEmployee.Size = new System.Drawing.Size(447, 140);
			this.ucSkillsDisplayEmployee.TabIndex = 22;
			// 
			// ucSkillsDisplayPerson
			// 
			this.ucSkillsDisplayPerson.CurrentPerson = null;
			this.ucSkillsDisplayPerson.Location = new System.Drawing.Point(3, 125);
			this.ucSkillsDisplayPerson.Name = "ucSkillsDisplayPerson";
			this.ucSkillsDisplayPerson.Size = new System.Drawing.Size(447, 140);
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
			this.Size = new System.Drawing.Size(902, 515);
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
        private System.Windows.Forms.Label SelectedPersonAge;
		private System.Windows.Forms.Label SelectedPersonName;
		private System.Windows.Forms.Button fireEmployee;
		private System.Windows.Forms.Label SelectedEmployeeAge;
		private System.Windows.Forms.Label SelectedEmployeeName;
		private System.Windows.Forms.Label SelectedSkillToTrainCost;
		private System.Windows.Forms.ComboBox SelectedEmployeeSkillsToTrain;
		private System.Windows.Forms.Button Train;
		private System.Windows.Forms.Label SelectedSkillToTrainTime;
		private System.Windows.Forms.Label IsBusy;
		private System.Windows.Forms.Label SelectedSkillTrainCostTitle;
		private System.Windows.Forms.Label SelectedSkillTrainTimeTitle;
		private UcEmployeeList UcEmployeeList1;
		private UcSkillsDisplay ucSkillsDisplayEmployee;
		private UcSkillsDisplay ucSkillsDisplayPerson;
	}
}
