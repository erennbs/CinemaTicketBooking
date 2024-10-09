using CinemaBooking.Models;
using CinemaBooking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBooking.Views {
    public partial class CinemaHallsUserControl : UserControl {
        private readonly CinemaHallService _cinemaHallService;

        public CinemaHallsUserControl() {
            _cinemaHallService = new CinemaHallService();
            InitializeComponent();
        }

        public void RefreshDataGridView() {
            if (!loginView.UserDetails.CinemaHallRead) {
                MessageBox.Show("Salonları okuma yetkiniz yok!");
            }

            dgwHalls.DataSource = _cinemaHallService.GetAllCinemaHallDetails();
        }

        private void CinemaHallsUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
        }

        private void dgwHalls_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwHalls.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0) {
                if (!loginView.UserDetails.CinemaHallDelete) {
                    MessageBox.Show("Salon silme yetkiniz yok!");
                    return;
                }
                
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try {
                        int hallId = (int)dgwHalls.Rows[e.RowIndex].Cells[0].Value;
                        _cinemaHallService.Delete(new CinemaHall { Id = hallId });
                        RefreshDataGridView();
                    }
                    catch (SqlException) {
                        MessageBox.Show("Bu salona kayıtlı seans(lar) bulunmakta!");
                    }
                }
            }
        }

        private void CinemaHallsUserControl_Load(object sender, EventArgs e) {
            RefreshDataGridView();

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Text = "Sil";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.FlatStyle = FlatStyle.Flat;

            dgwHalls.Columns.Add(deleteColumn);
        }
    }
}
