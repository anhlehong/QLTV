using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DangNhapBUS
    {
        #region SINGLETON
        private static DangNhapBUS instance;

        public static DangNhapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DangNhapBUS();
                return instance;
            }
        }

        private DangNhapBUS() { }
        #endregion

        public bool checkDangNhap(string strName, string strPass)
        {
            DANGNHAP acc = new DANGNHAP()
            {
                UserName = strName,
                PassWord = strPass
            };
            return DangNhapDAL.Instance.checkDangNhap(acc);
        }

        public bool addDangNhap(string tenTaiKhoan)
        {
            DANGNHAP newDangNhap = new DANGNHAP()
            {
                UserName= tenTaiKhoan,
                PassWord= "123"
            };
            return DangNhapDAL.Instance.addDangNhap(newDangNhap);
        }

        public bool UpdatePassword(string oddName, string oddPass, string newPassword)
        {
            DANGNHAP oddDangNhap = new DANGNHAP()
            {
                UserName = oddName,
                PassWord = oddPass,
            };
            return DangNhapDAL.Instance.UpdatePassword(oddDangNhap, newPassword);
        }
        public bool UpdateuserName(string userName)
        {
            return DangNhapDAL.Instance.UpdateuserName(userName);
        }
    }
}