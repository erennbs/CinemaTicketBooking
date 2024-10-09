namespace CinemaBooking.Views {
    partial class MovieDetailsUserControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetailsUserControl));
            panel1 = new Panel();
            lblDurationVal = new Label();
            lblDuration = new Label();
            lblReleaseDateVal = new Label();
            lblReleaseDate = new Label();
            lblGenreVal = new Label();
            lblGenre = new Label();
            lblLanguageVal = new Label();
            lblLanguage = new Label();
            lblDescription = new Label();
            pbxMovieImage = new PictureBox();
            lblMovieName = new Label();
            panel2 = new Panel();
            flpShows = new FlowLayoutPanel();
            lblShows = new Label();
            btnPreviousPage = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMovieImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDurationVal);
            panel1.Controls.Add(lblDuration);
            panel1.Controls.Add(lblReleaseDateVal);
            panel1.Controls.Add(lblReleaseDate);
            panel1.Controls.Add(lblGenreVal);
            panel1.Controls.Add(lblGenre);
            panel1.Controls.Add(lblLanguageVal);
            panel1.Controls.Add(lblLanguage);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(pbxMovieImage);
            panel1.Controls.Add(lblMovieName);
            panel1.Font = new Font("Segoe UI", 10F);
            panel1.Location = new Point(16, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 337);
            panel1.TabIndex = 0;
            // 
            // lblDurationVal
            // 
            lblDurationVal.AutoSize = true;
            lblDurationVal.Font = new Font("Microsoft New Tai Lue", 10F);
            lblDurationVal.Location = new Point(810, 237);
            lblDurationVal.Name = "lblDurationVal";
            lblDurationVal.Size = new Size(45, 26);
            lblDurationVal.TabIndex = 13;
            lblDurationVal.Text = "121";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblDuration.Location = new Point(674, 237);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(108, 27);
            lblDuration.TabIndex = 12;
            lblDuration.Text = "Süre (dk) :";
            // 
            // lblReleaseDateVal
            // 
            lblReleaseDateVal.AutoSize = true;
            lblReleaseDateVal.Font = new Font("Microsoft New Tai Lue", 10F);
            lblReleaseDateVal.Location = new Point(810, 199);
            lblReleaseDateVal.Name = "lblReleaseDateVal";
            lblReleaseDateVal.Size = new Size(94, 26);
            lblReleaseDateVal.TabIndex = 11;
            lblReleaseDateVal.Text = "01/01/24";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblReleaseDate.Location = new Point(674, 199);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(130, 27);
            lblReleaseDate.TabIndex = 10;
            lblReleaseDate.Text = "Yayın Tarihi:";
            // 
            // lblGenreVal
            // 
            lblGenreVal.AutoSize = true;
            lblGenreVal.Font = new Font("Microsoft New Tai Lue", 10F);
            lblGenreVal.Location = new Point(330, 238);
            lblGenreVal.Name = "lblGenreVal";
            lblGenreVal.Size = new Size(81, 26);
            lblGenreVal.TabIndex = 9;
            lblGenreVal.Text = "Aksiyon";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblGenre.Location = new Point(280, 237);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(49, 27);
            lblGenre.TabIndex = 8;
            lblGenre.Text = "Tür:";
            // 
            // lblLanguageVal
            // 
            lblLanguageVal.AutoSize = true;
            lblLanguageVal.Font = new Font("Microsoft New Tai Lue", 10F);
            lblLanguageVal.Location = new Point(329, 200);
            lblLanguageVal.Name = "lblLanguageVal";
            lblLanguageVal.Size = new Size(69, 26);
            lblLanguageVal.TabIndex = 7;
            lblLanguageVal.Text = "Türkçe";
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblLanguage.Location = new Point(279, 199);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(44, 27);
            lblLanguage.TabIndex = 6;
            lblLanguage.Text = "Dil:";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Microsoft New Tai Lue", 10F);
            lblDescription.Location = new Point(280, 66);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1000, 115);
            lblDescription.TabIndex = 5;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // pbxMovieImage
            // 
            pbxMovieImage.BackColor = SystemColors.Control;
            pbxMovieImage.Location = new Point(10, 17);
            pbxMovieImage.Name = "pbxMovieImage";
            pbxMovieImage.Size = new Size(240, 300);
            pbxMovieImage.TabIndex = 4;
            pbxMovieImage.TabStop = false;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Microsoft New Tai Lue", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(277, 17);
            lblMovieName.Margin = new Padding(0);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(127, 37);
            lblMovieName.TabIndex = 3;
            lblMovieName.Text = "Film Adı";
            // 
            // panel2
            // 
            panel2.Controls.Add(flpShows);
            panel2.Controls.Add(lblShows);
            panel2.Location = new Point(16, 399);
            panel2.Name = "panel2";
            panel2.Size = new Size(1284, 162);
            panel2.TabIndex = 1;
            // 
            // flpShows
            // 
            flpShows.Location = new Point(10, 43);
            flpShows.Name = "flpShows";
            flpShows.Size = new Size(1270, 104);
            flpShows.TabIndex = 5;
            // 
            // lblShows
            // 
            lblShows.AutoSize = true;
            lblShows.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShows.Location = new Point(6, 9);
            lblShows.Margin = new Padding(0);
            lblShows.Name = "lblShows";
            lblShows.Size = new Size(109, 31);
            lblShows.TabIndex = 4;
            lblShows.Text = "Seanslar";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.Location = new Point(16, 10);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(112, 34);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "Geri";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // MovieDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(btnPreviousPage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MovieDetailsUserControl";
            Size = new Size(1319, 753);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMovieImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescription;
        private PictureBox pbxMovieImage;
        private Label lblMovieName;
        private Label lblLanguageVal;
        private Label lblLanguage;
        private Label lblGenreVal;
        private Label lblGenre;
        private Label lblReleaseDateVal;
        private Label lblReleaseDate;
        private Label lblDurationVal;
        private Label lblDuration;
        private Panel panel2;
        private Label lblShows;
        private Button btnPreviousPage;
        private FlowLayoutPanel flpShows;
    }
}
