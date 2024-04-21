using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhieuPhatDAL
    {
        #region SINGLETON
        private static PhieuPhatDAL instance;

        public static PhieuPhatDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuPhatDAL();
                return instance;
            }
        }

        private PhieuPhatDAL() { }

        #endregion

        #region load PhieuPhat
        public List<PHIEUPHAT> loadPhieuPhat()
        {
            List<PHIEUPHAT> listSach = new List<PHIEUPHAT>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUPHATs
                          orderby u.MaPhieuPhat ascending
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region add PhieuPhat
        public bool addPhieuPhat(PHIEUPHAT newPhieuPhat)
        {
            using (var db = new QLTVEntities())
            {
                db.PHIEUPHATs.Add(newPhieuPhat);
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

        #region delete PhieuPhat
        public bool deletePhieuPhat(string MaPhieuPhat)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    PHIEUPHAT delete = db.PHIEUPHATs.Where(p => p.MaPhieuPhat == MaPhieuPhat).FirstOrDefault();
                    db.PHIEUPHATs.Remove(delete);
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

        #region delete PhieuPhat By MaPhieuMuon
        public bool deletePhieuPhatByMaPhieuMuon(string MaPhieuMuon)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    PHIEUPHAT delete = db.PHIEUPHATs.Where(p => p.MaPhieuMuon == MaPhieuMuon).FirstOrDefault();
                    if (delete == null)
                        return false;

                    db.PHIEUPHATs.Remove(delete);
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

        #region find PhieuPhat by MaPhieuPhat
        public List<PHIEUPHAT> findPhieuPhatByMaPhieuPhat(string MaPhieuPhat)
        {
            List<PHIEUPHAT> listSach = new List<PHIEUPHAT>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUPHATs
                          where u.MaPhieuPhat.Contains(MaPhieuPhat)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find PhieuPhat by MaPhieuMuon
        public List<PHIEUPHAT> findPhieuPhatByMaPhieuMuon(string MaPhieuMuon)
        {
            List<PHIEUPHAT> listSach = new List<PHIEUPHAT>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUPHATs
                          where u.MaPhieuMuon.Contains(MaPhieuMuon)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region edit PhieuPhat
        public bool editPhieuPhat(string MaPhieuPhat, PHIEUPHAT newPhieuPhat)
        {
            PHIEUPHAT phieuPhat;
            using (var db = new QLTVEntities())
            {
                phieuPhat = db.PHIEUPHATs.Where(p => p.MaPhieuPhat == MaPhieuPhat).SingleOrDefault();

                phieuPhat.MaPhieuMuon = newPhieuPhat.MaPhieuMuon;
                phieuPhat.NgayTaoPhieuPhat = newPhieuPhat.NgayTaoPhieuPhat;
                phieuPhat.TienPhat = newPhieuPhat.TienPhat;
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
