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
    public partial class frThemPhieuMuon : Form
    {
        public frThemPhieuMuon()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu mượn !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã độc giả !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sách !!!");
            }
            else
            {
                if (PhieuMuonBUS.Instance.addPhieuMuon(txtMaPhieuMuon.Text, txtMaDocGia.Text, txtMaSach.Text))
                {
                    MessageBox.Show("Thêm Phiếu mượn thành công !!!");
                }
                this.Close();
            }
        }

    }
}
