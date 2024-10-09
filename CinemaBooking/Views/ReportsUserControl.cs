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
    public partial class ReportsUserControl : UserControl {
        private readonly MovieService _movieService;
        private readonly UserService _userService;

        public ReportsUserControl() {
            _movieService = new MovieService();
            _userService = new UserService();

            InitializeComponent();
        }

        private void ReportsUserControl_Load(object sender, EventArgs e) {
            RefreshDataGridView();
        }

        private void RefreshDataGridView() {
            if (!loginView.UserDetails.ReportRead) {
                MessageBox.Show("Raporları okuma yetkiniz yok!");
                return;
            }

            dgwMostWatchedMovies.DataSource = _movieService.GetTop5MostWatchedMovies();
        }

        private void tabReports_Selected(object sender, TabControlEventArgs e) {
            if (!loginView.UserDetails.ReportRead) {
                MessageBox.Show("Raporları okuma yetkiniz yok!");
                return;
            }

            if (e.TabPageIndex == 0) {
                dgwMostWatchedMovies.DataSource = _movieService.GetTop5MostWatchedMovies();
            }
            else if (e.TabPageIndex == 1) {
                dgwLeastWatchedMovies.DataSource = _movieService.GetTop5LeastWatchedMovies();
            }
            else if (e.TabPageIndex == 2) {
                dgwMovieWithLength.DataSource = _movieService.GetAllMoviesWithLengths();
            }
            else if (e.TabPageIndex == 3) {
                dgwUsersWithAge.DataSource = _userService.GetAllUsersWithAge();
            }
            else if (e.TabPageIndex == 4) {
                dgwViewerCountByMovieAndShow.DataSource = _movieService.GetAllViewerCountByShowAndMovie();
            }
            else if (e.TabPageIndex == 5) { 
                dgwMovieCountsByLanguage.DataSource = _movieService.GetAllMovieCountByLanguage();
            }
        }
    }
}
