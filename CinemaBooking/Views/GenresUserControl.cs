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
    public partial class GenresUserControl : UserControl {
        private readonly GenreService _genreService;
        private string _editingCellOldValue;

        public GenresUserControl() {
            _genreService = new GenreService();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.GenreInsert) {
                MessageBox.Show("Tür ekleme yetkiniz yok!");
                return;
            }

            if (txtGenre.Text.Length == 0) {
                MessageBox.Show("Alanı doldurunuz!");
                return;
            }

            _genreService.Add(new Models.Genre { Name = txtGenre.Text });
            txtGenre.Clear();
            RefreshDataGridView();
        }

        private void GenresUserControl_Load(object sender, EventArgs e) {
            dgwGenres.AutoGenerateColumns = false;
            dgwGenres.DataSource = new BindingList<Genre>(_genreService.GetAll());
        }

        private void RefreshDataGridView() {
            dgwGenres.DataSource = null;
            dgwGenres.DataSource = new BindingList<Genre>(_genreService.GetAll());
        }

        private void GenresUserControl_ControlAdded(object sender, ControlEventArgs e) {

        }

        private void dgwGenres_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            if (!loginView.UserDetails.GenreUpdate) {
                MessageBox.Show("Tür düzenleme yetkiniz yok!");
                e.Cancel = true;
                return;
            }

            _editingCellOldValue = dgwGenres.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgwGenres_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (!loginView.UserDetails.GenreUpdate) {
                MessageBox.Show("Tür düzenleme yetkiniz yok!");
                return;
            }

            if (dgwGenres.Rows[e.RowIndex].Cells[1].Value == _editingCellOldValue) return;

            DialogResult result = MessageBox.Show("Değiştirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                _genreService.Update((Genre)dgwGenres.CurrentRow.DataBoundItem);
            }
            else {
                dgwGenres.Rows[e.RowIndex].Cells[1].Value = _editingCellOldValue;
                return;
            }
        }

        private void dgwGenres_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwGenres.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0) {
                if (!loginView.UserDetails.GenreDelete) {
                    MessageBox.Show("Tür silme yetkiniz yok!");
                    return;
                }

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try { 
                        int genreId = ((Genre)dgwGenres.Rows[e.RowIndex].DataBoundItem).Id;
                        _genreService.Delete(new Genre { Id = genreId });
                        RefreshDataGridView();
                    }
                    catch (SqlException) {
                        MessageBox.Show("Bu türde film(ler) bulunmakta!", "Hata");
                    }
                }
            }
        }

        private void GenresUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
        }
    }
}
