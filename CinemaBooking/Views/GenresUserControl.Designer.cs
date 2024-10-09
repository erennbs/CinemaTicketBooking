namespace CinemaBooking.Views {
    partial class GenresUserControl {
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
            lblLanguages = new Label();
            dgwGenres = new DataGridView();
            colLanguageId = new DataGridViewTextBoxColumn();
            colGenreName = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            lblAdd = new Label();
            txtGenre = new TextBox();
            lblGenre = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwGenres).BeginInit();
            SuspendLayout();
            // 
            // lblLanguages
            // 
            lblLanguages.AutoSize = true;
            lblLanguages.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblLanguages.Location = new Point(0, 9);
            lblLanguages.Name = "lblLanguages";
            lblLanguages.Size = new Size(109, 43);
            lblLanguages.TabIndex = 2;
            lblLanguages.Text = "Türler";
            // 
            // dgwGenres
            // 
            dgwGenres.AllowUserToAddRows = false;
            dgwGenres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwGenres.BackgroundColor = Color.Gainsboro;
            dgwGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGenres.Columns.AddRange(new DataGridViewColumn[] { colLanguageId, colGenreName, colDelete });
            dgwGenres.Location = new Point(20, 87);
            dgwGenres.Name = "dgwGenres";
            dgwGenres.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwGenres.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwGenres.Size = new Size(591, 530);
            dgwGenres.TabIndex = 3;
            dgwGenres.CellBeginEdit += dgwGenres_CellBeginEdit;
            dgwGenres.CellContentClick += dgwGenres_CellContentClick;
            dgwGenres.CellEndEdit += dgwGenres_CellEndEdit;
            // 
            // colLanguageId
            // 
            colLanguageId.DataPropertyName = "Id";
            colLanguageId.HeaderText = "Id";
            colLanguageId.MinimumWidth = 8;
            colLanguageId.Name = "colLanguageId";
            colLanguageId.ReadOnly = true;
            colLanguageId.Width = 150;
            // 
            // colGenreName
            // 
            colGenreName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGenreName.DataPropertyName = "Name";
            colGenreName.HeaderText = "Tür";
            colGenreName.MinimumWidth = 8;
            colGenreName.Name = "colGenreName";
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
            // lblAdd
            // 
            lblAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAdd.Location = new Point(655, 87);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(80, 43);
            lblAdd.TabIndex = 4;
            lblAdd.Text = "Ekle";
            // 
            // txtGenre
            // 
            txtGenre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtGenre.Location = new Point(662, 207);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(500, 31);
            txtGenre.TabIndex = 39;
            // 
            // lblGenre
            // 
            lblGenre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblGenre.Location = new Point(662, 177);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(44, 27);
            lblGenre.TabIndex = 38;
            lblGenre.Text = "Tür";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(47, 54, 69);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft New Tai Lue", 10F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1024, 289);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // GenresUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAdd);
            Controls.Add(txtGenre);
            Controls.Add(lblGenre);
            Controls.Add(lblAdd);
            Controls.Add(dgwGenres);
            Controls.Add(lblLanguages);
            Name = "GenresUserControl";
            Size = new Size(1222, 638);
            Load += GenresUserControl_Load;
            ParentChanged += GenresUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwGenres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLanguages;
        private DataGridView dgwGenres;
        private DataGridViewTextBoxColumn colLanguageName;
        private Label lblAdd;
        private TextBox txtGenre;
        private Label lblGenre;
        private Button btnAdd;
        private DataGridViewTextBoxColumn colLanguageId;
        private DataGridViewTextBoxColumn colGenreName;
        private DataGridViewButtonColumn colDelete;
    }
}
