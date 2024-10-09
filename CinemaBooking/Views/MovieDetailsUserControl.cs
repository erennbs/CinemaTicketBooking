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
    public partial class MovieDetailsUserControl : UserControl {
        private readonly ShowService _showService;

        public MovieDetailsUserControl(MovieDetailsDto movieDetailsDto) {
            _showService = new ShowService();

            InitializeComponent();
            ShowDetails(movieDetailsDto);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e) {
            Parent.Controls.RemoveAt(0);
        }

        private void ShowDetails(MovieDetailsDto movieDetailsDto) {
            lblMovieName.Text = movieDetailsDto.Title;
            lblDescription.Text = movieDetailsDto.Description;
            lblGenreVal.Text = movieDetailsDto.Genre;
            lblLanguageVal.Text = movieDetailsDto.Language;
            lblDurationVal.Text = movieDetailsDto.Duration.ToString();
            lblReleaseDateVal.Text = movieDetailsDto.ReleaseDate.ToShortDateString();

            DateTime startTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);
            DateTime endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);

            List<Show> shows = _showService.GetAllShowsByMovieNameAndDate(movieDetailsDto.Title, startTime, endTime);

            foreach (Show show in shows) { 
                Label btn = new Label();
                btn.BackColor = Color.Gainsboro;
                btn.Text = show.StartTime.ToShortTimeString();
                btn.Height = 35;
                btn.Width = 90;
                btn.TextAlign = ContentAlignment.MiddleCenter;

                flpShows.Controls.Add(btn);
            }
        }
    }
}
