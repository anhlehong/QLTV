using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frDoiMatKhau : Form
    {
        public frDoiMatKhau()
        {
            InitializeComponent();
            lblTenDangNhap.Text = UserSession.Instance.UserName;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ !!!");
            }
            else if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu Mới !!!");

            }
            else if (DangNhapBUS.Instance.UpdatePassword(lblTenDangNhap.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công !!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng !!!");
            }
        }
    }
}
