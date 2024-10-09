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
using CinemaBooking.Models;

namespace CinemaBooking {
    public partial class registerView : Form {
        private readonly UserService _userService;
        private readonly Form _loginView;

        public registerView(Form loginView) {
            _userService = new UserService();
            _loginView = loginView;

            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0) {
                lblErrorMessage.Text = "Tüm alanları doldurunuz!";
                lblErrorMessage.Visible = true;
                return;
            }
            if (DateTime.Now.Year - dtpBirthday.Value.Year < 18) {
                lblErrorMessage.Text = "Yaşınız 18'den büyük olmalı";
                lblErrorMessage.Visible = true;
                return;
            }

            _userService.Add(new User {
                UserName = txtUsername.Text,
                Birthday = dtpBirthday.Value,
                Password = txtPassword.Text,
            });

            Hide();
            _loginView.Show();
        }

        private void registerView_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Hide();
            _loginView.Show();
        }
    }
}
