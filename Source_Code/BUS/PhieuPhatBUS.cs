using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuPhatBUS
    {
        #region SINGLETON
        private static PhieuPhatBUS instance;

        public static PhieuPhatBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuPhatBUS();
                return instance;
            }
        }

        private PhieuPhatBUS() { }

        #endregion

        #region addColumns
        private void addColumns(DataGridView data)
        {
            // Thêm cột "Mã phiếu phạt"
            var colMaPhieuPhat = new DataGridViewTextBoxColumn();
            colMaPhieuPhat.Name = "MaPhieuPhat";
            colMaPhieuPhat.HeaderText = "Mã phiếu phạt";
            colMaPhieuPhat.DataPropertyName = "MaPhieuPhat";
            data.Columns.Add(colMaPhieuPhat);

            // Thêm cột "Mã phiếu mượn"
            var colMaPhieuMuon = new DataGridViewTextBoxColumn();
            colMaPhieuMuon.Name = "MaPhieuMuon";
            colMaPhieuMuon.HeaderText = "Mã phiếu mượn";
            colMaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            data.Columns.Add(colMaPhieuMuon);

            // Thêm cột "Ngày tạo phiếu phạt"
            var colNgayTaoPhieuPhat = new DataGridViewTextBoxColumn();
            colNgayTaoPhieuPhat.Name = "NgayTaoPhieuPhat";
            colNgayTaoPhieuPhat.HeaderText = "Ngày tạo phiếu phạt";
            colNgayTaoPhieuPhat.DataPropertyName = "NgayTaoPhieuPhat";
            data.Columns.Add(colNgayTaoPhieuPhat);

            // Thêm cột "Tiền phạt"
            var colTienPhat = new DataGridViewTextBoxColumn();
            colTienPhat.Name = "TienPhat";
            colTienPhat.HeaderText = "Tiền phạt";
            colTienPhat.DataPropertyName = "TienPhat";
            data.Columns.Add(colTienPhat);
        }

        #endregion

        #region load PhieuPhat
        public void loadPhieuPhat(DataGridView data)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = PhieuPhatDAL.Instance.loadPhieuPhat();

            data.Refresh();

            data.Columns["MaPhieuPhat"].ReadOnly = true;
            data.Columns["MaPhieuMuon"].ReadOnly = true;

        }
        #endregion

        #region add PhieuPhat
        public bool addPhieuPhat(string strMaPhieuPhat, string strMaPhieuMuon,
            DateTime dateNgayTaoPhieuPhat, string strTienPhat)
        {
            int iTienPhat = Int32.Parse(strTienPhat);
            PHIEUPHAT newPhieuPhat = new PHIEUPHAT()
            {
                MaPhieuPhat = strMaPhieuPhat,
                MaPhieuMuon = strMaPhieuMuon,
                NgayTaoPhieuPhat = dateNgayTaoPhieuPhat,
                TienPhat = iTienPhat
            };
            return PhieuPhatDAL.Instance.addPhieuPhat(newPhieuPhat);
        }
        #endregion

        #region delete PhieuPhat
        public bool DeletePhieuPhat(DataGridView data)
        {
            string MaPhieuPhat = data.SelectedCells[0].OwningRow.Cells["MaPhieuPhat"].Value.ToString();
            return PhieuPhatDAL.Instance.deletePhieuPhat(MaPhieuPhat);
        }
        #endregion

        #region find PhieuPhat by MaPhieuPhat
        public void findPhieuPhatByMaPhieuPhat(DataGridView data, string strMaPhieuPhat)
        {
            data.DataSource = PhieuPhatDAL.Instance.findPhieuPhatByMaPhieuPhat(strMaPhieuPhat);
        }
        #endregion

        #region find PhieuPhat by MaPhieuMuon
        public void findPhieuPhatByMaPhieuMuon(DataGridView data, string strMaPhieuMuon)
        {
            data.DataSource = PhieuPhatDAL.Instance.findPhieuPhatByMaPhieuMuon(strMaPhieuMuon);
        }
        #endregion

        #region edit PhieuPhat
        public bool editPhieuPhat(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MaPhieuPhat = row.Cells["MaPhieuPhat"].Value.ToString();
            string MaPhieuMuon = row.Cells["MaPhieuMuon"].Value.ToString();
            DateTime? NgayTaoPhieuPhat = (DateTime?)row.Cells["NgayTaoPhieuPhat"].Value;
            int? TienPhat = (int?)row.Cells["TienPhat"].Value;

            PHIEUPHAT newPhieuPhat = new PHIEUPHAT();
            newPhieuPhat.MaPhieuPhat = MaPhieuPhat;
            newPhieuPhat.MaPhieuMuon = MaPhieuMuon;
            newPhieuPhat.NgayTaoPhieuPhat = NgayTaoPhieuPhat;
            newPhieuPhat.TienPhat = TienPhat;

            return PhieuPhatDAL.Instance.editPhieuPhat(MaPhieuPhat, newPhieuPhat);
        }
        #endregion
    }
}
