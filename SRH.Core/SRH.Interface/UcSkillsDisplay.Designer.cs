namespace SRH.Interface
{
	partial class UcSkillsDisplay
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
			System.Windows.Forms.Label SelectedPersonSkillsTitle;
			this.selectedPersonSkillList = new System.Windows.Forms.ListView();
			this.SelectedEmployeeSkillNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SelectedEmployeeSkillLeverHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			SelectedPersonSkillsTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SelectedPersonSkillsTitle
			// 
			SelectedPersonSkillsTitle.AutoSize = true;
			SelectedPersonSkillsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			SelectedPersonSkillsTitle.Location = new System.Drawing.Point(1, 0);
			SelectedPersonSkillsTitle.Name = "SelectedPersonSkillsTitle";
			SelectedPersonSkillsTitle.Size = new System.Drawing.Size(103, 16);
			SelectedPersonSkillsTitle.TabIndex = 13;
			SelectedPersonSkillsTitle.Text = "Compétences";
			// 
			// selectedPersonSkillList
			// 
			this.selectedPersonSkillList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectedEmployeeSkillNameHeader,
            this.SelectedEmployeeSkillLeverHeader});
			this.selectedPersonSkillList.Location = new System.Drawing.Point(4, 19);
			this.selectedPersonSkillList.Name = "selectedPersonSkillList";
			this.selectedPersonSkillList.Size = new System.Drawing.Size(430, 117);
			this.selectedPersonSkillList.TabIndex = 14;
			this.selectedPersonSkillList.UseCompatibleStateImageBehavior = false;
			this.selectedPersonSkillList.View = System.Windows.Forms.View.Tile;
			// 
			// SelectedEmployeeSkillNameHeader
			// 
			this.SelectedEmployeeSkillNameHeader.Text = "Compétence";
			this.SelectedEmployeeSkillNameHeader.Width = 108;
			// 
			// SelectedEmployeeSkillLeverHeader
			// 
			this.SelectedEmployeeSkillLeverHeader.Text = "Niveau";
			this.SelectedEmployeeSkillLeverHeader.Width = 107;
			// 
			// UcSkillsDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.selectedPersonSkillList);
			this.Controls.Add(SelectedPersonSkillsTitle);
			this.Name = "UcSkillsDisplay";
			this.Size = new System.Drawing.Size(437, 138);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView selectedPersonSkillList;
		private System.Windows.Forms.ColumnHeader SelectedEmployeeSkillNameHeader;
		private System.Windows.Forms.ColumnHeader SelectedEmployeeSkillLeverHeader;

	}
}
