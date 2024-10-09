using CinemaBooking.Models;
using CinemaBooking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBooking.Views {
    public partial class ShowsUserControl : UserControl {
        private readonly ShowService _showService;
        private readonly MovieService _movieService;
        private readonly CinemaService _cinemaService;
        private readonly CinemaHallService _cinemaHallService;

        public ShowsUserControl() {
            _showService = new ShowService();
            _movieService = new MovieService();
            _cinemaService = new CinemaService();
            _cinemaHallService = new CinemaHallService();

            InitializeComponent();
        }

        private void RefreshComboBoxes() {
            cmbMovieFilter.DisplayMember = "Title";
            cmbMovieFilter.ValueMember = "Id";
            cmbMovieFilter.DataSource = _movieService.GetAll();
            cmbMovieFilter.SelectedItem = null;

            cmbCinemaFilter.DataSource = _cinemaService.GetAll();
            cmbCinemaFilter.SelectedItem = null;
        }

        private void RefreshDataGridView() {
            if (!loginView.UserDetails.ShowRead) {
                MessageBox.Show("Seansları okuma yetkiniz yok!");
                return;
            }

            dgwShows.AutoGenerateColumns = false;
            dgwShows.DataSource = _showService.GetAllShowDetails();
        }

        private void ShowEditPage(ShowDetailsDto showDetails) {
            Parent.Controls.Add(new EditShowUserControl(showDetails));
            Parent.Controls[1].BringToFront();
            Parent.Controls[0].Dock = DockStyle.Fill;
        }

        private void ShowsUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
            RefreshComboBoxes();
        }

        private void dgwShows_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwShows.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 7) {
                if (!loginView.UserDetails.ShowDelete) {
                    MessageBox.Show("Seans silme yetkiniz yok!");
                    return;
                }

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    int showId = (int)dgwShows.Rows[e.RowIndex].Cells[0].Value;
                    _showService.Delete(new Show { Id = showId });
                    RefreshDataGridView();
                }
            }
            else if (dgwShows.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 6) {
                if (!loginView.UserDetails.ShowUpdate) {
                    MessageBox.Show("Seans düzenleme yetkiniz yok");
                    return;
                }
                ShowDetailsDto showDetails = (ShowDetailsDto)dgwShows.Rows[e.RowIndex].DataBoundItem;
                ShowEditPage(showDetails);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            if (cmbMovieFilter.SelectedItem == null && cmbCinemaFilter.SelectedItem == null) return;

            dgwShows.DataSource = _showService.GetAllShowDetails(cmbMovieFilter.Text, cmbCinemaFilter.Text);
        }

        private void btnResetFilter_Click(object sender, EventArgs e) {
            cmbCinemaFilter.SelectedItem = null;
            cmbMovieFilter.SelectedItem = null;
            RefreshDataGridView();
        }
    }
}
