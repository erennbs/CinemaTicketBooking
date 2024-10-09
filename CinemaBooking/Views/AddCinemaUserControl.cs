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
    public partial class AddCinemaUserControl : UserControl {
        private readonly CinemaService _cinemaService;
        private readonly CityService _cityDal;

        public AddCinemaUserControl() {
            _cinemaService = new CinemaService();
            _cityDal = new CityService();
            InitializeComponent();
        }

        private void ClearInputs() {
            txtCinemaName.Clear();
            cmbCity.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.CinemaInsert) {
                MessageBox.Show("Sinema ekleme yetkiniz yok!");
                return;
            }

            if (txtCinemaName.Text.Length == 0 || cmbCity.SelectedItem == null) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            _cinemaService.Add(new Cinema { Name = txtCinemaName.Text, CityId = (int)cmbCity.SelectedValue });
            ClearInputs();
        }

        private void AddCinemaUserControl_Load(object sender, EventArgs e) {
            RefreshComboBoxes();
        }

        private void RefreshComboBoxes() {
            cmbCity.DataSource = _cityDal.GetAll();
            cmbCity.SelectedItem = null;
        }

        private void AddCinemaUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshComboBoxes();
        }
    }
}
