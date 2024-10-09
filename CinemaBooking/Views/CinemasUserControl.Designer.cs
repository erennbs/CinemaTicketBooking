namespace CinemaBooking.Views {
    partial class CinemasUserControl {
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
            lblCinemas = new Label();
            dgwCinemas = new DataGridView();
            colCinemaId = new DataGridViewTextBoxColumn();
            colCinemaName = new DataGridViewTextBoxColumn();
            colCinemaCity = new DataGridViewTextBoxColumn();
            colEditBtn = new DataGridViewButtonColumn();
            colDeleteBtn = new DataGridViewButtonColumn();
            cmbCityFilter = new ComboBox();
            lblCityFilter = new Label();
            btnFilter = new Button();
            btnResetFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCinemas).BeginInit();
            SuspendLayout();
            // 
            // lblCinemas
            // 
            lblCinemas.AutoSize = true;
            lblCinemas.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblCinemas.Location = new Point(0, 9);
            lblCinemas.Name = "lblCinemas";
            lblCinemas.Size = new Size(167, 43);
            lblCinemas.TabIndex = 1;
            lblCinemas.Text = "Sinemalar";
            // 
            // dgwCinemas
            // 
            dgwCinemas.AllowUserToAddRows = false;
            dgwCinemas.AllowUserToDeleteRows = false;
            dgwCinemas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCinemas.BackgroundColor = Color.Gainsboro;
            dgwCinemas.BorderStyle = BorderStyle.None;
            dgwCinemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCinemas.Columns.AddRange(new DataGridViewColumn[] { colCinemaId, colCinemaName, colCinemaCity, colEditBtn, colDeleteBtn });
            dgwCinemas.Location = new Point(12, 235);
            dgwCinemas.Name = "dgwCinemas";
            dgwCinemas.ReadOnly = true;
            dgwCinemas.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgwCinemas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwCinemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCinemas.Size = new Size(1243, 435);
            dgwCinemas.TabIndex = 2;
            dgwCinemas.CellContentClick += dgwCinemas_CellContentClick;
            // 
            // colCinemaId
            // 
            colCinemaId.DataPropertyName = "Id";
            colCinemaId.HeaderText = "Id";
            colCinemaId.MinimumWidth = 8;
            colCinemaId.Name = "colCinemaId";
            colCinemaId.ReadOnly = true;
            colCinemaId.Width = 150;
            // 
            // colCinemaName
            // 
            colCinemaName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCinemaName.DataPropertyName = "Name";
            colCinemaName.HeaderText = "Sinema Adı";
            colCinemaName.MinimumWidth = 8;
            colCinemaName.Name = "colCinemaName";
            colCinemaName.ReadOnly = true;
            // 
            // colCinemaCity
            // 
            colCinemaCity.DataPropertyName = "City";
            colCinemaCity.HeaderText = "Şehir";
            colCinemaCity.MinimumWidth = 8;
            colCinemaCity.Name = "colCinemaCity";
            colCinemaCity.ReadOnly = true;
            colCinemaCity.Width = 250;
            // 
            // colEditBtn
            // 
            colEditBtn.FlatStyle = FlatStyle.Flat;
            colEditBtn.HeaderText = "";
            colEditBtn.MinimumWidth = 8;
            colEditBtn.Name = "colEditBtn";
            colEditBtn.ReadOnly = true;
            colEditBtn.Resizable = DataGridViewTriState.True;
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
            colDeleteBtn.Text = "Sil";
            colDeleteBtn.UseColumnTextForButtonValue = true;
            colDeleteBtn.Width = 50;
            // 
            // cmbCityFilter
            // 
            cmbCityFilter.DisplayMember = "Name";
            cmbCityFilter.FormattingEnabled = true;
            cmbCityFilter.Location = new Point(12, 146);
            cmbCityFilter.Name = "cmbCityFilter";
            cmbCityFilter.Size = new Size(205, 33);
            cmbCityFilter.TabIndex = 3;
            cmbCityFilter.ValueMember = "Id";
            // 
            // lblCityFilter
            // 
            lblCityFilter.AutoSize = true;
            lblCityFilter.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCityFilter.Location = new Point(12, 118);
            lblCityFilter.Name = "lblCityFilter";
            lblCityFilter.Size = new Size(56, 24);
            lblCityFilter.TabIndex = 4;
            lblCityFilter.Text = "Şehir";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(47, 54, 69);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(270, 146);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.White;
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 69);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(421, 146);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(112, 34);
            btnResetFilter.TabIndex = 12;
            btnResetFilter.Text = "Sıfırla";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // CinemasUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnResetFilter);
            Controls.Add(btnFilter);
            Controls.Add(lblCityFilter);
            Controls.Add(cmbCityFilter);
            Controls.Add(dgwCinemas);
            Controls.Add(lblCinemas);
            Name = "CinemasUserControl";
            Size = new Size(1270, 686);
            Load += CinemasUserControl_Load;
            ParentChanged += CinemasUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwCinemas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCinemas;
        private DataGridView dgwCinemas;
        private ComboBox cmbCityFilter;
        private Label lblCityFilter;
        private Button btnFilter;
        private DataGridViewTextBoxColumn colCinemaId;
        private DataGridViewTextBoxColumn colCinemaName;
        private DataGridViewTextBoxColumn colCinemaCity;
        private DataGridViewButtonColumn colEditBtn;
        private DataGridViewButtonColumn colDeleteBtn;
        private Button btnResetFilter;
    }
}
