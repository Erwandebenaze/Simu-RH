namespace SRH.Interface
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveGameButton.Location = new System.Drawing.Point(0, 0);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(999, 44);
            this.SaveGameButton.TabIndex = 0;
            this.SaveGameButton.Text = "Sauvegarder la partie";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewGameButton.Location = new System.Drawing.Point(0, 44);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(999, 44);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "Nouvelle partie";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoadGameButton.Location = new System.Drawing.Point(0, 88);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(999, 44);
            this.LoadGameButton.TabIndex = 3;
            this.LoadGameButton.Text = "Charger une partie";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 599);
            this.Controls.Add(this.LoadGameButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.SaveGameButton);
            this.KeyPreview = true;
            this.Name = "Options";
            this.Text = "Options";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Options_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button LoadGameButton;
        internal System.Windows.Forms.Button SaveGameButton;
    }
}