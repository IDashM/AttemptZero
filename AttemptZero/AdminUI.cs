using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttemptZero
{
    public partial class AdminUI : Form
    {
        String sqlcon = @"Data Source=LAPTOP-V5O7M5C5\SQLEXPRESS;Initial Catalog=AttempZero;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
  
        Form1 form;
        public AdminUI()
        {
            InitializeComponent();
           
        }
        private void AdminUI_Load(object sender, EventArgs e)
        {
            DashboardHomePanel.Show();
            AddDriverPanel.Hide();
            HistoryPurchasePanel.Hide();
            SalesPanel.Hide();
            ChatBoxPanel.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDriver_btn_Click(object sender, EventArgs e)
        {

        }

        private void TotalSale() { 
            
        }
        private void OrderRecieved()
        {

        }
        private void Total_User()
        {

        }
        private void TotalProfit()
        {

        }


        private void RecentOrder_btn_Click(object sender, EventArgs e)
        {

        }
        private void UserItem()
        {
            UserShowPanel.Controls.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from FirstName", sqlcon);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    UserChatBoxInterface[] userControl = new UserChatBoxInterface[table.Rows.Count];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            userControl[i] = new UserChatBoxInterface();
                            MemoryStream stream = new MemoryStream((byte[])row["image"]);
                            userControl[i].Icon = new Bitmap(stream);
                            userControl[i].Title = row["FirstName"].ToString();
                            if (userControl[i].Title == form.getUserName())
                            {
                                UserShowPanel.Controls.Remove(userControl[i]);
                            }
                            else {
                                UserShowPanel.Controls.Add(userControl[i]);
                            }
                        }
                    }
                }
            }
        }


        private void toSwitch(String sw) {
            switch (sw) {
                case "CustomerChatBox":
                    DashboardHomePanel.Hide();
                    AddDriverPanel.Hide();
                    HistoryPurchasePanel.Hide();
                    SalesPanel.Hide();
                    ChatBoxPanel.Show();
                    break;
                case "dashboard":
                    DashboardHomePanel.Show();
                    AddDriverPanel.Hide();
                    HistoryPurchasePanel.Hide();
                    SalesPanel.Hide();
                    ChatBoxPanel.Hide();
                    break;
                case "addDriver":
                    DashboardHomePanel.Hide();
                    AddDriverPanel.Show();
                    HistoryPurchasePanel.Hide();
                    SalesPanel.Hide();
                    ChatBoxPanel.Hide();
                    break;
                case "History":
                    DashboardHomePanel.Hide();
                    AddDriverPanel.Hide();
                    HistoryPurchasePanel.Show();
                    SalesPanel.Hide();
                    ChatBoxPanel.Hide();
                    break;
                case "Sales":
                    DashboardHomePanel.Hide();
                    AddDriverPanel.Hide();
                    HistoryPurchasePanel.Hide();
                    SalesPanel.Show();
                   
                    ChatBoxPanel.Hide();
                    break;
            }
        }
                private void CustomerChatBox_Click(object sender, EventArgs e)
                {
             toSwitch("CustomerChatBox");
                    
                }
        private void AddDriver_Click(object sender, EventArgs e)
        {
            toSwitch("addDriver");
        }

        private void ChatBoxPanel_Paint(object sender, PaintEventArgs e)
                {

                }

        private void DashboardHomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
   
        }

        private void AdminDashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
    }

