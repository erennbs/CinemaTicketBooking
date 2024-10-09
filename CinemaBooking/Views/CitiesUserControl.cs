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
    public partial class CitiesUserControl : UserControl {
        private readonly CityService _cityService;
        private string _editingCellOldValue;

        public CitiesUserControl() {
            _cityService = new CityService();
            InitializeComponent();
        }

        private void CitiesUserControl_Load(object sender, EventArgs e) {
            dgwCities.AutoGenerateColumns = false;
            dgwCities.DataSource = new BindingList<City>(_cityService.GetAll());
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.CityInsert) {
                MessageBox.Show("Şehir ekleme yetkiniz yok!");
                return;
            }

            if (txtCity.Text.Length == 0) {
                MessageBox.Show("Alanı doldurunuz!");
                return;
            }

            _cityService.Add(new City { Name = txtCity.Text });
            txtCity.Clear();
            RefreshDataGridView();
        }

        private void RefreshDataGridView() {
            dgwCities.DataSource = new BindingList<City>(_cityService.GetAll());
        }

        private void dgwCities_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            _editingCellOldValue = dgwCities.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgwCities_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (!loginView.UserDetails.CityDelete) {
                MessageBox.Show("Şehir silme yetkiniz yok!");
                return;
            }

            if (dgwCities.Rows[e.RowIndex].Cells[1].Value == _editingCellOldValue) return;

            DialogResult result = MessageBox.Show("Değiştirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                _cityService.Update((City)dgwCities.CurrentRow.DataBoundItem);
            }
            else {
                dgwCities.Rows[e.RowIndex].Cells[1].Value = _editingCellOldValue;
                return;
            }
        }

        private void CitiesUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
        }

        private void dgwCities_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwCities.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0) {
                if (!loginView.UserDetails.LanguageDelete) {
                    MessageBox.Show("Şehir silme yetkiniz yok!");
                    return;
                }

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try {
                        int cityId = ((City)dgwCities.Rows[e.RowIndex].DataBoundItem).Id;
                        _cityService.Delete(new City { Id = cityId });
                        RefreshDataGridView();
                    }
                    catch (SqlException) {
                        MessageBox.Show("Bu şehirde kayıtlı sinema(lar) bulunmakta!", "Hata");
                    }
                }
            }
        }
    }
}
