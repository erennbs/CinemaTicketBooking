namespace CinemaBooking.Views {
    partial class LogsUserControl {
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
            label1 = new Label();
            dgwLogs = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colProccessType = new DataGridViewTextBoxColumn();
            colProccessTable = new DataGridViewTextBoxColumn();
            colProccessData = new DataGridViewTextBoxColumn();
            colInsertDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwLogs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 0;
            label1.Text = "Log Kayıtları";
            // 
            // dgwLogs
            // 
            dgwLogs.AllowUserToAddRows = false;
            dgwLogs.AllowUserToDeleteRows = false;
            dgwLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwLogs.BackgroundColor = Color.Gainsboro;
            dgwLogs.BorderStyle = BorderStyle.None;
            dgwLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLogs.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colProccessType, colProccessTable, colProccessData, colInsertDate });
            dgwLogs.Location = new Point(12, 140);
            dgwLogs.Name = "dgwLogs";
            dgwLogs.ReadOnly = true;
            dgwLogs.RowHeadersWidth = 62;
            dgwLogs.Size = new Size(1285, 571);
            dgwLogs.TabIndex = 1;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 150;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Kullanıcı Adı";
            colUsername.MinimumWidth = 8;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 150;
            // 
            // colProccessType
            // 
            colProccessType.DataPropertyName = "ProccessType";
            colProccessType.HeaderText = "İşlem Tipi";
            colProccessType.MinimumWidth = 8;
            colProccessType.Name = "colProccessType";
            colProccessType.ReadOnly = true;
            colProccessType.Width = 150;
            // 
            // colProccessTable
            // 
            colProccessTable.DataPropertyName = "ProccessTable";
            colProccessTable.HeaderText = "Tablo";
            colProccessTable.MinimumWidth = 8;
            colProccessTable.Name = "colProccessTable";
            colProccessTable.ReadOnly = true;
            colProccessTable.Width = 150;
            // 
            // colProccessData
            // 
            colProccessData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProccessData.DataPropertyName = "ProccessData";
            colProccessData.HeaderText = "Veri";
            colProccessData.MinimumWidth = 8;
            colProccessData.Name = "colProccessData";
            colProccessData.ReadOnly = true;
            // 
            // colInsertDate
            // 
            colInsertDate.DataPropertyName = "InsertDate";
            colInsertDate.HeaderText = "Tarih";
            colInsertDate.MinimumWidth = 8;
            colInsertDate.Name = "colInsertDate";
            colInsertDate.ReadOnly = true;
            colInsertDate.Width = 150;
            // 
            // LogsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgwLogs);
            Controls.Add(label1);
            Name = "LogsUserControl";
            Size = new Size(1307, 725);
            ParentChanged += LogsUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgwLogs;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colProccessType;
        private DataGridViewTextBoxColumn colProccessTable;
        private DataGridViewTextBoxColumn colProccessData;
        private DataGridViewTextBoxColumn colInsertDate;
    }
}
