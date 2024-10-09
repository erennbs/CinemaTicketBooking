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
    public partial class MoviesUserControl : UserControl {
        private readonly MovieService _movieService;
        private readonly LanguageService _languageService;
        private readonly GenreService _genreService;
        private readonly ShowService _showService;

        public MoviesUserControl() {
            _movieService = new MovieService();
            _languageService = new LanguageService();
            _genreService = new GenreService();
            _showService = new ShowService();
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            if (cmbGenreFilter.SelectedItem == null && cmbLanguageFilter.SelectedItem == null) return;

            dgwMovies.DataSource = _movieService.GetAllMovieDetails(cmbLanguageFilter.Text, cmbGenreFilter.Text);
        }

        private void RefreshDataGridView() {
            if (!loginView.UserDetails.MovieRead) {
                MessageBox.Show("Filmleri okuma yetkiniz yok!");
                return;
            }

            dgwMovies.AutoGenerateColumns = false;
            dgwMovies.DataSource = _movieService.GetAllMovieDetails();
        }

        private void RefreshFilters() {
            cmbLanguageFilter.DataSource = _languageService.GetAll();
            cmbLanguageFilter.SelectedItem = null;

            cmbGenreFilter.DataSource = _genreService.GetAll();
            cmbGenreFilter.SelectedItem = null;
        }

        private void ShowMovieDetails(MovieDetailsDto movieDetailsDto) {
            Parent.Controls.Add(new MovieDetailsUserControl(movieDetailsDto));
            Parent.Controls[1].BringToFront();
            Parent.Controls[0].Dock = DockStyle.Fill;
        }

        private void ShowMovieEditPage(MovieDetailsDto movieDetails) {
            Parent.Controls.Add(new EditMovieUserControl(movieDetails));
            Parent.Controls[1].BringToFront();
            Parent.Controls[0].Dock = DockStyle.Fill;
        }

        private void dgwMovies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            ShowMovieDetails((MovieDetailsDto)dgwMovies.Rows[e.RowIndex].DataBoundItem);
        }

        private void dgwMovies_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwMovies.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 9) {
                if (!loginView.UserDetails.MovieDelete) {
                    MessageBox.Show("Film silme yetkiniz yok!");
                    return;
                }
                
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    try {
                        int movieId = (int)dgwMovies.Rows[e.RowIndex].Cells[0].Value;
                        _movieService.Delete(new Movie { Id = movieId });
                    }
                    catch (SqlException) {
                        MessageBox.Show("Bu filmin seans(lar)ı bulunmakta!", "Hata");
                    }
                }
            }
            else if (dgwMovies.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 8) {
                if (!loginView.UserDetails.MovieUpdate) {
                    MessageBox.Show("Film düzenleme yetkiniz yok!");
                    return;
                }

                MovieDetailsDto movieDetails = (MovieDetailsDto)dgwMovies.Rows[e.RowIndex].DataBoundItem;
                ShowMovieEditPage(movieDetails);
            }
        }

        private void MoviesUserControl_ParentChanged(object sender, EventArgs e) {
            dgwMovies.AutoGenerateColumns = false;
            RefreshFilters();
            RefreshDataGridView();
        }

        private void btnResetFilter_Click(object sender, EventArgs e) {
            cmbGenreFilter.SelectedItem = null;
            cmbLanguageFilter.SelectedItem = null;
            RefreshDataGridView();
        }
    }
}
