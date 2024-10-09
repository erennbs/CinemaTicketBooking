namespace CinemaBooking.Views {
    partial class AddBookingUserControl {
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
            pnlBookingForm = new Panel();
            cmbCinema = new ComboBox();
            lblCinema = new Label();
            flpSeats = new FlowLayoutPanel();
            cmbMovie = new ComboBox();
            cmbShow = new ComboBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblShow = new Label();
            lblMovieName = new Label();
            lblAddBooking = new Label();
            pnlBookingForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBookingForm
            // 
            pnlBookingForm.Anchor = AnchorStyles.Top;
            pnlBookingForm.Controls.Add(cmbCinema);
            pnlBookingForm.Controls.Add(lblCinema);
            pnlBookingForm.Controls.Add(flpSeats);
            pnlBookingForm.Controls.Add(cmbMovie);
            pnlBookingForm.Controls.Add(cmbShow);
            pnlBookingForm.Controls.Add(btnClear);
            pnlBookingForm.Controls.Add(btnAdd);
            pnlBookingForm.Controls.Add(lblShow);
            pnlBookingForm.Controls.Add(lblMovieName);
            pnlBookingForm.Location = new Point(178, 112);
            pnlBookingForm.Name = "pnlBookingForm";
            pnlBookingForm.Size = new Size(1019, 1026);
            pnlBookingForm.TabIndex = 5;
            // 
            // cmbCinema
            // 
            cmbCinema.DisplayMember = "Name";
            cmbCinema.FormattingEnabled = true;
            cmbCinema.Location = new Point(244, 74);
            cmbCinema.Name = "cmbCinema";
            cmbCinema.Size = new Size(500, 33);
            cmbCinema.TabIndex = 44;
            cmbCinema.ValueMember = "Id";
            cmbCinema.SelectedIndexChanged += cmbCinema_SelectedIndexChanged;
            // 
            // lblCinema
            // 
            lblCinema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCinema.AutoSize = true;
            lblCinema.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCinema.Location = new Point(244, 44);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(81, 27);
            lblCinema.TabIndex = 43;
            lblCinema.Text = "Sinema";
            // 
            // flpSeats
            // 
            flpSeats.Location = new Point(76, 349);
            flpSeats.Name = "flpSeats";
            flpSeats.Size = new Size(870, 441);
            flpSeats.TabIndex = 42;
            // 
            // cmbMovie
            // 
            cmbMovie.DisplayMember = "Title";
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(244, 162);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(500, 33);
            cmbMovie.TabIndex = 39;
            cmbMovie.ValueMember = "Id";
            cmbMovie.SelectedIndexChanged += cmbMovie_SelectedIndexChanged;
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
            btnClear.Location = new Point(479, 846);
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
            btnAdd.Location = new Point(606, 846);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            lblMovieName.Location = new Point(244, 132);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(52, 27);
            lblMovieName.TabIndex = 18;
            lblMovieName.Text = "Film";
            // 
            // lblAddBooking
            // 
            lblAddBooking.AutoSize = true;
            lblAddBooking.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAddBooking.Location = new Point(13, 12);
            lblAddBooking.Name = "lblAddBooking";
            lblAddBooking.Size = new Size(279, 43);
            lblAddBooking.TabIndex = 6;
            lblAddBooking.Text = "Yeni Rezervasyon";
            // 
            // AddBookingUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(lblAddBooking);
            Controls.Add(pnlBookingForm);
            Name = "AddBookingUserControl";
            Size = new Size(1378, 1375);
            ParentChanged += AddBookingUserControl_ParentChanged;
            pnlBookingForm.ResumeLayout(false);
            pnlBookingForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBookingForm;
        private ComboBox cmbShow;
        private Button btnClear;
        private Button btnAdd;
        private Label lblShow;
        private Label lblMovieName;
        private Label lblAddBooking;
        private ComboBox cmbMovie;
        private FlowLayoutPanel flpSeats;
        private ComboBox cmbCinema;
        private Label lblCinema;
    }
}
