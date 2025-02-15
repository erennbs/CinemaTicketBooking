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
    public partial class AddShowUserControl : UserControl {
        private readonly ShowService _showService;
        private readonly CinemaService _cinemaService;
        private readonly MovieService _movieService;
        private readonly CinemaHallService _cinemaHallService;

        public AddShowUserControl() {
            _showService = new ShowService();
            _cinemaService = new CinemaService();
            _movieService = new MovieService();
            _cinemaHallService = new CinemaHallService();
            InitializeComponent();
        }

        private void ClearInputs() {
            cmbMovie.ResetText();
            cmbHall.ResetText();
            cmbCinema.ResetText();
            dtpStartTime.ResetText();
            dtpEndTime.ResetText();
        }
        
        private void btnClear_Click(object sender, EventArgs e) {
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.ShowInsert) {
                MessageBox.Show("Seans ekleme yetkiniz yok!");
                return;
            }

            if (cmbMovie.SelectedItem == null || cmbCinema.SelectedItem == null || cmbHall.SelectedItem == null ||
                dtpStartTime.Value.ToString().Length == 0 || dtpEndTime.Value.ToString().Length == 0) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            if (dtpEndTime.Value < dtpStartTime.Value) {
                MessageBox.Show("Bitiş zamanı başlangıç saatinden sonra olmalı");
                return;
            }

            Show newShow = new Show {
                MovieId = (int)cmbMovie.SelectedValue,
                HallId = (int)cmbHall.SelectedValue,
                StartTime = dtpStartTime.Value,
                EndTime = dtpEndTime.Value,
            };

            _showService.Add(newShow);
            ClearInputs();
        }

        private void cmbCinema_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbCinema.SelectedItem == null) return;

            cmbHall.DataSource = _cinemaHallService.GetAllCinemaHallsByCinemaId((int)cmbCinema.SelectedValue);
            cmbHall.DisplayMember = "Number";
            cmbHall.ValueMember = "Id";
            cmbHall.SelectedItem = null;
        }

        private void RefreshComboBoxes() {
            cmbMovie.DataSource = _movieService.GetAllMovieTitles();
            cmbMovie.SelectedItem = null;

            cmbCinema.DataSource = _cinemaService.GetAll();
            cmbCinema.SelectedItem = null;

            cmbHall.DataSource = null;
        }

        private void AddShowUserControl_Load(object sender, EventArgs e) {
            RefreshComboBoxes();
        }

        private void AddShowUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshComboBoxes();
        }
    }
}
