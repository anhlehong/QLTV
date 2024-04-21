using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAL
{
    public class DangNhapDAL
    {
        #region SINGLETON
        private static DangNhapDAL instance;

        public static DangNhapDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapDAL();
                return instance;
            }
        }

        private DangNhapDAL() { }

        #endregion
        public bool checkDangNhap(DANGNHAP acc)
        {
            using(var db = new QLTVEntities())
            {
                var user = db.DANGNHAPs.FirstOrDefault(u => u.UserName == acc.UserName  && u.PassWord == acc.PassWord);
                return user != null;
            }
        }
        public bool addDangNhap(DANGNHAP newDangNHap)
        {
            using (var db = new QLTVEntities())
            {
                db.DANGNHAPs.Add(newDangNHap);
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
        public bool UpdatePassword(DANGNHAP acc, string newPassword)
        {
            using (var db = new QLTVEntities())
            {
                var user = db.DANGNHAPs.FirstOrDefault(u => u.UserName == acc.UserName && u.PassWord == acc.PassWord);

                if (user != null)
                {
                    user.PassWord = newPassword;

                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }
        public bool UpdateuserName(string userName)
        {
            using (var db = new QLTVEntities())
            {
                var user = db.DANGNHAPs.FirstOrDefault(u => u.UserName == userName);

                if (user != null)
                {
                    user.UserName = userName;
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

    }
}
