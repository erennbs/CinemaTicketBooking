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
    public partial class LogsUserControl : UserControl {
        private readonly UserService _userService;
        
        public LogsUserControl() {
            _userService = new UserService();

            InitializeComponent();
        }

        public void RefreshDataGridView() {
            if (!loginView.UserDetails.LogRead) {
                MessageBox.Show("Log kayıtlarını okuma yetkiniz yok!");
                return;
            }

            dgwLogs.DataSource = _userService.GetAllLogs();
        }

        private void LogsUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
        }
    }
}
