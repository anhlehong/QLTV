using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BookBUS
    {
        #region SINGLETON
        private static BookBUS instance;

        public static BookBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookBUS();
                return instance;
            }
        }

        private BookBUS() { }

        #endregion

        #region addColumns
        private void addColumns(DataGridView data)
        {
            // Thêm cột "Mã sách"
            var colMaSach = new DataGridViewTextBoxColumn();
            colMaSach.Name = "MaSach";
            colMaSach.HeaderText = "Mã sách";
            colMaSach.DataPropertyName = "MaSach";
            data.Columns.Add(colMaSach);

            // Thêm cột "Tên sách"
            var colTenSach = new DataGridViewTextBoxColumn();
            colTenSach.Name = "TenSach";
            colTenSach.HeaderText = "Tên sách";
            colTenSach.DataPropertyName = "TenSach";
            data.Columns.Add(colTenSach);

            // Thêm cột "Loại sách"
            var colLoaiSach = new DataGridViewTextBoxColumn();
            colLoaiSach.Name = "LoaiSach";
            colLoaiSach.HeaderText = "Loại sách";
            colLoaiSach.DataPropertyName = "LoaiSach";
            data.Columns.Add(colLoaiSach);

            // Thêm cột "Tác giả"
            var colTacGia = new DataGridViewTextBoxColumn();
            colTacGia.Name = "TacGia";
            colTacGia.HeaderText = "Tác giả";
            colTacGia.DataPropertyName = "TacGia";
            data.Columns.Add(colTacGia);

            // Thêm cột "Nhà xuất bản"
            var colNhaXuatBan = new DataGridViewTextBoxColumn();
            colNhaXuatBan.Name = "NhaXuatBan";
            colNhaXuatBan.HeaderText = "Nhà xuất bản";
            colNhaXuatBan.DataPropertyName = "NhaXuatBan";
            data.Columns.Add(colNhaXuatBan);

            // Thêm cột "Ngày xuất bản"
            var colNgayXuatBan = new DataGridViewTextBoxColumn();
            colNgayXuatBan.Name = "NgayXuatBan";
            colNgayXuatBan.HeaderText = "Ngày xuất bản";
            colNgayXuatBan.DataPropertyName = "NgayXuatBan";
            data.Columns.Add(colNgayXuatBan);

            // Thêm cột "Số lượng"
            var colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.Name = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.DataPropertyName = "SoLuong";
            data.Columns.Add(colSoLuong);
        }
        #endregion

        #region load Sach
        public void loadSach(DataGridView data)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = BookDAL.Instance.loadSach();

            data.Refresh();

            data.Columns["MaSach"].ReadOnly = true;
        }
        #endregion

        #region find Sach by MaSach
        public void findSachByMaSach(DataGridView data, string strMaSach)
        {
            data.DataSource = BookDAL.Instance.findSachByMaSach(strMaSach);
        }
        #endregion

        #region find Sach by TenSach
        public void findSachByTenSach(DataGridView data, string strTenSach)
        {
            data.DataSource = BookDAL.Instance.findSachByTenSach(strTenSach);
        }
        #endregion

        #region add Sach
        public bool addSach(string strMaSach, string strTenSach, string strLoaiSach,
            string strTacGia, string strNhaXuatBan, DateTime dateNgayXuatBan, string strSoLuong)
        {
            int iSoLuong = Int32.Parse(strSoLuong);
            SACH newSach = new SACH()
            {
                MaSach = strMaSach,
                TenSach = strTenSach,
                LoaiSach = strLoaiSach,
                TacGia = strTacGia,
                NhaXuatBan = strNhaXuatBan,
                NgayXuatBan = dateNgayXuatBan,
                SoLuong = iSoLuong
            };
            return BookDAL.Instance.addSach(newSach);
        }
        #endregion

        #region delete Sach
        public bool DeleteSach(DataGridView data)
        {
            string MaSach = data.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
            try
            {
                PhieuMuonBUS.Instance.deleteAllPhieuMuonByMaSach(MaSach);
                return BookDAL.Instance.deleteSach(MaSach);
            }
            catch
            {
                return false;
            }
            
        }
        #endregion

        #region edit Sach
        public bool editSach(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string MaSach = row.Cells["MaSach"].Value.ToString();

            string TenSach = row.Cells["TenSach"].Value.ToString();

            object LoaiSachValue = row.Cells["LoaiSach"].Value;
            string LoaiSach = LoaiSachValue != null ? LoaiSachValue.ToString() : null;

            object TacGiaValue = row.Cells["TacGia"].Value;
            string TacGia = TacGiaValue != null ? TacGiaValue.ToString() : null;

            object NhaXuatBanValue = row.Cells["NhaXuatBan"].Value;
            string NhaXuatBan = NhaXuatBanValue != null ? NhaXuatBanValue.ToString() : null;

            DateTime? NgayXuatBan = (DateTime?)row.Cells["NgayXuatBan"].Value;

            int? SoLuong = (int?)row.Cells["SoLuong"].Value;


            SACH newSach = new SACH();
            newSach.MaSach = MaSach;
            newSach.TenSach = TenSach;
            newSach.LoaiSach = LoaiSach;
            newSach.TacGia = TacGia;
            newSach.NhaXuatBan = NhaXuatBan;
            newSach.NgayXuatBan = NgayXuatBan;
            newSach.SoLuong = SoLuong;

            return BookDAL.Instance.editSach(MaSach, newSach);
        }
        #endregion
    }
}
