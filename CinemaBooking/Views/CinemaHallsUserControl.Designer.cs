namespace CinemaBooking.Views {
    partial class CinemaHallsUserControl {
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
            lblCinemaHalls = new Label();
            dgwHalls = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNumber = new DataGridViewTextBoxColumn();
            colCinema = new DataGridViewTextBoxColumn();
            colTotalSeats = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwHalls).BeginInit();
            SuspendLayout();
            // 
            // lblCinemaHalls
            // 
            lblCinemaHalls.AutoSize = true;
            lblCinemaHalls.Font = new Font("Microsoft New Tai Lue", 16F, FontStyle.Bold);
            lblCinemaHalls.Location = new Point(3, 10);
            lblCinemaHalls.Name = "lblCinemaHalls";
            lblCinemaHalls.Size = new Size(141, 43);
            lblCinemaHalls.TabIndex = 2;
            lblCinemaHalls.Text = "Salonlar";
            // 
            // dgwHalls
            // 
            dgwHalls.AllowUserToAddRows = false;
            dgwHalls.AllowUserToDeleteRows = false;
            dgwHalls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwHalls.BackgroundColor = Color.Gainsboro;
            dgwHalls.BorderStyle = BorderStyle.None;
            dgwHalls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwHalls.Columns.AddRange(new DataGridViewColumn[] { colId, colNumber, colCinema, colTotalSeats });
            dgwHalls.Location = new Point(12, 154);
            dgwHalls.Name = "dgwHalls";
            dgwHalls.ReadOnly = true;
            dgwHalls.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 54, 69);
            dgwHalls.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwHalls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwHalls.Size = new Size(1397, 654);
            dgwHalls.TabIndex = 3;
            dgwHalls.CellContentClick += dgwHalls_CellContentClick;
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
            // colNumber
            // 
            colNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNumber.DataPropertyName = "Number";
            colNumber.HeaderText = "Numara";
            colNumber.MinimumWidth = 8;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            // 
            // colCinema
            // 
            colCinema.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCinema.DataPropertyName = "CinemaName";
            colCinema.HeaderText = "Sinema";
            colCinema.MinimumWidth = 8;
            colCinema.Name = "colCinema";
            colCinema.ReadOnly = true;
            // 
            // colTotalSeats
            // 
            colTotalSeats.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalSeats.DataPropertyName = "TotalSeats";
            colTotalSeats.HeaderText = "Koltuk Sayısı";
            colTotalSeats.MinimumWidth = 8;
            colTotalSeats.Name = "colTotalSeats";
            colTotalSeats.ReadOnly = true;
            // 
            // CinemaHallsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgwHalls);
            Controls.Add(lblCinemaHalls);
            Name = "CinemaHallsUserControl";
            Size = new Size(1421, 821);
            Load += CinemaHallsUserControl_Load;
            ParentChanged += CinemaHallsUserControl_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)dgwHalls).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCinemaHalls;
        private DataGridView dgwHalls;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colCinema;
        private DataGridViewTextBoxColumn colTotalSeats;
    }
}
