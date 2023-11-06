using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loupay_Service.Database;

namespace Loupay_Service.Account
{
    /// <summary>
    /// Singleton class use for storing current application logged in account
    /// </summary>
    public static class CurrentAccount
    {
        private static NguoiDung _instance;

        public static NguoiDung Instance
        {
            get { if ( _instance == null ) _instance = new NguoiDung(); return _instance; }
            set { _instance = value; }
        }
    }
}
