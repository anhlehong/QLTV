using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class BookDAL
    {
        #region SINGLETON
        private static BookDAL instance;

        public static BookDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookDAL();
                return instance;
            }
        }

        private BookDAL() { }

        #endregion

        #region load Sach
        public List<SACH> loadSach()
        {
            List<SACH> listSach = new List<SACH>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.SACHes
                          orderby u.MaSach ascending
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find Sach by MaSach
        public List<SACH> findSachByMaSach(string MaSach)
        {
            List<SACH> listSach = new List<SACH>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.SACHes
                          where u.MaSach.Contains(MaSach)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find Sach by TenSach
        public List<SACH> findSachByTenSach(string TenSach)
        {
            List<SACH> listSach = new List<SACH>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.SACHes
                          where u.TenSach.Contains(TenSach)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region add Sach
        public bool addSach(SACH newSach)
        {
            using (var db = new QLTVEntities())
            {
                db.SACHes.Add(newSach);
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

        #region delete Sach
        public bool deleteSach(string MaSach)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    SACH delete = db.SACHes.Where(p => p.MaSach == MaSach).FirstOrDefault();
                    db.SACHes.Remove(delete);
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

        #region edit Sach
        public bool editSach(string MaSach, SACH newSach)
        {
            using (var db = new QLTVEntities())
            {
                SACH sach = db.SACHes.Where(p => p.MaSach == MaSach).SingleOrDefault();

                sach.TenSach = newSach.TenSach;
                sach.LoaiSach = newSach.LoaiSach;
                sach.TacGia = newSach.TacGia;
                sach.NhaXuatBan = newSach.NhaXuatBan;
                sach.NgayXuatBan = newSach.NgayXuatBan;
                sach.SoLuong = newSach.SoLuong;

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
    }
}
