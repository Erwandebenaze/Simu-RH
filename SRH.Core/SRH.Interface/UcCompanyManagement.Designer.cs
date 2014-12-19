﻿namespace SRH.Interface
{
    partial class UcCompanyManagement
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Commerciaux", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Directeurs des ressources humaines", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Directeur de projets", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Recruteurs", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Membres du comité d\'entreprise", System.Windows.Forms.HorizontalAlignment.Left);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DesaffectManager = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.managerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.managerAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.managerUsedSkill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.managerUsedSkillLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.managerList = new System.Windows.Forms.ListView();
			this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
			this.UcSkillsDisplay1 = new SRH.Interface.UcSkillsDisplay();
			this.AffectManager = new System.Windows.Forms.Button();
			this.IsBusyTitle = new System.Windows.Forms.Label();
			this.SkillsToAffect = new System.Windows.Forms.ComboBox();
			this.IsBusy = new System.Windows.Forms.Label();
			this.SelectedManagerAffectTitle = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel2);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(891, 529);
			this.splitContainer1.SplitterDistance = 292;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.managerList);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(303, 389);
			this.panel2.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.DesaffectManager);
			this.panel1.Location = new System.Drawing.Point(3, 398);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(303, 37);
			this.panel1.TabIndex = 8;
			// 
			// DesaffectManager
			// 
			this.DesaffectManager.Location = new System.Drawing.Point(225, 5);
			this.DesaffectManager.Name = "DesaffectManager";
			this.DesaffectManager.Size = new System.Drawing.Size(75, 23);
			this.DesaffectManager.TabIndex = 0;
			this.DesaffectManager.Text = "Retirer";
			this.DesaffectManager.UseVisualStyleBackColor = true;
			this.DesaffectManager.Click += new System.EventHandler(this.DesaffectManager_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.UcEmployeeList1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.92439F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.07561F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 529);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// managerName
			// 
			this.managerName.Text = "Nom";
			// 
			// managerAge
			// 
			this.managerAge.Text = "Age";
			this.managerAge.Width = 51;
			// 
			// managerUsedSkill
			// 
			this.managerUsedSkill.Text = "Compétence utilisée";
			// 
			// managerUsedSkillLevel
			// 
			this.managerUsedSkillLevel.Text = "Niveau de la compétence";
			// 
			// managerList
			// 
			this.managerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.managerName,
            this.managerAge,
            this.managerUsedSkill,
            this.managerUsedSkillLevel});
			this.managerList.FullRowSelect = true;
			listViewGroup1.Header = "Commerciaux";
			listViewGroup1.Name = "salesRepGroup";
			listViewGroup2.Header = "Directeurs des ressources humaines";
			listViewGroup2.Name = "humanResourcesGroup";
			listViewGroup3.Header = "Directeur de projets";
			listViewGroup3.Name = "projDirectorGroup";
			listViewGroup4.Header = "Recruteurs";
			listViewGroup4.Name = "recruteurHandlersGroup";
			listViewGroup5.Header = "Membres du comité d\'entreprise";
			listViewGroup5.Name = "animationGroup";
			this.managerList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
			this.managerList.Location = new System.Drawing.Point(0, 0);
			this.managerList.Name = "managerList";
			this.managerList.Size = new System.Drawing.Size(304, 390);
			this.managerList.TabIndex = 7;
			this.managerList.UseCompatibleStateImageBehavior = false;
			this.managerList.View = System.Windows.Forms.View.Details;
			this.managerList.SelectedIndexChanged += new System.EventHandler(this.managerList_SelectedIndexChanged);
			// 
			// UcEmployeeList1
			// 
			this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcEmployeeList1.Location = new System.Drawing.Point(4, 4);
			this.UcEmployeeList1.Margin = new System.Windows.Forms.Padding(4);
			this.UcEmployeeList1.Name = "UcEmployeeList1";
			this.UcEmployeeList1.Size = new System.Drawing.Size(588, 308);
			this.UcEmployeeList1.TabIndex = 0;
			// 
			// UcSkillsDisplay1
			// 
			this.UcSkillsDisplay1.CurrentPerson = null;
			this.UcSkillsDisplay1.Location = new System.Drawing.Point(4, 4);
			this.UcSkillsDisplay1.Margin = new System.Windows.Forms.Padding(4);
			this.UcSkillsDisplay1.Name = "UcSkillsDisplay1";
			this.UcSkillsDisplay1.Size = new System.Drawing.Size(437, 138);
			this.UcSkillsDisplay1.TabIndex = 1;
			// 
			// AffectManager
			// 
			this.AffectManager.Enabled = false;
			this.AffectManager.Location = new System.Drawing.Point(362, 151);
			this.AffectManager.Name = "AffectManager";
			this.AffectManager.Size = new System.Drawing.Size(75, 23);
			this.AffectManager.TabIndex = 4;
			this.AffectManager.Text = "Affecter";
			this.AffectManager.UseVisualStyleBackColor = true;
			this.AffectManager.Visible = false;
			this.AffectManager.Click += new System.EventHandler(this.Affect_Manager_Click);
			// 
			// IsBusyTitle
			// 
			this.IsBusyTitle.AutoSize = true;
			this.IsBusyTitle.Location = new System.Drawing.Point(13, 186);
			this.IsBusyTitle.Name = "IsBusyTitle";
			this.IsBusyTitle.Size = new System.Drawing.Size(51, 13);
			this.IsBusyTitle.TabIndex = 5;
			this.IsBusyTitle.Text = "Occupé :";
			this.IsBusyTitle.Visible = false;
			// 
			// SkillsToAffect
			// 
			this.SkillsToAffect.FormattingEnabled = true;
			this.SkillsToAffect.Location = new System.Drawing.Point(134, 153);
			this.SkillsToAffect.Name = "SkillsToAffect";
			this.SkillsToAffect.Size = new System.Drawing.Size(213, 21);
			this.SkillsToAffect.TabIndex = 2;
			this.SkillsToAffect.Visible = false;
			this.SkillsToAffect.SelectedIndexChanged += new System.EventHandler(this.SkillsToAffect_SelectedIndexChanged);
			// 
			// IsBusy
			// 
			this.IsBusy.AutoSize = true;
			this.IsBusy.Location = new System.Drawing.Point(70, 186);
			this.IsBusy.Name = "IsBusy";
			this.IsBusy.Size = new System.Drawing.Size(14, 13);
			this.IsBusy.TabIndex = 6;
			this.IsBusy.Text = "X";
			this.IsBusy.Visible = false;
			// 
			// SelectedManagerAffectTitle
			// 
			this.SelectedManagerAffectTitle.AutoSize = true;
			this.SelectedManagerAffectTitle.Location = new System.Drawing.Point(13, 156);
			this.SelectedManagerAffectTitle.Name = "SelectedManagerAffectTitle";
			this.SelectedManagerAffectTitle.Size = new System.Drawing.Size(115, 13);
			this.SelectedManagerAffectTitle.TabIndex = 3;
			this.SelectedManagerAffectTitle.Text = "Compétence à affecter";
			this.SelectedManagerAffectTitle.Visible = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.IsBusy);
			this.panel4.Controls.Add(this.SelectedManagerAffectTitle);
			this.panel4.Controls.Add(this.IsBusyTitle);
			this.panel4.Controls.Add(this.UcSkillsDisplay1);
			this.panel4.Controls.Add(this.SkillsToAffect);
			this.panel4.Controls.Add(this.AffectManager);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 319);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(590, 207);
			this.panel4.TabIndex = 8;
			// 
			// UcCompanyManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UcCompanyManagement";
			this.Size = new System.Drawing.Size(891, 529);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private UcSkillsDisplay UcSkillsDisplay1;
		private UcEmployeeList UcEmployeeList1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button DesaffectManager;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListView managerList;
		private System.Windows.Forms.ColumnHeader managerName;
		private System.Windows.Forms.ColumnHeader managerAge;
		private System.Windows.Forms.ColumnHeader managerUsedSkill;
		private System.Windows.Forms.ColumnHeader managerUsedSkillLevel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label IsBusy;
		private System.Windows.Forms.Label SelectedManagerAffectTitle;
		private System.Windows.Forms.Label IsBusyTitle;
		private System.Windows.Forms.ComboBox SkillsToAffect;
		private System.Windows.Forms.Button AffectManager;
    }
}
