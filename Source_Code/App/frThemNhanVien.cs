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
    public partial class frThemNhanVien : Form
    {
        public frThemNhanVien()
        {
            InitializeComponent();
            dateNgaySinh.Value = DateTime.Today;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên !!!");
            }
            else if (cboGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập !!!");
            }
            else
            {
                if (AdminBUS.Instance.addNhanVien(txtMaNhanVien.Text, txtHoTen.Text, dateNgaySinh.Value,
                    cboGioiTinh.SelectedItem.ToString(), txtDiaChi.Text, txtTenDangNhap.Text))
                {
                    MessageBox.Show("Thêm Nhân viên quản lý thư viện thành công !!!");
                }
                this.Close();
            }

        }
    }
}
