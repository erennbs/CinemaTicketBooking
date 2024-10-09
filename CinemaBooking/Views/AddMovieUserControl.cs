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
    public partial class AddMovieUserControl : UserControl {
        private readonly MovieService _movieService;
        private readonly GenreService _genreService;
        private readonly LanguageService _languageDal;

        public AddMovieUserControl() {
            _movieService = new MovieService();
            _genreService = new GenreService();
            _languageDal = new LanguageService();
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearInputs();
        }

        private void btnFilePicker_Click(object sender, EventArgs e) {
            if (ofdImagePicker.ShowDialog() == DialogResult.OK) {
                btnFilePicker.Text = ofdImagePicker.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.MovieInsert) {
                MessageBox.Show("Film ekleme yetkiniz yok!");
                return;
            }

            if (txtMovieName.Text.Length == 0 || cmbLanguage.SelectedItem == null || cmbGenre.SelectedItem == null ||
                nudDuration.Value <= 0 || nudPrice.Value <= 0) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            Movie newMovie = new Movie() {
                Title = txtMovieName.Text,
                Description = txtDescription.Text,
                LanguageId = (int)cmbLanguage.SelectedValue,
                GenreId = (int)cmbGenre.SelectedValue,
                Duration = (int)nudDuration.Value,
                TicketPrice = nudPrice.Value,
                ReleaseDate = dtpRelaseDate.Value,
                ImagePath = ofdImagePicker.FileName
            };

            _movieService.Add(newMovie);
            ClearInputs();
        }

        private void AddMovieUserControl_Load(object sender, EventArgs e) {
            cmbGenre.DataSource = _genreService.GetAll();
            cmbGenre.SelectedItem = null;

            cmbLanguage.DataSource = _languageDal.GetAll();
            cmbLanguage.SelectedItem = null;
        }

        private void RefreshComboBoxes() {
            cmbGenre.DataSource = null;
            cmbGenre.DataSource = _genreService.GetAll();
            cmbGenre.SelectedItem = null;

            cmbLanguage.DataSource = null;
            cmbLanguage.DataSource = _languageDal.GetAll();
            cmbLanguage.SelectedItem = null;
        }

        private void ClearInputs() {
            txtMovieName.Clear();
            txtDescription.Clear();
            cmbLanguage.ResetText();
            cmbGenre.ResetText();
            dtpRelaseDate.Value = DateTime.Now;
            nudDuration.ResetText();
            nudPrice.ResetText();
            ofdImagePicker.FileName = string.Empty;
            btnFilePicker.ResetText();
        }

        private void AddMovieUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshComboBoxes();
        }
    }
}
