using CinemaBooking.Services;
using CinemaBooking.Models;
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
    public partial class UsersUserControl : UserControl {
        private readonly UserService _userService;

        public UsersUserControl() {
            _userService = new UserService();
            InitializeComponent();
        }

        private void RefreshDataGridView() {
            if (!loginView.UserDetails.UserRead) {
                MessageBox.Show("Kullanıcıları okuma yetkiniz yok!");
                return;
            }

            dgwUsers.DataSource = _userService.GetAllUsersWithRoles();
        }

        private void UsersUserControl_Load(object sender, EventArgs e) {
            RefreshDataGridView();
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Text = "Güncelle";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.FlatStyle = FlatStyle.Flat;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Text = "Sil";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.FlatStyle = FlatStyle.Flat;

            dgwUsers.Columns.Add(editColumn);
            dgwUsers.Columns.Add(deleteColumn);
        }

        private void dgwUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgwUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1) {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    int userId = ((UserWithRoles)dgwUsers.Rows[e.RowIndex].DataBoundItem).UserId;
                    _userService.Delete(new User { Id = userId });
                    RefreshDataGridView();
                }
            }
            else if (dgwUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0) {
                UserWithRoles roles = (UserWithRoles)dgwUsers.Rows[e.RowIndex].DataBoundItem;
                _userService.UpdateUserRoles(roles);
            }
        }

        private void UsersUserControl_ParentChanged(object sender, EventArgs e) {
            RefreshDataGridView();
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            if (txtUsernameFilter.Text.Length == 0) return;

            dgwUsers.DataSource = _userService.GetAllUsersWithRoles(txtUsernameFilter.Text);
        }

        private void btnResetFilter_Click(object sender, EventArgs e) {
            txtUsernameFilter.Text = "";

            RefreshDataGridView();
        }
    }
}
