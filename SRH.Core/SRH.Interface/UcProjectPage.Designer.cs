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
            this._startOrStopProject = new System.Windows.Forms.Button();
            this._numberOfWorkers = new System.Windows.Forms.Label();
            this.NumberOfWorkers = new System.Windows.Forms.Label();
            this._estimatedTime = new System.Windows.Forms.Label();
            this.EstimatedTime = new System.Windows.Forms.Label();
            this._earnings = new System.Windows.Forms.Label();
            this.EarningsText = new System.Windows.Forms.Label();
            this._difficulty = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this._projectNameText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._startOrStopProject);
            this.splitContainer1.Panel2.Controls.Add(this._numberOfWorkers);
            this.splitContainer1.Panel2.Controls.Add(this.NumberOfWorkers);
            this.splitContainer1.Panel2.Controls.Add(this._estimatedTime);
            this.splitContainer1.Panel2.Controls.Add(this.EstimatedTime);
            this.splitContainer1.Panel2.Controls.Add(this._earnings);
            this.splitContainer1.Panel2.Controls.Add(this.EarningsText);
            this.splitContainer1.Panel2.Controls.Add(this._difficulty);
            this.splitContainer1.Panel2.Controls.Add(this.Difficulty);
            this.splitContainer1.Panel2.Controls.Add(this._projectNameText);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 630);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer2.Size = new System.Drawing.Size(365, 630);
            this.splitContainer2.SplitterDistance = 271;
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
            this.listPossibleProjects.Location = new System.Drawing.Point(0, 0);
            this.listPossibleProjects.Margin = new System.Windows.Forms.Padding(4);
            this.listPossibleProjects.Name = "listPossibleProjects";
            this.listPossibleProjects.Size = new System.Drawing.Size(365, 271);
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
            this.listCurrentProjects.Location = new System.Drawing.Point(0, 0);
            this.listCurrentProjects.Margin = new System.Windows.Forms.Padding(4);
            this.listCurrentProjects.Name = "listCurrentProjects";
            this.listCurrentProjects.Size = new System.Drawing.Size(365, 355);
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
            // _startOrStopProject
            // 
            this._startOrStopProject.Location = new System.Drawing.Point(531, 121);
            this._startOrStopProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._startOrStopProject.Name = "_startOrStopProject";
            this._startOrStopProject.Size = new System.Drawing.Size(164, 23);
            this._startOrStopProject.TabIndex = 11;
            this._startOrStopProject.Text = "Action sur projet";
            this._startOrStopProject.UseVisualStyleBackColor = true;
            this._startOrStopProject.Click += new System.EventHandler(this._startOrStopProject_Click);
            // 
            // _numberOfWorkers
            // 
            this._numberOfWorkers.AutoSize = true;
            this._numberOfWorkers.Location = new System.Drawing.Point(244, 240);
            this._numberOfWorkers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._numberOfWorkers.Name = "_numberOfWorkers";
            this._numberOfWorkers.Size = new System.Drawing.Size(17, 17);
            this._numberOfWorkers.TabIndex = 10;
            this._numberOfWorkers.Text = "X";
            // 
            // NumberOfWorkers
            // 
            this.NumberOfWorkers.AutoSize = true;
            this.NumberOfWorkers.Location = new System.Drawing.Point(40, 240);
            this.NumberOfWorkers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfWorkers.Name = "NumberOfWorkers";
            this.NumberOfWorkers.Size = new System.Drawing.Size(152, 17);
            this.NumberOfWorkers.TabIndex = 9;
            this.NumberOfWorkers.Text = "Nombre de membres : ";
            // 
            // _estimatedTime
            // 
            this._estimatedTime.AutoSize = true;
            this._estimatedTime.Location = new System.Drawing.Point(244, 197);
            this._estimatedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._estimatedTime.Name = "_estimatedTime";
            this._estimatedTime.Size = new System.Drawing.Size(17, 17);
            this._estimatedTime.TabIndex = 8;
            this._estimatedTime.Text = "X";
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.AutoSize = true;
            this.EstimatedTime.Location = new System.Drawing.Point(40, 197);
            this.EstimatedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.Size = new System.Drawing.Size(108, 17);
            this.EstimatedTime.TabIndex = 7;
            this.EstimatedTime.Text = "Temps estimé : ";
            // 
            // _earnings
            // 
            this._earnings.AutoSize = true;
            this._earnings.Location = new System.Drawing.Point(244, 160);
            this._earnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._earnings.Name = "_earnings";
            this._earnings.Size = new System.Drawing.Size(17, 17);
            this._earnings.TabIndex = 6;
            this._earnings.Text = "X";
            // 
            // EarningsText
            // 
            this.EarningsText.AutoSize = true;
            this.EarningsText.Location = new System.Drawing.Point(40, 160);
            this.EarningsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EarningsText.Name = "EarningsText";
            this.EarningsText.Size = new System.Drawing.Size(50, 17);
            this.EarningsText.TabIndex = 5;
            this.EarningsText.Text = "Gain : ";
            // 
            // _difficulty
            // 
            this._difficulty.AutoSize = true;
            this._difficulty.Location = new System.Drawing.Point(244, 126);
            this._difficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._difficulty.Name = "_difficulty";
            this._difficulty.Size = new System.Drawing.Size(17, 17);
            this._difficulty.TabIndex = 4;
            this._difficulty.Text = "X";
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Location = new System.Drawing.Point(40, 126);
            this.Difficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(134, 17);
            this.Difficulty.TabIndex = 3;
            this.Difficulty.Text = "Difficulté du projet : ";
            // 
            // _projectNameText
            // 
            this._projectNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._projectNameText.AutoSize = true;
            this._projectNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._projectNameText.Location = new System.Drawing.Point(333, 20);
            this._projectNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._projectNameText.Name = "_projectNameText";
            this._projectNameText.Size = new System.Drawing.Size(146, 25);
            this._projectNameText.TabIndex = 2;
            this._projectNameText.Text = "Nom du projet";
            this._projectNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcProjectPage";
            this.Size = new System.Drawing.Size(1100, 630);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listPossibleProjects;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader LevelRequired;
        private System.Windows.Forms.ColumnHeader EarningsExpected;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ListView listCurrentProjects;
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

    }
}
