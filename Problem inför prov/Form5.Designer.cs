
namespace Problem_inför_prov
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.SlotImages = new System.Windows.Forms.ImageList(this.components);
            this.BttnPull = new System.Windows.Forms.Button();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Slot2 = new System.Windows.Forms.PictureBox();
            this.Slot3 = new System.Windows.Forms.PictureBox();
            this.Slot1Timer = new System.Windows.Forms.Timer(this.components);
            this.Slot2Timer = new System.Windows.Forms.Timer(this.components);
            this.Slot3Timer = new System.Windows.Forms.Timer(this.components);
            this.KeepSlot1 = new System.Windows.Forms.CheckBox();
            this.KeepSlot2 = new System.Windows.Forms.CheckBox();
            this.KeepSlot3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).BeginInit();
            this.SuspendLayout();
            // 
            // SlotImages
            // 
            this.SlotImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SlotImages.ImageStream")));
            this.SlotImages.TransparentColor = System.Drawing.Color.Transparent;
            this.SlotImages.Images.SetKeyName(0, "banana.png");
            this.SlotImages.Images.SetKeyName(1, "diamond.jpg");
            this.SlotImages.Images.SetKeyName(2, "lemon.png");
            this.SlotImages.Images.SetKeyName(3, "raspberry.jpg");
            this.SlotImages.Images.SetKeyName(4, "seven.jpg");
            this.SlotImages.Images.SetKeyName(5, "watermelon.png");
            // 
            // BttnPull
            // 
            this.BttnPull.Location = new System.Drawing.Point(189, 146);
            this.BttnPull.Name = "BttnPull";
            this.BttnPull.Size = new System.Drawing.Size(75, 23);
            this.BttnPull.TabIndex = 0;
            this.BttnPull.Text = "button1";
            this.BttnPull.UseVisualStyleBackColor = true;
            this.BttnPull.Click += new System.EventHandler(this.BttnPull_Click);
            // 
            // Slot1
            // 
            this.Slot1.Location = new System.Drawing.Point(293, 108);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(100, 100);
            this.Slot1.TabIndex = 1;
            this.Slot1.TabStop = false;
            // 
            // Slot2
            // 
            this.Slot2.Location = new System.Drawing.Point(419, 108);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(100, 100);
            this.Slot2.TabIndex = 2;
            this.Slot2.TabStop = false;
            // 
            // Slot3
            // 
            this.Slot3.Location = new System.Drawing.Point(543, 108);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(100, 100);
            this.Slot3.TabIndex = 3;
            this.Slot3.TabStop = false;
            // 
            // Slot1Timer
            // 
            this.Slot1Timer.Tick += new System.EventHandler(this.SlotTimer_Tick);
            // 
            // Slot2Timer
            // 
            this.Slot2Timer.Tick += new System.EventHandler(this.Slot2Timer_Tick);
            // 
            // Slot3Timer
            // 
            this.Slot3Timer.Tick += new System.EventHandler(this.Slot3Timer_Tick);
            // 
            // KeepSlot1
            // 
            this.KeepSlot1.AutoSize = true;
            this.KeepSlot1.Location = new System.Drawing.Point(293, 228);
            this.KeepSlot1.Name = "KeepSlot1";
            this.KeepSlot1.Size = new System.Drawing.Size(80, 17);
            this.KeepSlot1.TabIndex = 4;
            this.KeepSlot1.Text = "checkBox1";
            this.KeepSlot1.UseVisualStyleBackColor = true;
            // 
            // KeepSlot2
            // 
            this.KeepSlot2.AutoSize = true;
            this.KeepSlot2.Location = new System.Drawing.Point(419, 228);
            this.KeepSlot2.Name = "KeepSlot2";
            this.KeepSlot2.Size = new System.Drawing.Size(80, 17);
            this.KeepSlot2.TabIndex = 5;
            this.KeepSlot2.Text = "checkBox2";
            this.KeepSlot2.UseVisualStyleBackColor = true;
            // 
            // KeepSlot3
            // 
            this.KeepSlot3.AutoSize = true;
            this.KeepSlot3.Location = new System.Drawing.Point(543, 228);
            this.KeepSlot3.Name = "KeepSlot3";
            this.KeepSlot3.Size = new System.Drawing.Size(80, 17);
            this.KeepSlot3.TabIndex = 6;
            this.KeepSlot3.Text = "checkBox3";
            this.KeepSlot3.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeepSlot3);
            this.Controls.Add(this.KeepSlot2);
            this.Controls.Add(this.KeepSlot1);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot1);
            this.Controls.Add(this.BttnPull);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList SlotImages;
        private System.Windows.Forms.Button BttnPull;
        private System.Windows.Forms.PictureBox Slot1;
        private System.Windows.Forms.PictureBox Slot2;
        private System.Windows.Forms.PictureBox Slot3;
        private System.Windows.Forms.Timer Slot1Timer;
        private System.Windows.Forms.Timer Slot2Timer;
        private System.Windows.Forms.Timer Slot3Timer;
        private System.Windows.Forms.CheckBox KeepSlot1;
        private System.Windows.Forms.CheckBox KeepSlot2;
        private System.Windows.Forms.CheckBox KeepSlot3;
    }
}