using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttemptZero
{
    public partial class Form1 : Form
    {
        //VARIABLES
        int MaxUserNameInput = 30, MaxFirstNameInput = 30, MaxLastNameInput = 30, MaxAddressInput = 50, MaxContactNumberInput = 11;

        String sqlcon = @"Data Source=LAPTOP-V5O7M5C5\SQLEXPRESS;Initial Catalog=AttempZero;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            ToRegisterPanel.Visible = false;
            LoginHeaderPanel.Visible = true;
            Login_Panel.Visible = false;

            try
            {
                SqlConnection con = new SqlConnection(sqlcon);
            }
            catch (Exception a) { 
                MessageBox.Show("Error: "+ a.Message);
            }
            
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ToRegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenToRegisterbtn_Click(object sender, EventArgs e)
        {
            ToRegisterPanel.Location = new System.Drawing.Point(4, 59);
            Login_Panel.Location = new System.Drawing.Point(925, 114);
            ToRegisterPanel.Visible = true;
            Login_Panel.Visible = false;


        }
   
        private void OpenLogin_Btn_Click(object sender, EventArgs e)
        {
   
            ToRegisterPanel.Location = new System.Drawing.Point(170, 299);
            Login_Panel.Location = new System.Drawing.Point(128, 108);
            ToRegisterPanel.Visible = false;
            Login_Panel.Visible = true;
           
        }

        private void LoginHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Panel_Paint(object sender, PaintEventArgs e)
        {

        }




        private void LoginSubmit_Btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string sql = "SELECT HostName FROM Customer_Information WHERE UserName = @UserName AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", UsernameInput.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordInput.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hostName = reader["HostName"].ToString();
                            switch (hostName)
                            {
                                case "CUSTOMER":
                                    CustomerUI customer = new CustomerUI();
                                    this.Hide();
                                    customer.Show();
                                    break;
                                case "ADMIN":
                                    AdminUI admin = new AdminUI();
                                    this.Hide();
                                    admin.Show();
                                    break;
                                case "DRIVER":
                                    DriverUI driver = new DriverUI();
                                    this.Hide();
                                    driver.Show();
                                    break;
                                default:
                                    MessageBox.Show("Error: NO HOSTNAME ASSIGNED");
                                    break;
                            }
                        }
                        else
                        {
                           
                        }
                    }
                }
            }
        }
        private void Register_Btn_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into Customer_Information values (@ID,@UserName,@LastName,@Address,FirstName,@ContactNumber,@DateRegistered,@Password)", con);
                if (ContactNumberRegisterInput != null && UserNameRegisterInput != null && LastNameRegisterInput != null && FirstNameRegisterInput != null && AddressRegisterInput != null && ContactNumberRegisterInput.TextLength == 11 && PasswordRegisterInput != null)
                {
                    SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM Customer_Information WHERE UserName = @UserName", con);
                    checkUsernameCmd.Parameters.AddWithValue("@UserName", UserNameRegisterInput.Text);
                    con.Open();
                    int count = (int)checkUsernameCmd.ExecuteScalar();
                    con.Close();
                    if (count == 0)
                    {
                        cmd.Parameters.AddWithValue("@UserName", UserNameRegisterInput.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameRegisterInput.Text);
                        cmd.Parameters.AddWithValue("@Address", AddressRegisterInput.Text);
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameRegisterInput.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", ContactNumberRegisterInput.Text);
                        cmd.Parameters.AddWithValue("@DateRegistered", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Password", PasswordRegisterInput.Text);
                        cmd.Parameters.AddWithValue("@HostName", "CUSTOMER");
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
   
            }
        private void ContactNumberRegisterInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else {
                e.Handled = false;
            }
        }

        private void ContactNumberRegisterInput_TextChanged(object sender, EventArgs e)
        {
            string input = ContactNumberRegisterInput.Text;
            if (!Regex.IsMatch(input, "^[0-9]*$") || ContactNumberRegisterInput.TextLength > 11)
            {
                ContactNumberRegisterInput.Text = input.Remove(input.Length - 1);
                ContactNumberRegisterInput.SelectionStart = input.Length;
            }
            if (ContactNumberRegisterInput.TextLength > 11) {
                MessageBox.Show("Total number Input only 11");
            }

        }

        private void FirstNameRegisterInput_TextChanged(object sender, EventArgs e)
        {
            string input = FirstNameRegisterInput.Text;

            if (input.Length > MaxFirstNameInput)
            {
                FirstNameRegisterInput.Text = input.Remove(input.Length - 1);
                FirstNameRegisterInput.SelectionStart = input.Length;
            }
        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void UserNameRegisterInput_TextChanged(object sender, EventArgs e)
        {
            string input = UserNameRegisterInput.Text;

            if (input.Length > MaxUserNameInput) {
                UserNameRegisterInput.Text = input.Remove(input.Length - 1);
                UserNameRegisterInput.SelectionStart = input.Length;
            }
        }
        private void AddressRegisterInput_TextChanged(object sender, EventArgs e)
        {
            string input = AddressRegisterInput.Text;

            if (input.Length > MaxAddressInput)
            {
                AddressRegisterInput.Text = input.Remove(input.Length - 1);
                AddressRegisterInput.SelectionStart = input.Length;

            }
        }

            private void LastNameRegisterInput_TextChanged(object sender, EventArgs e)
        {
            string input = LastNameRegisterInput.Text;

            if (input.Length > MaxLastNameInput)
            {
                LastNameRegisterInput.Text = input.Remove(input.Length - 1);
                LastNameRegisterInput.SelectionStart = input.Length;

            }
        }
        private void PasswordRegisterInput_TextChanged(object sender, EventArgs e)
        {
            string input = PasswordRegisterInput.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[0-9]*$"))
            {

                PasswordRegisterInput.Text = input.Remove(input.Length - 1);
                PasswordRegisterInput.SelectionStart = input.Length;
            }
        }
    }
}
