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
    public partial class frManager : Form
    {
        public frManager()
        {
            InitializeComponent();
            loadUCAdmin();
            loadUCBook();
            loadUCPhieuMuon();
            loadUCPhieuPhat();
            loadUCPhieuTra();
            loadUCReaders();
        }
        #region load User Control
        private void loadUCAdmin()
        {
            if (!tabAdmin.Controls.Contains(ucAdmin.Instance))
            {
                tabAdmin.Controls.Add(ucAdmin.Instance);
                ucAdmin.Instance.Dock = DockStyle.Fill;
                ucAdmin.Instance.BringToFront();
            }
            else
                ucAdmin.Instance.BringToFront();
        }
        private void loadUCBook()
        {
            if (!tabBooks.Controls.Contains(ucBook.Instance))
            {
                tabBooks.Controls.Add(ucBook.Instance);
                ucBook.Instance.Dock = DockStyle.Fill;
                ucBook.Instance.BringToFront();
            }
            else
                ucBook.Instance.BringToFront();
        }
        private void loadUCPhieuMuon()
        {
            if (!tabPhieuMuon.Controls.Contains(ucPhieuMuon.Instance))
            {
                tabPhieuMuon.Controls.Add(ucPhieuMuon.Instance);
                ucPhieuMuon.Instance.Dock = DockStyle.Fill;
                ucPhieuMuon.Instance.BringToFront();
            }
            else
                ucPhieuMuon.Instance.BringToFront();
        }
        private void loadUCPhieuPhat()
        {
            if (!tabPhieuPhat.Controls.Contains(ucPhieuPhat.Instance))
            {
                tabPhieuPhat.Controls.Add(ucPhieuPhat.Instance);
                ucPhieuPhat.Instance.Dock = DockStyle.Fill;
                ucPhieuPhat.Instance.BringToFront();
            }
            else
                ucPhieuPhat.Instance.BringToFront();
        }
        private void loadUCPhieuTra()
        {
            if (!tabPhieuTra.Controls.Contains(ucPhieuTra.Instance))
            {
                tabPhieuTra.Controls.Add(ucPhieuTra.Instance);
                ucPhieuTra.Instance.Dock = DockStyle.Fill;
                ucPhieuTra.Instance.BringToFront();
            }
            else
                ucPhieuTra.Instance.BringToFront();
        }
        private void loadUCReaders()
        {
            if (!tabReaders.Controls.Contains(ucReaders.Instance))
            {
                tabReaders.Controls.Add(ucReaders.Instance);
                ucReaders.Instance.Dock = DockStyle.Fill;
                ucReaders.Instance.BringToFront();
            }
            else
                ucReaders.Instance.BringToFront();
        }
        #endregion
    }
}
