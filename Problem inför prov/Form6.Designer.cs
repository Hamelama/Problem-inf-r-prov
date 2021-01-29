
namespace Problem_inför_prov
{
    partial class Form6
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
            this.TboxName = new System.Windows.Forms.TextBox();
            this.TboxResult = new System.Windows.Forms.TextBox();
            this.TboxGrade = new System.Windows.Forms.TextBox();
            this.BttnEnter = new System.Windows.Forms.Button();
            this.BttnForward = new System.Windows.Forms.Button();
            this.BttnBackward = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TboxName
            // 
            this.TboxName.Location = new System.Drawing.Point(197, 97);
            this.TboxName.Name = "TboxName";
            this.TboxName.Size = new System.Drawing.Size(100, 20);
            this.TboxName.TabIndex = 0;
            // 
            // TboxResult
            // 
            this.TboxResult.Location = new System.Drawing.Point(197, 150);
            this.TboxResult.Name = "TboxResult";
            this.TboxResult.Size = new System.Drawing.Size(100, 20);
            this.TboxResult.TabIndex = 1;
            // 
            // TboxGrade
            // 
            this.TboxGrade.Location = new System.Drawing.Point(197, 203);
            this.TboxGrade.Name = "TboxGrade";
            this.TboxGrade.Size = new System.Drawing.Size(100, 20);
            this.TboxGrade.TabIndex = 2;
            // 
            // BttnEnter
            // 
            this.BttnEnter.Location = new System.Drawing.Point(338, 97);
            this.BttnEnter.Name = "BttnEnter";
            this.BttnEnter.Size = new System.Drawing.Size(75, 23);
            this.BttnEnter.TabIndex = 3;
            this.BttnEnter.Text = "button1";
            this.BttnEnter.UseVisualStyleBackColor = true;
            this.BttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            // 
            // BttnForward
            // 
            this.BttnForward.Location = new System.Drawing.Point(338, 148);
            this.BttnForward.Name = "BttnForward";
            this.BttnForward.Size = new System.Drawing.Size(75, 23);
            this.BttnForward.TabIndex = 4;
            this.BttnForward.Text = "button2";
            this.BttnForward.UseVisualStyleBackColor = true;
            this.BttnForward.Click += new System.EventHandler(this.BttnForward_Click);
            // 
            // BttnBackward
            // 
            this.BttnBackward.Location = new System.Drawing.Point(338, 177);
            this.BttnBackward.Name = "BttnBackward";
            this.BttnBackward.Size = new System.Drawing.Size(75, 23);
            this.BttnBackward.TabIndex = 5;
            this.BttnBackward.Text = "button3";
            this.BttnBackward.UseVisualStyleBackColor = true;
            this.BttnBackward.Click += new System.EventHandler(this.BttnBackward_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(194, 81);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "label1";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(194, 134);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(35, 13);
            this.LabelResult.TabIndex = 7;
            this.LabelResult.Text = "label2";
            // 
            // LabelGrade
            // 
            this.LabelGrade.AutoSize = true;
            this.LabelGrade.Location = new System.Drawing.Point(194, 187);
            this.LabelGrade.Name = "LabelGrade";
            this.LabelGrade.Size = new System.Drawing.Size(35, 13);
            this.LabelGrade.TabIndex = 8;
            this.LabelGrade.Text = "label3";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelGrade);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.BttnBackward);
            this.Controls.Add(this.BttnForward);
            this.Controls.Add(this.BttnEnter);
            this.Controls.Add(this.TboxGrade);
            this.Controls.Add(this.TboxResult);
            this.Controls.Add(this.TboxName);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TboxName;
        private System.Windows.Forms.TextBox TboxResult;
        private System.Windows.Forms.TextBox TboxGrade;
        private System.Windows.Forms.Button BttnEnter;
        private System.Windows.Forms.Button BttnForward;
        private System.Windows.Forms.Button BttnBackward;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label LabelGrade;
    }
}