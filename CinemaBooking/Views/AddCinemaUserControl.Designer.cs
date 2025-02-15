namespace CinemaBooking.Views {
    partial class AddCinemaUserControl {
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
            pnlCinemaForm = new Panel();
            cmbCity = new ComboBox();
            txtCinemaName = new TextBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblCity = new Label();
            lblCinemaName = new Label();
            lblAddCinema = new Label();
            pnlCinemaForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCinemaForm
            // 
            pnlCinemaForm.Anchor = AnchorStyles.Top;
            pnlCinemaForm.Controls.Add(cmbCity);
            pnlCinemaForm.Controls.Add(txtCinemaName);
            pnlCinemaForm.Controls.Add(btnClear);
            pnlCinemaForm.Controls.Add(btnAdd);
            pnlCinemaForm.Controls.Add(lblCity);
            pnlCinemaForm.Controls.Add(lblCinemaName);
            pnlCinemaForm.Location = new Point(250, 98);
            pnlCinemaForm.Name = "pnlCinemaForm";
            pnlCinemaForm.Size = new Size(700, 440);
            pnlCinemaForm.TabIndex = 4;
            // 
            // cmbCity
            // 
            cmbCity.DisplayMember = "Name";
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(93, 177);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(500, 33);
            cmbCity.TabIndex = 38;
            cmbCity.ValueMember = "Id";
            // 
            // txtCinemaName
            // 
            txtCinemaName.Location = new Point(93, 77);
            txtCinemaName.Name = "txtCinemaName";
            txtCinemaName.Size = new Size(500, 31);
            txtCinemaName.TabIndex = 37;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft New Tai Lue", 10F);
            btnClear.Location = new Point(328, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 50);
            btnClear.TabIndex = 33;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(47, 54, 69);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft New Tai Lue", 10F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(455, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCity.Location = new Point(93, 147);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(73, 27);
            lblCity.TabIndex = 20;
            lblCity.Text = "Şehir*";
            // 
            // lblCinemaName
            // 
            lblCinemaName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCinemaName.AutoSize = true;
            lblCinemaName.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCinemaName.Location = new Point(93, 47);
            lblCinemaName.Name = "lblCinemaName";
            lblCinemaName.Size = new Size(128, 27);
            lblCinemaName.TabIndex = 18;
            lblCinemaName.Text = "Sinema Adı*";
            // 
            // lblAddCinema
            // 
            lblAddCinema.AutoSize = true;
            lblAddCinema.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAddCinema.Location = new Point(14, 16);
            lblAddCinema.Name = "lblAddCinema";
            lblAddCinema.Size = new Size(198, 43);
            lblAddCinema.TabIndex = 5;
            lblAddCinema.Text = "Sinema Ekle";
            // 
            // AddCinemaUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblAddCinema);
            Controls.Add(pnlCinemaForm);
            Name = "AddCinemaUserControl";
            Size = new Size(1200, 732);
            Load += AddCinemaUserControl_Load;
            ParentChanged += AddCinemaUserControl_ParentChanged;
            pnlCinemaForm.ResumeLayout(false);
            pnlCinemaForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCinemaForm;
        private Button btnClear;
        private Button btnAdd;
        private Label lblCity;
        private Label lblCinemaName;
        private Label lblAddCinema;
        private TextBox txtCinemaName;
        private ComboBox cmbCity;
    }
}
