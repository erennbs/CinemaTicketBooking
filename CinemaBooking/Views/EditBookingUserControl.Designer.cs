namespace CinemaBooking.Views {
    partial class EditBookingUserControl {
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
            btnPreviousPage = new Button();
            pnlBookingForm = new Panel();
            cmbMovie = new ComboBox();
            cmbCinema = new ComboBox();
            lblCinema = new Label();
            flpSeats = new FlowLayoutPanel();
            cmbShow = new ComboBox();
            btnClear = new Button();
            btnEdit = new Button();
            lblShow = new Label();
            lblMovieName = new Label();
            pnlBookingForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Location = new Point(12, 13);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(112, 34);
            btnPreviousPage.TabIndex = 8;
            btnPreviousPage.Text = "Geri";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // pnlBookingForm
            // 
            pnlBookingForm.Anchor = AnchorStyles.Top;
            pnlBookingForm.Controls.Add(cmbMovie);
            pnlBookingForm.Controls.Add(cmbCinema);
            pnlBookingForm.Controls.Add(lblCinema);
            pnlBookingForm.Controls.Add(flpSeats);
            pnlBookingForm.Controls.Add(cmbShow);
            pnlBookingForm.Controls.Add(btnClear);
            pnlBookingForm.Controls.Add(btnEdit);
            pnlBookingForm.Controls.Add(lblShow);
            pnlBookingForm.Controls.Add(lblMovieName);
            pnlBookingForm.Location = new Point(194, 101);
            pnlBookingForm.Name = "pnlBookingForm";
            pnlBookingForm.Size = new Size(1006, 1026);
            pnlBookingForm.TabIndex = 9;
            // 
            // cmbMovie
            // 
            cmbMovie.DisplayMember = "Title";
            cmbMovie.Enabled = false;
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(244, 163);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(500, 33);
            cmbMovie.TabIndex = 45;
            cmbMovie.ValueMember = "Id";
            // 
            // cmbCinema
            // 
            cmbCinema.DisplayMember = "Name";
            cmbCinema.Enabled = false;
            cmbCinema.FormattingEnabled = true;
            cmbCinema.Location = new Point(244, 72);
            cmbCinema.Name = "cmbCinema";
            cmbCinema.Size = new Size(500, 33);
            cmbCinema.TabIndex = 44;
            cmbCinema.ValueMember = "Id";
            // 
            // lblCinema
            // 
            lblCinema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCinema.AutoSize = true;
            lblCinema.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCinema.Location = new Point(244, 42);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(81, 27);
            lblCinema.TabIndex = 43;
            lblCinema.Text = "Sinema";
            // 
            // flpSeats
            // 
            flpSeats.Location = new Point(65, 349);
            flpSeats.Name = "flpSeats";
            flpSeats.Size = new Size(870, 441);
            flpSeats.TabIndex = 42;
            // 
            // cmbShow
            // 
            cmbShow.DisplayMember = "StartTime";
            cmbShow.FormattingEnabled = true;
            cmbShow.Items.AddRange(new object[] { "deneme" });
            cmbShow.Location = new Point(244, 250);
            cmbShow.Name = "cmbShow";
            cmbShow.Size = new Size(500, 33);
            cmbShow.TabIndex = 38;
            cmbShow.ValueMember = "Id";
            cmbShow.SelectedIndexChanged += cmbShow_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft New Tai Lue", 10F);
            btnClear.Location = new Point(479, 848);
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
            btnEdit.Location = new Point(606, 848);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 50);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblShow
            // 
            lblShow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblShow.AutoSize = true;
            lblShow.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblShow.Location = new Point(244, 220);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(66, 27);
            lblShow.TabIndex = 20;
            lblShow.Text = "Seans";
            // 
            // lblMovieName
            // 
            lblMovieName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblMovieName.Location = new Point(244, 133);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(52, 27);
            lblMovieName.TabIndex = 18;
            lblMovieName.Text = "Film";
            // 
            // EditBookingUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlBookingForm);
            Controls.Add(btnPreviousPage);
            Name = "EditBookingUserControl";
            Size = new Size(1391, 1205);
            pnlBookingForm.ResumeLayout(false);
            pnlBookingForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnPreviousPage;
        private Panel pnlBookingForm;
        private FlowLayoutPanel flpSeats;
        private ComboBox cmbShow;
        private Button btnClear;
        private Button btnEdit;
        private Label lblShow;
        private Label lblMovieName;
        private Label lblCinema;
        private ComboBox cmbMovie;
        private ComboBox cmbCinema;
    }
}
