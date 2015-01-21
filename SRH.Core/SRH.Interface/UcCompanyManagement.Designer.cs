namespace SRH.Interface
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup26 = new System.Windows.Forms.ListViewGroup("Commerciaux", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup27 = new System.Windows.Forms.ListViewGroup("Directeurs des ressources humaines", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup28 = new System.Windows.Forms.ListViewGroup("Directeur de projets", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup29 = new System.Windows.Forms.ListViewGroup("Recruteurs", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup30 = new System.Windows.Forms.ListViewGroup("Membres du comité d\'entreprise", System.Windows.Forms.HorizontalAlignment.Left);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.managerList = new System.Windows.Forms.ListView();
            this.managerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerUsedSkill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerUsedSkillLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesaffectManager = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IsBusy = new System.Windows.Forms.Label();
            this.SelectedManagerAffectTitle = new System.Windows.Forms.Label();
            this.IsBusyTitle = new System.Windows.Forms.Label();
            this.UcSkillsDisplay1 = new SRH.Interface.UcSkillsDisplay();
            this.SkillsToAffect = new System.Windows.Forms.ComboBox();
            this.AffectManager = new System.Windows.Forms.Button();
            this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
            this._infoManagement = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1188, 651);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.managerList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DesaffectManager);
            this.splitContainer2.Size = new System.Drawing.Size(504, 651);
            this.splitContainer2.SplitterDistance = 615;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 8;
            // 
            // managerList
            // 
            this.managerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.managerName,
            this.managerAge,
            this.managerUsedSkill,
            this.managerUsedSkillLevel});
            this.managerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerList.FullRowSelect = true;
            listViewGroup26.Header = "Commerciaux";
            listViewGroup26.Name = "salesRepGroup";
            listViewGroup27.Header = "Directeurs des ressources humaines";
            listViewGroup27.Name = "humanResourcesGroup";
            listViewGroup28.Header = "Directeur de projets";
            listViewGroup28.Name = "projDirectorGroup";
            listViewGroup29.Header = "Recruteurs";
            listViewGroup29.Name = "recruteurHandlersGroup";
            listViewGroup30.Header = "Membres du comité d\'entreprise";
            listViewGroup30.Name = "animationGroup";
            this.managerList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup26,
            listViewGroup27,
            listViewGroup28,
            listViewGroup29,
            listViewGroup30});
            this.managerList.Location = new System.Drawing.Point(0, 0);
            this.managerList.Margin = new System.Windows.Forms.Padding(4);
            this.managerList.Name = "managerList";
            this.managerList.Size = new System.Drawing.Size(504, 615);
            this.managerList.TabIndex = 7;
            this.managerList.UseCompatibleStateImageBehavior = false;
            this.managerList.View = System.Windows.Forms.View.Details;
            this.managerList.SelectedIndexChanged += new System.EventHandler(this.managerList_SelectedIndexChanged);
            // 
            // managerName
            // 
            this.managerName.Text = "Nom";
            this.managerName.Width = 88;
            // 
            // managerAge
            // 
            this.managerAge.Text = "Age";
            this.managerAge.Width = 72;
            // 
            // managerUsedSkill
            // 
            this.managerUsedSkill.Text = "Compétence utilisée";
            this.managerUsedSkill.Width = 155;
            // 
            // managerUsedSkillLevel
            // 
            this.managerUsedSkillLevel.Text = "Niveau de la compétence";
            this.managerUsedSkillLevel.Width = 172;
            // 
            // DesaffectManager
            // 
            this.DesaffectManager.Location = new System.Drawing.Point(400, 4);
            this.DesaffectManager.Margin = new System.Windows.Forms.Padding(4);
            this.DesaffectManager.Name = "DesaffectManager";
            this.DesaffectManager.Size = new System.Drawing.Size(100, 28);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.71077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.59924F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 651);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.panel4.Location = new System.Drawing.Point(4, 441);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(672, 206);
            this.panel4.TabIndex = 8;
            // 
            // IsBusy
            // 
            this.IsBusy.AutoSize = true;
            this.IsBusy.Location = new System.Drawing.Point(93, 229);
            this.IsBusy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IsBusy.Name = "IsBusy";
            this.IsBusy.Size = new System.Drawing.Size(17, 17);
            this.IsBusy.TabIndex = 6;
            this.IsBusy.Text = "X";
            this.IsBusy.Visible = false;
            // 
            // SelectedManagerAffectTitle
            // 
            this.SelectedManagerAffectTitle.AutoSize = true;
            this.SelectedManagerAffectTitle.Location = new System.Drawing.Point(17, 192);
            this.SelectedManagerAffectTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedManagerAffectTitle.Name = "SelectedManagerAffectTitle";
            this.SelectedManagerAffectTitle.Size = new System.Drawing.Size(151, 17);
            this.SelectedManagerAffectTitle.TabIndex = 3;
            this.SelectedManagerAffectTitle.Text = "Compétence à affecter";
            this.SelectedManagerAffectTitle.Visible = false;
            // 
            // IsBusyTitle
            // 
            this.IsBusyTitle.AutoSize = true;
            this.IsBusyTitle.Location = new System.Drawing.Point(17, 229);
            this.IsBusyTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IsBusyTitle.Name = "IsBusyTitle";
            this.IsBusyTitle.Size = new System.Drawing.Size(65, 17);
            this.IsBusyTitle.TabIndex = 5;
            this.IsBusyTitle.Text = "Occupé :";
            this.IsBusyTitle.Visible = false;
            // 
            // UcSkillsDisplay1
            // 
            this.UcSkillsDisplay1.CurrentPerson = null;
            this.UcSkillsDisplay1.Location = new System.Drawing.Point(5, 5);
            this.UcSkillsDisplay1.Margin = new System.Windows.Forms.Padding(5);
            this.UcSkillsDisplay1.Name = "UcSkillsDisplay1";
            this.UcSkillsDisplay1.Size = new System.Drawing.Size(583, 170);
            this.UcSkillsDisplay1.TabIndex = 1;
            // 
            // SkillsToAffect
            // 
            this.SkillsToAffect.FormattingEnabled = true;
            this.SkillsToAffect.Location = new System.Drawing.Point(179, 188);
            this.SkillsToAffect.Margin = new System.Windows.Forms.Padding(4);
            this.SkillsToAffect.Name = "SkillsToAffect";
            this.SkillsToAffect.Size = new System.Drawing.Size(283, 24);
            this.SkillsToAffect.TabIndex = 2;
            this.SkillsToAffect.Visible = false;
            this.SkillsToAffect.SelectedIndexChanged += new System.EventHandler(this.SkillsToAffect_SelectedIndexChanged);
            // 
            // AffectManager
            // 
            this.AffectManager.Enabled = false;
            this.AffectManager.Location = new System.Drawing.Point(483, 186);
            this.AffectManager.Margin = new System.Windows.Forms.Padding(4);
            this.AffectManager.Name = "AffectManager";
            this.AffectManager.Size = new System.Drawing.Size(100, 28);
            this.AffectManager.TabIndex = 4;
            this.AffectManager.Text = "Affecter";
            this.AffectManager.UseVisualStyleBackColor = true;
            this.AffectManager.Visible = false;
            this.AffectManager.Click += new System.EventHandler(this.Affect_Manager_Click);
            // 
            // UcEmployeeList1
            // 
            this.UcEmployeeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcEmployeeList1.Location = new System.Drawing.Point(5, 5);
            this.UcEmployeeList1.Margin = new System.Windows.Forms.Padding(5);
            this.UcEmployeeList1.Name = "UcEmployeeList1";
            this.UcEmployeeList1.Size = new System.Drawing.Size(670, 427);
            this.UcEmployeeList1.TabIndex = 0;
            // 
            // _infoManagement
            // 
            this._infoManagement.AutomaticDelay = 1000;
            this._infoManagement.AutoPopDelay = 10000;
            this._infoManagement.InitialDelay = 200;
            this._infoManagement.IsBalloon = true;
            this._infoManagement.ReshowDelay = 200;
            this._infoManagement.ToolTipTitle = "Les différents managers";
            // 
            // UcCompanyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcCompanyManagement";
            this.Size = new System.Drawing.Size(1188, 651);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private UcSkillsDisplay UcSkillsDisplay1;
		private UcEmployeeList UcEmployeeList1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label IsBusy;
		private System.Windows.Forms.Label SelectedManagerAffectTitle;
		private System.Windows.Forms.Label IsBusyTitle;
		private System.Windows.Forms.ComboBox SkillsToAffect;
		private System.Windows.Forms.Button AffectManager;
		private System.Windows.Forms.Button DesaffectManager;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ListView managerList;
		private System.Windows.Forms.ColumnHeader managerName;
		private System.Windows.Forms.ColumnHeader managerAge;
		private System.Windows.Forms.ColumnHeader managerUsedSkill;
        private System.Windows.Forms.ColumnHeader managerUsedSkillLevel;
        private System.Windows.Forms.ToolTip _infoManagement;
    }
}
