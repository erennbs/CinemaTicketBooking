namespace CinemaBooking.Views {
    partial class AddShowUserControl {
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
            lblAddShow = new Label();
            pnlShowForm = new Panel();
            cmbCinema = new ComboBox();
            lblCinema = new Label();
            dtpEndTime = new DateTimePicker();
            lblEnd = new Label();
            cmbMovie = new ComboBox();
            btnClear = new Button();
            btnAdd = new Button();
            dtpStartTime = new DateTimePicker();
            lblStart = new Label();
            cmbHall = new ComboBox();
            lblHall = new Label();
            lblMovie = new Label();
            pnlShowForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddShow
            // 
            lblAddShow.AutoSize = true;
            lblAddShow.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAddShow.Location = new Point(17, 17);
            lblAddShow.Name = "lblAddShow";
            lblAddShow.Size = new Size(174, 43);
            lblAddShow.TabIndex = 1;
            lblAddShow.Text = "Seans Ekle";
            // 
            // pnlShowForm
            // 
            pnlShowForm.Anchor = AnchorStyles.Top;
            pnlShowForm.Controls.Add(cmbCinema);
            pnlShowForm.Controls.Add(lblCinema);
            pnlShowForm.Controls.Add(dtpEndTime);
            pnlShowForm.Controls.Add(lblEnd);
            pnlShowForm.Controls.Add(cmbMovie);
            pnlShowForm.Controls.Add(btnClear);
            pnlShowForm.Controls.Add(btnAdd);
            pnlShowForm.Controls.Add(dtpStartTime);
            pnlShowForm.Controls.Add(lblStart);
            pnlShowForm.Controls.Add(cmbHall);
            pnlShowForm.Controls.Add(lblHall);
            pnlShowForm.Controls.Add(lblMovie);
            pnlShowForm.Location = new Point(250, 77);
            pnlShowForm.Name = "pnlShowForm";
            pnlShowForm.Size = new Size(700, 581);
            pnlShowForm.TabIndex = 3;
            // 
            // cmbCinema
            // 
            cmbCinema.DisplayMember = "Name";
            cmbCinema.FormattingEnabled = true;
            cmbCinema.Location = new Point(93, 165);
            cmbCinema.Name = "cmbCinema";
            cmbCinema.Size = new Size(500, 33);
            cmbCinema.TabIndex = 38;
            cmbCinema.ValueMember = "Id";
            cmbCinema.SelectedIndexChanged += cmbCinema_SelectedIndexChanged;
            // 
            // lblCinema
            // 
            lblCinema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCinema.AutoSize = true;
            lblCinema.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCinema.Location = new Point(93, 135);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(81, 27);
            lblCinema.TabIndex = 37;
            lblCinema.Text = "Sinema";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(358, 346);
            dtpEndTime.MaximumSize = new Size(235, 0);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(235, 31);
            dtpEndTime.TabIndex = 36;
            // 
            // lblEnd
            // 
            lblEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblEnd.Location = new Point(358, 316);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(56, 27);
            lblEnd.TabIndex = 35;
            lblEnd.Text = "Bitiş";
            // 
            // cmbMovie
            // 
            cmbMovie.DisplayMember = "Title";
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(93, 77);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(500, 33);
            cmbMovie.TabIndex = 34;
            cmbMovie.ValueMember = "Id";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft New Tai Lue", 10F);
            btnClear.Location = new Point(328, 452);
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
            btnAdd.Location = new Point(455, 452);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(93, 346);
            dtpStartTime.MaximumSize = new Size(235, 0);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(235, 31);
            dtpStartTime.TabIndex = 31;
            // 
            // lblStart
            // 
            lblStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblStart.Location = new Point(93, 316);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(104, 27);
            lblStart.TabIndex = 28;
            lblStart.Text = "Başlangıç";
            // 
            // cmbHall
            // 
            cmbHall.DisplayMember = "Number";
            cmbHall.FormattingEnabled = true;
            cmbHall.Location = new Point(93, 251);
            cmbHall.Name = "cmbHall";
            cmbHall.Size = new Size(500, 33);
            cmbHall.TabIndex = 23;
            cmbHall.ValueMember = "Id";
            // 
            // lblHall
            // 
            lblHall.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHall.AutoSize = true;
            lblHall.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblHall.Location = new Point(93, 221);
            lblHall.Name = "lblHall";
            lblHall.Size = new Size(64, 27);
            lblHall.TabIndex = 20;
            lblHall.Text = "Salon";
            // 
            // lblMovie
            // 
            lblMovie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMovie.AutoSize = true;
            lblMovie.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblMovie.Location = new Point(93, 47);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(52, 27);
            lblMovie.TabIndex = 18;
            lblMovie.Text = "Film";
            // 
            // AddShowUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlShowForm);
            Controls.Add(lblAddShow);
            Name = "AddShowUserControl";
            Size = new Size(1200, 750);
            Load += AddShowUserControl_Load;
            ParentChanged += AddShowUserControl_ParentChanged;
            pnlShowForm.ResumeLayout(false);
            pnlShowForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddShow;
        private Panel pnlShowForm;
        private Button btnClear;
        private Button btnAdd;
        private DateTimePicker dtpStartTime;
        private Label lblStart;
        private ComboBox cmbHall;
        private Label lblHall;
        private Label lblMovie;
        private ComboBox cmbMovie;
        private DateTimePicker dtpEndTime;
        private Label lblEnd;
        private ComboBox cmbCinema;
        private Label lblCinema;
    }
}
