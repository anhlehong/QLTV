using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ReadersDAL
    {
        #region SINGLETON
        private static ReadersDAL instance;

        public static ReadersDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReadersDAL();
                return instance;
            }
        }

        private ReadersDAL() { }

        #endregion

        #region load DocGia
        public List<DOCGIA> loadDocGia()
        {
            List<DOCGIA> listSach = new List<DOCGIA>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.DOCGIAs
                          orderby u.MaDocGia ascending
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find DocGia By MaDocGia
        public List<DOCGIA> findDocGiaByMaDocGia(string MaDocGia)
        {
            List<DOCGIA> listSach = new List<DOCGIA>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.DOCGIAs
                          where u.MaDocGia.Contains(MaDocGia)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find DocGia By HoTen
        public List<DOCGIA> findDocGiaByHoTen(string HoTen)
        {
            List<DOCGIA> listSach = new List<DOCGIA>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.DOCGIAs
                          where u.HoTen.Contains(HoTen)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region delete DocGia
        public bool deleteDocGia(string MaDocGia)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    DOCGIA delete = db.DOCGIAs.Where(p => p.MaDocGia == MaDocGia).FirstOrDefault();
                    db.DOCGIAs.Remove(delete);
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

        #region edit DocGia
        public bool editDocGia(string MaDocGia, DOCGIA newDocGia)
        {
            using (var db = new QLTVEntities())
            {
                DOCGIA docGia = db.DOCGIAs.Where(p => p.MaDocGia == MaDocGia).SingleOrDefault();

                docGia.HoTen = newDocGia.HoTen;
                docGia.NgaySinh = newDocGia.NgaySinh;
                docGia.GioiTinh = newDocGia.GioiTinh;
                docGia.DiaChi = newDocGia.DiaChi;
                docGia.SDT = newDocGia.SDT;
                docGia.CCCD = newDocGia.CCCD;

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

        #region add DocGia
        public bool addDocGia(DOCGIA newDocGia)
        {
            using (var db = new QLTVEntities())
            {
                db.DOCGIAs.Add(newDocGia);
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
