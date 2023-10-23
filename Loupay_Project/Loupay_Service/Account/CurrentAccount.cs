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
    public class CurrentAccount
    {
        private static tbl_User _instance;

        public static tbl_User Instance
        {
            get { if ( _instance == null ) _instance = new tbl_User(); return _instance; }
            set { _instance = value; }
        }
        private CurrentAccount()
        {
            
        }
    }
}
