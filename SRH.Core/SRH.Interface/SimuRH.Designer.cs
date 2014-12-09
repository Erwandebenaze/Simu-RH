﻿namespace SRH.Interface
{
    partial class SimuRH
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.Label WealthTitle;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimuRH));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Board = new System.Windows.Forms.TabPage();
            this.Employees = new System.Windows.Forms.TabPage();
			this.ucEmployeePage = new SRH.Interface.UcEmployeePage();
			this.Projects = new System.Windows.Forms.TabPage();
			this.ucProjectPage = new SRH.Interface.UcProjectPage();
			this.CompanyManagement = new System.Windows.Forms.TabPage();
			this.ucCompanyManagement1 = new SRH.Interface.UcCompanyManagement();
			this.Statistics = new System.Windows.Forms.TabPage();
            this.ucStatistics1 = new SRH.Interface.UcStatistics();
			this._dateOfGame = new System.Windows.Forms.Label();
			this._day = new System.Windows.Forms.Label();
			this._pauseButton = new System.Windows.Forms.Button();
			this._x2Button = new System.Windows.Forms.Button();
			this._x5Button = new System.Windows.Forms.Button();
			this._x10Button = new System.Windows.Forms.Button();
			this._playButton = new System.Windows.Forms.Button();
			this._companyProgressBar = new System.Windows.Forms.ProgressBar();
			this._currentCompanyLevel = new System.Windows.Forms.Label();
			this._nextCompanyLevel = new System.Windows.Forms.Label();
			this.companyExperience = new System.Windows.Forms.Label();
			this.experiencePanel = new System.Windows.Forms.Panel();
			this.CompanyWealth = new System.Windows.Forms.Label();
			WealthTitle = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.Employees.SuspendLayout();
			this.Projects.SuspendLayout();
			this.CompanyManagement.SuspendLayout();
			this.Statistics.SuspendLayout();
			this.experiencePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// WealthTitle
			// 
			resources.ApplyResources(WealthTitle, "WealthTitle");
			WealthTitle.Name = "WealthTitle";
			// 
			// tabControl1
			// 
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Controls.Add(this.Board);
			this.tabControl1.Controls.Add(this.Employees);
			this.tabControl1.Controls.Add(this.Projects);
			this.tabControl1.Controls.Add(this.CompanyManagement);
			this.tabControl1.Controls.Add(this.Statistics);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// Board
			// 
			resources.ApplyResources(this.Board, "Board");
			this.Board.Name = "Board";
			this.Board.UseVisualStyleBackColor = true;
			// 
            // Employees
			// 
            this.Employees.Controls.Add(this.ucEmployeePage);
			resources.ApplyResources(this.Employees, "Employees");
            this.Employees.Name = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
			// 
			// ucEmployeePage
			// 
			resources.ApplyResources(this.ucEmployeePage, "ucEmployeePage");
			this.ucEmployeePage.Name = "ucEmployeePage";
			// 
			// Projects
			// 
			this.Projects.Controls.Add(this.ucProjectPage);
			resources.ApplyResources(this.Projects, "Projects");
			this.Projects.Name = "Projects";
			this.Projects.UseVisualStyleBackColor = true;
			// 
			// ucProjectPage
			// 
			resources.ApplyResources(this.ucProjectPage, "ucProjectPage");
			this.ucProjectPage.Name = "ucProjectPage";
			// 
			// CompanyManagement
			// 
			this.CompanyManagement.Controls.Add(this.ucCompanyManagement1);
			resources.ApplyResources(this.CompanyManagement, "CompanyManagement");
			this.CompanyManagement.Name = "CompanyManagement";
			this.CompanyManagement.UseVisualStyleBackColor = true;
			// 
			// ucCompanyManagement1
			// 
			resources.ApplyResources(this.ucCompanyManagement1, "ucCompanyManagement1");
			this.ucCompanyManagement1.Name = "ucCompanyManagement1";
			// 
			// Statistics
			// 
			this.Statistics.Controls.Add(this.ucStatistics1);
			resources.ApplyResources(this.Statistics, "Statistics");
			this.Statistics.Name = "Statistics";
			this.Statistics.UseVisualStyleBackColor = true;
            // 
            // ucStatistics1
            // 
            this.ucStatistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatistics1.Location = new System.Drawing.Point(3, 2);
            this.ucStatistics1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucStatistics1.Name = "ucStatistics1";
            this.ucStatistics1.Size = new System.Drawing.Size(1171, 593);
            this.ucStatistics1.TabIndex = 0;
			// 
			// ucStatistics1
			// 
			resources.ApplyResources(this.ucStatistics1, "ucStatistics1");
			this.ucStatistics1.Name = "ucStatistics1";
			// 
			// _dateOfGame
			// 
			resources.ApplyResources(this._dateOfGame, "_dateOfGame");
			this._dateOfGame.Name = "_dateOfGame";
			// 
			// _day
			// 
			resources.ApplyResources(this._day, "_day");
			this._day.Name = "_day";
			// 
			// _pauseButton
			// 
			resources.ApplyResources(this._pauseButton, "_pauseButton");
			this._pauseButton.Name = "_pauseButton";
			this._pauseButton.UseVisualStyleBackColor = true;
			this._pauseButton.Click += new System.EventHandler(this._pauseButton_Click);
			// 
			// _x2Button
			// 
			resources.ApplyResources(this._x2Button, "_x2Button");
			this._x2Button.Name = "_x2Button";
			this._x2Button.UseVisualStyleBackColor = true;
			this._x2Button.Click += new System.EventHandler(this._x2Button_Click);
			// 
			// _x5Button
			// 
			resources.ApplyResources(this._x5Button, "_x5Button");
			this._x5Button.Name = "_x5Button";
			this._x5Button.UseVisualStyleBackColor = true;
			this._x5Button.Click += new System.EventHandler(this._x5Button_Click);
			// 
			// _x10Button
			// 
			resources.ApplyResources(this._x10Button, "_x10Button");
			this._x10Button.Name = "_x10Button";
			this._x10Button.UseVisualStyleBackColor = true;
			this._x10Button.Click += new System.EventHandler(this._x10Button_Click);
			// 
			// _playButton
			// 
			resources.ApplyResources(this._playButton, "_playButton");
			this._playButton.Name = "_playButton";
			this._playButton.UseVisualStyleBackColor = true;
			this._playButton.Click += new System.EventHandler(this._playButton_Click);
			// 
			// _companyProgressBar
			// 
			resources.ApplyResources(this._companyProgressBar, "_companyProgressBar");
			this._companyProgressBar.Name = "_companyProgressBar";
			// 
			// _currentCompanyLevel
			// 
			resources.ApplyResources(this._currentCompanyLevel, "_currentCompanyLevel");
			this._currentCompanyLevel.Name = "_currentCompanyLevel";
			// 
			// _nextCompanyLevel
			// 
			resources.ApplyResources(this._nextCompanyLevel, "_nextCompanyLevel");
			this._nextCompanyLevel.Name = "_nextCompanyLevel";
			// 
			// companyExperience
			// 
			resources.ApplyResources(this.companyExperience, "companyExperience");
			this.companyExperience.Name = "companyExperience";
			// 
			// experiencePanel
			// 
			this.experiencePanel.Controls.Add(this.CompanyWealth);
			this.experiencePanel.Controls.Add(WealthTitle);
			this.experiencePanel.Controls.Add(this.companyExperience);
			this.experiencePanel.Controls.Add(this._nextCompanyLevel);
			this.experiencePanel.Controls.Add(this._currentCompanyLevel);
			this.experiencePanel.Controls.Add(this._companyProgressBar);
			resources.ApplyResources(this.experiencePanel, "experiencePanel");
            // 
            // _dateOfGame
            // 
            this._dateOfGame.AutoSize = true;
            this._dateOfGame.Location = new System.Drawing.Point(91, 9);
            this._dateOfGame.Name = "_dateOfGame";
            this._dateOfGame.Size = new System.Drawing.Size(38, 17);
            this._dateOfGame.TabIndex = 1;
            this._dateOfGame.Text = "Date";
            // 
            // _day
            // 
            this._day.AutoSize = true;
            this._day.Location = new System.Drawing.Point(28, 9);
            this._day.Name = "_day";
            this._day.Size = new System.Drawing.Size(36, 17);
            this._day.TabIndex = 2;
            this._day.Text = "Jour";
            // 
            // _pauseButton
            // 
            this._pauseButton.Location = new System.Drawing.Point(248, 9);
            this._pauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._pauseButton.Name = "_pauseButton";
            this._pauseButton.Size = new System.Drawing.Size(40, 25);
            this._pauseButton.TabIndex = 3;
            this._pauseButton.Text = "||";
            this._pauseButton.UseVisualStyleBackColor = true;
            this._pauseButton.Click += new System.EventHandler(this._pauseButton_Click);
            // 
            // _x2Button
            // 
            this._x2Button.Location = new System.Drawing.Point(293, 9);
            this._x2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._x2Button.Name = "_x2Button";
            this._x2Button.Size = new System.Drawing.Size(45, 25);
            this._x2Button.TabIndex = 4;
            this._x2Button.Text = "X2";
            this._x2Button.UseVisualStyleBackColor = true;
            this._x2Button.Click += new System.EventHandler(this._x2Button_Click);
            // 
            // _x5Button
            // 
            this._x5Button.Location = new System.Drawing.Point(347, 9);
            this._x5Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._x5Button.Name = "_x5Button";
            this._x5Button.Size = new System.Drawing.Size(49, 25);
            this._x5Button.TabIndex = 5;
            this._x5Button.Text = "X5";
            this._x5Button.UseVisualStyleBackColor = true;
            this._x5Button.Click += new System.EventHandler(this._x5Button_Click);
            // 
            // _x10Button
            // 
            this._x10Button.Location = new System.Drawing.Point(401, 9);
            this._x10Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._x10Button.Name = "_x10Button";
            this._x10Button.Size = new System.Drawing.Size(51, 25);
            this._x10Button.TabIndex = 6;
            this._x10Button.Text = "X10";
            this._x10Button.UseVisualStyleBackColor = true;
            this._x10Button.Click += new System.EventHandler(this._x10Button_Click);
            // 
            // _playButton
            // 
            this._playButton.Enabled = false;
            this._playButton.Location = new System.Drawing.Point(203, 9);
            this._playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(40, 25);
            this._playButton.TabIndex = 7;
            this._playButton.Text = "►";
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this._playButton_Click);
            // 
            // _companyProgressBar
            // 
            this._companyProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._companyProgressBar.Location = new System.Drawing.Point(55, 9);
            this._companyProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._companyProgressBar.Name = "_companyProgressBar";
            this._companyProgressBar.Size = new System.Drawing.Size(248, 23);
            this._companyProgressBar.TabIndex = 8;
            // 
            // _currentCompanyLevel
            // 
            this._currentCompanyLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._currentCompanyLevel.AutoSize = true;
            this._currentCompanyLevel.Location = new System.Drawing.Point(32, 12);
            this._currentCompanyLevel.Name = "_currentCompanyLevel";
            this._currentCompanyLevel.Size = new System.Drawing.Size(17, 17);
            this._currentCompanyLevel.TabIndex = 9;
            this._currentCompanyLevel.Text = "X";
            this._currentCompanyLevel.Visible = false;
            // 
            // _nextCompanyLevel
            // 
            this._nextCompanyLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._nextCompanyLevel.AutoSize = true;
            this._nextCompanyLevel.Location = new System.Drawing.Point(309, 12);
            this._nextCompanyLevel.Name = "_nextCompanyLevel";
            this._nextCompanyLevel.Size = new System.Drawing.Size(17, 17);
            this._nextCompanyLevel.TabIndex = 10;
            this._nextCompanyLevel.Text = "X";
            this._nextCompanyLevel.Visible = false;
            // 
            // companyExperience
            // 
            this.companyExperience.AutoSize = true;
            this.companyExperience.Location = new System.Drawing.Point(359, 14);
            this.companyExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyExperience.Name = "companyExperience";
            this.companyExperience.Size = new System.Drawing.Size(17, 17);
            this.companyExperience.TabIndex = 11;
            this.companyExperience.Text = "X";
            this.companyExperience.Visible = false;
            // 
            // experiencePanel
            // 
            this.experiencePanel.Controls.Add(this.CompanyWealth);
            this.experiencePanel.Controls.Add(WealthTitle);
            this.experiencePanel.Controls.Add(this.companyExperience);
            this.experiencePanel.Controls.Add(this._nextCompanyLevel);
            this.experiencePanel.Controls.Add(this._currentCompanyLevel);
            this.experiencePanel.Controls.Add(this._companyProgressBar);
            this.experiencePanel.Location = new System.Drawing.Point(472, 0);
            this.experiencePanel.Margin = new System.Windows.Forms.Padding(4);
			this.experiencePanel.Name = "experiencePanel";
			// 
			// CompanyWealth
			// 
			resources.ApplyResources(this.CompanyWealth, "CompanyWealth");
			this.CompanyWealth.Name = "CompanyWealth";
			// 
			// SimuRH
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.experiencePanel);
			this.Controls.Add(this._playButton);
			this.Controls.Add(this._x10Button);
			this.Controls.Add(this._x5Button);
			this.Controls.Add(this._x2Button);
			this.Controls.Add(this._pauseButton);
			this.Controls.Add(this._day);
			this.Controls.Add(this._dateOfGame);
			this.Controls.Add(this.tabControl1);
			this.KeyPreview = true;
			this.Name = "SimuRH";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
			this.tabControl1.ResumeLayout(false);
			this.Employees.ResumeLayout(false);
			this.Employees.PerformLayout();
			this.Projects.ResumeLayout(false);
			this.CompanyManagement.ResumeLayout(false);
			this.Statistics.ResumeLayout(false);
			this.experiencePanel.ResumeLayout(false);
			this.experiencePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Board;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.TabPage Projects;
        private System.Windows.Forms.TabPage CompanyManagement;
        private System.Windows.Forms.TabPage Statistics;
		private UcProjectPage ucProjectPage;
		private UcEmployeePage ucEmployeePage;
        private System.Windows.Forms.Label _dateOfGame;
        private System.Windows.Forms.Label _day;
        private System.Windows.Forms.Button _pauseButton;
        private System.Windows.Forms.Button _x2Button;
        private System.Windows.Forms.Button _x5Button;
        private System.Windows.Forms.Button _x10Button;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.ProgressBar _companyProgressBar;
        private System.Windows.Forms.Label _currentCompanyLevel;
        private System.Windows.Forms.Label _nextCompanyLevel;
		private System.Windows.Forms.Label companyExperience;
		private System.Windows.Forms.Panel experiencePanel;
		private System.Windows.Forms.Label CompanyWealth;
		private UcStatistics ucStatistics1;
		private UcCompanyManagement ucCompanyManagement1;

    }
}

