namespace SRH.Interface
{
    partial class NewGameForm
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
            this._gameNameText = new System.Windows.Forms.TextBox();
            this._ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _gameNameText
            // 
            this._gameNameText.Location = new System.Drawing.Point(63, 12);
            this._gameNameText.Name = "_gameNameText";
            this._gameNameText.Size = new System.Drawing.Size(215, 22);
            this._gameNameText.TabIndex = 0;
            // 
            // _ok
            // 
            this._ok.Location = new System.Drawing.Point(90, 54);
            this._ok.Name = "_ok";
            this._ok.Size = new System.Drawing.Size(91, 38);
            this._ok.TabIndex = 1;
            this._ok.Text = "OK";
            this._ok.UseVisualStyleBackColor = true;
            this._ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // _cancel
            // 
            this._cancel.Location = new System.Drawing.Point(187, 54);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(91, 38);
            this._cancel.TabIndex = 1;
            this._cancel.Text = "Annuler";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewGameForm
            // 
            this.AcceptButton = this._ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(293, 106);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._ok);
            this.Controls.Add(this._gameNameText);
            this.KeyPreview = true;
            this.Name = "NewGameForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _gameNameText;
        private System.Windows.Forms.Button _ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _cancel;
    }
}