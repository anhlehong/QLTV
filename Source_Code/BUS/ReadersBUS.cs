using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ReadersBUS
    {
        #region SINGLETON
        private static ReadersBUS instance;

        public static ReadersBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReadersBUS();
                return instance;
            }
        }
        #endregion

        #region addColumns
        private void addColumns(DataGridView data)
        {
            // Thêm cột "Mã độc giả"
            var colMaDocGia = new DataGridViewTextBoxColumn();
            colMaDocGia.Name = "MaDocGia";
            colMaDocGia.HeaderText = "Mã độc giả";
            colMaDocGia.DataPropertyName = "MaDocGia";
            data.Columns.Add(colMaDocGia);

            // Thêm cột "Họ và tên"
            var colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.Name = "HoTen";
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.DataPropertyName = "HoTen";
            data.Columns.Add(colHoTen);

            // Thêm cột "Ngày sinh"
            var colNgaySinh = new DataGridViewTextBoxColumn();
            colNgaySinh.Name = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.DataPropertyName = "NgaySinh";
            data.Columns.Add(colNgaySinh);

            // Thêm cột "Giới tính"
            var colGioiTinh = new DataGridViewTextBoxColumn();
            colGioiTinh.Name = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.DataPropertyName = "GioiTinh";
            data.Columns.Add(colGioiTinh);

            // Thêm cột "Địa chỉ"
            var colDiaChi = new DataGridViewTextBoxColumn();
            colDiaChi.Name = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.DataPropertyName = "DiaChi";
            data.Columns.Add(colDiaChi);

            // Thêm cột "Số điện thoại"
            var colSDT = new DataGridViewTextBoxColumn();
            colSDT.Name = "SDT";
            colSDT.HeaderText = "Số điện thoại";
            colSDT.DataPropertyName = "SDT";
            data.Columns.Add(colSDT);

            // Thêm cột "CCCD"
            var colCCCD = new DataGridViewTextBoxColumn();
            colCCCD.Name = "CCCD";
            colCCCD.HeaderText = "CCCD";
            colCCCD.DataPropertyName = "CCCD";
            data.Columns.Add(colCCCD);
        }
        #endregion

        #region load DocGia
        public void loadDocGia(DataGridView data)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = ReadersDAL.Instance.loadDocGia();

            data.Refresh();

            data.Columns["MaDocGia"].ReadOnly = true;
        }
        #endregion

        #region find DocGia By MaDocGia
        public void findDocGiaByMaDocGia(DataGridView data, string MaDocGia)
        {
            data.DataSource = ReadersDAL.Instance.findDocGiaByMaDocGia(MaDocGia);
        }
        #endregion

        #region find DocGia By HoTen
        public void findDocGiaByHoTen(DataGridView data, string HoTen)
        {
            data.DataSource = ReadersDAL.Instance.findDocGiaByHoTen(HoTen);
        }
        #endregion

        #region delete DocGia
        public bool DeleteDocGia(DataGridView data)
        {
            string MaDocGia = data.SelectedCells[0].OwningRow.Cells["MaDocGia"].Value.ToString();
            try
            {
                PhieuMuonBUS.Instance.deleteAllPhieuMuonByMaDocGia(MaDocGia);
                return ReadersDAL.Instance.deleteDocGia(MaDocGia);
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region edit DocGia
        public bool editDocGia(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string MaDocGia = row.Cells["MaDocGia"].Value.ToString();

            string HoTen = row.Cells["HoTen"].Value.ToString();

            DateTime? NgaySinh = (DateTime?)row.Cells["NgaySinh"].Value;

            object gioiTinhValue = row.Cells["GioiTinh"].Value;
            string GioiTinh = gioiTinhValue != null ? gioiTinhValue.ToString() : null;

            object diaChiValue = row.Cells["DiaChi"].Value;
            string DiaChi = diaChiValue != null ? diaChiValue.ToString() : null;

            object SDTValue = row.Cells["SDT"].Value;
            string SDT = SDTValue != null ? SDTValue.ToString() : null;

            object CCCDValue = row.Cells["CCCD"].Value;
            string CCCD = CCCDValue != null ? CCCDValue.ToString() : null;

            DOCGIA newDocGia  = new DOCGIA();
            newDocGia.MaDocGia = MaDocGia;
            newDocGia.HoTen = HoTen;
            newDocGia.NgaySinh = NgaySinh;
            newDocGia.GioiTinh = GioiTinh;
            newDocGia.DiaChi = DiaChi;
            newDocGia.SDT = SDT;
            newDocGia.CCCD = CCCD;

            return ReadersDAL.Instance.editDocGia(MaDocGia, newDocGia);
        }
        #endregion

        #region add DocGia
        public bool addDocGia(string strMaDocGia, string strHoTen, DateTime dateNgaySinh,
            string strGioiTinh, string strDiaChi, string strSDT, string strCCCD)
        {
            DOCGIA newDocGia = new DOCGIA()
            {
                MaDocGia = strMaDocGia,
                HoTen = strHoTen,
                NgaySinh = dateNgaySinh,
                GioiTinh = strGioiTinh,
                DiaChi =strDiaChi,
                SDT = strSDT,
                CCCD = strCCCD
            };
            return ReadersDAL.Instance.addDocGia(newDocGia);
        }
        #endregion
    }
}
