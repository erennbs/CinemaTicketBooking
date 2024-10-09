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
    public partial class EditShowUserControl : UserControl {
        private readonly ShowDetailsDto _showDetails;
        private readonly ShowService _showService ;
        private readonly MovieService _movieService;
        private readonly CinemaService _cinemaService;
        private readonly CinemaHallService _cinemaHallService;

        public EditShowUserControl(ShowDetailsDto showDetailsDto) {
            _showDetails = showDetailsDto;
            _showService = new ShowService();
            _movieService = new MovieService();
            _cinemaService = new CinemaService();
            _cinemaHallService = new CinemaHallService();

            InitializeComponent();

            RefreshComboBoxes();
            FillInputs();
        }

        private void FillInputs() {
            cmbMovie.SelectedIndex = cmbMovie.FindStringExact(_showDetails.MovieTitle);
            cmbCinema.SelectedIndex = cmbCinema.FindStringExact(_showDetails.CinemaName);
            cmbHall.DisplayMember = "Number";
            cmbHall.ValueMember = "Id";
            cmbHall.DataSource = _cinemaHallService.GetAllCinemaHallsByCinemaId((int)cmbCinema.SelectedValue);
            cmbHall.SelectedIndex = cmbHall.FindStringExact(_showDetails.Hall.ToString());
            dtpStartTime.Value = _showDetails.StartTime;
            dtpEndTime.Value = _showDetails.EndTime;

            
        }

        private void RefreshComboBoxes() {
            cmbMovie.DataSource = _movieService.GetAllMovieTitles();
            cmbCinema.DataSource = _cinemaService.GetAll();
            cmbHall.DataSource = null;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e) {
            Parent.Controls.RemoveAt(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.ShowUpdate) {
                MessageBox.Show("Seans düzenleme yetkiniz yok!");
                return;
            }

            if (cmbMovie.SelectedItem == null || cmbCinema.SelectedItem == null || cmbHall.SelectedItem == null ||
                dtpStartTime.Value.ToString().Length == 0 || dtpEndTime.Value.ToString().Length == 0) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            Show show = new Show {
                Id = _showDetails.Id,
                MovieId = (int)cmbMovie.SelectedValue,
                HallId = (int)cmbHall.SelectedValue,
                StartTime = dtpStartTime.Value,
                EndTime = dtpEndTime.Value
            };

            _showService.Update(show);
        }

        private void cmbCinema_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbCinema.SelectedValue == null) return;

            cmbHall.DisplayMember = "Number";
            cmbHall.ValueMember = "Id";
            cmbHall.DataSource = _cinemaHallService.GetAllCinemaHallsByCinemaId((int)cmbCinema.SelectedValue);
            cmbHall.SelectedItem = null;
        }
    }
}
