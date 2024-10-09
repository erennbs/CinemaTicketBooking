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
    public partial class EditMovieUserControl : UserControl {
        private readonly MovieDetailsDto _movieDetails;
        private readonly MovieService _movieService;
        private readonly GenreService _genreService;
        private readonly LanguageService _languageService;

        public EditMovieUserControl(MovieDetailsDto movieDetailsDto) {

            _movieDetails = movieDetailsDto;
            _movieService = new MovieService();
            _languageService = new LanguageService();
            _genreService = new GenreService();
            InitializeComponent();
            GetComboBoxValues();
            FillInputs(movieDetailsDto);
        }

        private void FillInputs(MovieDetailsDto movieDetailsDto) {
            txtMovieName.Text = movieDetailsDto.Title;
            txtDescription.Text = movieDetailsDto.Description;
            cmbGenre.SelectedIndex = cmbGenre.FindStringExact(movieDetailsDto.Genre);
            cmbLanguage.SelectedIndex = cmbLanguage.FindStringExact(movieDetailsDto.Language);
            dtpRelaseDate.Value = movieDetailsDto.ReleaseDate;
            nudDuration.Value = movieDetailsDto.Duration;
            nudPrice.Value = movieDetailsDto.TicketPrice;
        }

        private void GetComboBoxValues() {
            cmbGenre.DataSource = _genreService.GetAll();

            cmbLanguage.DataSource = _languageService.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.MovieUpdate) {
                MessageBox.Show("Film düzenleme yetkiniz yok!");
                return;
            }

            if (txtMovieName.Text.Length == 0 || cmbLanguage.SelectedItem == null || cmbGenre.SelectedItem == null ||
                nudDuration.Value <= 0 || nudPrice.Value <= 0) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            Movie movie = new Movie {
                Id = _movieDetails.Id,
                Title = txtMovieName.Text,
                Description = txtDescription.Text,
                GenreId = (int)cmbGenre.SelectedValue,
                LanguageId = (int)cmbLanguage.SelectedValue,
                Duration = (int)nudDuration.Value,
                ReleaseDate = dtpRelaseDate.Value,
                TicketPrice = nudPrice.Value
            };

            _movieService.Update(movie);
            Parent.Controls.RemoveAt(0);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e) {
            Parent.Controls.RemoveAt(0);
        }
    }
}
