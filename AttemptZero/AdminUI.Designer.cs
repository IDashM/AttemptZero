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
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddDriver = new System.Windows.Forms.Button();
            this.History_btn = new System.Windows.Forms.Button();
            this.Sales_btn = new System.Windows.Forms.Button();
            this.CustomerChatBox = new System.Windows.Forms.Button();
            this.ChatBoxPanel = new System.Windows.Forms.Panel();
            this.UserShowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userChatBoxInterface1 = new AttemptZero.UserChatBoxInterface();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminDashboardlabel = new System.Windows.Forms.Label();
            this.AdminDashboardPanel = new System.Windows.Forms.Panel();
            this.AddDriverPanel = new System.Windows.Forms.Panel();
            this.SalesPanel = new System.Windows.Forms.Panel();
            this.HistoryPurchasePanel = new System.Windows.Forms.Panel();
            this.DashboardHomePanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.ChatBoxPanel.SuspendLayout();
            this.UserShowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.AddDriverPanel);
            this.panel3.Controls.Add(this.SalesPanel);
            this.panel3.Controls.Add(this.HistoryPurchasePanel);
            this.panel3.Controls.Add(this.DashboardHomePanel);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.ChatBoxPanel);
            this.panel3.Controls.Add(this.CustomerChatBox);
            this.panel3.Controls.Add(this.Sales_btn);
            this.panel3.Controls.Add(this.History_btn);
            this.panel3.Controls.Add(this.AddDriver);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 550);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // AddDriver
            // 
            this.AddDriver.BackColor = System.Drawing.Color.Chartreuse;
            this.AddDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.AddDriver.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AddDriver.Location = new System.Drawing.Point(0, 92);
            this.AddDriver.Name = "AddDriver";
            this.AddDriver.Size = new System.Drawing.Size(104, 50);
            this.AddDriver.TabIndex = 0;
            this.AddDriver.Text = "🚗";
            this.AddDriver.UseVisualStyleBackColor = false;
            // 
            // History_btn
            // 
            this.History_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.History_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.History_btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.History_btn.Location = new System.Drawing.Point(0, 148);
            this.History_btn.Name = "History_btn";
            this.History_btn.Size = new System.Drawing.Size(104, 50);
            this.History_btn.TabIndex = 1;
            this.History_btn.Text = "📋";
            this.History_btn.UseVisualStyleBackColor = false;
            // 
            // Sales_btn
            // 
            this.Sales_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.Sales_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Sales_btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Sales_btn.Location = new System.Drawing.Point(0, 204);
            this.Sales_btn.Name = "Sales_btn";
            this.Sales_btn.Size = new System.Drawing.Size(104, 50);
            this.Sales_btn.TabIndex = 2;
            this.Sales_btn.Text = "🛒";
            this.Sales_btn.UseVisualStyleBackColor = false;
            // 
            // CustomerChatBox
            // 
            this.CustomerChatBox.BackColor = System.Drawing.Color.Chartreuse;
            this.CustomerChatBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerChatBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CustomerChatBox.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CustomerChatBox.Location = new System.Drawing.Point(0, 260);
            this.CustomerChatBox.Name = "CustomerChatBox";
            this.CustomerChatBox.Size = new System.Drawing.Size(104, 50);
            this.CustomerChatBox.TabIndex = 3;
            this.CustomerChatBox.Text = "💬";
            this.CustomerChatBox.UseVisualStyleBackColor = false;
            this.CustomerChatBox.Click += new System.EventHandler(this.CustomerChatBox_Click);
            // 
            // ChatBoxPanel
            // 
            this.ChatBoxPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.ChatBoxPanel.Controls.Add(this.UserShowPanel);
            this.ChatBoxPanel.Location = new System.Drawing.Point(55, 504);
            this.ChatBoxPanel.Name = "ChatBoxPanel";
            this.ChatBoxPanel.Size = new System.Drawing.Size(841, 439);
            this.ChatBoxPanel.TabIndex = 2;
            this.ChatBoxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChatBoxPanel_Paint);
            // 
            // UserShowPanel
            // 
            this.UserShowPanel.Controls.Add(this.userChatBoxInterface1);
            this.UserShowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserShowPanel.Location = new System.Drawing.Point(528, 0);
            this.UserShowPanel.Name = "UserShowPanel";
            this.UserShowPanel.Size = new System.Drawing.Size(313, 439);
            this.UserShowPanel.TabIndex = 1;
            // 
            // userChatBoxInterface1
            // 
            this.userChatBoxInterface1.Icon = null;
            this.userChatBoxInterface1.Location = new System.Drawing.Point(3, 3);
            this.userChatBoxInterface1.Name = "userChatBoxInterface1";
            this.userChatBoxInterface1.Size = new System.Drawing.Size(303, 100);
            this.userChatBoxInterface1.TabIndex = 0;
            this.userChatBoxInterface1.Title = null;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chartreuse;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(3, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "🏡";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.AdminDashboardlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(104, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 47);
            this.panel1.TabIndex = 0;
            // 
            // AdminDashboardlabel
            // 
            this.AdminDashboardlabel.AutoSize = true;
            this.AdminDashboardlabel.BackColor = System.Drawing.Color.LimeGreen;
            this.AdminDashboardlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdminDashboardlabel.Location = new System.Drawing.Point(6, 9);
            this.AdminDashboardlabel.Name = "AdminDashboardlabel";
            this.AdminDashboardlabel.Size = new System.Drawing.Size(230, 31);
            this.AdminDashboardlabel.TabIndex = 0;
            this.AdminDashboardlabel.Text = "Admin Dashboard";
            this.AdminDashboardlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminDashboardPanel
            // 
            this.AdminDashboardPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.AdminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDashboardPanel.Location = new System.Drawing.Point(104, 47);
            this.AdminDashboardPanel.Name = "AdminDashboardPanel";
            this.AdminDashboardPanel.Size = new System.Drawing.Size(899, 503);
            this.AdminDashboardPanel.TabIndex = 3;
            this.AdminDashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminDashboardPanel_Paint);
            // 
            // AddDriverPanel
            // 
            this.AddDriverPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.AddDriverPanel.Location = new System.Drawing.Point(88, 350);
            this.AddDriverPanel.Name = "AddDriverPanel";
            this.AddDriverPanel.Size = new System.Drawing.Size(841, 439);
            this.AddDriverPanel.TabIndex = 4;
            // 
            // SalesPanel
            // 
            this.SalesPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.SalesPanel.Location = new System.Drawing.Point(33, 507);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.Size = new System.Drawing.Size(841, 439);
            this.SalesPanel.TabIndex = 5;
            // 
            // HistoryPurchasePanel
            // 
            this.HistoryPurchasePanel.BackColor = System.Drawing.Color.PaleGreen;
            this.HistoryPurchasePanel.Location = new System.Drawing.Point(58, 388);
            this.HistoryPurchasePanel.Name = "HistoryPurchasePanel";
            this.HistoryPurchasePanel.Size = new System.Drawing.Size(841, 439);
            this.HistoryPurchasePanel.TabIndex = 4;
            // 
            // DashboardHomePanel
            // 
            this.DashboardHomePanel.BackColor = System.Drawing.Color.PaleGreen;
            this.DashboardHomePanel.Location = new System.Drawing.Point(12, 523);
            this.DashboardHomePanel.Name = "DashboardHomePanel";
            this.DashboardHomePanel.Size = new System.Drawing.Size(841, 503);
            this.DashboardHomePanel.TabIndex = 5;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.AdminDashboardPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "AdminUI";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.panel3.ResumeLayout(false);
            this.ChatBoxPanel.ResumeLayout(false);
            this.UserShowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminDashboardlabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel ChatBoxPanel;
        private System.Windows.Forms.FlowLayoutPanel UserShowPanel;
        private UserChatBoxInterface userChatBoxInterface1;
        private System.Windows.Forms.Button CustomerChatBox;
        private System.Windows.Forms.Button Sales_btn;
        private System.Windows.Forms.Button History_btn;
        private System.Windows.Forms.Button AddDriver;
        private System.Windows.Forms.Panel AdminDashboardPanel;
        private System.Windows.Forms.Panel AddDriverPanel;
        private System.Windows.Forms.Panel SalesPanel;
        private System.Windows.Forms.Panel HistoryPurchasePanel;
        private System.Windows.Forms.Panel DashboardHomePanel;
    }
}