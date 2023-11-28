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

        public static NguoiDung GetUser(string userId)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    NguoiDung user = (from u in dataContext.NguoiDungs
                                     where u.IDNguoiDung == userId
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

        public static List<KhuVuc> GetAllKhuVuc()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<KhuVuc> khuVucs = new List<KhuVuc>();
                    khuVucs = (from kv in dataContext.KhuVucs
                               select kv).OrderBy(id => id.IDKhuVuc).ToList();
                    return khuVucs;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static KhuVuc GetKhuVuc(string khuVucId)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    KhuVuc khuVucs = new KhuVuc();
                    khuVucs = (from kv in dataContext.KhuVucs
                               where kv.IDKhuVuc == khuVucId
                               select kv).FirstOrDefault();
                    return khuVucs;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<Ban> GetAllBan()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<Ban> bans = new List<Ban>();
                    bans = (from b in dataContext.Bans
                            select b).OrderBy(id => id.IDBan).ToList();
                    return bans;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static Ban GetBan(string BanId)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    Ban ban = new Ban();
                    ban = (from b in dataContext.Bans
                           where b.IDBan == BanId
                           select b).FirstOrDefault();
                    return ban;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<Mon> GetAllMon()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<Mon> mons = new List<Mon>();
                    mons = (from mon in dataContext.Mons
                            select mon).OrderBy(id => id.IDMon).ToList();
                    return mons;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
