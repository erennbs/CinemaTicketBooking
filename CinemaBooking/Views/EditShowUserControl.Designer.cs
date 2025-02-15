namespace CinemaBooking.Views {
    partial class EditShowUserControl {
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
            pnlShowForm = new Panel();
            cmbCinema = new ComboBox();
            lblCinema = new Label();
            dtpEndTime = new DateTimePicker();
            lblEnd = new Label();
            cmbMovie = new ComboBox();
            btnClear = new Button();
            btnEdit = new Button();
            dtpStartTime = new DateTimePicker();
            lblStart = new Label();
            cmbHall = new ComboBox();
            lblHall = new Label();
            lblMovie = new Label();
            btnPreviousPage = new Button();
            pnlShowForm.SuspendLayout();
            SuspendLayout();
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
            pnlShowForm.Controls.Add(btnEdit);
            pnlShowForm.Controls.Add(dtpStartTime);
            pnlShowForm.Controls.Add(lblStart);
            pnlShowForm.Controls.Add(cmbHall);
            pnlShowForm.Controls.Add(lblHall);
            pnlShowForm.Controls.Add(lblMovie);
            pnlShowForm.Location = new Point(252, 75);
            pnlShowForm.Name = "pnlShowForm";
            pnlShowForm.Size = new Size(700, 581);
            pnlShowForm.TabIndex = 5;
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
            lblCinema.Size = new Size(90, 27);
            lblCinema.TabIndex = 37;
            lblCinema.Text = "Sinema*";
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
            lblEnd.Size = new Size(65, 27);
            lblEnd.TabIndex = 35;
            lblEnd.Text = "Bitiş*";
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
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(47, 54, 69);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft New Tai Lue", 10F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(455, 452);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 50);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            lblStart.Size = new Size(113, 27);
            lblStart.TabIndex = 28;
            lblStart.Text = "Başlangıç*";
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
            lblHall.Size = new Size(73, 27);
            lblHall.TabIndex = 20;
            lblHall.Text = "Salon*";
            // 
            // lblMovie
            // 
            lblMovie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMovie.AutoSize = true;
            lblMovie.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblMovie.Location = new Point(93, 47);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(61, 27);
            lblMovie.TabIndex = 18;
            lblMovie.Text = "Film*";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Location = new Point(12, 12);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(112, 34);
            btnPreviousPage.TabIndex = 8;
            btnPreviousPage.Text = "Geri";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // EditShowUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPreviousPage);
            Controls.Add(pnlShowForm);
            Name = "EditShowUserControl";
            Size = new Size(1200, 750);
            pnlShowForm.ResumeLayout(false);
            pnlShowForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlShowForm;
        private ComboBox cmbCinema;
        private Label lblCinema;
        private DateTimePicker dtpEndTime;
        private Label lblEnd;
        private ComboBox cmbMovie;
        private Button btnClear;
        private Button btnEdit;
        private DateTimePicker dtpStartTime;
        private Label lblStart;
        private ComboBox cmbHall;
        private Label lblHall;
        private Label lblMovie;
        private Button btnPreviousPage;
    }
}
