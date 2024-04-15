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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttemptZero
{
    public partial class Form1 : Form
    {
        //VARIABLES
        string username;
        int MaxUserNameInput = 30, MaxFirstNameInput = 30, MaxLastNameInput = 30, MaxAddressInput = 50, MaxContactNumberInput = 11;
        bool toCheckEmailVerification = false;
        String PassKey;

        String sqlcon = @"Data Source=LAPTOP-V5O7M5C5\SQLEXPRESS;Initial Catalog=AttempZero;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            ToRegisterPanel.Visible = false;
            LoginHeaderPanel.Visible = true;
            ToRegisterPanel.Location = new Point(899, 437);
            Login_Panel.Location = new Point(899, 109);
            EmailVerifyPanel.Visible = false;
            EmailVerifyPanel.Location = new Point(889,359);
            Login_Panel.Visible = false;

            try
            {
                SqlConnection con = new SqlConnection(sqlcon);
            }
            catch (Exception a) { 
                MessageBox.Show("Error: "+ a.Message);
            }
            
        }
        private void LoginSubmit_Btn_Click(object sender, EventArgs e)
        {
           ;
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
                            MessageBox.Show("NO USERNAME FOUND PLEASE RE-INPUT","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void Register_Btn_Click(object sender, EventArgs e)
        {
            ToRegisterPanel.Location = new System.Drawing.Point(899, 437);
            ToRegisterPanel.Visible = false;
            ToRegisterPanel.Hide();
            Login_Panel.Hide();
            EmailVerifyPanel.Location = new Point(93, 146);
            EmailVerifyPanel.Visible = true;
        }
        public string getUserName() {
            return username;
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
            if (!Regex.IsMatch(input, "^[0-9]*$") || ContactNumberRegisterInput.TextLength > MaxContactNumberInput)
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

       

        private void SendCode() {
            Random rn = new Random();
            DateTime now = DateTime.Now;
            String aa = Convert.ToString(rn.Next());
            String code = now.ToString("HHmmss"+aa);
            PassKey = code;
        }

        private String GetCode() {
            return PassKey;
        }

        private void SendCode_btn_Click(object sender, EventArgs e)
        {
           
            SendCode();
            string fromEmail = "kickcamp06@gmail.com";
            string password = "0912309224827123150Dave";
            string toEmail = EmailVerifyText.Text;
            string subject = "Email Verification";
           
            
            string body = "The Code is : "+ GetCode();

            try
            {
                MailMessage message = new MailMessage(fromEmail, toEmail, subject, body);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587); // Update with your SMTP server and port
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(fromEmail, password);
                smtpClient.Send(message);
                toCheckEmailVerification = true;
                MessageBox.Show("Verification email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending verification email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void VerifyCode_Click(object sender, EventArgs e)
        {
            String qw = Convert.ToString(EmailVerifyCode.Text);
            if (qw.Equals(GetCode()))
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
                        cmd.Parameters.AddWithValue("@HostName", "CUSTOMER");
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Registration Complete");
                        EmailVerifyPanel.Visible = false;
                        EmailVerifyPanel.Location = new Point(889, 359);

                    }
                }
                else if(toCheckEmailVerification)
                {
                    MessageBox.Show("Please Get the Code to Verify your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toCheckEmailVerification = false;
                }
                else
                {
                    MessageBox.Show("Error Input. Please Input all the TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameInput_Click() {
            UsernameInput.Text = "";
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void EmailVerifyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserNameInputClick(object sender, EventArgs e)
        {
            UsernameInput.Text = "";
        }

        private void PasswordInputClick(object sender, EventArgs e)
        {
            PasswordInput.Text = "";
        }

        private void LoginHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void EmailVerifyCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailVerifyText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
