namespace SRH.Interface
{
    partial class Form1
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
            this.ucProjectPage1 = new SRH.Interface.UcProjectPage();
            this.EntreprisePage = new System.Windows.Forms.TabPage();
            this.ResumeEntreprisePage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // BureauPage
            // 
            this.BureauPage.Location = new System.Drawing.Point(4, 25);
            this.BureauPage.Name = "BureauPage";
            this.BureauPage.Padding = new System.Windows.Forms.Padding(3);
            this.BureauPage.Size = new System.Drawing.Size(1009, 598);
            this.BureauPage.TabIndex = 0;
            this.BureauPage.Text = "Bureau";
            this.BureauPage.UseVisualStyleBackColor = true;
            // 
            // EmployésPage
            // 
            this.EmployésPage.Location = new System.Drawing.Point(4, 25);
            this.EmployésPage.Name = "EmployésPage";
            this.EmployésPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployésPage.Size = new System.Drawing.Size(1009, 598);
            this.EmployésPage.TabIndex = 1;
            this.EmployésPage.Text = "Employés";
            this.EmployésPage.UseVisualStyleBackColor = true;
            // 
            // ProjetTable
            // 
            this.ProjetTable.Controls.Add(this.ucProjectPage1);
            this.ProjetTable.Location = new System.Drawing.Point(4, 25);
            this.ProjetTable.Name = "ProjetTable";
            this.ProjetTable.Padding = new System.Windows.Forms.Padding(3);
            this.ProjetTable.Size = new System.Drawing.Size(1009, 598);
            this.ProjetTable.TabIndex = 2;
            this.ProjetTable.Text = "Gestion projets";
            this.ProjetTable.UseVisualStyleBackColor = true;
            // 
            // ucProjectPage1
            // 
            this.ucProjectPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProjectPage1.Location = new System.Drawing.Point(3, 3);
            this.ucProjectPage1.Name = "ucProjectPage1";
            this.ucProjectPage1.Size = new System.Drawing.Size(1003, 592);
            this.ucProjectPage1.TabIndex = 0;
            // 
            // EntreprisePage
            // 
            this.EntreprisePage.Location = new System.Drawing.Point(4, 25);
            this.EntreprisePage.Name = "EntreprisePage";
            this.EntreprisePage.Padding = new System.Windows.Forms.Padding(3);
            this.EntreprisePage.Size = new System.Drawing.Size(1009, 598);
            this.EntreprisePage.TabIndex = 3;
            this.EntreprisePage.Text = "Gestion entreprise";
            this.EntreprisePage.UseVisualStyleBackColor = true;
            // 
            // ResumeEntreprisePage
            // 
            this.ResumeEntreprisePage.Location = new System.Drawing.Point(4, 25);
            this.ResumeEntreprisePage.Name = "ResumeEntreprisePage";
            this.ResumeEntreprisePage.Padding = new System.Windows.Forms.Padding(3);
            this.ResumeEntreprisePage.Size = new System.Drawing.Size(1009, 598);
            this.ResumeEntreprisePage.TabIndex = 4;
            this.ResumeEntreprisePage.Text = "Résumé entreprises";
            this.ResumeEntreprisePage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 664);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SimuRH";
            this.tabControl1.ResumeLayout(false);
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
        private UcProjectPage ucProjectPage1;

    }
}

