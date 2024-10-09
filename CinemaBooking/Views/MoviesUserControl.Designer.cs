namespace CinemaBooking.Views {
    partial class MoviesUserControl {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dgwMovies = new DataGridView();
            movieId = new DataGridViewTextBoxColumn();
            colMovieName = new DataGridViewTextBoxColumn();
            colMovieDescription = new DataGridViewTextBoxColumn();
            colMovieGenre = new DataGridViewTextBoxColumn();
            colMovieLanguage = new DataGridViewTextBoxColumn();
            colMovieDuration = new DataGridViewTextBoxColumn();
            colMovieRelaseDate = new DataGridViewTextBoxColumn();
            colMoviePrice = new DataGridViewTextBoxColumn();
            colEditButton = new DataGridViewButtonColumn();
            colDeleteButton = new DataGridViewButtonColumn();
            btnFilter = new Button();
            lblLanguageFilter = new Label();
            cmbLanguageFilter = new ComboBox();
            lblGenreFilter = new Label();
            cmbGenreFilter = new ComboBox();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwMovies).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(122, 43);
            label1.TabIndex = 0;
            label1.Text = "Filmler";
            // 
            // dgwMovies
            // 
            dgwMovies.AllowUserToAddRows = false;
            dgwMovies.AllowUserToDeleteRows = false;
            dgwMovies.AllowUserToOrderColumns = true;
            dgwMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwMovies.BackgroundColor = Color.Gainsboro;
            dgwMovies.BorderStyle = BorderStyle.None;
            dgwMovies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgwMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMovies.Columns.AddRange(new DataGridViewColumn[] { movieId, colMovieName, colMovieDescription, colMovieGenre, colMovieLanguage, colMovieDuration, colMovieRelaseDate, colMoviePrice, colEditButton, colDeleteButton });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwMovies.DefaultCellStyle = dataGridViewCellStyle2;
            dgwMovies.Location = new Point(16, 200);
            dgwMovies.Name = "dgwMovies";
            dgwMovies.ReadOnly = true;
            dgwMovies.RowHeadersWidth = 62;
            dgwMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwMovies.Size = new Size(1298, 545);
            dgwMovies.TabIndex = 1;
            dgwMovies.CellContentClick += dgwMovies_CellContentClick;
            dgwMovies.CellMouseDoubleClick += dgwMovies_CellMouseDoubleClick;
            // 
            // movieId
            // 
            movieId.DataPropertyName = "Id";
            movieId.HeaderText = "Id";
            movieId.MinimumWidth = 8;
            movieId.Name = "movieId";
            movieId.ReadOnly = true;
            movieId.Width = 50;
            // 
            // colMovieName
            // 
            colMovieName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovieName.DataPropertyName = "Title";
            colMovieName.HeaderText = "Film Adı";
            colMovieName.MinimumWidth = 8;
            colMovieName.Name = "colMovieName";
            colMovieName.ReadOnly = true;
            // 
            // colMovieDescription
            // 
            colMovieDescription.DataPropertyName = "Description";
            colMovieDescription.HeaderText = "Açıklama";
            colMovieDescription.MinimumWidth = 8;
            colMovieDescription.Name = "colMovieDescription";
            colMovieDescription.ReadOnly = true;
            colMovieDescription.Width = 200;
            // 
            // colMovieGenre
            // 
            colMovieGenre.DataPropertyName = "Genre";
            colMovieGenre.HeaderText = "Tür";
            colMovieGenre.MinimumWidth = 8;
            colMovieGenre.Name = "colMovieGenre";
            colMovieGenre.ReadOnly = true;
            colMovieGenre.Width = 150;
            // 
            // colMovieLanguage
            // 
            colMovieLanguage.DataPropertyName = "Language";
            colMovieLanguage.HeaderText = "Dil";
            colMovieLanguage.MinimumWidth = 8;
            colMovieLanguage.Name = "colMovieLanguage";
            colMovieLanguage.ReadOnly = true;
            colMovieLanguage.Width = 150;
            // 
            // colMovieDuration
            // 
            colMovieDuration.DataPropertyName = "Duration";
            colMovieDuration.HeaderText = "Süre";
            colMovieDuration.MinimumWidth = 8;
            colMovieDuration.Name = "colMovieDuration";
            colMovieDuration.ReadOnly = true;
            colMovieDuration.Width = 150;
            // 
            // colMovieRelaseDate
            // 
            colMovieRelaseDate.DataPropertyName = "ReleaseDate";
            colMovieRelaseDate.HeaderText = "Yayın Tarihi";
            colMovieRelaseDate.MinimumWidth = 8;
            colMovieRelaseDate.Name = "colMovieRelaseDate";
            colMovieRelaseDate.ReadOnly = true;
            colMovieRelaseDate.Width = 150;
            // 
            // colMoviePrice
            // 
            colMoviePrice.DataPropertyName = "TicketPrice";
            colMoviePrice.HeaderText = "Ücret (TL)";
            colMoviePrice.MinimumWidth = 8;
            colMoviePrice.Name = "colMoviePrice";
            colMoviePrice.ReadOnly = true;
            colMoviePrice.Width = 150;
            // 
            // colEditButton
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            colEditButton.DefaultCellStyle = dataGridViewCellStyle1;
            colEditButton.FlatStyle = FlatStyle.Flat;
            colEditButton.HeaderText = "";
            colEditButton.MinimumWidth = 8;
            colEditButton.Name = "colEditButton";
            colEditButton.ReadOnly = true;
            colEditButton.Resizable = DataGridViewTriState.False;
            colEditButton.Text = "Düzenle";
            colEditButton.UseColumnTextForButtonValue = true;
            colEditButton.Width = 150;
            // 
            // colDeleteButton
            // 
            colDeleteButton.FlatStyle = FlatStyle.Flat;
            colDeleteButton.HeaderText = "";
            colDeleteButton.MinimumWidth = 8;
            colDeleteButton.Name = "colDeleteButton";
            colDeleteButton.ReadOnly = true;
            colDeleteButton.Resizable = DataGridViewTriState.False;
            colDeleteButton.Text = "Sil";
            colDeleteButton.UseColumnTextForButtonValue = true;
            colDeleteButton.Width = 50;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(47, 54, 69);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(560, 126);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 11;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblLanguageFilter
            // 
            lblLanguageFilter.AutoSize = true;
            lblLanguageFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLanguageFilter.Location = new Point(16, 100);
            lblLanguageFilter.Name = "lblLanguageFilter";
            lblLanguageFilter.Size = new Size(33, 24);
            lblLanguageFilter.TabIndex = 10;
            lblLanguageFilter.Text = "Dil";
            // 
            // cmbLanguageFilter
            // 
            cmbLanguageFilter.DisplayMember = "Name";
            cmbLanguageFilter.FormattingEnabled = true;
            cmbLanguageFilter.Location = new Point(16, 128);
            cmbLanguageFilter.Name = "cmbLanguageFilter";
            cmbLanguageFilter.Size = new Size(199, 33);
            cmbLanguageFilter.TabIndex = 9;
            cmbLanguageFilter.ValueMember = "Id";
            // 
            // lblGenreFilter
            // 
            lblGenreFilter.AutoSize = true;
            lblGenreFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenreFilter.Location = new Point(269, 100);
            lblGenreFilter.Name = "lblGenreFilter";
            lblGenreFilter.Size = new Size(39, 24);
            lblGenreFilter.TabIndex = 13;
            lblGenreFilter.Text = "Tür";
            // 
            // cmbGenreFilter
            // 
            cmbGenreFilter.DisplayMember = "Name";
            cmbGenreFilter.FormattingEnabled = true;
            cmbGenreFilter.Location = new Point(269, 128);
            cmbGenreFilter.Name = "cmbGenreFilter";
            cmbGenreFilter.Size = new Size(199, 33);
            cmbGenreFilter.TabIndex = 12;
            cmbGenreFilter.ValueMember = "Id";
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.White;
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(717, 126);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(112, 34);
            btnResetFilter.TabIndex = 14;
            btnResetFilter.Text = "Sıfırla";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // MoviesUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnResetFilter);
            Controls.Add(lblGenreFilter);
            Controls.Add(cmbGenreFilter);
            Controls.Add(btnFilter);
            Controls.Add(lblLanguageFilter);
            Controls.Add(cmbLanguageFilter);
            Controls.Add(dgwMovies);
            Controls.Add(label1);
            Name = "MoviesUserControl";
            Size = new Size(1333, 766);
            ParentChanged += MoviesUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgwMovies;
        private Button btnFilter;
        private Label lblLanguageFilter;
        private ComboBox cmbLanguageFilter;
        private Label lblGenreFilter;
        private ComboBox cmbGenreFilter;
        private DataGridViewTextBoxColumn movieId;
        private DataGridViewTextBoxColumn colMovieName;
        private DataGridViewTextBoxColumn colMovieDescription;
        private DataGridViewTextBoxColumn colMovieGenre;
        private DataGridViewTextBoxColumn colMovieLanguage;
        private DataGridViewTextBoxColumn colMovieDuration;
        private DataGridViewTextBoxColumn colMovieRelaseDate;
        private DataGridViewTextBoxColumn colMoviePrice;
        private DataGridViewButtonColumn colEditButton;
        private DataGridViewButtonColumn colDeleteButton;
        private Button btnResetFilter;
    }
}
