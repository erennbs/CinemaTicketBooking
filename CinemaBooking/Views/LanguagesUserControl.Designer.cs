namespace CinemaBooking.Views {
    partial class LanguagesUserControl {
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAdd = new Button();
            txtLanguage = new TextBox();
            lblLanguage = new Label();
            lblAdd = new Label();
            dgwLanguages = new DataGridView();
            colLanguageId = new DataGridViewTextBoxColumn();
            colLanguageName = new DataGridViewTextBoxColumn();
            colDeleteButton = new DataGridViewButtonColumn();
            cmsCellMenu = new ContextMenuStrip(components);
            tsmiDelete = new ToolStripMenuItem();
            lblLanguages = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwLanguages).BeginInit();
            cmsCellMenu.SuspendLayout();
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
            btnAdd.Location = new Point(1146, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 50);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLanguage
            // 
            txtLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLanguage.Location = new Point(784, 210);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(500, 31);
            txtLanguage.TabIndex = 45;
            // 
            // lblLanguage
            // 
            lblLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold);
            lblLanguage.Location = new Point(784, 180);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(39, 27);
            lblLanguage.TabIndex = 44;
            lblLanguage.Text = "Dil";
            // 
            // lblAdd
            // 
            lblAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblAdd.Location = new Point(777, 90);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(80, 43);
            lblAdd.TabIndex = 43;
            lblAdd.Text = "Ekle";
            // 
            // dgwLanguages
            // 
            dgwLanguages.AllowUserToAddRows = false;
            dgwLanguages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwLanguages.BackgroundColor = Color.Gainsboro;
            dgwLanguages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLanguages.Columns.AddRange(new DataGridViewColumn[] { colLanguageId, colLanguageName, colDeleteButton });
            dgwLanguages.ContextMenuStrip = cmsCellMenu;
            dgwLanguages.Location = new Point(18, 90);
            dgwLanguages.Name = "dgwLanguages";
            dgwLanguages.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwLanguages.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgwLanguages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwLanguages.Size = new Size(715, 687);
            dgwLanguages.TabIndex = 42;
            dgwLanguages.CellBeginEdit += dgwLanguages_CellBeginEdit;
            dgwLanguages.CellContentClick += dgwLanguages_CellContentClick;
            dgwLanguages.CellEndEdit += dgwLanguages_CellEndEdit;
            // 
            // colLanguageId
            // 
            colLanguageId.DataPropertyName = "Id";
            colLanguageId.HeaderText = "Id";
            colLanguageId.MinimumWidth = 8;
            colLanguageId.Name = "colLanguageId";
            colLanguageId.ReadOnly = true;
            colLanguageId.Resizable = DataGridViewTriState.False;
            colLanguageId.Width = 150;
            // 
            // colLanguageName
            // 
            colLanguageName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLanguageName.DataPropertyName = "Name";
            colLanguageName.HeaderText = "Dil";
            colLanguageName.MinimumWidth = 8;
            colLanguageName.Name = "colLanguageName";
            // 
            // colDeleteButton
            // 
            colDeleteButton.FlatStyle = FlatStyle.Flat;
            colDeleteButton.HeaderText = "";
            colDeleteButton.MinimumWidth = 8;
            colDeleteButton.Name = "colDeleteButton";
            colDeleteButton.Text = "Sil";
            colDeleteButton.UseColumnTextForButtonValue = true;
            colDeleteButton.Width = 150;
            // 
            // cmsCellMenu
            // 
            cmsCellMenu.ImageScalingSize = new Size(24, 24);
            cmsCellMenu.Items.AddRange(new ToolStripItem[] { tsmiDelete });
            cmsCellMenu.Name = "cmsCellMenu";
            cmsCellMenu.Size = new Size(103, 36);
            // 
            // tsmiDelete
            // 
            tsmiDelete.Name = "tsmiDelete";
            tsmiDelete.Size = new Size(102, 32);
            tsmiDelete.Text = "Sil";
            // 
            // lblLanguages
            // 
            lblLanguages.AutoSize = true;
            lblLanguages.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblLanguages.Location = new Point(3, 9);
            lblLanguages.Name = "lblLanguages";
            lblLanguages.Size = new Size(100, 43);
            lblLanguages.TabIndex = 41;
            lblLanguages.Text = "Diller";
            // 
            // LanguagesUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(lblLanguage);
            Controls.Add(lblAdd);
            Controls.Add(dgwLanguages);
            Controls.Add(lblLanguages);
            Name = "LanguagesUserControl";
            Size = new Size(1346, 795);
            Load += LanguagesUserControl_Load;
            ParentChanged += LanguagesUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwLanguages).EndInit();
            cmsCellMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtLanguage;
        private Label lblLanguage;
        private Label lblAdd;
        private DataGridView dgwLanguages;
        private Label lblLanguages;
        private ContextMenuStrip cmsCellMenu;
        private ToolStripMenuItem tsmiDelete;
        private DataGridViewTextBoxColumn colLanguageId;
        private DataGridViewTextBoxColumn colLanguageName;
        private DataGridViewButtonColumn colDeleteButton;
    }
}
