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

    public partial class ucPhieuTra : UserControl
    {
        #region SINGLETON
        private static ucPhieuTra instance;
        public static ucPhieuTra Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucPhieuTra();
                return instance;
            }
        }
        public ucPhieuTra()
        {
            InitializeComponent();
            PhieuTraBUS.Instance.loadPhieuTra(gridPhieuTra);
            txtTimPhieuTra.Text = null;
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PhieuTraBUS.Instance.loadPhieuTra(gridPhieuTra);
            txtTimPhieuTra.Text = null;
        }

        private void btnTimPhieuTra_Click(object sender, EventArgs e)
        {
            if (rdoMaPhieuMuon.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimPhieuTra.Text))
                {
                    MessageBox.Show("Vui lòng nhập nộp dung tìm kiếm !!!");
                }
                else
                {
                    PhieuTraBUS.Instance.findPhieuTraByMaPhieuMuon(gridPhieuTra, txtTimPhieuTra.Text);
                }
            }
            else if (rdoMaPhieTra.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimPhieuTra.Text))
                {
                    MessageBox.Show("Vui lòng nhập nộp dung tìm kiếm !!!");
                }
                else
                {
                    PhieuTraBUS.Instance.findPhieuTraByMaPhieuTra(gridPhieuTra, txtTimPhieuTra.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo Mã phiếu mượn hay Mã phiếu trả !!!");
            }
        }

        private void btnThemPhieuTra_Click(object sender, EventArgs e)
        {
            fThemPhieuTra formThemPhieuTra = new fThemPhieuTra();
            formThemPhieuTra.ShowDialog();
            PhieuTraBUS.Instance.loadPhieuTra(gridPhieuTra);
        }

        private void btnXoaPhieuTra_Click(object sender, EventArgs e)
        {
            if (PhieuTraBUS.Instance.DeletePhieuTra(gridPhieuTra))
                MessageBox.Show("Xóa phiếu trả thành công !!!");
            PhieuTraBUS.Instance.loadPhieuTra(gridPhieuTra);
        }
    }
}
