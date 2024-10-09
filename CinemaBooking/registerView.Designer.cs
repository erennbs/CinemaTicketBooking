namespace CinemaBooking {
    partial class registerView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblBirthday = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            lblRegister = new Label();
            lblErrorMessage = new Label();
            linkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblBirthday.Location = new Point(170, 336);
            lblBirthday.Margin = new Padding(0);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(142, 27);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Doğum Tarihi";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Font = new Font("Microsoft New Tai Lue", 10F);
            txtUsername.Location = new Point(170, 244);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(440, 34);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(170, 214);
            lblUsername.Margin = new Padding(0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(132, 27);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Kullanıcı Adı";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Microsoft New Tai Lue", 10F);
            txtPassword.Location = new Point(170, 485);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(440, 34);
            txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(170, 455);
            lblPassword.Margin = new Padding(0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 27);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Şifre";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(170, 366);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(440, 31);
            dtpBirthday.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(47, 54, 69);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.Window;
            btnRegister.Location = new Point(170, 638);
            btnRegister.Name = "btnRegister";
            btnRegister.Padding = new Padding(0, 5, 0, 5);
            btnRegister.Size = new Size(440, 44);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold);
            lblRegister.Location = new Point(318, 91);
            lblRegister.Margin = new Padding(0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(152, 48);
            lblRegister.TabIndex = 12;
            lblRegister.Text = "Kayıt Ol";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.OrangeRed;
            lblErrorMessage.Location = new Point(170, 557);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(220, 25);
            lblErrorMessage.TabIndex = 13;
            lblErrorMessage.Text = "- Tüm alanları doldurunuz!";
            lblErrorMessage.Visible = false;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(537, 726);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(79, 25);
            linkLogin.TabIndex = 14;
            linkLogin.TabStop = true;
            linkLogin.Text = "Giriş Yap";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // registerView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 844);
            Controls.Add(linkLogin);
            Controls.Add(lblErrorMessage);
            Controls.Add(lblRegister);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblBirthday);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            MaximumSize = new Size(800, 900);
            MinimumSize = new Size(800, 900);
            Name = "registerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerView";
            FormClosed += registerView_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBirthday;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Label lblRegister;
        private Label lblErrorMessage;
        private LinkLabel linkLogin;
    }
}