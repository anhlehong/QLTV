using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class AdminDAL
    {

        #region SINGLETON
        private static AdminDAL instance;

        public static AdminDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminDAL();
                return instance;
            }
        }

        private AdminDAL() { }

        #endregion

        #region load Admin
        public List<NHANVIEN> loadAdmin()
        {
            List<NHANVIEN> listSach = new List<NHANVIEN>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.NHANVIENs
                          orderby u.MaNhanVien ascending
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find Admin by MaNhanVien
        public List<NHANVIEN> findAdminByMaNhanVien(string MaNhanVien)
        {
            List<NHANVIEN> listSach = new List<NHANVIEN>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.NHANVIENs
                          where u.MaNhanVien.Contains(MaNhanVien)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find Admin By TenDangNhap
        public List<NHANVIEN> findAdminByTenDangNhap(string tenDangNhap)
        {
            using (var db = new QLTVEntities())
            {
                List<NHANVIEN> users = db.NHANVIENs.Where(u => u.TenDangNhap == tenDangNhap).ToList();
                return users;
            }
        }
        #endregion

        #region add NhanVien
        public bool addNhanVien(NHANVIEN newNhanVien)
        {
            using (var db = new QLTVEntities())
            {
                db.NHANVIENs.Add(newNhanVien);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        #endregion

        #region edit NhanVien
        public bool editNhanVien(string MaNhanVien, NHANVIEN newNhanVien)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    NHANVIEN nhanvien = db.NHANVIENs.Where(p => p.MaNhanVien == MaNhanVien).SingleOrDefault();

                    nhanvien.HoTen = newNhanVien.HoTen;
                    nhanvien.NgaySinh = newNhanVien.NgaySinh;
                    nhanvien.DiaChi = newNhanVien.DiaChi;
                    nhanvien.GioiTinh = newNhanVien.GioiTinh;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        #endregion

        #region delete NhanVien
        public bool deleteNhanVien(string MaNhanVien)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    NHANVIEN delete = db.NHANVIENs.Where(p => p.MaNhanVien == MaNhanVien).FirstOrDefault();
                    db.NHANVIENs.Remove(delete);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        #endregion

    }
}
