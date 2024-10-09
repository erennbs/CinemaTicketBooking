namespace CinemaBooking.Views {
    partial class EditCinemaUserControl {
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
            btnEdit = new Button();
            lblCity = new Label();
            lblCinemaName = new Label();
            btnPreviousPage = new Button();
            pnlCinemaForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCinemaForm
            // 
            pnlCinemaForm.Anchor = AnchorStyles.Top;
            pnlCinemaForm.Controls.Add(cmbCity);
            pnlCinemaForm.Controls.Add(txtCinemaName);
            pnlCinemaForm.Controls.Add(btnClear);
            pnlCinemaForm.Controls.Add(btnEdit);
            pnlCinemaForm.Controls.Add(lblCity);
            pnlCinemaForm.Controls.Add(lblCinemaName);
            pnlCinemaForm.Location = new Point(261, 83);
            pnlCinemaForm.Name = "pnlCinemaForm";
            pnlCinemaForm.Size = new Size(700, 440);
            pnlCinemaForm.TabIndex = 6;
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
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(47, 54, 69);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft New Tai Lue", 10F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(455, 270);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 50);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCity.Location = new Point(93, 147);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(64, 27);
            lblCity.TabIndex = 20;
            lblCity.Text = "Şehir";
            // 
            // lblCinemaName
            // 
            lblCinemaName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCinemaName.AutoSize = true;
            lblCinemaName.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCinemaName.Location = new Point(93, 47);
            lblCinemaName.Name = "lblCinemaName";
            lblCinemaName.Size = new Size(119, 27);
            lblCinemaName.TabIndex = 18;
            lblCinemaName.Text = "Sinema Adı";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Location = new Point(13, 12);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(112, 34);
            btnPreviousPage.TabIndex = 7;
            btnPreviousPage.Text = "Geri";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // EditCinemaUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPreviousPage);
            Controls.Add(pnlCinemaForm);
            Name = "EditCinemaUserControl";
            Size = new Size(1235, 703);
            pnlCinemaForm.ResumeLayout(false);
            pnlCinemaForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlCinemaForm;
        private ComboBox cmbCity;
        private TextBox txtCinemaName;
        private Button btnClear;
        private Button btnEdit;
        private Label lblCity;
        private Label lblCinemaName;
        private Button btnPreviousPage;
    }
}
