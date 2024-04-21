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
    public partial class frThemPhieuPhat : Form
    {
        public frThemPhieuPhat()
        {
            InitializeComponent();
            dateNgayTaoPhieuPhat.Value=DateTime.Today;
        }

        #region add PhieuPhat
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMaPhieuPhat.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu phạt !!!"); 
            }
            else if (String.IsNullOrWhiteSpace(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu mượn !!!");
            }
            else if (String.IsNullOrWhiteSpace(txtSoTienPhat.Text))
            {
                MessageBox.Show("Vui lòng nhập Số tiền phạt !!!");
            }
            else
            {
                if (PhieuPhatBUS.Instance.addPhieuPhat(txtMaPhieuPhat.Text, txtMaPhieuMuon.Text,
                    dateNgayTaoPhieuPhat.Value, txtSoTienPhat.Text))
                {
                    MessageBox.Show("Thêm Phiếu phạt thành công !!!");
                }
                this.Close();
            }
        }
        #endregion


    }
}
