
namespace Problem_inför_prov
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputPlaintextTbox = new System.Windows.Forms.TextBox();
            this.OutputEncryptedTbox = new System.Windows.Forms.TextBox();
            this.InputEncryptedTbox = new System.Windows.Forms.TextBox();
            this.OutputPlaintextTbox = new System.Windows.Forms.TextBox();
            this.InputPlaintextLabel = new System.Windows.Forms.Label();
            this.InputEncryptedLabel = new System.Windows.Forms.Label();
            this.OutputEncryptedLabel = new System.Windows.Forms.Label();
            this.OutputPlaintextLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.KeyTextbox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputPlaintextTbox
            // 
            this.InputPlaintextTbox.Location = new System.Drawing.Point(117, 142);
            this.InputPlaintextTbox.Name = "InputPlaintextTbox";
            this.InputPlaintextTbox.Size = new System.Drawing.Size(100, 20);
            this.InputPlaintextTbox.TabIndex = 0;
            // 
            // OutputEncryptedTbox
            // 
            this.OutputEncryptedTbox.Location = new System.Drawing.Point(470, 143);
            this.OutputEncryptedTbox.Name = "OutputEncryptedTbox";
            this.OutputEncryptedTbox.Size = new System.Drawing.Size(100, 20);
            this.OutputEncryptedTbox.TabIndex = 1;
            // 
            // InputEncryptedTbox
            // 
            this.InputEncryptedTbox.Location = new System.Drawing.Point(117, 231);
            this.InputEncryptedTbox.Name = "InputEncryptedTbox";
            this.InputEncryptedTbox.Size = new System.Drawing.Size(100, 20);
            this.InputEncryptedTbox.TabIndex = 2;
            // 
            // OutputPlaintextTbox
            // 
            this.OutputPlaintextTbox.Location = new System.Drawing.Point(470, 234);
            this.OutputPlaintextTbox.Name = "OutputPlaintextTbox";
            this.OutputPlaintextTbox.Size = new System.Drawing.Size(100, 20);
            this.OutputPlaintextTbox.TabIndex = 3;
            // 
            // InputPlaintextLabel
            // 
            this.InputPlaintextLabel.AutoSize = true;
            this.InputPlaintextLabel.Location = new System.Drawing.Point(114, 121);
            this.InputPlaintextLabel.Name = "InputPlaintextLabel";
            this.InputPlaintextLabel.Size = new System.Drawing.Size(35, 13);
            this.InputPlaintextLabel.TabIndex = 4;
            this.InputPlaintextLabel.Text = "label1";
            // 
            // InputEncryptedLabel
            // 
            this.InputEncryptedLabel.AutoSize = true;
            this.InputEncryptedLabel.Location = new System.Drawing.Point(114, 215);
            this.InputEncryptedLabel.Name = "InputEncryptedLabel";
            this.InputEncryptedLabel.Size = new System.Drawing.Size(35, 13);
            this.InputEncryptedLabel.TabIndex = 5;
            this.InputEncryptedLabel.Text = "label2";
            // 
            // OutputEncryptedLabel
            // 
            this.OutputEncryptedLabel.AutoSize = true;
            this.OutputEncryptedLabel.Location = new System.Drawing.Point(467, 121);
            this.OutputEncryptedLabel.Name = "OutputEncryptedLabel";
            this.OutputEncryptedLabel.Size = new System.Drawing.Size(35, 13);
            this.OutputEncryptedLabel.TabIndex = 6;
            this.OutputEncryptedLabel.Text = "label3";
            // 
            // OutputPlaintextLabel
            // 
            this.OutputPlaintextLabel.AutoSize = true;
            this.OutputPlaintextLabel.Location = new System.Drawing.Point(467, 215);
            this.OutputPlaintextLabel.Name = "OutputPlaintextLabel";
            this.OutputPlaintextLabel.Size = new System.Drawing.Size(35, 13);
            this.OutputPlaintextLabel.TabIndex = 7;
            this.OutputPlaintextLabel.Text = "label4";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(333, 140);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "button1";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(333, 231);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "button1";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // KeyTextbox
            // 
            this.KeyTextbox.Location = new System.Drawing.Point(317, 87);
            this.KeyTextbox.Name = "KeyTextbox";
            this.KeyTextbox.Size = new System.Drawing.Size(100, 20);
            this.KeyTextbox.TabIndex = 10;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(317, 68);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(35, 13);
            this.KeyLabel.TabIndex = 11;
            this.KeyLabel.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyTextbox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.OutputPlaintextLabel);
            this.Controls.Add(this.OutputEncryptedLabel);
            this.Controls.Add(this.InputEncryptedLabel);
            this.Controls.Add(this.InputPlaintextLabel);
            this.Controls.Add(this.OutputPlaintextTbox);
            this.Controls.Add(this.InputEncryptedTbox);
            this.Controls.Add(this.OutputEncryptedTbox);
            this.Controls.Add(this.InputPlaintextTbox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputPlaintextTbox;
        private System.Windows.Forms.TextBox OutputEncryptedTbox;
        private System.Windows.Forms.TextBox InputEncryptedTbox;
        private System.Windows.Forms.TextBox OutputPlaintextTbox;
        private System.Windows.Forms.Label InputPlaintextLabel;
        private System.Windows.Forms.Label InputEncryptedLabel;
        private System.Windows.Forms.Label OutputEncryptedLabel;
        private System.Windows.Forms.Label OutputPlaintextLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox KeyTextbox;
        private System.Windows.Forms.Label KeyLabel;
    }
}