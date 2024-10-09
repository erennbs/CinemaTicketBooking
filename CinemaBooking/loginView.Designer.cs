namespace CinemaBooking {
    partial class loginView {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            lblErrorMessage = new Label();
            linkLabel1 = new LinkLabel();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(170, 231);
            lblUsername.Margin = new Padding(0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(132, 27);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Kullanıcı Adı";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Font = new Font("Microsoft New Tai Lue", 10F);
            txtUsername.Location = new Point(170, 262);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(440, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Microsoft New Tai Lue", 10F);
            txtPassword.Location = new Point(170, 384);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(440, 34);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(170, 354);
            lblPassword.Margin = new Padding(0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 27);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Şifre";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(47, 54, 69);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.Window;
            btnLogin.Location = new Point(170, 520);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(0, 5, 0, 5);
            btnLogin.Size = new Size(440, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.OrangeRed;
            lblErrorMessage.Location = new Point(170, 456);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(245, 26);
            lblErrorMessage.TabIndex = 5;
            lblErrorMessage.Text = "- E-posta ya da şifre hatalı!";
            lblErrorMessage.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(529, 603);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 26);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold);
            lblLogin.Location = new Point(301, 97);
            lblLogin.Margin = new Padding(0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(173, 48);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "Giriş Yap";
            // 
            // loginView
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(778, 844);
            Controls.Add(lblLogin);
            Controls.Add(linkLabel1);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Font = new Font("Microsoft New Tai Lue", 10F);
            MaximumSize = new Size(800, 900);
            MinimumSize = new Size(800, 900);
            Name = "loginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblErrorMessage;
        private LinkLabel linkLabel1;
        private Label lblLogin;
    }
}
