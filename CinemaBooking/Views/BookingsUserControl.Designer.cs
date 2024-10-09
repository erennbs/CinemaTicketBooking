namespace CinemaBooking.Views {
    partial class BookingsUserControl {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgwBookings = new DataGridView();
            colBookingId = new DataGridViewTextBoxColumn();
            colMovieName = new DataGridViewTextBoxColumn();
            colUserFullName = new DataGridViewTextBoxColumn();
            colCinema = new DataGridViewTextBoxColumn();
            colHall = new DataGridViewTextBoxColumn();
            colSeats = new DataGridViewTextBoxColumn();
            colStartTime = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            lblCinemas = new Label();
            btnFilter = new Button();
            lblMovieFilter = new Label();
            cmbMovieFilter = new ComboBox();
            lblCinemaFilter = new Label();
            cmbCinemaFilter = new ComboBox();
            lblHallFilter = new Label();
            cmbHallFilter = new ComboBox();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwBookings).BeginInit();
            SuspendLayout();
            // 
            // dgwBookings
            // 
            dgwBookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwBookings.BackgroundColor = Color.Gainsboro;
            dgwBookings.BorderStyle = BorderStyle.None;
            dgwBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBookings.Columns.AddRange(new DataGridViewColumn[] { colBookingId, colMovieName, colUserFullName, colCinema, colHall, colSeats, colStartTime, colEdit, colDelete });
            dgwBookings.Location = new Point(12, 226);
            dgwBookings.Name = "dgwBookings";
            dgwBookings.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwBookings.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwBookings.Size = new Size(1565, 525);
            dgwBookings.TabIndex = 3;
            dgwBookings.CellContentClick += dgwBookings_CellContentClick;
            // 
            // colBookingId
            // 
            colBookingId.DataPropertyName = "Id";
            colBookingId.HeaderText = "Id";
            colBookingId.MinimumWidth = 8;
            colBookingId.Name = "colBookingId";
            colBookingId.ReadOnly = true;
            colBookingId.Width = 150;
            // 
            // colMovieName
            // 
            colMovieName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovieName.DataPropertyName = "MovieTitle";
            colMovieName.HeaderText = "Film Adı";
            colMovieName.MinimumWidth = 8;
            colMovieName.Name = "colMovieName";
            // 
            // colUserFullName
            // 
            colUserFullName.DataPropertyName = "Username";
            colUserFullName.HeaderText = "Kullanıcı Adı";
            colUserFullName.MinimumWidth = 8;
            colUserFullName.Name = "colUserFullName";
            colUserFullName.Width = 300;
            // 
            // colCinema
            // 
            colCinema.DataPropertyName = "CinemaName";
            colCinema.HeaderText = "Sinema";
            colCinema.MinimumWidth = 8;
            colCinema.Name = "colCinema";
            colCinema.Width = 150;
            // 
            // colHall
            // 
            colHall.DataPropertyName = "HallNumber";
            colHall.HeaderText = "Salon";
            colHall.MinimumWidth = 8;
            colHall.Name = "colHall";
            colHall.Width = 150;
            // 
            // colSeats
            // 
            colSeats.DataPropertyName = "Seats";
            colSeats.HeaderText = "Koltuklar";
            colSeats.MinimumWidth = 8;
            colSeats.Name = "colSeats";
            colSeats.Width = 150;
            // 
            // colStartTime
            // 
            colStartTime.DataPropertyName = "StartTime";
            colStartTime.HeaderText = "Başlangıç";
            colStartTime.MinimumWidth = 8;
            colStartTime.Name = "colStartTime";
            colStartTime.Width = 150;
            // 
            // colEdit
            // 
            colEdit.FlatStyle = FlatStyle.Flat;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Text = "Düzenle";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 150;
            // 
            // colDelete
            // 
            colDelete.FlatStyle = FlatStyle.Flat;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.True;
            colDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            colDelete.Text = "Sil";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 50;
            // 
            // lblCinemas
            // 
            lblCinemas.AutoSize = true;
            lblCinemas.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblCinemas.Location = new Point(12, 11);
            lblCinemas.Name = "lblCinemas";
            lblCinemas.Size = new Size(245, 43);
            lblCinemas.TabIndex = 4;
            lblCinemas.Text = "Rezervasyonlar";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(47, 54, 69);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(986, 145);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 11;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblMovieFilter
            // 
            lblMovieFilter.AutoSize = true;
            lblMovieFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieFilter.Location = new Point(12, 117);
            lblMovieFilter.Name = "lblMovieFilter";
            lblMovieFilter.Size = new Size(45, 24);
            lblMovieFilter.TabIndex = 10;
            lblMovieFilter.Text = "Film";
            // 
            // cmbMovieFilter
            // 
            cmbMovieFilter.DisplayMember = "Title";
            cmbMovieFilter.FormattingEnabled = true;
            cmbMovieFilter.Location = new Point(12, 145);
            cmbMovieFilter.Name = "cmbMovieFilter";
            cmbMovieFilter.Size = new Size(295, 33);
            cmbMovieFilter.TabIndex = 9;
            cmbMovieFilter.ValueMember = "Id";
            // 
            // lblCinemaFilter
            // 
            lblCinemaFilter.AutoSize = true;
            lblCinemaFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCinemaFilter.Location = new Point(369, 117);
            lblCinemaFilter.Name = "lblCinemaFilter";
            lblCinemaFilter.Size = new Size(72, 24);
            lblCinemaFilter.TabIndex = 16;
            lblCinemaFilter.Text = "Sinema";
            // 
            // cmbCinemaFilter
            // 
            cmbCinemaFilter.DisplayMember = "Name";
            cmbCinemaFilter.FormattingEnabled = true;
            cmbCinemaFilter.Location = new Point(369, 145);
            cmbCinemaFilter.Name = "cmbCinemaFilter";
            cmbCinemaFilter.Size = new Size(225, 33);
            cmbCinemaFilter.TabIndex = 15;
            cmbCinemaFilter.ValueMember = "Id";
            cmbCinemaFilter.SelectedIndexChanged += cmbCinemaFilter_SelectedIndexChanged;
            // 
            // lblHallFilter
            // 
            lblHallFilter.AutoSize = true;
            lblHallFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHallFilter.Location = new Point(664, 117);
            lblHallFilter.Name = "lblHallFilter";
            lblHallFilter.Size = new Size(57, 24);
            lblHallFilter.TabIndex = 18;
            lblHallFilter.Text = "Salon";
            // 
            // cmbHallFilter
            // 
            cmbHallFilter.DisplayMember = "Number";
            cmbHallFilter.FormattingEnabled = true;
            cmbHallFilter.Location = new Point(664, 145);
            cmbHallFilter.Name = "cmbHallFilter";
            cmbHallFilter.Size = new Size(225, 33);
            cmbHallFilter.TabIndex = 17;
            cmbHallFilter.ValueMember = "Id";
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.White;
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(1140, 145);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(112, 34);
            btnResetFilter.TabIndex = 19;
            btnResetFilter.Text = "Sıfırla";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // BookingsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(btnResetFilter);
            Controls.Add(lblHallFilter);
            Controls.Add(cmbHallFilter);
            Controls.Add(lblCinemaFilter);
            Controls.Add(cmbCinemaFilter);
            Controls.Add(btnFilter);
            Controls.Add(lblMovieFilter);
            Controls.Add(cmbMovieFilter);
            Controls.Add(lblCinemas);
            Controls.Add(dgwBookings);
            Name = "BookingsUserControl";
            Size = new Size(1595, 764);
            Load += BookingsUserControl_Load;
            ParentChanged += BookingsUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwBookings;
        private Label lblCinemas;
        private Button btnFilter;
        private Label lblMovieFilter;
        private ComboBox cmbMovieFilter;
        private Label lblCinemaFilter;
        private ComboBox cmbCinemaFilter;
        private Label lblHallFilter;
        private ComboBox cmbHallFilter;
        private DataGridViewTextBoxColumn colBookingId;
        private DataGridViewTextBoxColumn colMovieName;
        private DataGridViewTextBoxColumn colUserFullName;
        private DataGridViewTextBoxColumn colCinema;
        private DataGridViewTextBoxColumn colHall;
        private DataGridViewTextBoxColumn colSeats;
        private DataGridViewTextBoxColumn colStartTime;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private Button btnResetFilter;
    }
}
