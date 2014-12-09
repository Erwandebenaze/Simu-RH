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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.contractHandlerList = new System.Windows.Forms.ListView();
			this.NameGestionnaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvlGestionnaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.humanResourcesList = new System.Windows.Forms.ListView();
			this.NameRessources = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvlRessources = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.projDirectorList = new System.Windows.Forms.ListView();
			this.NameDirecteurs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvlDirecteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.animationList = new System.Windows.Forms.ListView();
			this.NameAnimation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvlAnimation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.commercialList = new System.Windows.Forms.ListView();
			this.NameCommerciaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvlOfCommerciaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SkillsToAffect = new System.Windows.Forms.ComboBox();
			this.SelectedManagerAffectTitle = new System.Windows.Forms.Label();
			this.Affect_Manager = new System.Windows.Forms.Button();
			this.IsBusyTitle = new System.Windows.Forms.Label();
			this.IsBusy = new System.Windows.Forms.Label();
			this.UcSkillsDisplay1 = new SRH.Interface.UcSkillsDisplay();
			this.UcEmployeeList1 = new SRH.Interface.UcEmployeeList();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.contractHandlerList);
			this.splitContainer1.Panel1.Controls.Add(this.humanResourcesList);
			this.splitContainer1.Panel1.Controls.Add(this.projDirectorList);
			this.splitContainer1.Panel1.Controls.Add(this.animationList);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.commercialList);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.IsBusy);
			this.splitContainer1.Panel2.Controls.Add(this.IsBusyTitle);
			this.splitContainer1.Panel2.Controls.Add(this.Affect_Manager);
			this.splitContainer1.Panel2.Controls.Add(this.SelectedManagerAffectTitle);
			this.splitContainer1.Panel2.Controls.Add(this.SkillsToAffect);
			this.splitContainer1.Panel2.Controls.Add(this.UcSkillsDisplay1);
			this.splitContainer1.Panel2.Controls.Add(this.UcEmployeeList1);
			this.splitContainer1.Size = new System.Drawing.Size(825, 512);
			this.splitContainer1.SplitterDistance = 348;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 0;
			// 
			// contractHandlerList
			// 
			this.contractHandlerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameGestionnaire,
            this.lvlGestionnaire});
			this.contractHandlerList.Location = new System.Drawing.Point(2, 436);
			this.contractHandlerList.Margin = new System.Windows.Forms.Padding(2);
			this.contractHandlerList.Name = "contractHandlerList";
			this.contractHandlerList.Size = new System.Drawing.Size(346, 80);
			this.contractHandlerList.TabIndex = 14;
			this.contractHandlerList.UseCompatibleStateImageBehavior = false;
			this.contractHandlerList.View = System.Windows.Forms.View.Details;
			// 
			// NameGestionnaire
			// 
			this.NameGestionnaire.Text = "Nom";
			this.NameGestionnaire.Width = 104;
			// 
			// lvlGestionnaire
			// 
			this.lvlGestionnaire.Text = "Niveau de la compétence";
			this.lvlGestionnaire.Width = 184;
			// 
			// humanResourcesList
			// 
			this.humanResourcesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameRessources,
            this.lvlRessources});
			this.humanResourcesList.Location = new System.Drawing.Point(3, 338);
			this.humanResourcesList.Margin = new System.Windows.Forms.Padding(2);
			this.humanResourcesList.Name = "humanResourcesList";
			this.humanResourcesList.Size = new System.Drawing.Size(345, 80);
			this.humanResourcesList.TabIndex = 13;
			this.humanResourcesList.UseCompatibleStateImageBehavior = false;
			this.humanResourcesList.View = System.Windows.Forms.View.Details;
			// 
			// NameRessources
			// 
			this.NameRessources.Text = "Nom";
			this.NameRessources.Width = 104;
			// 
			// lvlRessources
			// 
			this.lvlRessources.Text = "Niveau de la compétence";
			this.lvlRessources.Width = 184;
			// 
			// projDirectorList
			// 
			this.projDirectorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameDirecteurs,
            this.lvlDirecteur});
			this.projDirectorList.Location = new System.Drawing.Point(2, 231);
			this.projDirectorList.Margin = new System.Windows.Forms.Padding(2);
			this.projDirectorList.Name = "projDirectorList";
			this.projDirectorList.Size = new System.Drawing.Size(346, 80);
			this.projDirectorList.TabIndex = 12;
			this.projDirectorList.UseCompatibleStateImageBehavior = false;
			this.projDirectorList.View = System.Windows.Forms.View.Details;
			// 
			// NameDirecteurs
			// 
			this.NameDirecteurs.Text = "Nom";
			this.NameDirecteurs.Width = 104;
			// 
			// lvlDirecteur
			// 
			this.lvlDirecteur.Text = "Niveau de la compétence";
			this.lvlDirecteur.Width = 184;
			// 
			// animationList
			// 
			this.animationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameAnimation,
            this.lvlAnimation});
			this.animationList.Location = new System.Drawing.Point(2, 125);
			this.animationList.Margin = new System.Windows.Forms.Padding(2);
			this.animationList.Name = "animationList";
			this.animationList.Size = new System.Drawing.Size(345, 80);
			this.animationList.TabIndex = 11;
			this.animationList.UseCompatibleStateImageBehavior = false;
			this.animationList.View = System.Windows.Forms.View.Details;
			// 
			// NameAnimation
			// 
			this.NameAnimation.Text = "Nom";
			this.NameAnimation.Width = 104;
			// 
			// lvlAnimation
			// 
			this.lvlAnimation.Text = "Niveau de la compétence";
			this.lvlAnimation.Width = 184;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(124, 419);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Gestionnaires de contrats";
			// 
			// commercialList
			// 
			this.commercialList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCommerciaux,
            this.lvlOfCommerciaux});
			this.commercialList.Location = new System.Drawing.Point(3, 16);
			this.commercialList.Margin = new System.Windows.Forms.Padding(2);
			this.commercialList.Name = "commercialList";
			this.commercialList.Size = new System.Drawing.Size(345, 80);
			this.commercialList.TabIndex = 5;
			this.commercialList.UseCompatibleStateImageBehavior = false;
			this.commercialList.View = System.Windows.Forms.View.Details;
			// 
			// NameCommerciaux
			// 
			this.NameCommerciaux.Text = "Nom";
			this.NameCommerciaux.Width = 104;
			// 
			// lvlOfCommerciaux
			// 
			this.lvlOfCommerciaux.Text = "Niveau de la compétence";
			this.lvlOfCommerciaux.Width = 184;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(124, 214);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Directeurs de projets";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(105, 109);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Membres du comité d\'entreprise";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(104, 322);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Directeurs ressources humaines";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(134, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Commerciaux";
			// 
			// SkillsToAffect
			// 
			this.SkillsToAffect.FormattingEnabled = true;
			this.SkillsToAffect.Location = new System.Drawing.Point(154, 436);
			this.SkillsToAffect.Name = "SkillsToAffect";
			this.SkillsToAffect.Size = new System.Drawing.Size(213, 21);
			this.SkillsToAffect.TabIndex = 2;
			this.SkillsToAffect.Visible = false;
			this.SkillsToAffect.SelectedIndexChanged += new System.EventHandler(this.SkillsToAffect_SelectedIndexChanged);
			// 
			// SelectedManagerAffectTitle
			// 
			this.SelectedManagerAffectTitle.AutoSize = true;
			this.SelectedManagerAffectTitle.Location = new System.Drawing.Point(33, 439);
			this.SelectedManagerAffectTitle.Name = "SelectedManagerAffectTitle";
			this.SelectedManagerAffectTitle.Size = new System.Drawing.Size(115, 13);
			this.SelectedManagerAffectTitle.TabIndex = 3;
			this.SelectedManagerAffectTitle.Text = "Compétence à affecter";
			this.SelectedManagerAffectTitle.Visible = false;
			// 
			// Affect_Manager
			// 
			this.Affect_Manager.Enabled = false;
			this.Affect_Manager.Location = new System.Drawing.Point(382, 434);
			this.Affect_Manager.Name = "Affect_Manager";
			this.Affect_Manager.Size = new System.Drawing.Size(75, 23);
			this.Affect_Manager.TabIndex = 4;
			this.Affect_Manager.Text = "Affecter";
			this.Affect_Manager.UseVisualStyleBackColor = true;
			this.Affect_Manager.Visible = false;
			this.Affect_Manager.Click += new System.EventHandler(this.Affect_Manager_Click);
			// 
			// IsBusyTitle
			// 
			this.IsBusyTitle.AutoSize = true;
			this.IsBusyTitle.Location = new System.Drawing.Point(36, 483);
			this.IsBusyTitle.Name = "IsBusyTitle";
			this.IsBusyTitle.Size = new System.Drawing.Size(51, 13);
			this.IsBusyTitle.TabIndex = 5;
			this.IsBusyTitle.Text = "Occupé :";
			this.IsBusyTitle.Visible = false;
			// 
			// IsBusy
			// 
			this.IsBusy.AutoSize = true;
			this.IsBusy.Location = new System.Drawing.Point(93, 483);
			this.IsBusy.Name = "IsBusy";
			this.IsBusy.Size = new System.Drawing.Size(14, 13);
			this.IsBusy.TabIndex = 6;
			this.IsBusy.Text = "X";
			this.IsBusy.Visible = false;
			// 
			// UcSkillsDisplay1
			// 
			this.UcSkillsDisplay1.CurrentPerson = null;
			this.UcSkillsDisplay1.Location = new System.Drawing.Point(25, 280);
			this.UcSkillsDisplay1.Name = "UcSkillsDisplay1";
			this.UcSkillsDisplay1.Size = new System.Drawing.Size(437, 138);
			this.UcSkillsDisplay1.TabIndex = 1;
			// 
			// UcEmployeeList1
			// 
			this.UcEmployeeList1.Location = new System.Drawing.Point(25, 30);
			this.UcEmployeeList1.Name = "UcEmployeeList1";
			this.UcEmployeeList1.Size = new System.Drawing.Size(432, 249);
			this.UcEmployeeList1.TabIndex = 0;
			// 
			// UcCompanyManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UcCompanyManagement";
			this.Size = new System.Drawing.Size(825, 512);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView commercialList;
        private System.Windows.Forms.ListView contractHandlerList;
        private System.Windows.Forms.ColumnHeader NameGestionnaire;
        private System.Windows.Forms.ColumnHeader lvlGestionnaire;
        private System.Windows.Forms.ListView humanResourcesList;
        private System.Windows.Forms.ColumnHeader NameRessources;
        private System.Windows.Forms.ColumnHeader lvlRessources;
        private System.Windows.Forms.ListView projDirectorList;
        private System.Windows.Forms.ColumnHeader NameDirecteurs;
        private System.Windows.Forms.ColumnHeader lvlDirecteur;
        private System.Windows.Forms.ListView animationList;
        private System.Windows.Forms.ColumnHeader NameAnimation;
        private System.Windows.Forms.ColumnHeader lvlAnimation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader NameCommerciaux;
        private System.Windows.Forms.ColumnHeader lvlOfCommerciaux;
		private UcSkillsDisplay UcSkillsDisplay1;
		private UcEmployeeList UcEmployeeList1;
		private System.Windows.Forms.ComboBox SkillsToAffect;
		private System.Windows.Forms.Button Affect_Manager;
		private System.Windows.Forms.Label IsBusy;
		private System.Windows.Forms.Label IsBusyTitle;
		private System.Windows.Forms.Label SelectedManagerAffectTitle;
    }
}
