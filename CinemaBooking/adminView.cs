using CinemaBooking;
using CinemaBooking.Models;
using CinemaBooking.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketSystemUI {
    public partial class adminView : Form {
        private Button _currentButton;
        private readonly Color _defaultButtonColor;
        private readonly Color _selectedButtonColor;
        private List<UserControl> _pages;

        public adminView() {
            _defaultButtonColor = Color.FromArgb(47, 54, 69);
            _selectedButtonColor = Color.FromArgb(35, 40, 51);

            _pages = new List<UserControl>();

            InitializeComponent();
            
            CreateButtons();

            lblUsername.Text = "Kullanıcı: " + loginView.UserDetails.UserName;
        }

        private void sidebarButton_Click(object sender, EventArgs e) {
            if (_currentButton == (Button)sender) return;

            if (_currentButton != null) {
                _currentButton.BackColor = _defaultButtonColor;
            }

            _currentButton = (Button)sender;
            _currentButton.BackColor = _selectedButtonColor;

            ChangeContentPage(Convert.ToInt32(_currentButton.Tag));
        }

        private void ChangeContentPage(int pageId) {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_pages[pageId]);
            pnlContent.Controls[0].Dock = DockStyle.Fill;
        }

        private void CreateButtons() {
            int counter = 0;
            Font font = new Font("Microsoft New Tai Lue", 10, FontStyle.Bold);

            if (loginView.UserDetails.LogRead) {
                _pages.Add(new LogsUserControl());
                Button btn = CreateButtonControl("Log Kayıtları", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.ReportRead) {
                _pages.Add(new ReportsUserControl());
                Button btn = CreateButtonControl("Raporlar", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.UserRead) {
                _pages.Add(new UsersUserControl());
                Button btn = CreateButtonControl("Kullanıcılar", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.BookingInsert) {
                _pages.Add(new AddBookingUserControl());
                Button btn = CreateButtonControl("Rezervasyon Ekle", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.CinemaHallInsert) {
                _pages.Add(new AddHallUserControl());
                Button btn = CreateButtonControl("Salon Ekle", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.CinemaInsert) {
                _pages.Add(new AddCinemaUserControl());
                Button btn = CreateButtonControl("Sinema Ekle", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.ShowInsert) {
                _pages.Add(new AddShowUserControl());
                Button btn = CreateButtonControl("Seans Ekle", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.MovieInsert) {
                _pages.Add(new AddMovieUserControl());
                Button btn = CreateButtonControl("Film Ekle", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.CityRead) {
                _pages.Add(new CitiesUserControl());
                Button btn = CreateButtonControl("Şehirler", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.GenreRead) {
                _pages.Add(new GenresUserControl());
                Button btn = CreateButtonControl("Türler", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.LanguageRead) {
                _pages.Add(new LanguagesUserControl());
                Button btn = CreateButtonControl("Diller", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.BookingRead) {
                _pages.Add(new BookingsUserControl());
                Button btn = CreateButtonControl("Rezervasyonlar", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.CinemaHallRead) {
                _pages.Add(new CinemaHallsUserControl());
                Button btn = CreateButtonControl("Salonlar", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.CinemaRead) {
                _pages.Add(new CinemasUserControl());
                Button btn = CreateButtonControl("Sinemalar", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.ShowRead) {
                _pages.Add(new ShowsUserControl());
                Button btn = CreateButtonControl("Seanslar", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }
            if (loginView.UserDetails.MovieRead) {
                _pages.Add(new MoviesUserControl());
                Button btn = CreateButtonControl("Filmler", counter, font);
                pnlSidebar.Controls.Add(btn);
                counter++;
            }           
        }

        public Button CreateButtonControl(string text, int tag, System.Drawing.Font font) {
            Button btn = new Button();
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = _selectedButtonColor;
            btn.FlatAppearance.MouseDownBackColor = _selectedButtonColor;
            btn.Height = 60;
            btn.Text = text;
            btn.Font = font;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ForeColor = Color.White;
            btn.Dock = DockStyle.Top;
            btn.Tag = tag;
            btn.Cursor = Cursors.Hand;
            btn.Click += sidebarButton_Click;

            return btn;
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void adminView_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
