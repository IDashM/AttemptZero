namespace AttemptZero
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.LoginSubmit_Btn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.ToRegisterPanel = new System.Windows.Forms.Panel();
            this.FirstNameRegisterInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LastNameRegisterInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ContactNumberRegisterInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressRegisterInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordRegisterInput = new System.Windows.Forms.TextBox();
            this.UserNameRegisterInput = new System.Windows.Forms.TextBox();
            this.LoginHeaderPanel = new System.Windows.Forms.Panel();
            this.OpenLogin_Btn = new System.Windows.Forms.Button();
            this.OpenToRegisterbtn = new System.Windows.Forms.Button();
            this.EmailVerifyPanel = new System.Windows.Forms.Panel();
            this.EmailVerifyCode = new System.Windows.Forms.TextBox();
            this.EmailVerifyText = new System.Windows.Forms.TextBox();
            this.VerifyCode = new System.Windows.Forms.Button();
            this.SendCode_btn = new System.Windows.Forms.Button();
            this.EmailVerifyLabel3 = new System.Windows.Forms.Label();
            this.EmailVerifyLabel1 = new System.Windows.Forms.Label();
            this.EmailVerifyLabel2 = new System.Windows.Forms.Label();
            this.Login_Panel.SuspendLayout();
            this.ToRegisterPanel.SuspendLayout();
            this.LoginHeaderPanel.SuspendLayout();
            this.EmailVerifyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Login_Panel.Controls.Add(this.LoginSubmit_Btn);
            this.Login_Panel.Controls.Add(this.PasswordLabel);
            this.Login_Panel.Controls.Add(this.UserNameLabel);
            this.Login_Panel.Controls.Add(this.PasswordInput);
            this.Login_Panel.Controls.Add(this.UsernameInput);
            this.Login_Panel.Controls.Add(this.label1);
            this.Login_Panel.Location = new System.Drawing.Point(891, 83);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(422, 302);
            this.Login_Panel.TabIndex = 2;
            this.Login_Panel.Visible = false;
            this.Login_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Panel_Paint);
            // 
            // LoginSubmit_Btn
            // 
            this.LoginSubmit_Btn.Location = new System.Drawing.Point(175, 255);
            this.LoginSubmit_Btn.Name = "LoginSubmit_Btn";
            this.LoginSubmit_Btn.Size = new System.Drawing.Size(75, 23);
            this.LoginSubmit_Btn.TabIndex = 6;
            this.LoginSubmit_Btn.Text = "Login";
            this.LoginSubmit_Btn.UseVisualStyleBackColor = true;
            this.LoginSubmit_Btn.Click += new System.EventHandler(this.LoginSubmit_Btn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(93, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(143, 33);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(93, 84);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(155, 33);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "UserName";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(87, 213);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '&';
            this.PasswordInput.Size = new System.Drawing.Size(250, 20);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(87, 122);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(250, 20);
            this.UsernameInput.TabIndex = 2;
            this.UsernameInput.Text = "Username";
            this.UsernameInput.TextChanged += new System.EventHandler(this.UsernameInput_TextChanged);
            // 
            // ToRegisterPanel
            // 
            this.ToRegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToRegisterPanel.Controls.Add(this.FirstNameRegisterInput);
            this.ToRegisterPanel.Controls.Add(this.label8);
            this.ToRegisterPanel.Controls.Add(this.LastNameRegisterInput);
            this.ToRegisterPanel.Controls.Add(this.label7);
            this.ToRegisterPanel.Controls.Add(this.label6);
            this.ToRegisterPanel.Controls.Add(this.ContactNumberRegisterInput);
            this.ToRegisterPanel.Controls.Add(this.label5);
            this.ToRegisterPanel.Controls.Add(this.AddressRegisterInput);
            this.ToRegisterPanel.Controls.Add(this.label4);
            this.ToRegisterPanel.Controls.Add(this.Register_Btn);
            this.ToRegisterPanel.Controls.Add(this.label2);
            this.ToRegisterPanel.Controls.Add(this.label3);
            this.ToRegisterPanel.Controls.Add(this.PasswordRegisterInput);
            this.ToRegisterPanel.Controls.Add(this.UserNameRegisterInput);
            this.ToRegisterPanel.Location = new System.Drawing.Point(888, 270);
            this.ToRegisterPanel.Name = "ToRegisterPanel";
            this.ToRegisterPanel.Size = new System.Drawing.Size(745, 429);
            this.ToRegisterPanel.TabIndex = 7;
            this.ToRegisterPanel.Visible = false;
            this.ToRegisterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ToRegisterPanel_Paint);
            // 
            // FirstNameRegisterInput
            // 
            this.FirstNameRegisterInput.Location = new System.Drawing.Point(391, 121);
            this.FirstNameRegisterInput.Name = "FirstNameRegisterInput";
            this.FirstNameRegisterInput.Size = new System.Drawing.Size(250, 20);
            this.FirstNameRegisterInput.TabIndex = 19;
            this.FirstNameRegisterInput.TextChanged += new System.EventHandler(this.FirstNameRegisterInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "Last Name";
            // 
            // LastNameRegisterInput
            // 
            this.LastNameRegisterInput.Location = new System.Drawing.Point(391, 195);
            this.LastNameRegisterInput.Name = "LastNameRegisterInput";
            this.LastNameRegisterInput.Size = new System.Drawing.Size(250, 20);
            this.LastNameRegisterInput.TabIndex = 16;
            this.LastNameRegisterInput.TextChanged += new System.EventHandler(this.LastNameRegisterInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "First Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "ContactNumber";
            // 
            // ContactNumberRegisterInput
            // 
            this.ContactNumberRegisterInput.Location = new System.Drawing.Point(391, 288);
            this.ContactNumberRegisterInput.Name = "ContactNumberRegisterInput";
            this.ContactNumberRegisterInput.Size = new System.Drawing.Size(250, 20);
            this.ContactNumberRegisterInput.TabIndex = 12;
            this.ContactNumberRegisterInput.TextChanged += new System.EventHandler(this.ContactNumberRegisterInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // AddressRegisterInput
            // 
            this.AddressRegisterInput.Location = new System.Drawing.Point(24, 288);
            this.AddressRegisterInput.Name = "AddressRegisterInput";
            this.AddressRegisterInput.Size = new System.Drawing.Size(250, 20);
            this.AddressRegisterInput.TabIndex = 8;
            this.AddressRegisterInput.Text = "Username";
            this.AddressRegisterInput.TextChanged += new System.EventHandler(this.AddressRegisterInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Register";
            // 
            // Register_Btn
            // 
            this.Register_Btn.Location = new System.Drawing.Point(535, 344);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(172, 54);
            this.Register_Btn.TabIndex = 6;
            this.Register_Btn.Text = "Register";
            this.Register_Btn.UseVisualStyleBackColor = true;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserName";
            // 
            // PasswordRegisterInput
            // 
            this.PasswordRegisterInput.Location = new System.Drawing.Point(24, 195);
            this.PasswordRegisterInput.Name = "PasswordRegisterInput";
            this.PasswordRegisterInput.Size = new System.Drawing.Size(250, 20);
            this.PasswordRegisterInput.TabIndex = 3;
            this.PasswordRegisterInput.TextChanged += new System.EventHandler(this.PasswordRegisterInput_TextChanged);
            // 
            // UserNameRegisterInput
            // 
            this.UserNameRegisterInput.Location = new System.Drawing.Point(24, 121);
            this.UserNameRegisterInput.Name = "UserNameRegisterInput";
            this.UserNameRegisterInput.Size = new System.Drawing.Size(250, 20);
            this.UserNameRegisterInput.TabIndex = 2;
            this.UserNameRegisterInput.Text = "Username";
            this.UserNameRegisterInput.TextChanged += new System.EventHandler(this.UserNameRegisterInput_TextChanged);
            // 
            // LoginHeaderPanel
            // 
            this.LoginHeaderPanel.BackColor = System.Drawing.Color.Green;
            this.LoginHeaderPanel.Controls.Add(this.OpenLogin_Btn);
            this.LoginHeaderPanel.Controls.Add(this.OpenToRegisterbtn);
            this.LoginHeaderPanel.Location = new System.Drawing.Point(4, 3);
            this.LoginHeaderPanel.Name = "LoginHeaderPanel";
            this.LoginHeaderPanel.Size = new System.Drawing.Size(748, 59);
            this.LoginHeaderPanel.TabIndex = 8;
            this.LoginHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginHeaderPanel_Paint);
            // 
            // OpenLogin_Btn
            // 
            this.OpenLogin_Btn.Location = new System.Drawing.Point(124, 3);
            this.OpenLogin_Btn.Name = "OpenLogin_Btn";
            this.OpenLogin_Btn.Size = new System.Drawing.Size(110, 47);
            this.OpenLogin_Btn.TabIndex = 1;
            this.OpenLogin_Btn.Text = "Login";
            this.OpenLogin_Btn.UseVisualStyleBackColor = true;
            this.OpenLogin_Btn.Click += new System.EventHandler(this.OpenLogin_Btn_Click);
            // 
            // OpenToRegisterbtn
            // 
            this.OpenToRegisterbtn.Location = new System.Drawing.Point(8, 3);
            this.OpenToRegisterbtn.Name = "OpenToRegisterbtn";
            this.OpenToRegisterbtn.Size = new System.Drawing.Size(110, 47);
            this.OpenToRegisterbtn.TabIndex = 0;
            this.OpenToRegisterbtn.Text = "Register";
            this.OpenToRegisterbtn.UseVisualStyleBackColor = true;
            this.OpenToRegisterbtn.Click += new System.EventHandler(this.OpenToRegisterbtn_Click);
            // 
            // EmailVerifyPanel
            // 
            this.EmailVerifyPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.EmailVerifyPanel.Controls.Add(this.EmailVerifyCode);
            this.EmailVerifyPanel.Controls.Add(this.EmailVerifyText);
            this.EmailVerifyPanel.Controls.Add(this.VerifyCode);
            this.EmailVerifyPanel.Controls.Add(this.SendCode_btn);
            this.EmailVerifyPanel.Controls.Add(this.EmailVerifyLabel3);
            this.EmailVerifyPanel.Controls.Add(this.EmailVerifyLabel1);
            this.EmailVerifyPanel.Controls.Add(this.EmailVerifyLabel2);
            this.EmailVerifyPanel.Location = new System.Drawing.Point(186, 213);
            this.EmailVerifyPanel.Name = "EmailVerifyPanel";
            this.EmailVerifyPanel.Size = new System.Drawing.Size(415, 249);
            this.EmailVerifyPanel.TabIndex = 11;
            // 
            // EmailVerifyCode
            // 
            this.EmailVerifyCode.Location = new System.Drawing.Point(28, 180);
            this.EmailVerifyCode.Name = "EmailVerifyCode";
            this.EmailVerifyCode.Size = new System.Drawing.Size(232, 20);
            this.EmailVerifyCode.TabIndex = 6;
            this.EmailVerifyCode.TextChanged += new System.EventHandler(this.EmailVerifyCode_TextChanged);
            // 
            // EmailVerifyText
            // 
            this.EmailVerifyText.Location = new System.Drawing.Point(28, 119);
            this.EmailVerifyText.Name = "EmailVerifyText";
            this.EmailVerifyText.Size = new System.Drawing.Size(232, 20);
            this.EmailVerifyText.TabIndex = 5;
            this.EmailVerifyText.TextChanged += new System.EventHandler(this.EmailVerifyText_TextChanged);
            // 
            // VerifyCode
            // 
            this.VerifyCode.Location = new System.Drawing.Point(303, 172);
            this.VerifyCode.Name = "VerifyCode";
            this.VerifyCode.Size = new System.Drawing.Size(93, 35);
            this.VerifyCode.TabIndex = 4;
            this.VerifyCode.Text = "Verify";
            this.VerifyCode.UseVisualStyleBackColor = true;
            this.VerifyCode.Click += new System.EventHandler(this.VerifyCode_Click);
            // 
            // SendCode_btn
            // 
            this.SendCode_btn.Location = new System.Drawing.Point(303, 103);
            this.SendCode_btn.Name = "SendCode_btn";
            this.SendCode_btn.Size = new System.Drawing.Size(93, 35);
            this.SendCode_btn.TabIndex = 3;
            this.SendCode_btn.Text = "Send Code";
            this.SendCode_btn.UseVisualStyleBackColor = true;
            this.SendCode_btn.Click += new System.EventHandler(this.SendCode_btn_Click);
            // 
            // EmailVerifyLabel3
            // 
            this.EmailVerifyLabel3.AutoSize = true;
            this.EmailVerifyLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EmailVerifyLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailVerifyLabel3.Location = new System.Drawing.Point(23, 151);
            this.EmailVerifyLabel3.Name = "EmailVerifyLabel3";
            this.EmailVerifyLabel3.Size = new System.Drawing.Size(64, 26);
            this.EmailVerifyLabel3.TabIndex = 2;
            this.EmailVerifyLabel3.Text = "Code";
            // 
            // EmailVerifyLabel1
            // 
            this.EmailVerifyLabel1.AutoSize = true;
            this.EmailVerifyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.EmailVerifyLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailVerifyLabel1.Location = new System.Drawing.Point(80, 27);
            this.EmailVerifyLabel1.Name = "EmailVerifyLabel1";
            this.EmailVerifyLabel1.Size = new System.Drawing.Size(281, 39);
            this.EmailVerifyLabel1.TabIndex = 1;
            this.EmailVerifyLabel1.Text = "Email Verification";
            // 
            // EmailVerifyLabel2
            // 
            this.EmailVerifyLabel2.AutoSize = true;
            this.EmailVerifyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EmailVerifyLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailVerifyLabel2.Location = new System.Drawing.Point(23, 90);
            this.EmailVerifyLabel2.Name = "EmailVerifyLabel2";
            this.EmailVerifyLabel2.Size = new System.Drawing.Size(68, 26);
            this.EmailVerifyLabel2.TabIndex = 0;
            this.EmailVerifyLabel2.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(933, 521);
            this.Controls.Add(this.EmailVerifyPanel);
            this.Controls.Add(this.ToRegisterPanel);
            this.Controls.Add(this.Login_Panel);
            this.Controls.Add(this.LoginHeaderPanel);
            this.MinimumSize = new System.Drawing.Size(456, 489);
            this.Name = "Form1";
            this.Text = "Trash Disposer Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.ToRegisterPanel.ResumeLayout(false);
            this.ToRegisterPanel.PerformLayout();
            this.LoginHeaderPanel.ResumeLayout(false);
            this.EmailVerifyPanel.ResumeLayout(false);
            this.EmailVerifyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginSubmit_Btn;
        private System.Windows.Forms.Panel ToRegisterPanel;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordRegisterInput;
        private System.Windows.Forms.TextBox UserNameRegisterInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel LoginHeaderPanel;
        private System.Windows.Forms.Button OpenLogin_Btn;
        private System.Windows.Forms.Button OpenToRegisterbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ContactNumberRegisterInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressRegisterInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameRegisterInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FirstNameRegisterInput;
        private System.Windows.Forms.Panel EmailVerifyPanel;
        private System.Windows.Forms.Button VerifyCode;
        private System.Windows.Forms.Button SendCode_btn;
        private System.Windows.Forms.Label EmailVerifyLabel3;
        private System.Windows.Forms.Label EmailVerifyLabel1;
        private System.Windows.Forms.Label EmailVerifyLabel2;
        private System.Windows.Forms.TextBox EmailVerifyCode;
        private System.Windows.Forms.TextBox EmailVerifyText;
    }
}

