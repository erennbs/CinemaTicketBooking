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
    public partial class EditCinemaUserControl : UserControl {
        private readonly CinemaDetailsDto _cinemaDetails;
        private readonly CinemaService _cinemaDal;
        private readonly CityService _cityDal;

        public EditCinemaUserControl(CinemaDetailsDto cinemaDetails) {
            _cinemaDetails = cinemaDetails;
            _cinemaDal = new CinemaService();
            _cityDal = new CityService();

            InitializeComponent();

            RefreshComboBoxes();
            FillInputs();
        }

        private void FillInputs() {
            txtCinemaName.Text = _cinemaDetails.Name;
            cmbCity.SelectedIndex = cmbCity.FindStringExact(_cinemaDetails.City);
        }

        private void RefreshComboBoxes() {
            cmbCity.DataSource = _cityDal.GetAll();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e) {
            Parent.Controls.RemoveAt(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.CinemaUpdate) {
                MessageBox.Show("Sinema düzenleme yetkiniz yok!");
                return;
            }

            if (txtCinemaName.Text.Length == 0 || cmbCity.SelectedItem == null) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            Cinema cinema = new Cinema {
                Id = _cinemaDetails.Id,
                Name = txtCinemaName.Text,
                CityId = (int)cmbCity.SelectedValue
            };

            _cinemaDal.Update(cinema);

            Parent.Controls.RemoveAt(0);
        }
    }
}
