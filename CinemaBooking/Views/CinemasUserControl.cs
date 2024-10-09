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
    public partial class CinemasUserControl : UserControl {
        private readonly CinemaService _cinemaService;
        private readonly CityService _cityService;

        public CinemasUserControl() {
            _cinemaService = new CinemaService();
            _cityService = new CityService();
            InitializeComponent();
        }

        private void CinemasUserControl_Load(object sender, EventArgs e) {
            dgwCinemas.AutoGenerateColumns = false;
            dgwCinemas.DataSource = _cinemaService.GetAllCinemaDetails();
            RefreshComboBoxes();
        }

        private void RefreshDataGridView() {
            dgwCinemas.AutoGenerateColumns = false;
            dgwCinemas.DataSource = _cinemaService.GetAllCinemaDetails();
        }

        private void RefreshComboBoxes() {
            cmbCityFilter.DataSource = _cityService.GetAll();
            cmbCityFilter.SelectedItem = null;
        }

        private void dgwCinemas_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwCinemas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 4) {
                if (!loginView.UserDetails.CinemaDelete) {
                    MessageBox.Show("Sinema silme yetkiniz yok!");
                    return;
                }

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try {
                        int cinemaId = (int)dgwCinemas.Rows[e.RowIndex].Cells[0].Value;
                        _cinemaService.Delete(new Cinema { Id = cinemaId });
                        RefreshDataGridView();
                    }
                    catch (SqlException) {
                        MessageBox.Show("Bu sinemaya kayıtlı salon(lar) bulunmakta!", "Hata");
                    }
                }
            }
            else if (dgwCinemas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 3) {
                if (!loginView.UserDetails.CinemaUpdate) {
                    MessageBox.Show("Sinema düzenleme yetkiniz yok!");
                    return;
                }

                CinemaDetailsDto cinemaDetails = (CinemaDetailsDto)dgwCinemas.Rows[e.RowIndex].DataBoundItem;
                ShowCinemaEditPage(cinemaDetails);
            }
        }

        private void ShowCinemaEditPage(CinemaDetailsDto cinemaDetails) {
            Parent.Controls.Add(new EditCinemaUserControl(cinemaDetails));
            Parent.Controls[1].BringToFront();
            Parent.Controls[0].Dock = DockStyle.Fill;
        }

        private void CinemasUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
            RefreshComboBoxes();
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            if (cmbCityFilter.SelectedItem == null) return;

            dgwCinemas.DataSource = _cinemaService.GetAllCinemaDetails(cmbCityFilter.Text);
        }

        private void btnResetFilter_Click(object sender, EventArgs e) {
            cmbCityFilter.SelectedItem = null;
            RefreshDataGridView();
        }
    }
}
