﻿using CinemaBooking;
using CinemaBooking.Models;
using CinemaBooking.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private readonly UserControl[] _pages;

        public adminView() {
            _defaultButtonColor = Color.FromArgb(47, 54, 69);
            _selectedButtonColor = Color.FromArgb(35, 40, 51);

            _pages = [ new MoviesUserControl(), new ShowsUserControl(),
                       new CinemasUserControl(), new CinemaHallsUserControl(), new BookingsUserControl(), 
                       new LanguagesUserControl(), new GenresUserControl(), new CitiesUserControl(),
                       new AddMovieUserControl(), new AddShowUserControl(),
                       new AddCinemaUserControl(), new AddHallUserControl(),
                       new AddBookingUserControl(), new UsersUserControl(), new ReportsUserControl(), new LogsUserControl()];

            InitializeComponent();

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

        private void btnLogout_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void adminView_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
