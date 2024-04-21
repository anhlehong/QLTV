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
    #region SINGLETON
    public partial class ucReaders : UserControl
    {
        private static ucReaders instance;
        public static ucReaders Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucReaders();
                return instance;
            }
        }
        public ucReaders()
        {
            InitializeComponent();
            ReadersBUS.Instance.loadDocGia(gridDocGia);
            txtTimDocGia.Text = null;
        }
        #endregion
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReadersBUS.Instance.loadDocGia(gridDocGia);
            txtTimDocGia.Text = null;
        }

        private void btnTimDocGia_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTimDocGia.Text))
            {
                ReadersBUS.Instance.findDocGiaByMaDocGia(gridDocGia, txtTimDocGia.Text);
                if (gridDocGia.Rows.Count == 0)
                    ReadersBUS.Instance.findDocGiaByHoTen(gridDocGia, txtTimDocGia.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm !!!");
            }
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            if (ReadersBUS.Instance.DeleteDocGia(gridDocGia))
            {
                MessageBox.Show("Xóa thành công !!!");
                ReadersBUS.Instance.loadDocGia(gridDocGia);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ReadersBUS.Instance.editDocGia(gridDocGia))
            {
                MessageBox.Show("Sửa thông tin độc giả thành công !!!");
                ReadersBUS.Instance.loadDocGia(gridDocGia);
            }
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            fAddReader formThemDocGia = new fAddReader();
            formThemDocGia.ShowDialog();
            ReadersBUS.Instance.loadDocGia(gridDocGia);
        }
    }
}
