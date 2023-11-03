using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Service.Database
{
    public static class DatabaseHandler
    {
        static LOUPAYDataContext dataContext = new LOUPAYDataContext();

        public static tbl_User GetUser(string userId)
        {
            using (dataContext)
            {
                try
                {
                    tbl_User user = (from u in dataContext.tbl_Users
                                     where u.UserId == userId
                                     select u).FirstOrDefault();
                    Trace.WriteLine("Successful! DatabaseHandler -> GetUser()!");
                    return user;
                }
                catch
                {
                    Trace.WriteLine("Exception caught! DatabaseHandler -> GetUser()!");
                    return null;
                }
            }
        }
    }
}
