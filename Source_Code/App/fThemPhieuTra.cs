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
    public partial class fThemPhieuTra : Form
    {
        public fThemPhieuTra()
        {
            InitializeComponent();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaPhieuTra.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu trả !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu mượn !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã độc giả !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã sách !!!");
            }
            else
            {
                if (PhieuTraBUS.Instance.addPhieuTra(txtMaPhieuTra.Text, txtMaPhieuMuon.Text,
                    txtMaDocGia.Text, txtMaSach.Text))
                {
                    MessageBox.Show("Thêm Phiếu trả thành công !!!");
                }
                this.Close();
            }
        }
    }
}
