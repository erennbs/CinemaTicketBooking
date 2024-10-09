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
    public partial class LanguagesUserControl : UserControl {
        private readonly LanguageService _languageService;
        private string _editingCellOldValue;

        public LanguagesUserControl() {
            _languageService = new LanguageService();
            InitializeComponent();
        }

        private void LanguagesUserControl_Load(object sender, EventArgs e) {
            dgwLanguages.AutoGenerateColumns = false;
            dgwLanguages.DataSource = _languageService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.LanguageInsert) {
                MessageBox.Show("Dil ekleme yetkiniz yok!");
            }

            if (txtLanguage.Text.Length == 0) {
                MessageBox.Show("Alanı doldurunuz!");
                return;
            }

            _languageService.Add(new Language { Name = txtLanguage.Text });
            txtLanguage.Clear();
            RefreshDataGridView();
        }

        private void dgwLanguages_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            if (!loginView.UserDetails.LanguageUpdate) {
                MessageBox.Show("Dil düzenleme yetkiniz yok!");
                e.Cancel = true;
                return;
            }
            _editingCellOldValue = dgwLanguages.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgwLanguages_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (dgwLanguages.Rows[e.RowIndex].Cells[1].Value == _editingCellOldValue) return;

            DialogResult result = MessageBox.Show("Değiştirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                _languageService.Update((Language)dgwLanguages.CurrentRow.DataBoundItem);
            }
            else {
                dgwLanguages.Rows[e.RowIndex].Cells[1].Value = _editingCellOldValue;
                return;
            }
        }

        private void RefreshDataGridView() {
            if (!loginView.UserDetails.LanguageRead) {
                MessageBox.Show("Filmleri okuma yetkiniz yok!");
                return;
            }

            dgwLanguages.DataSource = _languageService.GetAll();
        }

        private void dgwLanguages_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwLanguages.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0) {
                if (!loginView.UserDetails.LanguageDelete) {
                    MessageBox.Show("Dil silme yetkiniz yok!");
                    return;
                }

                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try {
                        int languageId = ((Language)dgwLanguages.Rows[e.RowIndex].DataBoundItem).Id;
                        _languageService.Delete(new Language { Id = languageId });
                        RefreshDataGridView();
                    }
                    catch (SqlException) {
                        MessageBox.Show("Bu dili kullanan film(ler) bulunmakta!", "Hata");
                    }
                }
            }
        }

        private void LanguagesUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
        }
    }
}
