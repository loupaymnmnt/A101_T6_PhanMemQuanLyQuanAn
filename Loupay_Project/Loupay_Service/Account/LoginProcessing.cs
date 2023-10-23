using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loupay_Service.Database;
using Loupay_Service.Account;

namespace Loupay_Service.Account
{
    public class LoginProcessing
    {
        LOUPAYDataContext loupay = new LOUPAYDataContext();

        public LoginProcessing()
        {

        }

        public LoginResult Process(string inputUsername, string inputPassword)
        {
            var loginUsers = from user in loupay.tbl_Users
                            where (user.Username == inputUsername && user.Password == inputPassword)
                            select user;
            var loginUser = loginUsers.FirstOrDefault();
            if (loginUser != null)
            {
                if ((bool)loginUser.IsDisabled == true)
                {
                    return LoginResult.DISABLED;
                }
                CurrentAccount.Instance = loginUser;
                return LoginResult.SUCCESSFUL;
            }
            return LoginResult.FAILED;
        }

    }
}
