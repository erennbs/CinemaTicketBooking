namespace MovieTicketSystemUI {
    partial class adminView {
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
            pnlSidebar = new Panel();
            panel1 = new Panel();
            btnLogout = new Button();
            lblUsername = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(47, 54, 69);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(320, 1032);
            pnlSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblUsername);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 973);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 59);
            panel1.TabIndex = 14;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 51);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(280, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(40, 40);
            btnLogout.TabIndex = 13;
            btnLogout.Text = ">";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(4, 14);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(48, 27);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "test";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(320, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1348, 1032);
            pnlContent.TabIndex = 1;
            // 
            // adminView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1668, 1032);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Name = "adminView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            FormClosed += adminView_FormClosed;
            pnlSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblUsername;
        private Button btnLogout;
        private Panel panel1;
    }
}