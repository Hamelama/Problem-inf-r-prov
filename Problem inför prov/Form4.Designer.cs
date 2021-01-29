
namespace Problem_inför_prov
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.ButtonRandomize = new System.Windows.Forms.Button();
            this.TboxRandom = new System.Windows.Forms.TextBox();
            this.TimerRandom = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButtonRandomize
            // 
            this.ButtonRandomize.Location = new System.Drawing.Point(260, 138);
            this.ButtonRandomize.Name = "ButtonRandomize";
            this.ButtonRandomize.Size = new System.Drawing.Size(75, 23);
            this.ButtonRandomize.TabIndex = 0;
            this.ButtonRandomize.Text = "button1";
            this.ButtonRandomize.UseVisualStyleBackColor = true;
            this.ButtonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
            // 
            // TboxRandom
            // 
            this.TboxRandom.Location = new System.Drawing.Point(356, 141);
            this.TboxRandom.Name = "TboxRandom";
            this.TboxRandom.Size = new System.Drawing.Size(100, 20);
            this.TboxRandom.TabIndex = 1;
            // 
            // TimerRandom
            // 
            this.TimerRandom.Tick += new System.EventHandler(this.TimerRandom_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TboxRandom);
            this.Controls.Add(this.ButtonRandomize);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRandomize;
        private System.Windows.Forms.TextBox TboxRandom;
        private System.Windows.Forms.Timer TimerRandom;
    }
}