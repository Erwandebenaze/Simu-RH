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
            this._saveGameButton = new System.Windows.Forms.Button();
            this._newGameButton = new System.Windows.Forms.Button();
            this._loadGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _saveGameButton
            // 
            this._saveGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._saveGameButton.Location = new System.Drawing.Point(0, 0);
            this._saveGameButton.Name = "_saveGameButton";
            this._saveGameButton.Size = new System.Drawing.Size(999, 44);
            this._saveGameButton.TabIndex = 0;
            this._saveGameButton.Text = "Sauvegarder la partie";
            this._saveGameButton.UseVisualStyleBackColor = true;
            this._saveGameButton.Click += new System.EventHandler(this.button1_Click);
            this._saveGameButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // _newGameButton
            // 
            this._newGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._newGameButton.Location = new System.Drawing.Point(0, 44);
            this._newGameButton.Name = "_newGameButton";
            this._newGameButton.Size = new System.Drawing.Size(999, 44);
            this._newGameButton.TabIndex = 2;
            this._newGameButton.Text = "Nouvelle partie";
            this._newGameButton.UseVisualStyleBackColor = true;
            // 
            // _loadGameButton
            // 
            this._loadGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this._loadGameButton.Location = new System.Drawing.Point(0, 88);
            this._loadGameButton.Name = "_loadGameButton";
            this._loadGameButton.Size = new System.Drawing.Size(999, 44);
            this._loadGameButton.TabIndex = 3;
            this._loadGameButton.Text = "Charger une partie";
            this._loadGameButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 599);
            this.Controls.Add(this._loadGameButton);
            this.Controls.Add(this._newGameButton);
            this.Controls.Add(this._saveGameButton);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _saveGameButton;
        private System.Windows.Forms.Button _newGameButton;
        private System.Windows.Forms.Button _loadGameButton;
    }
}