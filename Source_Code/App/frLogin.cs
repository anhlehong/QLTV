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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản !!!");
            }
            else if (string.IsNullOrWhiteSpace(txtUserpwd.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu !!!");
            }
            else if (DangNhapBUS.Instance.checkDangNhap(txtUsername.Text, txtUserpwd.Text))
            {
                UserSession.Instance.SetUserName(txtUsername.Text);
                frManager f = new frManager();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng !!!");
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
