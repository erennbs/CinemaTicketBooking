namespace CinemaBooking.Views {
    partial class AddMovieUserControl {
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
            lblAddMovie = new Label();
            pnlMovieForm = new Panel();
            btnFilePicker = new Button();
            lblImage = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            dtpRelaseDate = new DateTimePicker();
            nudPrice = new NumericUpDown();
            lblPrice = new Label();
            label1 = new Label();
            nudDuration = new NumericUpDown();
            lblDuration = new Label();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            cmbLanguage = new ComboBox();
            lblLanguage = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtMovieName = new TextBox();
            lblMovieName = new Label();
            ofdImagePicker = new OpenFileDialog();
            pnlMovieForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // lblAddMovie
            // 
            lblAddMovie.AutoSize = true;
            lblAddMovie.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAddMovie.Location = new Point(15, 19);
            lblAddMovie.Name = "lblAddMovie";
            lblAddMovie.Size = new Size(153, 43);
            lblAddMovie.TabIndex = 1;
            lblAddMovie.Text = "Film Ekle";
            // 
            // pnlMovieForm
            // 
            pnlMovieForm.Anchor = AnchorStyles.Top;
            pnlMovieForm.Controls.Add(btnFilePicker);
            pnlMovieForm.Controls.Add(lblImage);
            pnlMovieForm.Controls.Add(btnClear);
            pnlMovieForm.Controls.Add(btnAdd);
            pnlMovieForm.Controls.Add(dtpRelaseDate);
            pnlMovieForm.Controls.Add(nudPrice);
            pnlMovieForm.Controls.Add(lblPrice);
            pnlMovieForm.Controls.Add(label1);
            pnlMovieForm.Controls.Add(nudDuration);
            pnlMovieForm.Controls.Add(lblDuration);
            pnlMovieForm.Controls.Add(cmbGenre);
            pnlMovieForm.Controls.Add(lblGenre);
            pnlMovieForm.Controls.Add(cmbLanguage);
            pnlMovieForm.Controls.Add(lblLanguage);
            pnlMovieForm.Controls.Add(txtDescription);
            pnlMovieForm.Controls.Add(lblDescription);
            pnlMovieForm.Controls.Add(txtMovieName);
            pnlMovieForm.Controls.Add(lblMovieName);
            pnlMovieForm.Location = new Point(291, 77);
            pnlMovieForm.Name = "pnlMovieForm";
            pnlMovieForm.Size = new Size(700, 663);
            pnlMovieForm.TabIndex = 2;
            // 
            // btnFilePicker
            // 
            btnFilePicker.BackColor = Color.Gainsboro;
            btnFilePicker.FlatAppearance.BorderColor = Color.Silver;
            btnFilePicker.FlatStyle = FlatStyle.Flat;
            btnFilePicker.Location = new Point(93, 502);
            btnFilePicker.Name = "btnFilePicker";
            btnFilePicker.Size = new Size(235, 34);
            btnFilePicker.TabIndex = 35;
            btnFilePicker.Text = "Dosya Seç";
            btnFilePicker.UseVisualStyleBackColor = false;
            btnFilePicker.Click += btnFilePicker_Click;
            // 
            // lblImage
            // 
            lblImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblImage.Location = new Point(93, 472);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(93, 27);
            lblImage.TabIndex = 34;
            lblImage.Text = "Fotoğraf";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft New Tai Lue", 10F);
            btnClear.Location = new Point(328, 586);
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
            btnAdd.Location = new Point(455, 586);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpRelaseDate
            // 
            dtpRelaseDate.Location = new Point(93, 412);
            dtpRelaseDate.MaximumSize = new Size(235, 0);
            dtpRelaseDate.Name = "dtpRelaseDate";
            dtpRelaseDate.Size = new Size(235, 31);
            dtpRelaseDate.TabIndex = 31;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(483, 412);
            nudPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.MaximumSize = new Size(110, 0);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(110, 31);
            nudPrice.TabIndex = 30;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblPrice.Location = new Point(483, 382);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 27);
            lblPrice.TabIndex = 29;
            lblPrice.Text = "Fiyat";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            label1.Location = new Point(93, 382);
            label1.Name = "label1";
            label1.Size = new Size(125, 27);
            label1.TabIndex = 28;
            label1.Text = "Yayın Tarihi";
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(359, 412);
            nudDuration.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudDuration.MaximumSize = new Size(110, 0);
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(110, 31);
            nudDuration.TabIndex = 27;
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblDuration.Location = new Point(358, 382);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(54, 27);
            lblDuration.TabIndex = 26;
            lblDuration.Text = "Süre";
            // 
            // cmbGenre
            // 
            cmbGenre.DisplayMember = "Name";
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(358, 327);
            cmbGenre.MaximumSize = new Size(235, 0);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(235, 33);
            cmbGenre.TabIndex = 25;
            cmbGenre.ValueMember = "Id";
            // 
            // lblGenre
            // 
            lblGenre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblGenre.Location = new Point(358, 297);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(44, 27);
            lblGenre.TabIndex = 24;
            lblGenre.Text = "Tür";
            // 
            // cmbLanguage
            // 
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Location = new Point(93, 327);
            cmbLanguage.MaximumSize = new Size(235, 0);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(235, 33);
            cmbLanguage.TabIndex = 23;
            cmbLanguage.ValueMember = "Id";
            // 
            // lblLanguage
            // 
            lblLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblLanguage.Location = new Point(93, 297);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(39, 27);
            lblLanguage.TabIndex = 22;
            lblLanguage.Text = "Dil";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(93, 177);
            txtDescription.MaximumSize = new Size(500, 102);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(500, 102);
            txtDescription.TabIndex = 21;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(93, 147);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(99, 27);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Açıklama";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(93, 77);
            txtMovieName.MaximumSize = new Size(500, 0);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(500, 31);
            txtMovieName.TabIndex = 19;
            // 
            // lblMovieName
            // 
            lblMovieName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblMovieName.Location = new Point(93, 47);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(90, 27);
            lblMovieName.TabIndex = 18;
            lblMovieName.Text = "Film Adı";
            // 
            // ofdImagePicker
            // 
            ofdImagePicker.Filter = "Image Files|*.jpg;*.jepg;*.png";
            ofdImagePicker.Title = "Resim Seç";
            // 
            // AddMovieUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlMovieForm);
            Controls.Add(lblAddMovie);
            Name = "AddMovieUserControl";
            Size = new Size(1283, 796);
            Load += AddMovieUserControl_Load;
            ParentChanged += AddMovieUserControl_ParentChanged;
            pnlMovieForm.ResumeLayout(false);
            pnlMovieForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddMovie;
        private Panel pnlMovieForm;
        private Button btnClear;
        private Button btnAdd;
        private DateTimePicker dtpRelaseDate;
        private NumericUpDown nudPrice;
        private Label lblPrice;
        private Label label1;
        private NumericUpDown nudDuration;
        private Label lblDuration;
        private ComboBox cmbGenre;
        private Label lblGenre;
        private ComboBox cmbLanguage;
        private Label lblLanguage;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtMovieName;
        private Label lblMovieName;
        private Button btnFilePicker;
        private Label lblImage;
        private OpenFileDialog ofdImagePicker;
    }
}
