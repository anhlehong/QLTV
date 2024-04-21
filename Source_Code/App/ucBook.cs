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
    public partial class ucBook : UserControl
    {
        #region SINGLETON
        private static ucBook instance;
        public static ucBook Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucBook();
                return instance;
            }
        }
        public ucBook()
        {
            InitializeComponent();
            BookBUS.Instance.loadSach(gridSach);
            txtTimSach.Text = null;
        }
        #endregion
        private void butRefresh_Click(object sender, EventArgs e)
        {
            BookBUS.Instance.loadSach(gridSach);
            txtTimSach.Text = null;
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtTimSach.Text))
            {
                BookBUS.Instance.findSachByMaSach(gridSach, txtTimSach.Text);
                if (gridSach.Rows.Count == 0)
                    BookBUS.Instance.findSachByTenSach(gridSach, txtTimSach.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm !!!");
            }
        }

        private void btnThemTaiLieu_Click(object sender, EventArgs e)
        {
            frThemTaiLieu formThemTaiLieu = new frThemTaiLieu();
            formThemTaiLieu.ShowDialog();
            BookBUS.Instance.loadSach(gridSach);
        }

        private void btnXoaTaiLieu_Click(object sender, EventArgs e)
        {
            if (BookBUS.Instance.DeleteSach(gridSach))
            {
                MessageBox.Show("Xóa Thành Công !!!");
                BookBUS.Instance.loadSach(gridSach);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (BookBUS.Instance.editSach(gridSach))
            {
                MessageBox.Show("Sửa thông tin sách thành công !!!");
                BookBUS.Instance.loadSach(gridSach);
            }
        }
    }
}
