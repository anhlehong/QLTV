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
    public partial class ucAdmin : UserControl
    {
        #region SINGLETON
        private static ucAdmin instance;
        public static ucAdmin Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucAdmin();
                return instance;
            }
        }
        public ucAdmin()
        {
            InitializeComponent();
            AdminBUS.Instance.loadAdmin(gridNhanVien);
            txtTimNhanVien.Text = null;
        }
        #endregion

        private void butRefresh_Click(object sender, EventArgs e)
        {
            AdminBUS.Instance.loadAdmin(gridNhanVien);
            txtTimNhanVien.Text = null;
        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTimNhanVien.Text))
            {
                AdminBUS.Instance.findAdminByMaNhanVien(gridNhanVien, txtTimNhanVien.Text);
                if (gridNhanVien.Rows.Count == 0)
                    AdminBUS.Instance.findAdminByTenDangNhap(gridNhanVien, txtTimNhanVien.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm !!!");
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frThemNhanVien formThemNhanVien = new frThemNhanVien();
            formThemNhanVien.ShowDialog();
            AdminBUS.Instance.loadAdmin(gridNhanVien);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frDoiMatKhau formDoiMatKhau = new frDoiMatKhau();
            formDoiMatKhau.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(AdminBUS.Instance.editNhanVien(gridNhanVien))
            {
                MessageBox.Show("Sửa thông tin admin thành công !!!");
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (gridNhanVien.SelectedCells.Count > 0)
            {
                if (AdminBUS.Instance.DeleteNhanVien(gridNhanVien))
                {
                    MessageBox.Show("Xóa Thành công !!!");
                    AdminBUS.Instance.loadAdmin(gridNhanVien);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần xóa !!!");
            }
        }
    }
}
