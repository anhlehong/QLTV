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
    public partial class ucPhieuMuon : UserControl
    {
        #region SINGLETON
        private static ucPhieuMuon instance;
        public static ucPhieuMuon Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucPhieuMuon();
                return instance;
            }
        }
        public ucPhieuMuon()
        {
            InitializeComponent();
            PhieuMuonBUS.Instance.loadPhieuMuon(gridPhieuMuon);
            txtTimPhieuMuon.Text = null;
        }
        #endregion

        private void butRefresh_Click(object sender, EventArgs e)
        {
            PhieuMuonBUS.Instance.loadPhieuMuon(gridPhieuMuon);
            txtTimPhieuMuon.Text = null;
        }

        private void btnTimPhieuMuon_Click(object sender, EventArgs e)
        {
            if (rdoMaPhieuMuon.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimPhieuMuon.Text))
                {
                    MessageBox.Show("Vui lòng nhập nộp dung tìm kiếm !!!");
                }
                else
                {
                    PhieuMuonBUS.Instance.findPhieuMuonByMaPhieuMuon(gridPhieuMuon, txtTimPhieuMuon.Text);
                }
            }
            else if (rdoMaDocGia.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimPhieuMuon.Text))
                {
                    MessageBox.Show("Vui lòng nhập nộp dung tìm kiếm !!!");
                }
                else
                {
                    PhieuMuonBUS.Instance.findPhieuMuonByMaDocGia(gridPhieuMuon, txtTimPhieuMuon.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo Mã phiếu mượn hay Mã độc giả !!!");
            }
        }

        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            if (PhieuMuonBUS.Instance.deletePhieuMuonByMaPhieuMuon(gridPhieuMuon))
            {
                MessageBox.Show("Xòa thành công !!!");
                PhieuMuonBUS.Instance.loadPhieuMuon(gridPhieuMuon);
            }
        }

        private void btnThemPhieuMuon_Click(object sender, EventArgs e)
        {
            frThemPhieuMuon formThemPhieuMuon = new frThemPhieuMuon();
            formThemPhieuMuon.ShowDialog();
            PhieuMuonBUS.Instance.loadPhieuMuon(gridPhieuMuon);
        }
    }
}
