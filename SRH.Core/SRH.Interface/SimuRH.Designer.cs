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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BureauPage = new System.Windows.Forms.TabPage();
            this.EmployésPage = new System.Windows.Forms.TabPage();
            this.ProjetTable = new System.Windows.Forms.TabPage();
            this.EntreprisePage = new System.Windows.Forms.TabPage();
            this.ResumeEntreprisePage = new System.Windows.Forms.TabPage();
            this._dateOfGame = new System.Windows.Forms.Label();
            this._day = new System.Windows.Forms.Label();
            this._pauseButton = new System.Windows.Forms.Button();
            this._x2Button = new System.Windows.Forms.Button();
            this._x5Button = new System.Windows.Forms.Button();
            this._x10Button = new System.Windows.Forms.Button();
            this._playButton = new System.Windows.Forms.Button();
            this.ucEmployeePage = new SRH.Interface.UcEmployeePage();
            this.ucProjectPage = new SRH.Interface.UcProjectPage();
            this.tabControl1.SuspendLayout();
            this.EmployésPage.SuspendLayout();
            this.ProjetTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.BureauPage);
            this.tabControl1.Controls.Add(this.EmployésPage);
            this.tabControl1.Controls.Add(this.ProjetTable);
            this.tabControl1.Controls.Add(this.EntreprisePage);
            this.tabControl1.Controls.Add(this.ResumeEntreprisePage);
            this.tabControl1.Location = new System.Drawing.Point(1, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // BureauPage
            // 
            this.BureauPage.Location = new System.Drawing.Point(4, 25);
            this.BureauPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BureauPage.Name = "BureauPage";
            this.BureauPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BureauPage.Size = new System.Drawing.Size(1009, 597);
            this.BureauPage.TabIndex = 0;
            this.BureauPage.Text = "Bureau";
            this.BureauPage.UseVisualStyleBackColor = true;
            // 
            // EmployésPage
            // 
            this.EmployésPage.Controls.Add(this.ucEmployeePage);
            this.EmployésPage.Location = new System.Drawing.Point(4, 25);
            this.EmployésPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployésPage.Name = "EmployésPage";
            this.EmployésPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployésPage.Size = new System.Drawing.Size(1009, 597);
            this.EmployésPage.TabIndex = 1;
            this.EmployésPage.Text = "Employés";
            this.EmployésPage.UseVisualStyleBackColor = true;
            // 
            // ProjetTable
            // 
            this.ProjetTable.Controls.Add(this.ucProjectPage);
            this.ProjetTable.Location = new System.Drawing.Point(4, 25);
            this.ProjetTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjetTable.Name = "ProjetTable";
            this.ProjetTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProjetTable.Size = new System.Drawing.Size(1009, 597);
            this.ProjetTable.TabIndex = 2;
            this.ProjetTable.Text = "Gestion projets";
            this.ProjetTable.UseVisualStyleBackColor = true;
            // 
            // EntreprisePage
            // 
            this.EntreprisePage.Location = new System.Drawing.Point(4, 25);
            this.EntreprisePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EntreprisePage.Name = "EntreprisePage";
            this.EntreprisePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EntreprisePage.Size = new System.Drawing.Size(1009, 597);
            this.EntreprisePage.TabIndex = 3;
            this.EntreprisePage.Text = "Gestion entreprise";
            this.EntreprisePage.UseVisualStyleBackColor = true;
            // 
            // ResumeEntreprisePage
            // 
            this.ResumeEntreprisePage.Location = new System.Drawing.Point(4, 25);
            this.ResumeEntreprisePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResumeEntreprisePage.Name = "ResumeEntreprisePage";
            this.ResumeEntreprisePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResumeEntreprisePage.Size = new System.Drawing.Size(1009, 597);
            this.ResumeEntreprisePage.TabIndex = 4;
            this.ResumeEntreprisePage.Text = "Résumé entreprises";
            this.ResumeEntreprisePage.UseVisualStyleBackColor = true;
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
            this._pauseButton.Name = "_pauseButton";
            this._pauseButton.Size = new System.Drawing.Size(40, 24);
            this._pauseButton.TabIndex = 3;
            this._pauseButton.Text = "||";
            this._pauseButton.UseVisualStyleBackColor = true;
            this._pauseButton.Click += new System.EventHandler(this._pauseButton_Click);
            // 
            // _x2Button
            // 
            this._x2Button.Location = new System.Drawing.Point(294, 9);
            this._x2Button.Name = "_x2Button";
            this._x2Button.Size = new System.Drawing.Size(46, 24);
            this._x2Button.TabIndex = 4;
            this._x2Button.Text = "X2";
            this._x2Button.UseVisualStyleBackColor = true;
            this._x2Button.Click += new System.EventHandler(this._x2Button_Click);
            // 
            // _x5Button
            // 
            this._x5Button.Location = new System.Drawing.Point(346, 9);
            this._x5Button.Name = "_x5Button";
            this._x5Button.Size = new System.Drawing.Size(49, 24);
            this._x5Button.TabIndex = 5;
            this._x5Button.Text = "X5";
            this._x5Button.UseVisualStyleBackColor = true;
            this._x5Button.Click += new System.EventHandler(this._x5Button_Click);
            // 
            // _x10Button
            // 
            this._x10Button.Location = new System.Drawing.Point(401, 9);
            this._x10Button.Name = "_x10Button";
            this._x10Button.Size = new System.Drawing.Size(51, 24);
            this._x10Button.TabIndex = 6;
            this._x10Button.Text = "X10";
            this._x10Button.UseVisualStyleBackColor = true;
            this._x10Button.Click += new System.EventHandler(this._x10Button_Click);
            // 
            // _playButton
            // 
            this._playButton.Enabled = false;
            this._playButton.Location = new System.Drawing.Point(202, 9);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(40, 24);
            this._playButton.TabIndex = 7;
            this._playButton.Text = "►";
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this._playButton_Click);
            // 
            // ucEmployeePage
            // 
            this.ucEmployeePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEmployeePage.AutoSize = true;
            this.ucEmployeePage.Location = new System.Drawing.Point(0, 0);
            this.ucEmployeePage.Margin = new System.Windows.Forms.Padding(5);
            this.ucEmployeePage.Name = "ucEmployeePage";
            this.ucEmployeePage.Size = new System.Drawing.Size(1467, 780);
            this.ucEmployeePage.TabIndex = 0;
            // 
            // ucProjectPage
            // 
            this.ucProjectPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProjectPage.Location = new System.Drawing.Point(3, 2);
            this.ucProjectPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucProjectPage.Name = "ucProjectPage";
            this.ucProjectPage.Size = new System.Drawing.Size(1003, 592);
            this.ucProjectPage.TabIndex = 0;
            // 
            // SimuRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 665);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this._x10Button);
            this.Controls.Add(this._x5Button);
            this.Controls.Add(this._x2Button);
            this.Controls.Add(this._pauseButton);
            this.Controls.Add(this._day);
            this.Controls.Add(this._dateOfGame);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimuRH";
            this.Text = "SimuRH";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.EmployésPage.ResumeLayout(false);
            this.EmployésPage.PerformLayout();
            this.ProjetTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BureauPage;
        private System.Windows.Forms.TabPage EmployésPage;
        private System.Windows.Forms.TabPage ProjetTable;
        private System.Windows.Forms.TabPage EntreprisePage;
        private System.Windows.Forms.TabPage ResumeEntreprisePage;
		private UcProjectPage ucProjectPage;
		private UcEmployeePage ucEmployeePage;
        private System.Windows.Forms.Label _dateOfGame;
        private System.Windows.Forms.Label _day;
        private System.Windows.Forms.Button _pauseButton;
        private System.Windows.Forms.Button _x2Button;
        private System.Windows.Forms.Button _x5Button;
        private System.Windows.Forms.Button _x10Button;
        private System.Windows.Forms.Button _playButton;

    }
}

