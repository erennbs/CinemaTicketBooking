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
    public partial class BookingsUserControl : UserControl {
        private readonly BookingService _bookingService;
        private readonly CinemaService _cinemaService;
        private readonly MovieService _movieService;
        private readonly CinemaHallService _cinemaHallService;

        public BookingsUserControl() {
            _bookingService = new BookingService();
            _cinemaService = new CinemaService();
            _movieService = new MovieService();
            _cinemaHallService = new CinemaHallService();

            InitializeComponent();
        }

        public void RefreshFilters() {
            cmbMovieFilter.DataSource = _movieService.GetAllMovieTitles();
            cmbMovieFilter.SelectedItem = null;

            cmbCinemaFilter.DataSource = _cinemaService.GetAll();
            cmbCinemaFilter.SelectedItem = null;

            cmbHallFilter.DataSource = null;
        }

        public void RefreshDataGridView() {
            if (!loginView.UserDetails.BookingRead) {
                MessageBox.Show("Rezervasyon okuma yetkiniz yok!");
                return;
            }
            dgwBookings.DataSource = _bookingService.GetAllBookingDetails();
        }

        private void BookingsUserControl_Load(object sender, EventArgs e) {
            RefreshDataGridView();
            RefreshFilters();
        }

        private void cmbCinemaFilter_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbCinemaFilter.SelectedValue == null) return;

            cmbHallFilter.DataSource = _cinemaHallService.GetAllCinemaHallsByCinemaId((int)cmbCinemaFilter.SelectedValue);
            cmbHallFilter.SelectedItem = null;
            cmbHallFilter.DisplayMember = "Number";
            cmbHallFilter.ValueMember = "Id";
        }

        private void dgwBookings_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwBookings.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1) {
                if (!loginView.UserDetails.BookingDelete) {
                    MessageBox.Show("Rezervasyon silme yetkiniz yok!");
                    return;
                }
                
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    int bookingId = ((BookingDetailsDto)dgwBookings.Rows[e.RowIndex].DataBoundItem).Id;
                    _bookingService.Delete(new Booking { Id = bookingId });
                    RefreshDataGridView();
                }
            }
            else if (dgwBookings.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0) {
                if (!loginView.UserDetails.BookingUpdate) {
                    MessageBox.Show("Rezervasyon düzenleme yetkiniz yok!");
                    return;
                }
                BookingDetailsDto movieDetails = (BookingDetailsDto)dgwBookings.Rows[e.RowIndex].DataBoundItem;
                ShowBookingEditPage(movieDetails);
            }
        }

        private void ShowBookingEditPage(BookingDetailsDto bookingDetails) {
            Parent.Controls.Add(new EditBookingUserControl(bookingDetails));
            Parent.Controls[1].BringToFront();
            Parent.Controls[0].Dock = DockStyle.Fill;
        }

        private void BookingsUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshFilters();
            RefreshDataGridView();
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            if (cmbCinemaFilter.SelectedItem == null && cmbHallFilter.SelectedItem == null
                && cmbMovieFilter.SelectedItem == null) return;

            dgwBookings.DataSource = _bookingService.GetAllBookingDetails(cmbMovieFilter.Text, cmbCinemaFilter.Text, cmbHallFilter.Text);
        }

        private void btnResetFilter_Click(object sender, EventArgs e) {
            cmbMovieFilter.SelectedItem = null;
            cmbCinemaFilter.SelectedItem = null;
            cmbHallFilter.DataSource = null;
            cmbHallFilter.SelectedItem = null;

            RefreshDataGridView();
        }
    }
}
