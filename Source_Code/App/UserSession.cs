using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class UserSession
    {
        private static UserSession _instance;
        public string UserName { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        public void SetUserName(string username)
        {
            UserName = username;
        }
    }

}
