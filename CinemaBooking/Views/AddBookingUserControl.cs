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
    public partial class AddBookingUserControl : UserControl {
        private readonly BookingService _bookingService;
        private readonly CinemaService _cinemaService;
        private readonly MovieService _movieService;
        private readonly ShowService _showService;
        private readonly ShowSeatService _showSeatService;

        private List<ShowSeatDetailsDto> showSeats;
        private List<ShowSeatDetailsDto> selectedSeats;

        public AddBookingUserControl() {
            _bookingService = new BookingService();
            _cinemaService = new CinemaService();
            _movieService = new MovieService();
            _showService = new ShowService();
            _showSeatService = new ShowSeatService();

            selectedSeats = new List<ShowSeatDetailsDto>();

            InitializeComponent();
        }

        private void RefreshInputs() {
            cmbCinema.DataSource = _cinemaService.GetAll();
            cmbCinema.SelectedItem = null;

            cmbMovie.DataSource = null;
            cmbShow.DataSource = null;
        }

        private void CreateSeats(List<ShowSeatDetailsDto> showSeats) {
            flpSeats.Controls.Clear();
            foreach (var seat in showSeats) {
                CheckBox checkBox = new CheckBox();
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.BackColor = seat.IsReserved ? Color.Red : Color.White;
                checkBox.Size = new Size(80, 80);
                checkBox.TextAlign = ContentAlignment.MiddleCenter;
                checkBox.Text = seat.SeatNumber.ToString();
                checkBox.AutoCheck = !seat.IsReserved;
                if (!seat.IsReserved) checkBox.CheckedChanged += CheckBoxCheckedChanged;

                flpSeats.Controls.Add(checkBox);
            }
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) {
                checkBox.BackColor = Color.Green;
                selectedSeats.Add(showSeats[flpSeats.Controls.IndexOf(checkBox)]);
            }
            else {
                checkBox.BackColor = Color.White;
                selectedSeats.Remove(showSeats[flpSeats.Controls.IndexOf(checkBox)]);
            }
        }

        private void cmbCinema_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbCinema.SelectedItem == null) return;

            cmbMovie.DataSource = _movieService.GetAllMovieTitlesOfCinema((int)cmbCinema.SelectedValue); ;
            cmbMovie.DisplayMember = "Title";
            cmbMovie.ValueMember = "Id";
            cmbMovie.SelectedItem = null;
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbMovie.SelectedItem == null) return;

            cmbShow.DataSource = _showService.GetFutureShowsByMovieAndCinema((int)cmbMovie.SelectedValue, (int)cmbCinema.SelectedValue);
            cmbShow.DisplayMember = "StartTime";
            cmbShow.ValueMember = "Id";
            cmbShow.SelectedItem = null;
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbShow.SelectedItem == null) {
                flpSeats.Controls.Clear();
                return;
            }

            showSeats = _showSeatService.GetAllShowSeatsByShowId((int)cmbShow.SelectedValue);

            CreateSeats(showSeats);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.BookingInsert) {
                MessageBox.Show("Rezervasyon ekleme yetkiniz yok!");
                return;
            }

            if (selectedSeats.Count == 0 || cmbCinema.SelectedItem == null || cmbMovie.SelectedItem == null) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }
            
            Booking insertedBooking = _bookingService.Add(new Booking {
                NumberOfSeats = selectedSeats.Count,
                UserId = loginView.UserDetails.UserId
            });

            foreach (var seat in selectedSeats) {
                _showSeatService.Update(new ShowSeat {
                    Id = seat.Id,
                    BookingId = insertedBooking.Id,
                    IsReserved = true,
                    HallSeatId = seat.HallSeatId,
                    ShowId = seat.ShowId,
                });
            }

            selectedSeats.Clear();
            RefreshInputs();
        }

        private void AddBookingUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshInputs();
        }

        
        private void btnClear_Click(object sender, EventArgs e) {
            RefreshInputs();
        }
    }
}
