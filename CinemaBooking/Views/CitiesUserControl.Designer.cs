namespace CinemaBooking.Views {
    partial class CitiesUserControl {
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
            btnAdd = new Button();
            txtCity = new TextBox();
            lblCitiesIn = new Label();
            lblAdd = new Label();
            dgwCities = new DataGridView();
            lblCities = new Label();
            colCityId = new DataGridViewTextBoxColumn();
            colCityName = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgwCities).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(47, 54, 69);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft New Tai Lue", 10F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1022, 289);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCity.Location = new Point(660, 207);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(500, 31);
            txtCity.TabIndex = 51;
            // 
            // lblCitiesIn
            // 
            lblCitiesIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCitiesIn.AutoSize = true;
            lblCitiesIn.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblCitiesIn.Location = new Point(660, 177);
            lblCitiesIn.Name = "lblCitiesIn";
            lblCitiesIn.Size = new Size(64, 27);
            lblCitiesIn.TabIndex = 50;
            lblCitiesIn.Text = "Şehir";
            // 
            // lblAdd
            // 
            lblAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAdd.Location = new Point(653, 87);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(80, 43);
            lblAdd.TabIndex = 49;
            lblAdd.Text = "Ekle";
            // 
            // dgwCities
            // 
            dgwCities.AllowUserToAddRows = false;
            dgwCities.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwCities.BackgroundColor = Color.Gainsboro;
            dgwCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCities.Columns.AddRange(new DataGridViewColumn[] { colCityId, colCityName, colDelete });
            dgwCities.Location = new Point(18, 87);
            dgwCities.Name = "dgwCities";
            dgwCities.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwCities.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwCities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCities.Size = new Size(591, 530);
            dgwCities.TabIndex = 48;
            dgwCities.CellBeginEdit += dgwCities_CellBeginEdit;
            dgwCities.CellContentClick += dgwCities_CellContentClick;
            dgwCities.CellEndEdit += dgwCities_CellEndEdit;
            // 
            // lblCities
            // 
            lblCities.AutoSize = true;
            lblCities.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblCities.Location = new Point(0, 9);
            lblCities.Name = "lblCities";
            lblCities.Size = new Size(140, 43);
            lblCities.TabIndex = 47;
            lblCities.Text = "Şehirler";
            // 
            // colCityId
            // 
            colCityId.DataPropertyName = "Id";
            colCityId.HeaderText = "Id";
            colCityId.MinimumWidth = 8;
            colCityId.Name = "colCityId";
            colCityId.ReadOnly = true;
            colCityId.Resizable = DataGridViewTriState.False;
            colCityId.Width = 150;
            // 
            // colCityName
            // 
            colCityName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCityName.DataPropertyName = "Name";
            colCityName.HeaderText = "Şehir";
            colCityName.MinimumWidth = 8;
            colCityName.Name = "colCityName";
            // 
            // colDelete
            // 
            colDelete.FlatStyle = FlatStyle.Flat;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "Sil";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 150;
            // 
            // CitiesUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAdd);
            Controls.Add(txtCity);
            Controls.Add(lblCitiesIn);
            Controls.Add(lblAdd);
            Controls.Add(dgwCities);
            Controls.Add(lblCities);
            Name = "CitiesUserControl";
            Size = new Size(1222, 638);
            Load += CitiesUserControl_Load;
            ParentChanged += CitiesUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwCities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtCity;
        private Label lblCitiesIn;
        private Label lblAdd;
        private DataGridView dgwCities;
        private Label lblCities;
        private DataGridViewTextBoxColumn colCityId;
        private DataGridViewTextBoxColumn colCityName;
        private DataGridViewButtonColumn colDelete;
    }
}
