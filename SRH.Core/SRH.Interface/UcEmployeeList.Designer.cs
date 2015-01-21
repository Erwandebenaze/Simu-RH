namespace SRH.Interface
{
	partial class UcEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcEmployeeList));
            this.employeeList = new System.Windows.Forms.ListView();
            this.EmployeeLastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeFirstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeBestSkillHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeBestSkillLevelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._infoListEmployees = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.employeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeLastNameHeader,
            this.EmployeeFirstNameHeader,
            this.EmployeeAgeHeader,
            this.EmployeeBestSkillHeader,
            this.EmployeeBestSkillLevelHeader});
            resources.ApplyResources(this.employeeList, "employeeList");
            this.employeeList.FullRowSelect = true;
            this.employeeList.MultiSelect = false;
            this.employeeList.Name = "employeeList";
            this.employeeList.UseCompatibleStateImageBehavior = false;
            this.employeeList.View = System.Windows.Forms.View.Details;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.employeeList_SelectedIndexChanged);
            // 
            // EmployeeLastNameHeader
            // 
            resources.ApplyResources(this.EmployeeLastNameHeader, "EmployeeLastNameHeader");
            // 
            // EmployeeFirstNameHeader
            // 
            resources.ApplyResources(this.EmployeeFirstNameHeader, "EmployeeFirstNameHeader");
            // 
            // EmployeeAgeHeader
            // 
            resources.ApplyResources(this.EmployeeAgeHeader, "EmployeeAgeHeader");
            // 
            // EmployeeBestSkillHeader
            // 
            resources.ApplyResources(this.EmployeeBestSkillHeader, "EmployeeBestSkillHeader");
            // 
            // EmployeeBestSkillLevelHeader
            // 
            resources.ApplyResources(this.EmployeeBestSkillLevelHeader, "EmployeeBestSkillLevelHeader");
            // 
            // _infoListEmployees
            // 
            this._infoListEmployees.AutoPopDelay = 3000;
            this._infoListEmployees.InitialDelay = 1700;
            this._infoListEmployees.IsBalloon = true;
            this._infoListEmployees.ReshowDelay = 100;
            this._infoListEmployees.ToolTipTitle = "Liste des employés";
            // 
            // UcEmployeeList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeList);
            this.Name = "UcEmployeeList";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView employeeList;
		private System.Windows.Forms.ColumnHeader EmployeeLastNameHeader;
		private System.Windows.Forms.ColumnHeader EmployeeFirstNameHeader;
		private System.Windows.Forms.ColumnHeader EmployeeAgeHeader;
		private System.Windows.Forms.ColumnHeader EmployeeBestSkillHeader;
		private System.Windows.Forms.ColumnHeader EmployeeBestSkillLevelHeader;
        private System.Windows.Forms.ToolTip _infoListEmployees;
	}
}
