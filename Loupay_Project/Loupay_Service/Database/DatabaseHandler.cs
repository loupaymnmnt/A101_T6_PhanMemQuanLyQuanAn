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

        public static List<NguoiDung> GetAllNguoiDung()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<NguoiDung> nguoidungs = new List<NguoiDung>();
                    nguoidungs = (from nguoidung in dataContext.NguoiDungs
                            select nguoidung).OrderBy(id => id.IDNguoiDung).ToList();
                    return nguoidungs;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static NguoiDung GetNguoiDung(string IDNguoiDung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    NguoiDung nguoidung = new NguoiDung();
                    nguoidung = (from nd in dataContext.NguoiDungs
                                 where nd.IDNguoiDung == IDNguoiDung
                                 select nd).FirstOrDefault();
                    return nguoidung;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<PhanQuyen> GetAllPhanQuyen()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<PhanQuyen> phanQuyens = new List<PhanQuyen>();
                    phanQuyens = (from phanquyen in dataContext.PhanQuyens
                                  select phanquyen).ToList();
                    return phanQuyens;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static List<PhanQuyen> GetAllPhanQuyenOfQuyenNguoiDung(string IDQuyenNguoiDung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<PhanQuyen> phanQuyens = new List<PhanQuyen>();
                    phanQuyens = (from phanquyen in dataContext.PhanQuyens
                                  where phanquyen.IDQuyenNguoiDung == IDQuyenNguoiDung
                                  select phanquyen).ToList();
                    return phanQuyens;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static void InsertNguoiDung(NguoiDung nguoiDung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    dataContext.NguoiDungs.InsertOnSubmit(nguoiDung);
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static void UpdateNguoiDung(NguoiDung nguoiDung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    NguoiDung nguoiDungi = (from nD in dataContext.NguoiDungs
                                           where nD.IDNguoiDung == nguoiDung.IDNguoiDung
                                           select nD).FirstOrDefault();
                    nguoiDungi.QuyenNguoiDung = nguoiDung.QuyenNguoiDung;
                    nguoiDungi.TenNguoiDung = nguoiDung.TenNguoiDung;
                    nguoiDungi.MatKhau = nguoiDung.MatKhau;
                    nguoiDungi.BiKhoa = nguoiDung.BiKhoa;
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static void DeleteNguoiDung(NguoiDung nguoiDung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    NguoiDung nguoiDungi = (from nD in dataContext.NguoiDungs
                                            where nD.IDNguoiDung == nguoiDung.IDNguoiDung
                                            select nD).FirstOrDefault();
                    nguoiDungi.QuyenNguoiDung = nguoiDung.QuyenNguoiDung;
                    nguoiDungi.TenNguoiDung = nguoiDung.TenNguoiDung;
                    nguoiDungi.MatKhau = nguoiDung.MatKhau;
                    nguoiDungi.BiKhoa = nguoiDung.BiKhoa;
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }
    }
}
