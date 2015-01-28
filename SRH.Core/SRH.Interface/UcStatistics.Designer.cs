namespace SRH.Interface
{
    partial class UcStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcStatistics));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._wealthText = new System.Windows.Forms.Label();
            this._nbEmployeeText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._companyNameText = new System.Windows.Forms.Label();
            this._myCompanyLogo = new System.Windows.Forms.PictureBox();
            this._steriaLogo = new System.Windows.Forms.PictureBox();
            this._sopraLogo = new System.Windows.Forms.PictureBox();
            this._capgeminiLogo = new System.Windows.Forms.PictureBox();
            this._atosLogo = new System.Windows.Forms.PictureBox();
            this._altranLogo = new System.Windows.Forms.PictureBox();
            this.ucGraph1 = new SRH.Interface.UcGraph();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._myCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._steriaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._sopraLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._capgeminiLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._atosLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._altranLogo)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.ucGraph1);
            this.splitContainer1.Panel1.Controls.Add(this._wealthText);
            this.splitContainer1.Panel1.Controls.Add(this._nbEmployeeText);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this._companyNameText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._myCompanyLogo);
            this.splitContainer1.Panel2.Controls.Add(this._steriaLogo);
            this.splitContainer1.Panel2.Controls.Add(this._sopraLogo);
            this.splitContainer1.Panel2.Controls.Add(this._capgeminiLogo);
            this.splitContainer1.Panel2.Controls.Add(this._atosLogo);
            this.splitContainer1.Panel2.Controls.Add(this._altranLogo);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 630);
            this.splitContainer1.SplitterDistance = 617;
            this.splitContainer1.TabIndex = 0;
            // 
            // _wealthText
            // 
            this._wealthText.AutoSize = true;
            this._wealthText.Location = new System.Drawing.Point(175, 128);
            this._wealthText.Name = "_wealthText";
            this._wealthText.Size = new System.Drawing.Size(12, 17);
            this._wealthText.TabIndex = 7;
            this._wealthText.Text = " ";
            // 
            // _nbEmployeeText
            // 
            this._nbEmployeeText.AutoSize = true;
            this._nbEmployeeText.Location = new System.Drawing.Point(175, 96);
            this._nbEmployeeText.Name = "_nbEmployeeText";
            this._nbEmployeeText.Size = new System.Drawing.Size(12, 17);
            this._nbEmployeeText.TabIndex = 6;
            this._nbEmployeeText.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fortune : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre d\'employés : ";
            // 
            // _companyNameText
            // 
            this._companyNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._companyNameText.AutoSize = true;
            this._companyNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._companyNameText.Location = new System.Drawing.Point(215, 25);
            this._companyNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._companyNameText.Name = "_companyNameText";
            this._companyNameText.Size = new System.Drawing.Size(146, 25);
            this._companyNameText.TabIndex = 3;
            this._companyNameText.Text = "Nom du projet";
            this._companyNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _myCompanyLogo
            // 
            this._myCompanyLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._myCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("_myCompanyLogo.Image")));
            this._myCompanyLogo.Location = new System.Drawing.Point(172, 256);
            this._myCompanyLogo.Name = "_myCompanyLogo";
            this._myCompanyLogo.Size = new System.Drawing.Size(118, 63);
            this._myCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._myCompanyLogo.TabIndex = 6;
            this._myCompanyLogo.TabStop = false;
            this._myCompanyLogo.Click += new System.EventHandler(this._myCompanyLogo_Click);
            // 
            // _steriaLogo
            // 
            this._steriaLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._steriaLogo.Image = ((System.Drawing.Image)(resources.GetObject("_steriaLogo.Image")));
            this._steriaLogo.Location = new System.Drawing.Point(329, 433);
            this._steriaLogo.Name = "_steriaLogo";
            this._steriaLogo.Size = new System.Drawing.Size(118, 63);
            this._steriaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._steriaLogo.TabIndex = 5;
            this._steriaLogo.TabStop = false;
            this._steriaLogo.Click += new System.EventHandler(this._steriaLogo_Click);
            // 
            // _sopraLogo
            // 
            this._sopraLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._sopraLogo.Image = ((System.Drawing.Image)(resources.GetObject("_sopraLogo.Image")));
            this._sopraLogo.Location = new System.Drawing.Point(43, 433);
            this._sopraLogo.Name = "_sopraLogo";
            this._sopraLogo.Size = new System.Drawing.Size(118, 63);
            this._sopraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._sopraLogo.TabIndex = 4;
            this._sopraLogo.TabStop = false;
            this._sopraLogo.Click += new System.EventHandler(this._sopraLogo_Click);
            // 
            // _capgeminiLogo
            // 
            this._capgeminiLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._capgeminiLogo.Image = ((System.Drawing.Image)(resources.GetObject("_capgeminiLogo.Image")));
            this._capgeminiLogo.Location = new System.Drawing.Point(172, 42);
            this._capgeminiLogo.Name = "_capgeminiLogo";
            this._capgeminiLogo.Size = new System.Drawing.Size(118, 63);
            this._capgeminiLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._capgeminiLogo.TabIndex = 3;
            this._capgeminiLogo.TabStop = false;
            this._capgeminiLogo.Click += new System.EventHandler(this._capgeminiLogo_Click);
            // 
            // _atosLogo
            // 
            this._atosLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._atosLogo.Image = ((System.Drawing.Image)(resources.GetObject("_atosLogo.Image")));
            this._atosLogo.Location = new System.Drawing.Point(358, 231);
            this._atosLogo.Name = "_atosLogo";
            this._atosLogo.Size = new System.Drawing.Size(118, 63);
            this._atosLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._atosLogo.TabIndex = 2;
            this._atosLogo.TabStop = false;
            this._atosLogo.Click += new System.EventHandler(this._atosLogo_Click);
            // 
            // _altranLogo
            // 
            this._altranLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._altranLogo.Image = ((System.Drawing.Image)(resources.GetObject("_altranLogo.Image")));
            this._altranLogo.Location = new System.Drawing.Point(3, 231);
            this._altranLogo.Name = "_altranLogo";
            this._altranLogo.Size = new System.Drawing.Size(118, 63);
            this._altranLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._altranLogo.TabIndex = 1;
            this._altranLogo.TabStop = false;
            this._altranLogo.Click += new System.EventHandler(this._altranLogo_Click);
            // 
            // ucGraph1
            // 
            this.ucGraph1.CurrentComp = null;
            this.ucGraph1.Location = new System.Drawing.Point(37, 201);
            this.ucGraph1.Name = "ucGraph1";
            this.ucGraph1.Size = new System.Drawing.Size(514, 304);
            this.ucGraph1.TabIndex = 8;
            // 
            // UcStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcStatistics";
            this.Size = new System.Drawing.Size(1100, 630);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._myCompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._steriaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._sopraLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._capgeminiLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._atosLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._altranLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox _altranLogo;
        private System.Windows.Forms.PictureBox _steriaLogo;
        private System.Windows.Forms.PictureBox _sopraLogo;
        private System.Windows.Forms.PictureBox _capgeminiLogo;
        private System.Windows.Forms.PictureBox _atosLogo;
        private System.Windows.Forms.PictureBox _myCompanyLogo;
        private System.Windows.Forms.Label _companyNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _nbEmployeeText;
        private System.Windows.Forms.Label _wealthText;
        private UcGraph ucGraph1;
    }
}
