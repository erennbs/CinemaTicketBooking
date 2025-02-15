using CinemaBooking.Models;
using CinemaBooking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBooking.Views {
    public partial class EditBookingUserControl : UserControl {
        private readonly BookingService _bookingService;
        private readonly CinemaService _cinemaService;
        private readonly MovieService _movieService;
        private readonly ShowService _showService;
        private readonly ShowSeatService _showSeatService;

        private List<ShowSeatDetailsDto> showSeats;
        private List<ShowSeatDetailsDto> selectedSeats;
        private List<ShowSeatDetailsDto> reservedSeats;

        private readonly BookingDetailsDto _bookingDetails;

        public EditBookingUserControl(BookingDetailsDto bookingDetails) {
            _bookingService = new BookingService();
            _cinemaService = new CinemaService();
            _movieService = new MovieService();
            _showService = new ShowService();
            _showSeatService = new ShowSeatService();

            reservedSeats = new List<ShowSeatDetailsDto>();
            selectedSeats = new List<ShowSeatDetailsDto>();

            _bookingDetails = bookingDetails;

            InitializeComponent();
            FillInputs(bookingDetails);
        }

        private void FillInputs(BookingDetailsDto bookingDetails) {
            cmbCinema.DataSource = _cinemaService.GetAll();
            cmbCinema.SelectedIndex = cmbCinema.FindStringExact(bookingDetails.CinemaName);
            cmbMovie.DataSource = _movieService.GetAllMovieTitlesOfCinema((int)cmbCinema.SelectedValue);
            cmbMovie.SelectedIndex = cmbMovie.FindStringExact(bookingDetails.MovieTitle);
            cmbShow.DataSource = _showService.GetFutureShowsByMovieAndCinema((int)cmbMovie.SelectedValue, (int)cmbCinema.SelectedValue);
            cmbShow.SelectedIndex = cmbShow.FindStringExact(bookingDetails.StartTime.ToString("d.MM.yyyy HH:mm"));
            
            //Debug.WriteLine(bookingDetails.StartTime.ToString("d.MM.yyyy HH:mm"));

            showSeats = _showSeatService.GetAllShowSeatsByShowId((int)cmbShow.SelectedValue);

            CreateSeats(showSeats);
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
                checkBox.CheckedChanged += CheckBoxCheckedChanged;

                flpSeats.Controls.Add(checkBox);

                if (seat.BookingId == _bookingDetails.Id) {
                    checkBox.AutoCheck = true;
                    checkBox.Checked = true;
                    reservedSeats.Add(seat);
                }
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

        private void btnPreviousPage_Click(object sender, EventArgs e) {
            Parent.Controls.RemoveAt(0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (!loginView.UserDetails.BookingUpdate) {
                MessageBox.Show("Rezervasyon düzenleme yetkiniz yok!");
                return;
            }

            if (selectedSeats.Count == 0 || cmbCinema.SelectedItem == null || cmbMovie.SelectedItem == null) {
                MessageBox.Show("Alanları doldurunuz!");
                return;
            }

            if (cmbShow.Text == _bookingDetails.StartTime.ToString("d.MM.yyyy HH:mm")) {
                _bookingService.Update(new Booking {
                    Id = _bookingDetails.Id,
                    NumberOfSeats = selectedSeats.Count,
                    UserId = loginView.UserDetails.UserId
                });

                foreach (var seat in selectedSeats) {
                    seat.BookingId = _bookingDetails.Id;
                    seat.IsReserved = true;
                    _showSeatService.Update(seat);
                }

                foreach (var seat in reservedSeats) {
                    if (!selectedSeats.Contains(seat)) {
                        seat.BookingId = null;
                        seat.IsReserved = false;
                        _showSeatService.Update(seat);
                    }
                }

            }
            else {
                foreach (var seat in selectedSeats) {
                    seat.BookingId = _bookingDetails.Id;
                    seat.IsReserved = true;
                    _showSeatService.Update(seat);
                }

                foreach (var seat in reservedSeats) {
                    seat.BookingId = null;
                    seat.IsReserved = false;
                    _showSeatService.Update(seat);
                }
            }
            Parent.Controls.RemoveAt(0); // go back to listing page
        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbShow.SelectedItem == null) {
                flpSeats.Controls.Clear();
                return;
            }

            showSeats = _showSeatService.GetAllShowSeatsByShowId((int)cmbShow.SelectedValue);

            CreateSeats(showSeats);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            reservedSeats.Clear();
            selectedSeats.Clear();
            FillInputs(_bookingDetails);
        }
    }
}
