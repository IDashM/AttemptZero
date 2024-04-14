namespace AttemptZero
{
    partial class DriverUI
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
            this.LogOUT = new System.Windows.Forms.Button();
            this.ChecksDriverIsOn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LogOUT
            // 
            this.LogOUT.Location = new System.Drawing.Point(696, 12);
            this.LogOUT.Name = "LogOUT";
            this.LogOUT.Size = new System.Drawing.Size(75, 23);
            this.LogOUT.TabIndex = 0;
            this.LogOUT.Text = "LogOut";
            this.LogOUT.UseVisualStyleBackColor = true;
            this.LogOUT.Click += new System.EventHandler(this.LogOUT_Click);
            // 
            // ChecksDriverIsOn
            // 
            this.ChecksDriverIsOn.Location = new System.Drawing.Point(1, 1);
            this.ChecksDriverIsOn.Name = "ChecksDriverIsOn";
            this.ChecksDriverIsOn.Size = new System.Drawing.Size(16, 10);
            this.ChecksDriverIsOn.TabIndex = 1;
            // 
            // DriverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChecksDriverIsOn);
            this.Controls.Add(this.LogOUT);
            this.Name = "DriverUI";
            this.Text = "DriverUI";
            this.Load += new System.EventHandler(this.DriverUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOUT;
        private System.Windows.Forms.Panel ChecksDriverIsOn;
    }
}