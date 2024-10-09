namespace CinemaBooking.Views {
    partial class ShowsUserControl {
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblShows = new Label();
            dgwShows = new DataGridView();
            colShowId = new DataGridViewTextBoxColumn();
            colMovieName = new DataGridViewTextBoxColumn();
            colmovieStartTime = new DataGridViewTextBoxColumn();
            colMovieEndTime = new DataGridViewTextBoxColumn();
            colMovieCinema = new DataGridViewTextBoxColumn();
            colMovieHall = new DataGridViewTextBoxColumn();
            colEditBtn = new DataGridViewButtonColumn();
            colDeleteBtn = new DataGridViewButtonColumn();
            btnFilter = new Button();
            lblMovieFilter = new Label();
            cmbMovieFilter = new ComboBox();
            lblCinema = new Label();
            cmbCinemaFilter = new ComboBox();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwShows).BeginInit();
            SuspendLayout();
            // 
            // lblShows
            // 
            lblShows.AutoSize = true;
            lblShows.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblShows.Location = new Point(0, 9);
            lblShows.Name = "lblShows";
            lblShows.Size = new Size(143, 43);
            lblShows.TabIndex = 1;
            lblShows.Text = "Seanslar";
            // 
            // dgwShows
            // 
            dgwShows.AllowUserToAddRows = false;
            dgwShows.AllowUserToDeleteRows = false;
            dgwShows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwShows.BackgroundColor = Color.Gainsboro;
            dgwShows.BorderStyle = BorderStyle.None;
            dgwShows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwShows.Columns.AddRange(new DataGridViewColumn[] { colShowId, colMovieName, colmovieStartTime, colMovieEndTime, colMovieCinema, colMovieHall, colEditBtn, colDeleteBtn });
            dgwShows.Location = new Point(17, 218);
            dgwShows.Name = "dgwShows";
            dgwShows.ReadOnly = true;
            dgwShows.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwShows.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgwShows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwShows.Size = new Size(1218, 467);
            dgwShows.TabIndex = 3;
            dgwShows.CellContentClick += dgwShows_CellContentClick;
            // 
            // colShowId
            // 
            colShowId.DataPropertyName = "Id";
            colShowId.HeaderText = "Id";
            colShowId.MinimumWidth = 8;
            colShowId.Name = "colShowId";
            colShowId.ReadOnly = true;
            colShowId.Width = 150;
            // 
            // colMovieName
            // 
            colMovieName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovieName.DataPropertyName = "MovieTitle";
            colMovieName.HeaderText = "Film Adı";
            colMovieName.MinimumWidth = 8;
            colMovieName.Name = "colMovieName";
            colMovieName.ReadOnly = true;
            colMovieName.Resizable = DataGridViewTriState.True;
            // 
            // colmovieStartTime
            // 
            colmovieStartTime.DataPropertyName = "StartTime";
            colmovieStartTime.HeaderText = "Başlangıç";
            colmovieStartTime.MinimumWidth = 8;
            colmovieStartTime.Name = "colmovieStartTime";
            colmovieStartTime.ReadOnly = true;
            colmovieStartTime.Width = 150;
            // 
            // colMovieEndTime
            // 
            colMovieEndTime.DataPropertyName = "EndTime";
            colMovieEndTime.HeaderText = "Bitiş";
            colMovieEndTime.MinimumWidth = 8;
            colMovieEndTime.Name = "colMovieEndTime";
            colMovieEndTime.ReadOnly = true;
            colMovieEndTime.Width = 150;
            // 
            // colMovieCinema
            // 
            colMovieCinema.DataPropertyName = "CinemaName";
            colMovieCinema.HeaderText = "Sinema";
            colMovieCinema.MinimumWidth = 8;
            colMovieCinema.Name = "colMovieCinema";
            colMovieCinema.ReadOnly = true;
            colMovieCinema.Width = 150;
            // 
            // colMovieHall
            // 
            colMovieHall.DataPropertyName = "Hall";
            colMovieHall.HeaderText = "Salon";
            colMovieHall.MinimumWidth = 8;
            colMovieHall.Name = "colMovieHall";
            colMovieHall.ReadOnly = true;
            colMovieHall.Width = 150;
            // 
            // colEditBtn
            // 
            colEditBtn.FlatStyle = FlatStyle.Flat;
            colEditBtn.HeaderText = "";
            colEditBtn.MinimumWidth = 8;
            colEditBtn.Name = "colEditBtn";
            colEditBtn.ReadOnly = true;
            colEditBtn.Resizable = DataGridViewTriState.True;
            colEditBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            colEditBtn.Text = "Düzenle";
            colEditBtn.UseColumnTextForButtonValue = true;
            colEditBtn.Width = 150;
            // 
            // colDeleteBtn
            // 
            colDeleteBtn.FlatStyle = FlatStyle.Flat;
            colDeleteBtn.HeaderText = "";
            colDeleteBtn.MinimumWidth = 8;
            colDeleteBtn.Name = "colDeleteBtn";
            colDeleteBtn.ReadOnly = true;
            colDeleteBtn.Resizable = DataGridViewTriState.True;
            colDeleteBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            colDeleteBtn.Text = "Sil";
            colDeleteBtn.UseColumnTextForButtonValue = true;
            colDeleteBtn.Width = 50;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(47, 54, 69);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(718, 140);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblMovieFilter
            // 
            lblMovieFilter.AutoSize = true;
            lblMovieFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieFilter.Location = new Point(17, 114);
            lblMovieFilter.Name = "lblMovieFilter";
            lblMovieFilter.Size = new Size(45, 24);
            lblMovieFilter.TabIndex = 7;
            lblMovieFilter.Text = "Film";
            // 
            // cmbMovieFilter
            // 
            cmbMovieFilter.FormattingEnabled = true;
            cmbMovieFilter.Location = new Point(17, 142);
            cmbMovieFilter.Name = "cmbMovieFilter";
            cmbMovieFilter.Size = new Size(295, 33);
            cmbMovieFilter.TabIndex = 6;
            // 
            // lblCinema
            // 
            lblCinema.AutoSize = true;
            lblCinema.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCinema.Location = new Point(374, 114);
            lblCinema.Name = "lblCinema";
            lblCinema.Size = new Size(72, 24);
            lblCinema.TabIndex = 10;
            lblCinema.Text = "Sinema";
            // 
            // cmbCinemaFilter
            // 
            cmbCinemaFilter.DisplayMember = "Name";
            cmbCinemaFilter.FormattingEnabled = true;
            cmbCinemaFilter.Location = new Point(374, 142);
            cmbCinemaFilter.Name = "cmbCinemaFilter";
            cmbCinemaFilter.Size = new Size(238, 33);
            cmbCinemaFilter.TabIndex = 9;
            cmbCinemaFilter.ValueMember = "Id";
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.White;
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(859, 140);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(112, 34);
            btnResetFilter.TabIndex = 11;
            btnResetFilter.Text = "Sıfırla";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // ShowsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnResetFilter);
            Controls.Add(lblCinema);
            Controls.Add(cmbCinemaFilter);
            Controls.Add(btnFilter);
            Controls.Add(lblMovieFilter);
            Controls.Add(cmbMovieFilter);
            Controls.Add(dgwShows);
            Controls.Add(lblShows);
            Name = "ShowsUserControl";
            Size = new Size(1252, 699);
            ParentChanged += ShowsUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwShows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShows;
        private DataGridView dgwShows;
        private Button btnFilter;
        private Label lblMovieFilter;
        private ComboBox cmbMovieFilter;
        private DataGridViewTextBoxColumn colShowId;
        private DataGridViewTextBoxColumn colMovieName;
        private DataGridViewTextBoxColumn colmovieStartTime;
        private DataGridViewTextBoxColumn colMovieEndTime;
        private DataGridViewTextBoxColumn colMovieCinema;
        private DataGridViewTextBoxColumn colMovieHall;
        private DataGridViewButtonColumn colEditBtn;
        private DataGridViewButtonColumn colDeleteBtn;
        private Label lblCinema;
        private ComboBox cmbCinemaFilter;
        private Button btnResetFilter;
    }
}
