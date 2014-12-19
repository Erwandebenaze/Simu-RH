namespace SRH.Interface
{
    partial class UcProjectPage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.listPossibleProjects = new System.Windows.Forms.ListView();
			this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LevelRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EarningsExpected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listCurrentProjects = new System.Windows.Forms.ListView();
			this.currentProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Earnings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TimeLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this._projectNameText = new System.Windows.Forms.Label();
			this.projectProgressBar = new System.Windows.Forms.ProgressBar();
			this.Difficulty = new System.Windows.Forms.Label();
			this._startOrStopProject = new System.Windows.Forms.Button();
			this._difficulty = new System.Windows.Forms.Label();
			this._numberOfWorkers = new System.Windows.Forms.Label();
			this.EarningsText = new System.Windows.Forms.Label();
			this.NumberOfWorkers = new System.Windows.Forms.Label();
			this._earnings = new System.Windows.Forms.Label();
			this._estimatedTime = new System.Windows.Forms.Label();
			this.EstimatedTime = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.listSkillsAvailable = new System.Windows.Forms.ListView();
			this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EmployeeSkill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.EmployeeLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.affectEmployee = new System.Windows.Forms.Button();
			this.listSkillsRequired = new System.Windows.Forms.ListView();
			this.ProjectEmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProjectSkillRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProjectLevelRecommanded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.desaffectEmployee = new System.Windows.Forms.Button();
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
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(1046, 616);
			this.splitContainer1.SplitterDistance = 347;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.listPossibleProjects);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.listCurrentProjects);
			this.splitContainer2.Size = new System.Drawing.Size(347, 616);
			this.splitContainer2.SplitterDistance = 264;
			this.splitContainer2.SplitterWidth = 3;
			this.splitContainer2.TabIndex = 0;
			// 
			// listPossibleProjects
			// 
			this.listPossibleProjects.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listPossibleProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Project,
            this.LevelRequired,
            this.EarningsExpected,
            this.Time});
			this.listPossibleProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listPossibleProjects.FullRowSelect = true;
			this.listPossibleProjects.Location = new System.Drawing.Point(0, 0);
			this.listPossibleProjects.Name = "listPossibleProjects";
			this.listPossibleProjects.Size = new System.Drawing.Size(347, 264);
			this.listPossibleProjects.TabIndex = 0;
			this.listPossibleProjects.UseCompatibleStateImageBehavior = false;
			this.listPossibleProjects.View = System.Windows.Forms.View.Details;
			this.listPossibleProjects.SelectedIndexChanged += new System.EventHandler(this.listPossibleProjects_SelectedIndexChanged);
			// 
			// Project
			// 
			this.Project.Text = "Projet proposés";
			this.Project.Width = 110;
			// 
			// LevelRequired
			// 
			this.LevelRequired.Text = "Niveau";
			this.LevelRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.LevelRequired.Width = 85;
			// 
			// EarningsExpected
			// 
			this.EarningsExpected.Text = "Gain";
			this.EarningsExpected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.EarningsExpected.Width = 85;
			// 
			// Time
			// 
			this.Time.Text = "Temps";
			this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Time.Width = 85;
			// 
			// listCurrentProjects
			// 
			this.listCurrentProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.currentProject,
            this.Level,
            this.Earnings,
            this.TimeLeft});
			this.listCurrentProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listCurrentProjects.FullRowSelect = true;
			this.listCurrentProjects.Location = new System.Drawing.Point(0, 0);
			this.listCurrentProjects.Name = "listCurrentProjects";
			this.listCurrentProjects.Size = new System.Drawing.Size(347, 349);
			this.listCurrentProjects.TabIndex = 0;
			this.listCurrentProjects.UseCompatibleStateImageBehavior = false;
			this.listCurrentProjects.View = System.Windows.Forms.View.Details;
			this.listCurrentProjects.SelectedIndexChanged += new System.EventHandler(this.listCurrentProjects_SelectedIndexChanged);
			// 
			// currentProject
			// 
			this.currentProject.Text = "Projet";
			this.currentProject.Width = 110;
			// 
			// Level
			// 
			this.Level.Text = "Niveau";
			this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Level.Width = 85;
			// 
			// Earnings
			// 
			this.Earnings.Text = "Gain";
			this.Earnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Earnings.Width = 85;
			// 
			// TimeLeft
			// 
			this.TimeLeft.Text = "Temps restant";
			this.TimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TimeLeft.Width = 105;
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
			this.splitContainer3.Panel1.Controls.Add(this._projectNameText);
			this.splitContainer3.Panel1.Controls.Add(this.projectProgressBar);
			this.splitContainer3.Panel1.Controls.Add(this.Difficulty);
			this.splitContainer3.Panel1.Controls.Add(this._startOrStopProject);
			this.splitContainer3.Panel1.Controls.Add(this._difficulty);
			this.splitContainer3.Panel1.Controls.Add(this._numberOfWorkers);
			this.splitContainer3.Panel1.Controls.Add(this.EarningsText);
			this.splitContainer3.Panel1.Controls.Add(this.NumberOfWorkers);
			this.splitContainer3.Panel1.Controls.Add(this._earnings);
			this.splitContainer3.Panel1.Controls.Add(this._estimatedTime);
			this.splitContainer3.Panel1.Controls.Add(this.EstimatedTime);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer3.Size = new System.Drawing.Size(695, 616);
			this.splitContainer3.SplitterDistance = 263;
			this.splitContainer3.TabIndex = 15;
			// 
			// _projectNameText
			// 
			this._projectNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._projectNameText.AutoSize = true;
			this._projectNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._projectNameText.Location = new System.Drawing.Point(316, 11);
			this._projectNameText.Name = "_projectNameText";
			this._projectNameText.Size = new System.Drawing.Size(121, 20);
			this._projectNameText.TabIndex = 2;
			this._projectNameText.Text = "Nom du projet";
			this._projectNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// projectProgressBar
			// 
			this.projectProgressBar.Location = new System.Drawing.Point(91, 170);
			this.projectProgressBar.Margin = new System.Windows.Forms.Padding(2);
			this.projectProgressBar.Name = "projectProgressBar";
			this.projectProgressBar.Size = new System.Drawing.Size(494, 19);
			this.projectProgressBar.TabIndex = 13;
			// 
			// Difficulty
			// 
			this.Difficulty.AutoSize = true;
			this.Difficulty.Location = new System.Drawing.Point(88, 58);
			this.Difficulty.Name = "Difficulty";
			this.Difficulty.Size = new System.Drawing.Size(101, 13);
			this.Difficulty.TabIndex = 3;
			this.Difficulty.Text = "Difficulté du projet : ";
			// 
			// _startOrStopProject
			// 
			this._startOrStopProject.Enabled = false;
			this._startOrStopProject.Location = new System.Drawing.Point(461, 37);
			this._startOrStopProject.Margin = new System.Windows.Forms.Padding(2);
			this._startOrStopProject.Name = "_startOrStopProject";
			this._startOrStopProject.Size = new System.Drawing.Size(123, 19);
			this._startOrStopProject.TabIndex = 11;
			this._startOrStopProject.Text = "Action sur projet";
			this._startOrStopProject.UseVisualStyleBackColor = true;
			this._startOrStopProject.Click += new System.EventHandler(this._startOrStopProject_Click);
			// 
			// _difficulty
			// 
			this._difficulty.AutoSize = true;
			this._difficulty.Location = new System.Drawing.Point(242, 58);
			this._difficulty.Name = "_difficulty";
			this._difficulty.Size = new System.Drawing.Size(14, 13);
			this._difficulty.TabIndex = 4;
			this._difficulty.Text = "X";
			// 
			// _numberOfWorkers
			// 
			this._numberOfWorkers.AutoSize = true;
			this._numberOfWorkers.Location = new System.Drawing.Point(242, 134);
			this._numberOfWorkers.Name = "_numberOfWorkers";
			this._numberOfWorkers.Size = new System.Drawing.Size(14, 13);
			this._numberOfWorkers.TabIndex = 10;
			this._numberOfWorkers.Text = "X";
			// 
			// EarningsText
			// 
			this.EarningsText.AutoSize = true;
			this.EarningsText.Location = new System.Drawing.Point(88, 80);
			this.EarningsText.Name = "EarningsText";
			this.EarningsText.Size = new System.Drawing.Size(38, 13);
			this.EarningsText.TabIndex = 5;
			this.EarningsText.Text = "Gain : ";
			// 
			// NumberOfWorkers
			// 
			this.NumberOfWorkers.AutoSize = true;
			this.NumberOfWorkers.Location = new System.Drawing.Point(88, 134);
			this.NumberOfWorkers.Name = "NumberOfWorkers";
			this.NumberOfWorkers.Size = new System.Drawing.Size(113, 13);
			this.NumberOfWorkers.TabIndex = 9;
			this.NumberOfWorkers.Text = "Nombre de membres : ";
			// 
			// _earnings
			// 
			this._earnings.AutoSize = true;
			this._earnings.Location = new System.Drawing.Point(242, 80);
			this._earnings.Name = "_earnings";
			this._earnings.Size = new System.Drawing.Size(14, 13);
			this._earnings.TabIndex = 6;
			this._earnings.Text = "X";
			// 
			// _estimatedTime
			// 
			this._estimatedTime.AutoSize = true;
			this._estimatedTime.Location = new System.Drawing.Point(242, 105);
			this._estimatedTime.Name = "_estimatedTime";
			this._estimatedTime.Size = new System.Drawing.Size(14, 13);
			this._estimatedTime.TabIndex = 8;
			this._estimatedTime.Text = "X";
			// 
			// EstimatedTime
			// 
			this.EstimatedTime.AutoSize = true;
			this.EstimatedTime.Location = new System.Drawing.Point(88, 105);
			this.EstimatedTime.Name = "EstimatedTime";
			this.EstimatedTime.Size = new System.Drawing.Size(81, 13);
			this.EstimatedTime.TabIndex = 7;
			this.EstimatedTime.Text = "Temps estimé : ";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.listSkillsAvailable, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.affectEmployee, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.listSkillsRequired, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.desaffectEmployee, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.95403F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.045977F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 349);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// listSkillsAvailable
			// 
			this.listSkillsAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeName,
            this.EmployeeSkill,
            this.EmployeeLevel});
			this.listSkillsAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listSkillsAvailable.FullRowSelect = true;
			this.listSkillsAvailable.Location = new System.Drawing.Point(349, 2);
			this.listSkillsAvailable.Margin = new System.Windows.Forms.Padding(2);
			this.listSkillsAvailable.Name = "listSkillsAvailable";
			this.listSkillsAvailable.Size = new System.Drawing.Size(344, 316);
			this.listSkillsAvailable.TabIndex = 0;
			this.listSkillsAvailable.UseCompatibleStateImageBehavior = false;
			this.listSkillsAvailable.View = System.Windows.Forms.View.Details;
			this.listSkillsAvailable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSkillsAvailable_MouseDoubleClick);
			// 
			// EmployeeName
			// 
			this.EmployeeName.Text = "Nom de l\'employée";
			this.EmployeeName.Width = 152;
			// 
			// EmployeeSkill
			// 
			this.EmployeeSkill.Text = "Compétence";
			this.EmployeeSkill.Width = 106;
			// 
			// EmployeeLevel
			// 
			this.EmployeeLevel.Text = "Niveau";
			this.EmployeeLevel.Width = 106;
			// 
			// affectEmployee
			// 
			this.affectEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.affectEmployee.Location = new System.Drawing.Point(599, 323);
			this.affectEmployee.Name = "affectEmployee";
			this.affectEmployee.Size = new System.Drawing.Size(93, 23);
			this.affectEmployee.TabIndex = 1;
			this.affectEmployee.Text = "Affecter";
			this.affectEmployee.UseVisualStyleBackColor = true;
			this.affectEmployee.Click += new System.EventHandler(this.affectEmployee_Click);
			// 
			// listSkillsRequired
			// 
			this.listSkillsRequired.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectEmployeeName,
            this.ProjectSkillRequired,
            this.ProjectLevelRecommanded});
			this.listSkillsRequired.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listSkillsRequired.FullRowSelect = true;
			this.listSkillsRequired.Location = new System.Drawing.Point(2, 2);
			this.listSkillsRequired.Margin = new System.Windows.Forms.Padding(2);
			this.listSkillsRequired.Name = "listSkillsRequired";
			this.listSkillsRequired.Size = new System.Drawing.Size(343, 316);
			this.listSkillsRequired.TabIndex = 0;
			this.listSkillsRequired.UseCompatibleStateImageBehavior = false;
			this.listSkillsRequired.View = System.Windows.Forms.View.Details;
			this.listSkillsRequired.SelectedIndexChanged += new System.EventHandler(this.listSkillsRequired_SelectedIndexChanged);
			this.listSkillsRequired.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSkillsRequired_MouseDoubleClick);
			// 
			// ProjectEmployeeName
			// 
			this.ProjectEmployeeName.Text = "Nom de l\'employée";
			this.ProjectEmployeeName.Width = 97;
			// 
			// ProjectSkillRequired
			// 
			this.ProjectSkillRequired.Text = "Compétence";
			this.ProjectSkillRequired.Width = 144;
			// 
			// ProjectLevelRecommanded
			// 
			this.ProjectLevelRecommanded.Text = "Niveau réel (recommandé)";
			this.ProjectLevelRecommanded.Width = 205;
			// 
			// desaffectEmployee
			// 
			this.desaffectEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.desaffectEmployee.Location = new System.Drawing.Point(251, 323);
			this.desaffectEmployee.Name = "desaffectEmployee";
			this.desaffectEmployee.Size = new System.Drawing.Size(93, 23);
			this.desaffectEmployee.TabIndex = 0;
			this.desaffectEmployee.Text = "Désaffecter";
			this.desaffectEmployee.UseVisualStyleBackColor = true;
			this.desaffectEmployee.Click += new System.EventHandler(this.desaffectEmployee_Click);
			// 
			// UcProjectPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcProjectPage";
			this.Size = new System.Drawing.Size(1046, 616);
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
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader LevelRequired;
        private System.Windows.Forms.ColumnHeader EarningsExpected;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader currentProject;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Earnings;
        private System.Windows.Forms.ColumnHeader TimeLeft;
        private System.Windows.Forms.Label _projectNameText;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label _difficulty;
        private System.Windows.Forms.Label EarningsText;
        private System.Windows.Forms.Label _earnings;
        private System.Windows.Forms.Label EstimatedTime;
        private System.Windows.Forms.Label _estimatedTime;
        private System.Windows.Forms.Label NumberOfWorkers;
        private System.Windows.Forms.Label _numberOfWorkers;
		private System.Windows.Forms.Button _startOrStopProject;
        private System.Windows.Forms.ColumnHeader ProjectEmployeeName;
        private System.Windows.Forms.ColumnHeader ProjectSkillRequired;
        private System.Windows.Forms.ColumnHeader ProjectLevelRecommanded;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader EmployeeSkill;
        private System.Windows.Forms.ColumnHeader EmployeeLevel;
        public System.Windows.Forms.ListView listPossibleProjects;
        public System.Windows.Forms.ListView listCurrentProjects;
        public System.Windows.Forms.ListView listSkillsRequired;
        public System.Windows.Forms.ListView listSkillsAvailable;
		private System.Windows.Forms.ProgressBar projectProgressBar;
		private System.Windows.Forms.Button affectEmployee;
		private System.Windows.Forms.Button desaffectEmployee;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer3;

    }
}
