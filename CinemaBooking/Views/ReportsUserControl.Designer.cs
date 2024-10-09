namespace CinemaBooking.Views {
    partial class ReportsUserControl {
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabReports = new TabControl();
            tabMostWatchedMovies = new TabPage();
            dgwMostWatchedMovies = new DataGridView();
            colMovieTitle = new DataGridViewTextBoxColumn();
            colWatchCount = new DataGridViewTextBoxColumn();
            tabLeastWatchedMovies = new TabPage();
            dgwLeastWatchedMovies = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dgwMovieWithLength = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            colMovieDescription = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            dgwUsersWithAge = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colBirthday = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dgwViewerCountByMovieAndShow = new DataGridView();
            colShowId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colViewerCount = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dgwMovieCountsByLanguage = new DataGridView();
            colLanguage = new DataGridViewTextBoxColumn();
            colMovieCount = new DataGridViewTextBoxColumn();
            tabReports.SuspendLayout();
            tabMostWatchedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMostWatchedMovies).BeginInit();
            tabLeastWatchedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwLeastWatchedMovies).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMovieWithLength).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwUsersWithAge).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwViewerCountByMovieAndShow).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMovieCountsByLanguage).BeginInit();
            SuspendLayout();
            // 
            // tabReports
            // 
            tabReports.Controls.Add(tabMostWatchedMovies);
            tabReports.Controls.Add(tabLeastWatchedMovies);
            tabReports.Controls.Add(tabPage3);
            tabReports.Controls.Add(tabPage1);
            tabReports.Controls.Add(tabPage2);
            tabReports.Controls.Add(tabPage4);
            tabReports.Dock = DockStyle.Fill;
            tabReports.Location = new Point(0, 0);
            tabReports.Name = "tabReports";
            tabReports.SelectedIndex = 0;
            tabReports.Size = new Size(1486, 858);
            tabReports.TabIndex = 0;
            tabReports.Selected += tabReports_Selected;
            // 
            // tabMostWatchedMovies
            // 
            tabMostWatchedMovies.Controls.Add(dgwMostWatchedMovies);
            tabMostWatchedMovies.Location = new Point(4, 34);
            tabMostWatchedMovies.Name = "tabMostWatchedMovies";
            tabMostWatchedMovies.Padding = new Padding(3);
            tabMostWatchedMovies.Size = new Size(1478, 820);
            tabMostWatchedMovies.TabIndex = 0;
            tabMostWatchedMovies.Text = "En Çok İzlenen Filmler";
            tabMostWatchedMovies.UseVisualStyleBackColor = true;
            // 
            // dgwMostWatchedMovies
            // 
            dgwMostWatchedMovies.AllowUserToAddRows = false;
            dgwMostWatchedMovies.AllowUserToDeleteRows = false;
            dgwMostWatchedMovies.BackgroundColor = Color.Gainsboro;
            dgwMostWatchedMovies.BorderStyle = BorderStyle.None;
            dgwMostWatchedMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMostWatchedMovies.Columns.AddRange(new DataGridViewColumn[] { colMovieTitle, colWatchCount });
            dgwMostWatchedMovies.Dock = DockStyle.Fill;
            dgwMostWatchedMovies.Location = new Point(3, 3);
            dgwMostWatchedMovies.Name = "dgwMostWatchedMovies";
            dgwMostWatchedMovies.ReadOnly = true;
            dgwMostWatchedMovies.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwMostWatchedMovies.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwMostWatchedMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwMostWatchedMovies.Size = new Size(1472, 814);
            dgwMostWatchedMovies.TabIndex = 1;
            // 
            // colMovieTitle
            // 
            colMovieTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovieTitle.DataPropertyName = "Title";
            colMovieTitle.FillWeight = 50F;
            colMovieTitle.HeaderText = "Film";
            colMovieTitle.MinimumWidth = 8;
            colMovieTitle.Name = "colMovieTitle";
            colMovieTitle.ReadOnly = true;
            // 
            // colWatchCount
            // 
            colWatchCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colWatchCount.DataPropertyName = "WatchCount";
            colWatchCount.FillWeight = 50F;
            colWatchCount.HeaderText = "İzlenme Sayısı";
            colWatchCount.MinimumWidth = 8;
            colWatchCount.Name = "colWatchCount";
            colWatchCount.ReadOnly = true;
            // 
            // tabLeastWatchedMovies
            // 
            tabLeastWatchedMovies.Controls.Add(dgwLeastWatchedMovies);
            tabLeastWatchedMovies.Location = new Point(4, 34);
            tabLeastWatchedMovies.Name = "tabLeastWatchedMovies";
            tabLeastWatchedMovies.Padding = new Padding(3);
            tabLeastWatchedMovies.Size = new Size(1478, 820);
            tabLeastWatchedMovies.TabIndex = 1;
            tabLeastWatchedMovies.Text = "En Az İzlenen Filmler";
            tabLeastWatchedMovies.UseVisualStyleBackColor = true;
            // 
            // dgwLeastWatchedMovies
            // 
            dgwLeastWatchedMovies.AllowUserToAddRows = false;
            dgwLeastWatchedMovies.AllowUserToDeleteRows = false;
            dgwLeastWatchedMovies.BackgroundColor = Color.Gainsboro;
            dgwLeastWatchedMovies.BorderStyle = BorderStyle.None;
            dgwLeastWatchedMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLeastWatchedMovies.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgwLeastWatchedMovies.Dock = DockStyle.Fill;
            dgwLeastWatchedMovies.Location = new Point(3, 3);
            dgwLeastWatchedMovies.Name = "dgwLeastWatchedMovies";
            dgwLeastWatchedMovies.ReadOnly = true;
            dgwLeastWatchedMovies.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwLeastWatchedMovies.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgwLeastWatchedMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwLeastWatchedMovies.Size = new Size(1472, 814);
            dgwLeastWatchedMovies.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            dataGridViewTextBoxColumn1.FillWeight = 50F;
            dataGridViewTextBoxColumn1.HeaderText = "Film";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "WatchCount";
            dataGridViewTextBoxColumn2.FillWeight = 50F;
            dataGridViewTextBoxColumn2.HeaderText = "İzlenme Sayısı";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgwMovieWithLength);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1478, 820);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Film Uzunlukları";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgwMovieWithLength
            // 
            dgwMovieWithLength.AllowUserToAddRows = false;
            dgwMovieWithLength.AllowUserToDeleteRows = false;
            dgwMovieWithLength.BackgroundColor = Color.Gainsboro;
            dgwMovieWithLength.BorderStyle = BorderStyle.None;
            dgwMovieWithLength.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMovieWithLength.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, colMovieDescription, colDuration, dataGridViewTextBoxColumn4 });
            dgwMovieWithLength.Dock = DockStyle.Fill;
            dgwMovieWithLength.Location = new Point(3, 3);
            dgwMovieWithLength.Name = "dgwMovieWithLength";
            dgwMovieWithLength.ReadOnly = true;
            dgwMovieWithLength.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwMovieWithLength.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgwMovieWithLength.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwMovieWithLength.Size = new Size(1472, 814);
            dgwMovieWithLength.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            dataGridViewTextBoxColumn3.FillWeight = 50F;
            dataGridViewTextBoxColumn3.HeaderText = "Film";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // colMovieDescription
            // 
            colMovieDescription.DataPropertyName = "Description";
            colMovieDescription.HeaderText = "Açıklama";
            colMovieDescription.MinimumWidth = 8;
            colMovieDescription.Name = "colMovieDescription";
            colMovieDescription.ReadOnly = true;
            colMovieDescription.Width = 150;
            // 
            // colDuration
            // 
            colDuration.DataPropertyName = "Duration";
            colDuration.HeaderText = "Süre (dk)";
            colDuration.MinimumWidth = 8;
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            colDuration.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Length";
            dataGridViewTextBoxColumn4.FillWeight = 50F;
            dataGridViewTextBoxColumn4.HeaderText = "Uzunluk";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgwUsersWithAge);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1478, 820);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Kullanıcı Yaşları";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwUsersWithAge
            // 
            dgwUsersWithAge.AllowUserToAddRows = false;
            dgwUsersWithAge.AllowUserToDeleteRows = false;
            dgwUsersWithAge.BackgroundColor = Color.Gainsboro;
            dgwUsersWithAge.BorderStyle = BorderStyle.None;
            dgwUsersWithAge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUsersWithAge.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUsername, colBirthday, colAge });
            dgwUsersWithAge.Dock = DockStyle.Fill;
            dgwUsersWithAge.Location = new Point(3, 3);
            dgwUsersWithAge.Name = "dgwUsersWithAge";
            dgwUsersWithAge.ReadOnly = true;
            dgwUsersWithAge.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwUsersWithAge.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgwUsersWithAge.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwUsersWithAge.Size = new Size(1472, 814);
            dgwUsersWithAge.TabIndex = 0;
            // 
            // colUserId
            // 
            colUserId.DataPropertyName = "Id";
            colUserId.HeaderText = "Id";
            colUserId.MinimumWidth = 8;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Width = 150;
            // 
            // colUsername
            // 
            colUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Kullanıcı Adı";
            colUsername.MinimumWidth = 8;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colBirthday
            // 
            colBirthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBirthday.DataPropertyName = "Birthday";
            colBirthday.HeaderText = "Doğum Tarihi";
            colBirthday.MinimumWidth = 8;
            colBirthday.Name = "colBirthday";
            colBirthday.ReadOnly = true;
            // 
            // colAge
            // 
            colAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAge.DataPropertyName = "Age";
            colAge.HeaderText = "Yaş";
            colAge.MinimumWidth = 8;
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgwViewerCountByMovieAndShow);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1478, 820);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Film ve Seans İzleyici Sayısı";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgwViewerCountByMovieAndShow
            // 
            dgwViewerCountByMovieAndShow.AllowUserToAddRows = false;
            dgwViewerCountByMovieAndShow.AllowUserToDeleteRows = false;
            dgwViewerCountByMovieAndShow.BackgroundColor = Color.Gainsboro;
            dgwViewerCountByMovieAndShow.BorderStyle = BorderStyle.None;
            dgwViewerCountByMovieAndShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwViewerCountByMovieAndShow.Columns.AddRange(new DataGridViewColumn[] { colShowId, colTitle, colViewerCount });
            dgwViewerCountByMovieAndShow.Dock = DockStyle.Fill;
            dgwViewerCountByMovieAndShow.Location = new Point(3, 3);
            dgwViewerCountByMovieAndShow.Name = "dgwViewerCountByMovieAndShow";
            dgwViewerCountByMovieAndShow.ReadOnly = true;
            dgwViewerCountByMovieAndShow.RowHeadersWidth = 62;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwViewerCountByMovieAndShow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgwViewerCountByMovieAndShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwViewerCountByMovieAndShow.Size = new Size(1472, 814);
            dgwViewerCountByMovieAndShow.TabIndex = 0;
            // 
            // colShowId
            // 
            colShowId.DataPropertyName = "ShowId";
            colShowId.HeaderText = "Seans Id";
            colShowId.MinimumWidth = 8;
            colShowId.Name = "colShowId";
            colShowId.ReadOnly = true;
            colShowId.Width = 150;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Film";
            colTitle.MinimumWidth = 8;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colViewerCount
            // 
            colViewerCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colViewerCount.DataPropertyName = "WatchCount";
            colViewerCount.HeaderText = "İzleyici Sayısı";
            colViewerCount.MinimumWidth = 8;
            colViewerCount.Name = "colViewerCount";
            colViewerCount.ReadOnly = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgwMovieCountsByLanguage);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1478, 820);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Dile Göre Film Sayısı";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgwMovieCountsByLanguage
            // 
            dgwMovieCountsByLanguage.AllowUserToAddRows = false;
            dgwMovieCountsByLanguage.AllowUserToDeleteRows = false;
            dgwMovieCountsByLanguage.BackgroundColor = Color.Gainsboro;
            dgwMovieCountsByLanguage.BorderStyle = BorderStyle.None;
            dgwMovieCountsByLanguage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMovieCountsByLanguage.Columns.AddRange(new DataGridViewColumn[] { colLanguage, colMovieCount });
            dgwMovieCountsByLanguage.Dock = DockStyle.Fill;
            dgwMovieCountsByLanguage.Location = new Point(3, 3);
            dgwMovieCountsByLanguage.Name = "dgwMovieCountsByLanguage";
            dgwMovieCountsByLanguage.ReadOnly = true;
            dgwMovieCountsByLanguage.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwMovieCountsByLanguage.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgwMovieCountsByLanguage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwMovieCountsByLanguage.Size = new Size(1472, 814);
            dgwMovieCountsByLanguage.TabIndex = 0;
            // 
            // colLanguage
            // 
            colLanguage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLanguage.DataPropertyName = "Language";
            colLanguage.HeaderText = "Dil";
            colLanguage.MinimumWidth = 8;
            colLanguage.Name = "colLanguage";
            colLanguage.ReadOnly = true;
            // 
            // colMovieCount
            // 
            colMovieCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMovieCount.DataPropertyName = "MovieCount";
            colMovieCount.HeaderText = "Film Sayısı";
            colMovieCount.MinimumWidth = 8;
            colMovieCount.Name = "colMovieCount";
            colMovieCount.ReadOnly = true;
            // 
            // ReportsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabReports);
            Name = "ReportsUserControl";
            Size = new Size(1486, 858);
            Load += ReportsUserControl_Load;
            tabReports.ResumeLayout(false);
            tabMostWatchedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwMostWatchedMovies).EndInit();
            tabLeastWatchedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwLeastWatchedMovies).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwMovieWithLength).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwUsersWithAge).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwViewerCountByMovieAndShow).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwMovieCountsByLanguage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabReports;
        private TabPage tabMostWatchedMovies;
        private TabPage tabLeastWatchedMovies;
        private TabPage tabPage3;
        private DataGridView dgwMostWatchedMovies;
        private DataGridView dgwLeastWatchedMovies;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private DataGridView dgwMovieWithLength;
        private DataGridView dgwUsersWithAge;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colBirthday;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colMovieTitle;
        private DataGridViewTextBoxColumn colWatchCount;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dgwMovieCountsByLanguage;
        private DataGridView dgwViewerCountByMovieAndShow;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn colMovieDescription;
        private DataGridViewTextBoxColumn colDuration;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn colShowId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colViewerCount;
        private DataGridViewTextBoxColumn colLanguage;
        private DataGridViewTextBoxColumn colMovieCount;
    }
}
