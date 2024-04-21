using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhieuMuonDAL
    {
        #region SINGLETON
        private static PhieuMuonDAL instance;

        public static PhieuMuonDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonDAL();
                return instance;
            }
        }

        private PhieuMuonDAL() { }

        #endregion

        #region load PhieuMuon
        public List<PHIEUMUON> loadPhieuMuon()
        {
            List<PHIEUMUON> listSach = new List<PHIEUMUON>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUMUONs
                          orderby u.MaPhieuMuon ascending
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find PhieuMuon by MaPhieuMuon
        public List<PHIEUMUON> findPhieuMuonByMaPhieuMuon(string MaPhieuMuon)
        {
            List<PHIEUMUON> listSach = new List<PHIEUMUON>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUMUONs
                          where u.MaPhieuMuon.Contains(MaPhieuMuon)
                          select u;

                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region find PhieuMuon by MaDocGia
        public List<PHIEUMUON> findPhieuMuonByMaDocGia(string MaDocGia)
        {
            List<PHIEUMUON> listSach = new List<PHIEUMUON>();
            using (var db = new QLTVEntities())
            {
                var tmp = from u in db.PHIEUMUONs
                          where u.MaDocGia.Contains(MaDocGia)
                          select u;
                listSach = tmp.ToList();
            }

            return listSach;
        }
        #endregion

        #region delete PhieuMuon By MaPhieuMuon
        public bool deletePhieuMuonByMaPhieuMuon(string MaphieuMuon)
        {
            using (var db = new QLTVEntities())
            {
                try
                {
                    PHIEUMUON delete = db.PHIEUMUONs.Where(p => p.MaPhieuMuon == MaphieuMuon).FirstOrDefault();
                    db.PHIEUMUONs.Remove(delete);
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

        #region find AllPhieuMuon By MaSach
        public List<PHIEUMUON> findAllPhieuMuonByMaSach(string MaSach)
        {
            using (var db = new QLTVEntities())
            {
                var findAllPhieuMuon = db.PHIEUMUONs.Where(p=>p.MaSach== MaSach).ToList();
                return findAllPhieuMuon.ToList();
            }
        }
        #endregion

        #region find AllPhieuMuon By MaDocGia
        public List<PHIEUMUON> findAllPhieuMuonByMaDocGia(string MaDocGia)
        {
            using (var db = new QLTVEntities())
            {
                var findAllPhieuMuon = db.PHIEUMUONs.Where(p => p.MaDocGia == MaDocGia).ToList();
                return findAllPhieuMuon.ToList();
            }
        }
        #endregion

        #region add PhieuMuon
        public bool addPhieuMuon(PHIEUMUON newPhieuMuon)
        {
            using (var db = new QLTVEntities())
            {
                db.PHIEUMUONs.Add(newPhieuMuon);
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
