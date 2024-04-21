using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuMuonBUS
    {
        #region SINGLETON
        private static PhieuMuonBUS instance;

        public static PhieuMuonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonBUS();
                return instance;
            }
        }

        private PhieuMuonBUS() { }

        #endregion

        #region addColumns
        private void addColumns(DataGridView data)
        {
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

            // Thêm cột "Ngày tạo phiếu mượn"
            var colNgayTaoPhieuMuon = new DataGridViewTextBoxColumn();
            colNgayTaoPhieuMuon.Name = "NgayTaoPhieuMuon";
            colNgayTaoPhieuMuon.HeaderText = "Ngày tạo phiếu mượn";
            colNgayTaoPhieuMuon.DataPropertyName = "NgayTaoPhieuMuon";
            data.Columns.Add(colNgayTaoPhieuMuon);

            // Thêm cột "Ngày trả"
            var colNgayTra = new DataGridViewTextBoxColumn();
            colNgayTra.Name = "NgayTra";
            colNgayTra.HeaderText = "Ngày trả";
            colNgayTra.DataPropertyName = "NgayTra";
            data.Columns.Add(colNgayTra);

            // Thêm cột "Tình trạng"
            var colTinhTrang = new DataGridViewTextBoxColumn();
            colTinhTrang.Name = "TinhTrang";
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.DataPropertyName = "TinhTrang";
            data.Columns.Add(colTinhTrang);
        }
        #endregion

        #region load PhieuMuon
        public void loadPhieuMuon(DataGridView data)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = PhieuMuonDAL.Instance.loadPhieuMuon();

            data.Refresh();

            data.Columns["MaPhieuMuon"].ReadOnly = true;
            data.Columns["MaDocGia"].ReadOnly = true;
            data.Columns["MaSach"].ReadOnly = true;

        }
        #endregion

        #region find PhieuMuon by MaPhieuMuon
        public void findPhieuMuonByMaPhieuMuon(DataGridView data, string MaPhieuMuon)
        {
            data.DataSource = PhieuMuonDAL.Instance.findPhieuMuonByMaPhieuMuon(MaPhieuMuon);
        }
        #endregion

        #region find PhieuMuon by MaDocGia
        public void findPhieuMuonByMaDocGia(DataGridView data, string MaDocGia)
        {
            data.DataSource = PhieuMuonDAL.Instance.findPhieuMuonByMaDocGia(MaDocGia);
        }
        #endregion

        #region delete PhieuMuon By MaPhieuMuon
        public bool deletePhieuMuonByMaPhieuMuon(DataGridView data)
        {
            string MaPhieuMUon = data.SelectedCells[0].OwningRow.Cells["MaPhieuMuon"].Value.ToString();
            PhieuPhatDAL.Instance.deletePhieuPhatByMaPhieuMuon(MaPhieuMUon);
            PhieuTraDAL.Instance.deletePhieuTraByMaPhieuMuon(MaPhieuMUon);
            return PhieuMuonDAL.Instance.deletePhieuMuonByMaPhieuMuon(MaPhieuMUon);
        }
        #endregion

        #region deleteAllPhieuMuonByMaSach
        public bool deleteAllPhieuMuonByMaSach(string MaSach)
        {
            List<PHIEUMUON> lis = PhieuMuonDAL.Instance.findAllPhieuMuonByMaSach(MaSach);
            foreach(var items in lis)
            {
                try
                {
                    string strMaPhieuMuon = items.MaPhieuMuon;
                    PhieuPhatDAL.Instance.deletePhieuPhatByMaPhieuMuon(strMaPhieuMuon);
                    PhieuTraDAL.Instance.deletePhieuTraByMaPhieuMuon(strMaPhieuMuon);
                    PhieuMuonDAL.Instance.deletePhieuMuonByMaPhieuMuon(strMaPhieuMuon);
                }
                catch 
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region deleteAllPhieuMuonByMaDocGia
        public bool deleteAllPhieuMuonByMaDocGia(string MaDocGia)
        {
            List<PHIEUMUON> lis = PhieuMuonDAL.Instance.findAllPhieuMuonByMaDocGia(MaDocGia);
            foreach (var items in lis)
            {
                try
                {
                    string strMaPhieuMuon = items.MaPhieuMuon;
                    PhieuPhatDAL.Instance.deletePhieuPhatByMaPhieuMuon(strMaPhieuMuon);
                    PhieuTraDAL.Instance.deletePhieuTraByMaPhieuMuon(strMaPhieuMuon);
                    PhieuMuonDAL.Instance.deletePhieuMuonByMaPhieuMuon(strMaPhieuMuon);
                }
                catch 
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region add PhieuMuon
        public bool addPhieuMuon(string strMaPhieuMuon, string strMaDocGia, string strMaSach)
        {
            PHIEUMUON newPhieuMuon = new PHIEUMUON()
            {
                MaPhieuMuon = strMaPhieuMuon,
                MaDocGia = strMaDocGia,
                MaSach = strMaSach,
                NgayTaoPhieuMuon = DateTime.Today,
                NgayTra = DateTime.Today.AddDays(30),
                TinhTrang = false
            };

            return PhieuMuonDAL.Instance.addPhieuMuon(newPhieuMuon);
        }
        #endregion
    }
}
