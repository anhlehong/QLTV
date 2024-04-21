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
    public partial class frThemTaiLieu : Form
    {
        public frThemTaiLieu()
        {
            InitializeComponent();
            dateNgayXuatBan.Value = DateTime.Today;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sách !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Sách !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng nhập Loại Sách !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Tác giả !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập Số lượng sách !!!");
            }
            else
            {
                if (BookBUS.Instance.addSach(txtMaSach.Text, txtTenSach.Text, txtLoaiSach.Text, txtTacGia.Text, txtNhaXuatBan.Text,
                    dateNgayXuatBan.Value, txtSoLuong.Text))
                {
                    MessageBox.Show("Thêm Sách thành công !!!");
                }
                this.Close();
            }

        }
    }
}