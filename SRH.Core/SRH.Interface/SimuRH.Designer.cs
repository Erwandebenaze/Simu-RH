namespace SRH.Interface
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
            this.ucEmployeePage = new SRH.Interface.UcEmployeePage();
            this.ProjetTable = new System.Windows.Forms.TabPage();
            this.ucProjectPage = new SRH.Interface.UcProjectPage();
            this.EntreprisePage = new System.Windows.Forms.TabPage();
            this.ResumeEntreprisePage = new System.Windows.Forms.TabPage();
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
            // ucEmployeePage
            // 
            this.ucEmployeePage.Location = new System.Drawing.Point(0, 0);
            this.ucEmployeePage.Margin = new System.Windows.Forms.Padding(5);
            this.ucEmployeePage.Name = "ucEmployeePage";
            this.ucEmployeePage.Size = new System.Drawing.Size(1007, 594);
            this.ucEmployeePage.TabIndex = 0;
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
            // SimuRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 665);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimuRH";
            this.Text = "SimuRH";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.EmployésPage.ResumeLayout(false);
            this.ProjetTable.ResumeLayout(false);
            this.ResumeLayout(false);

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

    }
}

