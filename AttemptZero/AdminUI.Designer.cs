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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminDashboardlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalesOnMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sidebar = new System.Windows.Forms.Panel();
            this.UserManagement_Panel = new System.Windows.Forms.Panel();
            this.UserManagement_btn = new System.Windows.Forms.Button();
            this.AdminDashboard_Panel = new System.Windows.Forms.Panel();
            this.AdminDashboard_btn = new System.Windows.Forms.Button();
            this.AddDriver_Panel = new System.Windows.Forms.Panel();
            this.AddDriver_btn = new System.Windows.Forms.Button();
            this.RecentOrder_Panel = new System.Windows.Forms.Panel();
            this.RecentOrder_btn = new System.Windows.Forms.Button();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOnMonth)).BeginInit();
            this.sidebar.SuspendLayout();
            this.UserManagement_Panel.SuspendLayout();
            this.AdminDashboard_Panel.SuspendLayout();
            this.AddDriver_Panel.SuspendLayout();
            this.RecentOrder_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AdminDashboardlabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 47);
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
            this.panel2.Controls.Add(this.SalesOnMonth);
            this.panel2.Controls.Add(this.sidebar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(944, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SalesOnMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.SalesOnMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SalesOnMonth.Legends.Add(legend2);
            this.SalesOnMonth.Location = new System.Drawing.Point(277, 67);
            this.SalesOnMonth.Name = "SalesOnMonth";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SalesOnMonth.Series.Add(series2);
            this.SalesOnMonth.Size = new System.Drawing.Size(300, 187);
            this.SalesOnMonth.TabIndex = 1;
            this.SalesOnMonth.Text = "chart1";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.LimeGreen;
            this.sidebar.Controls.Add(this.UserManagement_Panel);
            this.sidebar.Controls.Add(this.AdminDashboard_Panel);
            this.sidebar.Controls.Add(this.AddDriver_Panel);
            this.sidebar.Controls.Add(this.RecentOrder_Panel);
            this.sidebar.Location = new System.Drawing.Point(0, 46);
            this.sidebar.MaximumSize = new System.Drawing.Size(191, 404);
            this.sidebar.MinimumSize = new System.Drawing.Size(65, 404);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(65, 404);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // UserManagement_Panel
            // 
            this.UserManagement_Panel.Controls.Add(this.UserManagement_btn);
            this.UserManagement_Panel.Location = new System.Drawing.Point(3, 233);
            this.UserManagement_Panel.Name = "UserManagement_Panel";
            this.UserManagement_Panel.Size = new System.Drawing.Size(193, 52);
            this.UserManagement_Panel.TabIndex = 4;
            // 
            // UserManagement_btn
            // 
            this.UserManagement_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.UserManagement_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserManagement_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserManagement_btn.FlatAppearance.BorderSize = 0;
            this.UserManagement_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagement_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UserManagement_btn.Location = new System.Drawing.Point(0, 0);
            this.UserManagement_btn.Name = "UserManagement_btn";
            this.UserManagement_btn.Size = new System.Drawing.Size(193, 52);
            this.UserManagement_btn.TabIndex = 0;
            this.UserManagement_btn.Text = "  👤     Users";
            this.UserManagement_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManagement_btn.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard_Panel
            // 
            this.AdminDashboard_Panel.BackColor = System.Drawing.Color.Transparent;
            this.AdminDashboard_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdminDashboard_Panel.Controls.Add(this.AdminDashboard_btn);
            this.AdminDashboard_Panel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdminDashboard_Panel.Location = new System.Drawing.Point(3, 75);
            this.AdminDashboard_Panel.Name = "AdminDashboard_Panel";
            this.AdminDashboard_Panel.Size = new System.Drawing.Size(193, 58);
            this.AdminDashboard_Panel.TabIndex = 1;
            // 
            // AdminDashboard_btn
            // 
            this.AdminDashboard_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.AdminDashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminDashboard_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDashboard_btn.FlatAppearance.BorderSize = 0;
            this.AdminDashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminDashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdminDashboard_btn.ForeColor = System.Drawing.Color.Black;
            this.AdminDashboard_btn.Location = new System.Drawing.Point(0, 0);
            this.AdminDashboard_btn.Name = "AdminDashboard_btn";
            this.AdminDashboard_btn.Size = new System.Drawing.Size(193, 58);
            this.AdminDashboard_btn.TabIndex = 0;
            this.AdminDashboard_btn.Text = "📅   Panel";
            this.AdminDashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminDashboard_btn.UseVisualStyleBackColor = false;
            // 
            // AddDriver_Panel
            // 
            this.AddDriver_Panel.Controls.Add(this.AddDriver_btn);
            this.AddDriver_Panel.Location = new System.Drawing.Point(3, 139);
            this.AddDriver_Panel.Name = "AddDriver_Panel";
            this.AddDriver_Panel.Size = new System.Drawing.Size(190, 41);
            this.AddDriver_Panel.TabIndex = 2;
            // 
            // AddDriver_btn
            // 
            this.AddDriver_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.AddDriver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDriver_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDriver_btn.FlatAppearance.BorderSize = 0;
            this.AddDriver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDriver_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AddDriver_btn.Location = new System.Drawing.Point(0, 0);
            this.AddDriver_btn.Name = "AddDriver_btn";
            this.AddDriver_btn.Size = new System.Drawing.Size(190, 41);
            this.AddDriver_btn.TabIndex = 0;
            this.AddDriver_btn.Text = "🚗    Add ";
            this.AddDriver_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDriver_btn.UseVisualStyleBackColor = false;
            this.AddDriver_btn.Click += new System.EventHandler(this.AddDriver_btn_Click);
            // 
            // RecentOrder_Panel
            // 
            this.RecentOrder_Panel.Controls.Add(this.RecentOrder_btn);
            this.RecentOrder_Panel.Location = new System.Drawing.Point(3, 186);
            this.RecentOrder_Panel.Name = "RecentOrder_Panel";
            this.RecentOrder_Panel.Size = new System.Drawing.Size(190, 41);
            this.RecentOrder_Panel.TabIndex = 3;
            // 
            // RecentOrder_btn
            // 
            this.RecentOrder_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.RecentOrder_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecentOrder_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentOrder_btn.FlatAppearance.BorderSize = 0;
            this.RecentOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecentOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RecentOrder_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecentOrder_btn.Location = new System.Drawing.Point(0, 0);
            this.RecentOrder_btn.Name = "RecentOrder_btn";
            this.RecentOrder_btn.Size = new System.Drawing.Size(190, 41);
            this.RecentOrder_btn.TabIndex = 0;
            this.RecentOrder_btn.Text = "🛒   Order";
            this.RecentOrder_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecentOrder_btn.UseVisualStyleBackColor = false;
            this.RecentOrder_btn.Click += new System.EventHandler(this.RecentOrder_btn_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "🗃️";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.panel2);
            this.Name = "AdminUI";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesOnMonth)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.UserManagement_Panel.ResumeLayout(false);
            this.AdminDashboard_Panel.ResumeLayout(false);
            this.AddDriver_Panel.ResumeLayout(false);
            this.RecentOrder_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminDashboardlabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel AddDriver_Panel;
        private System.Windows.Forms.Button AddDriver_btn;
        private System.Windows.Forms.Panel AdminDashboard_Panel;
        private System.Windows.Forms.Button AdminDashboard_btn;
        private System.Windows.Forms.Panel UserManagement_Panel;
        private System.Windows.Forms.Button UserManagement_btn;
        private System.Windows.Forms.Panel RecentOrder_Panel;
        private System.Windows.Forms.Button RecentOrder_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesOnMonth;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Button button1;
    }
}