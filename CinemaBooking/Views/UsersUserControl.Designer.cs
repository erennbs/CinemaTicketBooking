namespace CinemaBooking.Views {
    partial class UsersUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblAddBooking = new Label();
            dgwUsers = new DataGridView();
            lblUsername = new Label();
            btnFilter = new Button();
            txtUsernameFilter = new TextBox();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwUsers).BeginInit();
            SuspendLayout();
            // 
            // lblAddBooking
            // 
            lblAddBooking.AutoSize = true;
            lblAddBooking.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAddBooking.Location = new Point(3, 12);
            lblAddBooking.Name = "lblAddBooking";
            lblAddBooking.Size = new Size(185, 43);
            lblAddBooking.TabIndex = 7;
            lblAddBooking.Text = "Kullanıcılar";
            // 
            // dgwUsers
            // 
            dgwUsers.AllowUserToAddRows = false;
            dgwUsers.AllowUserToDeleteRows = false;
            dgwUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwUsers.BackgroundColor = Color.Gainsboro;
            dgwUsers.BorderStyle = BorderStyle.None;
            dgwUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUsers.Location = new Point(17, 205);
            dgwUsers.Name = "dgwUsers";
            dgwUsers.RowHeadersWidth = 62;
            dgwUsers.Size = new Size(1262, 490);
            dgwUsers.TabIndex = 8;
            dgwUsers.CellContentClick += dgwUsers_CellContentClick;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(17, 102);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(117, 24);
            lblUsername.TabIndex = 16;
            lblUsername.Text = "Kullanıcı Adı";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(47, 54, 69);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(330, 129);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 14;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtUsernameFilter
            // 
            txtUsernameFilter.Location = new Point(17, 132);
            txtUsernameFilter.Name = "txtUsernameFilter";
            txtUsernameFilter.Size = new Size(226, 31);
            txtUsernameFilter.TabIndex = 17;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.White;
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(486, 129);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(112, 34);
            btnResetFilter.TabIndex = 18;
            btnResetFilter.Text = "Sıfırla";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // UsersUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnResetFilter);
            Controls.Add(txtUsernameFilter);
            Controls.Add(lblUsername);
            Controls.Add(btnFilter);
            Controls.Add(dgwUsers);
            Controls.Add(lblAddBooking);
            Name = "UsersUserControl";
            Size = new Size(1299, 712);
            Load += UsersUserControl_Load;
            ParentChanged += UsersUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddBooking;
        private DataGridView dgwUsers;
        private Label lblUsername;
        private Button btnFilter;
        private TextBox txtUsernameFilter;
        private Button btnResetFilter;
    }
}
