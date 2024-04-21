using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhieuTraDAL
    {
        #region SINGLETON
        private static PhieuTraDAL instance;

        public static PhieuTraDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraDAL();
                return instance;
            }
        }

        private PhieuTraDAL() { }

        #endregion

        #region load PhieuTra
        public List<PHIEUTRA> loadPhieuTra()
        {
            List<PHIEUTRA> listSach = new List<PHIEUTRA>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUTRAs
                          orderby u.MaPhieuTra ascending
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find PhieuTra By MaPhieuTra
        public List<PHIEUTRA> findPhieuTraByMaPhieuTra(string MaPhieuTra)
        {
            List<PHIEUTRA> listSach = new List<PHIEUTRA>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUTRAs
                          where u.MaPhieuTra.Contains(MaPhieuTra)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find PhieuTra by MaPhieuMuon
        public List<PHIEUTRA> findPhieuTraByMaPhieuMuon(string MaPhieuMuon)
        {
            List<PHIEUTRA> listSach = new List<PHIEUTRA>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUTRAs
                          where u.MaPhieuMuon.Contains(MaPhieuMuon)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region delete PhieuTra
        public bool deletePhieuTra(string MaPhieuTra)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    PHIEUTRA delete = db.PHIEUTRAs.Where(p => p.MaPhieuTra == MaPhieuTra).FirstOrDefault();
                    db.PHIEUTRAs.Remove(delete);
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

        #region delete PhieuTra By MaPhieuMuon
        public bool deletePhieuTraByMaPhieuMuon(string MaPhieuMuon)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    PHIEUTRA delete = db.PHIEUTRAs.Where(p => p.MaPhieuMuon == MaPhieuMuon).FirstOrDefault();
                    if (delete == null)
                        return false;

                    db.PHIEUTRAs.Remove(delete);
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

        #region add PhieuTra
        public bool addPhieuTra(PHIEUTRA newPhieuTra)
        {
            using (var db = new QLTVEntities())
            {
                db.PHIEUTRAs.Add(newPhieuTra);
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
