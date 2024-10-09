namespace CinemaBooking.Views {
    partial class AddHallUserControl {
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
            lblAddHall = new Label();
            pnlHallForm = new Panel();
            nudTotalSeats = new NumericUpDown();
            lblTotalSeats = new Label();
            nudHallNumber = new NumericUpDown();
            cmbCinema = new ComboBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblHallNumber = new Label();
            lblCinema = new Label();
            pnlHallForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalSeats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHallNumber).BeginInit();
            SuspendLayout();
            // 
            // lblAddHall
            // 
            lblAddHall.AutoSize = true;
            lblAddHall.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAddHall.Location = new Point(3, 14);
            lblAddHall.Name = "lblAddHall";
            lblAddHall.Size = new Size(172, 43);
            lblAddHall.TabIndex = 6;
            lblAddHall.Text = "Salon Ekle";
            // 
            // pnlHallForm
            // 
            pnlHallForm.Anchor = AnchorStyles.Top;
            pnlHallForm.Controls.Add(nudTotalSeats);
            pnlHallForm.Controls.Add(lblTotalSeats);
            pnlHallForm.Controls.Add(nudHallNumber);
            pnlHallForm.Controls.Add(cmbCinema);
            pnlHallForm.Controls.Add(btnClear);
            pnlHallForm.Controls.Add(btnAdd);
            pnlHallForm.Controls.Add(lblHallNumber);
            pnlHallForm.Controls.Add(lblCinema);
            pnlHallForm.Location = new Point(237, 106);
            pnlHallForm.Name = "pnlHallForm";
            pnlHallForm.Size = new Size(700, 469);
            pnlHallForm.TabIndex = 7;
            // 
            // nudTotalSeats
            // 
            nudTotalSeats.Location = new Point(93, 266);
            nudTotalSeats.Name = "nudTotalSeats";
            nudTotalSeats.Size = new Size(500, 31);
            nudTotalSeats.TabIndex = 42;
            // 
            // lblTotalSeats
            // 
            lblTotalSeats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSeats.AutoSize = true;
            lblTotalSeats.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblTotalSeats.Location = new Point(93, 236);
            lblTotalSeats.Name = "lblTotalSeats";
            lblTotalSeats.Size = new Size(134, 27);
            lblTotalSeats.TabIndex = 41;
            lblTotalSeats.Text = "Koltuk Sayısı";
            // 
            // nudHallNumber
            // 
            nudHallNumber.Location = new Point(93, 177);
            nudHallNumber.Name = "nudHallNumber";
            nudHallNumber.Size = new Size(500, 31);
            nudHallNumber.TabIndex = 40;
            // 
            // cmbCinema
            // 
            cmbCinema.DisplayMember = "Name";
            cmbCinema.FormattingEnabled = true;
            cmbCinema.Location = new Point(93, 77);
            cmbCinema.Name = "cmbCinema";
            cmbCinema.Size = new Size(500, 33);
            cmbCinema.TabIndex = 39;
            cmbCinema.ValueMember = "Id";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft New Tai Lue", 10F);
            btnClear.Location = new Point(328, 353);
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
            btnAdd.Location = new Point(455, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblHallNumber
            // 
            lblHallNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHallNumber.AutoSize = true;
            lblHallNumber.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblHallNumber.Location = new Point(93, 147);
            lblHallNumber.Name = "lblHallNumber";
            lblHallNumber.Size = new Size(161, 27);
            lblHallNumber.TabIndex = 20;
            lblHallNumber.Text = "Salon Numarası";
            // 
            // lblCinema
            // 
            lblCinema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCinema.AutoSize = true;
            lblCinema.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCinema.Location = new Point(93, 47);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(81, 27);
            lblCinema.TabIndex = 18;
            lblCinema.Text = "Sinema";
            // 
            // AddHallUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlHallForm);
            Controls.Add(lblAddHall);
            Name = "AddHallUserControl";
            Size = new Size(1189, 680);
            Load += AddHallUserControl_Load;
            ParentChanged += AddHallUserControl_ParentChanged;
            pnlHallForm.ResumeLayout(false);
            pnlHallForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalSeats).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHallNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddHall;
        private Panel pnlHallForm;
        private ComboBox cmbCinema;
        private ComboBox cmbCity;
        private Button btnClear;
        private Button btnAdd;
        private Label lblHallNumber;
        private Label lblCinema;
        private NumericUpDown nudTotalSeats;
        private Label lblTotalSeats;
        private NumericUpDown nudHallNumber;
    }
}
