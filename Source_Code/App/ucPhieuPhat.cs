using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace App
{
    public partial class ucPhieuPhat : UserControl
    {
        #region SINGLETON
        private static ucPhieuPhat instance;
        public static ucPhieuPhat Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucPhieuPhat();
                return instance;
            }
        }
        public ucPhieuPhat()
        {
            InitializeComponent();
            PhieuPhatBUS.Instance.loadPhieuPhat(gridPhieuPhat);
            txtTimPhieuPhat.Text = null;
        }
        #endregion

        #region load PhieuPhat
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PhieuPhatBUS.Instance.loadPhieuPhat(gridPhieuPhat);
            txtTimPhieuPhat.Text = null;
        }
        #endregion

        #region add PhieuPhat
        private void btnThemPhieuPhat_Click(object sender, EventArgs e)
        {
            frThemPhieuPhat formThemPhieuPhat = new frThemPhieuPhat();
            formThemPhieuPhat.ShowDialog();
            PhieuPhatBUS.Instance.loadPhieuPhat(gridPhieuPhat);
        }
        #endregion

        #region delete PhieuPhat
        private void btnXoaPhieuPhat_Click(object sender, EventArgs e)
        {
            if (gridPhieuPhat.SelectedCells.Count > 0)
            {
                if(PhieuPhatBUS.Instance.DeletePhieuPhat(gridPhieuPhat))
                {
                    MessageBox.Show("Xóa Thành công !!!");
                    PhieuPhatBUS.Instance.loadPhieuPhat(gridPhieuPhat);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ô cần xóa !!!");
            }
        }

        #endregion

        #region find PhieuPhat
        private void btnTimPhieuPhat_Click(object sender, EventArgs e)
        {
            if(rdoMaPhieuMuon.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimPhieuPhat.Text))
                {
                    MessageBox.Show("Vui lòng nhập nộp dung tìm kiếm !!!");
                }
                else
                {
                    PhieuPhatBUS.Instance.findPhieuPhatByMaPhieuMuon(gridPhieuPhat, txtTimPhieuPhat.Text);
                }
            }
            else if (rdoMaPhieuPhat.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimPhieuPhat.Text))
                {
                    MessageBox.Show("Vui lòng nhập nộp dung tìm kiếm !!!");
                }
                else
                {
                    PhieuPhatBUS.Instance.findPhieuPhatByMaPhieuPhat(gridPhieuPhat, txtTimPhieuPhat.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm kiếm theo Mã phiếu mượn hay Mã phiếu phạt !!!");
            }
        }

        #endregion

        #region edit PhieuPhat
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (PhieuPhatBUS.Instance.editPhieuPhat(gridPhieuPhat))
            {
                MessageBox.Show("Sửa phiếu phạt thành công !!!");
                PhieuPhatBUS.Instance.loadPhieuPhat(gridPhieuPhat);
            }
        }
        #endregion
    }
}
