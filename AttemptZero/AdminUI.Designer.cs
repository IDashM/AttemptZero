namespace AttemptZero
{
    partial class AdminUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminDashboardlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminDashboard_Panel = new System.Windows.Forms.Panel();
            this.AdminDashboard_btn = new System.Windows.Forms.Button();
            this.AddDriver_Panel = new System.Windows.Forms.Panel();
            this.AddDriver_btn = new System.Windows.Forms.Button();
            this.RecentOrder_Panel = new System.Windows.Forms.Panel();
            this.RecentOrder_btn = new System.Windows.Forms.Button();
            this.UserManagement_Panel = new System.Windows.Forms.Panel();
            this.UserManagement_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.AdminDashboard_Panel.SuspendLayout();
            this.AddDriver_Panel.SuspendLayout();
            this.RecentOrder_Panel.SuspendLayout();
            this.UserManagement_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.AdminDashboardlabel);
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 47);
            this.panel1.TabIndex = 0;
            // 
            // AdminDashboardlabel
            // 
            this.AdminDashboardlabel.AutoSize = true;
            this.AdminDashboardlabel.BackColor = System.Drawing.Color.LimeGreen;
            this.AdminDashboardlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdminDashboardlabel.Location = new System.Drawing.Point(271, 9);
            this.AdminDashboardlabel.Name = "AdminDashboardlabel";
            this.AdminDashboardlabel.Size = new System.Drawing.Size(230, 31);
            this.AdminDashboardlabel.TabIndex = 0;
            this.AdminDashboardlabel.Text = "Admin Dashboard";
            this.AdminDashboardlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(944, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.UserManagement_Panel);
            this.panel3.Controls.Add(this.RecentOrder_Panel);
            this.panel3.Controls.Add(this.AddDriver_Panel);
            this.panel3.Controls.Add(this.AdminDashboard_Panel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 450);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // AdminDashboard_Panel
            // 
            this.AdminDashboard_Panel.BackColor = System.Drawing.Color.Transparent;
            this.AdminDashboard_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminDashboard_Panel.Controls.Add(this.AdminDashboard_btn);
            this.AdminDashboard_Panel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdminDashboard_Panel.Location = new System.Drawing.Point(3, 56);
            this.AdminDashboard_Panel.Name = "AdminDashboard_Panel";
            this.AdminDashboard_Panel.Size = new System.Drawing.Size(133, 58);
            this.AdminDashboard_Panel.TabIndex = 1;
            // 
            // AdminDashboard_btn
            // 
            this.AdminDashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.AdminDashboard_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdminDashboard_btn.Location = new System.Drawing.Point(0, 0);
            this.AdminDashboard_btn.Name = "AdminDashboard_btn";
            this.AdminDashboard_btn.Size = new System.Drawing.Size(133, 58);
            this.AdminDashboard_btn.TabIndex = 0;
            this.AdminDashboard_btn.Text = "Dashboard";
            this.AdminDashboard_btn.UseVisualStyleBackColor = false;
            // 
            // AddDriver_Panel
            // 
            this.AddDriver_Panel.Controls.Add(this.AddDriver_btn);
            this.AddDriver_Panel.Location = new System.Drawing.Point(3, 120);
            this.AddDriver_Panel.Name = "AddDriver_Panel";
            this.AddDriver_Panel.Size = new System.Drawing.Size(133, 41);
            this.AddDriver_Panel.TabIndex = 2;
            // 
            // AddDriver_btn
            // 
            this.AddDriver_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDriver_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddDriver_btn.Location = new System.Drawing.Point(0, 0);
            this.AddDriver_btn.Name = "AddDriver_btn";
            this.AddDriver_btn.Size = new System.Drawing.Size(133, 41);
            this.AddDriver_btn.TabIndex = 0;
            this.AddDriver_btn.Text = "ADD Driver";
            this.AddDriver_btn.UseVisualStyleBackColor = true;
            this.AddDriver_btn.Click += new System.EventHandler(this.AddDriver_btn_Click);
            // 
            // RecentOrder_Panel
            // 
            this.RecentOrder_Panel.Controls.Add(this.RecentOrder_btn);
            this.RecentOrder_Panel.Location = new System.Drawing.Point(3, 167);
            this.RecentOrder_Panel.Name = "RecentOrder_Panel";
            this.RecentOrder_Panel.Size = new System.Drawing.Size(133, 41);
            this.RecentOrder_Panel.TabIndex = 3;
            // 
            // RecentOrder_btn
            // 
            this.RecentOrder_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RecentOrder_btn.Location = new System.Drawing.Point(0, 0);
            this.RecentOrder_btn.Name = "RecentOrder_btn";
            this.RecentOrder_btn.Size = new System.Drawing.Size(133, 41);
            this.RecentOrder_btn.TabIndex = 0;
            this.RecentOrder_btn.Text = "Recent Order";
            this.RecentOrder_btn.UseVisualStyleBackColor = true;
            // 
            // UserManagement_Panel
            // 
            this.UserManagement_Panel.Controls.Add(this.UserManagement_btn);
            this.UserManagement_Panel.Location = new System.Drawing.Point(3, 214);
            this.UserManagement_Panel.Name = "UserManagement_Panel";
            this.UserManagement_Panel.Size = new System.Drawing.Size(167, 52);
            this.UserManagement_Panel.TabIndex = 4;
            // 
            // UserManagement_btn
            // 
            this.UserManagement_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserManagement_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserManagement_btn.Location = new System.Drawing.Point(0, 0);
            this.UserManagement_btn.Name = "UserManagement_btn";
            this.UserManagement_btn.Size = new System.Drawing.Size(167, 52);
            this.UserManagement_btn.TabIndex = 0;
            this.UserManagement_btn.Text = "User Management";
            this.UserManagement_btn.UseVisualStyleBackColor = true;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.panel2);
            this.Name = "AdminUI";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.AdminDashboard_Panel.ResumeLayout(false);
            this.AddDriver_Panel.ResumeLayout(false);
            this.RecentOrder_Panel.ResumeLayout(false);
            this.UserManagement_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminDashboardlabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel AddDriver_Panel;
        private System.Windows.Forms.Button AddDriver_btn;
        private System.Windows.Forms.Panel AdminDashboard_Panel;
        private System.Windows.Forms.Button AdminDashboard_btn;
        private System.Windows.Forms.Panel UserManagement_Panel;
        private System.Windows.Forms.Button UserManagement_btn;
        private System.Windows.Forms.Panel RecentOrder_Panel;
        private System.Windows.Forms.Button RecentOrder_btn;
    }
}