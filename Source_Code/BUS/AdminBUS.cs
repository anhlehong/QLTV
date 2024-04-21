using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class AdminBUS
    {
        #region SINGLETON
        private static AdminBUS instance;

        public static AdminBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminBUS();
                return instance;
            }
        }

        private AdminBUS() { }

        #endregion

        #region addColumns
        private void addColumns(DataGridView data)
        {
            var colMaNhanVien = new DataGridViewTextBoxColumn();
            colMaNhanVien.Name = "MaNhanVien";
            colMaNhanVien.HeaderText = "Mã nhân viên";
            colMaNhanVien.DataPropertyName = "MaNhanVien";
            data.Columns.Add(colMaNhanVien);

            var colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.Name = "HoTen";
            colHoTen.HeaderText = "Họ tên";
            colHoTen.DataPropertyName = "HoTen";
            data.Columns.Add(colHoTen);

            var colNgaySinh = new DataGridViewTextBoxColumn();
            colNgaySinh.Name = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.DataPropertyName = "NgaySinh";
            data.Columns.Add(colNgaySinh);

            var colDiaChi = new DataGridViewTextBoxColumn();
            colDiaChi.Name = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.DataPropertyName = "DiaChi";
            data.Columns.Add(colDiaChi);

            var colGioiTinh = new DataGridViewTextBoxColumn();
            colGioiTinh.Name = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.DataPropertyName = "GioiTinh";
            data.Columns.Add(colGioiTinh);

            var colTenDangNhap = new DataGridViewTextBoxColumn();
            colTenDangNhap.Name = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            data.Columns.Add(colTenDangNhap);
        }
        #endregion

        #region load Admin
        public void loadAdmin(DataGridView data)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = AdminDAL.Instance.loadAdmin();

            data.Refresh();

            data.Columns["MaNhanVien"].ReadOnly = true;
            data.Columns["TenDangNhap"].ReadOnly = true;

        }
        #endregion

        #region find Admin by MaNhanVien
        public void findAdminByMaNhanVien(DataGridView data, string MaNhanVien)
        {
            data.DataSource = AdminDAL.Instance.findAdminByMaNhanVien(MaNhanVien);
        }
        #endregion

        #region add NhanVien
        public bool addNhanVien(string strMaNhanVien, string strHoTen, DateTime dateNgaSinh,
            string strGioiTinh, string strDiaChi, string strTenDangNhap)
        {
            DangNhapBUS.Instance.addDangNhap(strTenDangNhap);

            NHANVIEN newNhanVien = new NHANVIEN()
            {
                MaNhanVien = strMaNhanVien,
                HoTen = strHoTen,
                NgaySinh = dateNgaSinh,
                DiaChi = strDiaChi,
                GioiTinh = strGioiTinh,
                TenDangNhap = strTenDangNhap
            };
            return AdminDAL.Instance.addNhanVien(newNhanVien);
        }
        #endregion

        #region find Admin By TenDangNhap
        public void findAdminByTenDangNhap(DataGridView data, string tenDangNhap)
        {
            // Đảm bảo rằng không tự động tạo cột
            data.AutoGenerateColumns = false;

            // Xóa các cột hiện có để tránh trùng lặp
            data.Columns.Clear();

            addColumns(data);

            data.DataSource = AdminDAL.Instance.findAdminByTenDangNhap(tenDangNhap);

            data.Refresh();
        }
        #endregion

        #region edit NhanVien
        public bool editNhanVien(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string MaNhanVien = row.Cells["MaNhanVien"].Value.ToString();

            string HoTen = row.Cells["HoTen"].Value.ToString();

            DateTime? NgaySinh = (DateTime?)row.Cells["NgaySinh"].Value;

            object DiaChiValue = row.Cells["DiaChi"].Value;
            string DiaChi = DiaChiValue != null ? DiaChiValue.ToString() : null;

            object GioiTinhValue = row.Cells["GioiTinh"].Value;
            string GioiTinh = GioiTinhValue != null ? GioiTinhValue.ToString() : null;

            string TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();

            NHANVIEN newNhanVien = new NHANVIEN();
            newNhanVien.MaNhanVien = MaNhanVien;
            newNhanVien.HoTen = HoTen;
            newNhanVien.NgaySinh = NgaySinh;
            newNhanVien.DiaChi = DiaChi;
            newNhanVien.GioiTinh = GioiTinh;
            newNhanVien.TenDangNhap = TenDangNhap;

           return AdminDAL.Instance.editNhanVien(MaNhanVien, newNhanVien);
        }
        #endregion

        #region delete NhanVien
       
        public bool DeleteNhanVien(DataGridView data)
        {
            string MaNhanVien = data.SelectedCells[0].OwningRow.Cells["MaNhanVien"].Value.ToString();
            return AdminDAL.Instance.deleteNhanVien(MaNhanVien);
        }

        #endregion
    }
}

