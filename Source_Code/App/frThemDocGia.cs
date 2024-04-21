using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class fAddReader : Form
    {
        public fAddReader()
        {
            InitializeComponent();
            dateNgaySinh.Value = DateTime.Today;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã độc giả !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên !!!");
            }
            else if (cboGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập căn cước công dân !!!");
            }
            else
            {
                if (ReadersBUS.Instance.addDocGia(txtMaDocGia.Text, txtHoTen.Text, dateNgaySinh.Value,
                    cboGioiTinh.SelectedItem.ToString(), txtDiaChi.Text, txtSDT.Text, txtCCCD.Text))
                {
                    MessageBox.Show("Thêm Độc giả thành công !!!");
                }
                this.Close();
            }
        }
    }
}
