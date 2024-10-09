namespace CinemaBooking {
    partial class frontDeskView {
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
            btnAddBooking = new Button();
            btnBookings = new Button();
            button1 = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            lblUsername = new Label();
            btnMovies = new Button();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(47, 54, 69);
            pnlSidebar.Controls.Add(btnAddBooking);
            pnlSidebar.Controls.Add(btnBookings);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Controls.Add(btnMovies);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(320, 748);
            pnlSidebar.TabIndex = 1;
            // 
            // btnAddBooking
            // 
            btnAddBooking.BackColor = Color.Transparent;
            btnAddBooking.Cursor = Cursors.Hand;
            btnAddBooking.Dock = DockStyle.Top;
            btnAddBooking.FlatAppearance.BorderSize = 0;
            btnAddBooking.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 40, 51);
            btnAddBooking.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 51);
            btnAddBooking.FlatStyle = FlatStyle.Flat;
            btnAddBooking.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBooking.ForeColor = Color.White;
            btnAddBooking.Location = new Point(0, 171);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(320, 57);
            btnAddBooking.TabIndex = 2;
            btnAddBooking.Tag = "3";
            btnAddBooking.Text = "Yeni Rezarvasyon";
            btnAddBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBooking.UseVisualStyleBackColor = false;
            btnAddBooking.Click += sidebarButton_Click;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.Transparent;
            btnBookings.Cursor = Cursors.Hand;
            btnBookings.Dock = DockStyle.Top;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 40, 51);
            btnBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 51);
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookings.ForeColor = Color.White;
            btnBookings.Location = new Point(0, 114);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(320, 57);
            btnBookings.TabIndex = 1;
            btnBookings.Tag = "2";
            btnBookings.Text = "Rezarvasyonlar";
            btnBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += sidebarButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 40, 51);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 57);
            button1.Name = "button1";
            button1.Size = new Size(320, 57);
            button1.TabIndex = 16;
            button1.Tag = "1";
            button1.Text = "Seanslar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += sidebarButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblUsername);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 54);
            panel1.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 51);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(280, 0);
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
            lblUsername.Location = new Point(4, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(48, 27);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "test";
            // 
            // btnMovies
            // 
            btnMovies.BackColor = Color.Transparent;
            btnMovies.Cursor = Cursors.Hand;
            btnMovies.Dock = DockStyle.Top;
            btnMovies.FlatAppearance.BorderSize = 0;
            btnMovies.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 40, 51);
            btnMovies.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 51);
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovies.ForeColor = Color.White;
            btnMovies.Location = new Point(0, 0);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(320, 57);
            btnMovies.TabIndex = 0;
            btnMovies.Tag = "0";
            btnMovies.Text = "Filmler";
            btnMovies.TextAlign = ContentAlignment.MiddleLeft;
            btnMovies.UseVisualStyleBackColor = false;
            btnMovies.Click += sidebarButton_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(320, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1080, 748);
            pnlContent.TabIndex = 2;
            // 
            // frontDeskView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1400, 748);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Name = "frontDeskView";
            Text = "frmFrontDesk";
            FormClosed += adminView_FormClosed;
            pnlSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnMovies;
        private Button btnAddBooking;
        private Button btnBookings;
        private Panel pnlContent;
        private Panel panel1;
        private Button btnLogout;
        private Label lblUsername;
        private Button button1;
    }
}