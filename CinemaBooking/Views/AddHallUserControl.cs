using CinemaBooking.Services;
using CinemaBooking.Models;
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
    public partial class AddHallUserControl : UserControl {
        private readonly CinemaHallService _cinemaHallService;
        private readonly CinemaService _cinemaService;

        public AddHallUserControl() {
            _cinemaHallService = new CinemaHallService();
            _cinemaService = new CinemaService();
            InitializeComponent();
        }

        private void ClearInputs() {
            cmbCinema.ResetText();
            nudHallNumber.ResetText();
            nudTotalSeats.ResetText();
        }

        private void RefreshComboBoxes() {
            cmbCinema.DataSource = _cinemaService.GetAll();
            cmbCinema.SelectedItem = null;
        }

        private void AddHallUserControl_Load(object sender, EventArgs e) {
            RefreshComboBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.CinemaHallInsert) {
                MessageBox.Show("Salon ekleme yetkiniz yok!");
                return;
            }

            if (cmbCinema.SelectedItem == null || nudHallNumber.Value <= 0 ||nudTotalSeats.Value <= 0) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            _cinemaHallService.Add(new CinemaHall {
                CinemaId = (int)cmbCinema.SelectedValue,
                Number = (int)nudHallNumber.Value,
                TotalSeats = (int)nudTotalSeats.Value,
            });
            ClearInputs();
        }

        private void AddHallUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshComboBoxes();
        }
    }
}
