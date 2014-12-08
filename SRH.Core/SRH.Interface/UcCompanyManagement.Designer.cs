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
            this.gestionnairesContratsList = new System.Windows.Forms.ListView();
            this.NameGestionnaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlGestionnaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ressourcesHumainesList = new System.Windows.Forms.ListView();
            this.NameRessources = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlRessources = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directeurProjetsList = new System.Windows.Forms.ListView();
            this.NameDirecteurs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlDirecteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.animationList = new System.Windows.Forms.ListView();
            this.NameAnimation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlAnimation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.commerciauxList = new System.Windows.Forms.ListView();
            this.NameCommerciaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlOfCommerciaux = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gestionnairesContratsList);
            this.splitContainer1.Panel1.Controls.Add(this.ressourcesHumainesList);
            this.splitContainer1.Panel1.Controls.Add(this.directeurProjetsList);
            this.splitContainer1.Panel1.Controls.Add(this.animationList);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.commerciauxList);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 630);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 0;
            // 
            // gestionnairesContratsList
            // 
            this.gestionnairesContratsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameGestionnaire,
            this.lvlGestionnaire});
            this.gestionnairesContratsList.Location = new System.Drawing.Point(3, 536);
            this.gestionnairesContratsList.Name = "gestionnairesContratsList";
            this.gestionnairesContratsList.Size = new System.Drawing.Size(460, 97);
            this.gestionnairesContratsList.TabIndex = 14;
            this.gestionnairesContratsList.UseCompatibleStateImageBehavior = false;
            this.gestionnairesContratsList.View = System.Windows.Forms.View.Details;
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
            // ressourcesHumainesList
            // 
            this.ressourcesHumainesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameRessources,
            this.lvlRessources});
            this.ressourcesHumainesList.Location = new System.Drawing.Point(4, 416);
            this.ressourcesHumainesList.Name = "ressourcesHumainesList";
            this.ressourcesHumainesList.Size = new System.Drawing.Size(459, 97);
            this.ressourcesHumainesList.TabIndex = 13;
            this.ressourcesHumainesList.UseCompatibleStateImageBehavior = false;
            this.ressourcesHumainesList.View = System.Windows.Forms.View.Details;
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
            // directeurProjetsList
            // 
            this.directeurProjetsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameDirecteurs,
            this.lvlDirecteur});
            this.directeurProjetsList.Location = new System.Drawing.Point(3, 284);
            this.directeurProjetsList.Name = "directeurProjetsList";
            this.directeurProjetsList.Size = new System.Drawing.Size(460, 97);
            this.directeurProjetsList.TabIndex = 12;
            this.directeurProjetsList.UseCompatibleStateImageBehavior = false;
            this.directeurProjetsList.View = System.Windows.Forms.View.Details;
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
            this.animationList.Location = new System.Drawing.Point(3, 154);
            this.animationList.Name = "animationList";
            this.animationList.Size = new System.Drawing.Size(459, 97);
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
            this.label2.Location = new System.Drawing.Point(166, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestionnaires de contrats";
            // 
            // commerciauxList
            // 
            this.commerciauxList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCommerciaux,
            this.lvlOfCommerciaux});
            this.commerciauxList.Location = new System.Drawing.Point(4, 20);
            this.commerciauxList.Name = "commerciauxList";
            this.commerciauxList.Size = new System.Drawing.Size(459, 97);
            this.commerciauxList.TabIndex = 5;
            this.commerciauxList.UseCompatibleStateImageBehavior = false;
            this.commerciauxList.View = System.Windows.Forms.View.Details;
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
            this.label5.Location = new System.Drawing.Point(166, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Directeurs de projets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Membres du comité d\'entreprise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Directeurs ressources humaines";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commerciaux";
            // 
            // UcCompanyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcCompanyManagement";
            this.Size = new System.Drawing.Size(1100, 630);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
        private System.Windows.Forms.ListView commerciauxList;
        private System.Windows.Forms.ListView gestionnairesContratsList;
        private System.Windows.Forms.ColumnHeader NameGestionnaire;
        private System.Windows.Forms.ColumnHeader lvlGestionnaire;
        private System.Windows.Forms.ListView ressourcesHumainesList;
        private System.Windows.Forms.ColumnHeader NameRessources;
        private System.Windows.Forms.ColumnHeader lvlRessources;
        private System.Windows.Forms.ListView directeurProjetsList;
        private System.Windows.Forms.ColumnHeader NameDirecteurs;
        private System.Windows.Forms.ColumnHeader lvlDirecteur;
        private System.Windows.Forms.ListView animationList;
        private System.Windows.Forms.ColumnHeader NameAnimation;
        private System.Windows.Forms.ColumnHeader lvlAnimation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader NameCommerciaux;
        private System.Windows.Forms.ColumnHeader lvlOfCommerciaux;
    }
}
