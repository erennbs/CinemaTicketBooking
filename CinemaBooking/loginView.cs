

using CinemaBooking.Models;
using CinemaBooking.Services;
using MovieTicketSystemUI;

namespace CinemaBooking {
    public partial class loginView : Form {
        public static UserWithRoles UserDetails { get; set; }

        public loginView() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            UserService userService = new UserService();
            if (txtUsername.Text == "" || txtPassword.Text == "") {
                lblErrorMessage.Text = "Alanlar� bo� b�rakmay�n�z!";
                lblErrorMessage.Visible = true;
                return;
            }

            UserWithRoles user = userService.GetUserWithRolesByCredentials(txtUsername.Text, txtPassword.Text);

            if (user != null) {
                UserDetails = user;
                Hide();

                new adminView().Show();
            }
            else {
                lblErrorMessage.Text = "Kullan�c� ad� ya da �ifre hatal�!";
                lblErrorMessage.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new registerView(this).Show();
            Hide();
        }
    }
}
