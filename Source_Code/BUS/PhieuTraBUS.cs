using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuTraBUS
    {
        #region SINGLETON
        private static PhieuTraBUS instance;

        public static PhieuTraBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraBUS();
                return instance;
            }
        }
        #endregion

        #region addColumns
        private void addColumns(DataGridView data)
        {
            // Thêm cột "Mã phiếu trả"
            var colMaPhieuTra = new DataGridViewTextBoxColumn();
            colMaPhieuTra.Name = "MaPhieuTra";
            colMaPhieuTra.HeaderText = "Mã phiếu trả";
            colMaPhieuTra.DataPropertyName = "MaPhieuTra";
            data.Columns.Add(colMaPhieuTra);

            // Thêm cột "Mã phiếu mượn"
            var colMaPhieuMuon = new DataGridViewTextBoxColumn();
            colMaPhieuMuon.Name = "MaPhieuMuon";
            colMaPhieuMuon.HeaderText = "Mã phiếu mượn";
            colMaPhieuMuon.DataPropertyName = "MaPhieuMuon";
            data.Columns.Add(colMaPhieuMuon);

            // Thêm cột "Mã độc giả"
            var colMaDocGia = new DataGridViewTextBoxColumn();
            colMaDocGia.Name = "MaDocGia";
            colMaDocGia.HeaderText = "Mã độc giả";
            colMaDocGia.DataPropertyName = "MaDocGia";
            data.Columns.Add(colMaDocGia);

            // Thêm cột "Mã sách"
            var colMaSach = new DataGridViewTextBoxColumn();
            colMaSach.Name = "MaSach";
            colMaSach.HeaderText = "Mã sách";
            colMaSach.DataPropertyName = "MaSach";
            data.Columns.Add(colMaSach);

            // Thêm cột "Ngày tạo phiếu trả"
            var colNgayTaoPhieuTra = new DataGridViewTextBoxColumn();
            colNgayTaoPhieuTra.Name = "NgayTaoPhieuTra";
            colNgayTaoPhieuTra.HeaderText = "Ngày tạo phiếu trả";
            colNgayTaoPhieuTra.DataPropertyName = "NgayTaoPhieuTra";
            data.Columns.Add(colNgayTaoPhieuTra);
        }
        #endregion

        #region load PhieuTra
        public void loadPhieuTra(DataGridView data)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = PhieuTraDAL.Instance.loadPhieuTra();

            data.Refresh();

            data.Columns["MaPhieuTra"].ReadOnly = true;
            data.Columns["MaPhieuMuon"].ReadOnly = true;
            data.Columns["MaDocGia"].ReadOnly = true;
            data.Columns["MaSach"].ReadOnly = true;

        }
        #endregion

        #region find PhieuTra By MaPhieuTra
        public void findPhieuTraByMaPhieuTra(DataGridView data, string MaPhieuTra)
        {
            data.DataSource = PhieuTraDAL.Instance.findPhieuTraByMaPhieuTra(MaPhieuTra);
        }
        #endregion

        #region find PhieuTra by MaPhieuMuon
        public void findPhieuTraByMaPhieuMuon(DataGridView data, string MaPhieuMuon)
        {
            data.DataSource = PhieuTraDAL.Instance.findPhieuTraByMaPhieuMuon(MaPhieuMuon);
        }
        #endregion

        #region delete PhieuTra
        public bool DeletePhieuTra(DataGridView data)
        {
            string MaPhieuTra = data.SelectedCells[0].OwningRow.Cells["MaPhieuTra"].Value.ToString();
            return PhieuTraDAL.Instance.deletePhieuTra(MaPhieuTra);
        }
        #endregion

        #region add PhieuTra
        public bool addPhieuTra(string strMaPhieuTra, string strMaPhieuMuon,
            string strMaDocGia, string strMaSach)
        {
            PHIEUTRA newPhieuTra = new PHIEUTRA()
            {
                MaPhieuTra=strMaPhieuTra,
                MaPhieuMuon=strMaPhieuMuon,
                MaDocGia=strMaDocGia,
                MaSach=strMaSach,
                NgayTaoPhieuTra = DateTime.Today
            };
            return PhieuTraDAL.Instance.addPhieuTra(newPhieuTra);
        }
        #endregion
    }
}
