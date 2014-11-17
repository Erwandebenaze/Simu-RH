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
			this.PersonList = new System.Windows.Forms.ListView();
			this.PersonLastnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonFirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PersonAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.EmployeeList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.SelectedPersonAge = new System.Windows.Forms.Label();
			this.SelectedPersonName = new System.Windows.Forms.Label();
			this.hirePerson = new System.Windows.Forms.Button();
			SelectedPersonTitle = new System.Windows.Forms.Label();
			SelectedPersonNameTitle = new System.Windows.Forms.Label();
			SelectedPersonAgeTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
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
			// PersonList
			// 
			this.PersonList.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.PersonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonLastnameHeader,
            this.PersonFirstnameHeader,
            this.PersonAgeHeader});
			this.PersonList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PersonList.Location = new System.Drawing.Point(0, 0);
			this.PersonList.MultiSelect = false;
			this.PersonList.Name = "PersonList";
			this.PersonList.Size = new System.Drawing.Size(376, 269);
			this.PersonList.TabIndex = 0;
			this.PersonList.UseCompatibleStateImageBehavior = false;
			this.PersonList.View = System.Windows.Forms.View.Details;
			this.PersonList.SelectedIndexChanged += new System.EventHandler(this.PersonList_SelectedIndexChanged);
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
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(819, 509);
			this.splitContainer1.SplitterDistance = 382;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Location = new System.Drawing.Point(3, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.EmployeeList);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.PersonList);
			this.splitContainer2.Size = new System.Drawing.Size(376, 509);
			this.splitContainer2.SplitterDistance = 236;
			this.splitContainer2.TabIndex = 1;
			// 
			// EmployeeList
			// 
			this.EmployeeList.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.EmployeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.EmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EmployeeList.Location = new System.Drawing.Point(0, 0);
			this.EmployeeList.MultiSelect = false;
			this.EmployeeList.Name = "EmployeeList";
			this.EmployeeList.Size = new System.Drawing.Size(376, 236);
			this.EmployeeList.TabIndex = 1;
			this.EmployeeList.UseCompatibleStateImageBehavior = false;
			this.EmployeeList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nom";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Prénom";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Age";
			this.columnHeader3.Width = 87;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.SelectedPersonAge);
			this.splitContainer3.Panel2.Controls.Add(this.SelectedPersonName);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonAgeTitle);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonNameTitle);
			this.splitContainer3.Panel2.Controls.Add(SelectedPersonTitle);
			this.splitContainer3.Panel2.Controls.Add(this.hirePerson);
			this.splitContainer3.Size = new System.Drawing.Size(433, 509);
			this.splitContainer3.SplitterDistance = 236;
			this.splitContainer3.TabIndex = 0;
			// 
			// SelectedPersonAge
			// 
			this.SelectedPersonAge.AutoSize = true;
			this.SelectedPersonAge.Location = new System.Drawing.Point(115, 83);
			this.SelectedPersonAge.Name = "SelectedPersonAge";
			this.SelectedPersonAge.Size = new System.Drawing.Size(14, 13);
			this.SelectedPersonAge.TabIndex = 5;
			this.SelectedPersonAge.Text = "X";
			// 
			// SelectedPersonName
			// 
			this.SelectedPersonName.AutoSize = true;
			this.SelectedPersonName.Location = new System.Drawing.Point(115, 59);
			this.SelectedPersonName.Name = "SelectedPersonName";
			this.SelectedPersonName.Size = new System.Drawing.Size(14, 13);
			this.SelectedPersonName.TabIndex = 4;
			this.SelectedPersonName.Text = "X";
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
			this.Size = new System.Drawing.Size(825, 515);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.ListView EmployeeList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button hirePerson;
        private System.Windows.Forms.Label SelectedPersonAge;
		private System.Windows.Forms.Label SelectedPersonName;
	}
}
