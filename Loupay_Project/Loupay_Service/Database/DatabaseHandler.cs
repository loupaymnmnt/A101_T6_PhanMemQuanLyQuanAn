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
                    dataContext.DeferredLoadingEnabled = false;
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

        public static void InsertKhuVuc(KhuVuc khuvuc)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    dataContext.KhuVucs.InsertOnSubmit(khuvuc);
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }
        public static void DeleteKhuVuc(string IDKhuVuc)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    KhuVuc kv = (from KV in dataContext.KhuVucs select KV).Where(t => t.IDKhuVuc == IDKhuVuc).FirstOrDefault();
                    dataContext.KhuVucs.DeleteOnSubmit(kv);
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static void UpdateKhuVuc(KhuVuc khuvuc)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    KhuVuc kv = (from KV in dataContext.KhuVucs select KV).Where(t => t.IDKhuVuc == khuvuc.IDKhuVuc).FirstOrDefault();
                    kv.TenKhuVuc = khuvuc.TenKhuVuc;
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static List<Ban> GetAllBan()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    dataContext.DeferredLoadingEnabled = false;
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

        public static void InsertBan(Ban ban)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    dataContext.Bans.InsertOnSubmit(ban);
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static void DeleteBan(string IDBan)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    Ban ban = (from b in dataContext.Bans select b).Where(t => t.IDBan == IDBan).FirstOrDefault();
                    dataContext.Bans.DeleteOnSubmit(ban);
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }


        public static void UpdateBan(Ban ban)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    Ban item = (from b in dataContext.Bans select b).Where(t => t.IDBan == ban.IDBan).FirstOrDefault();
                    item.IDKhuVuc = ban.IDKhuVuc;
                    item.TrangThai = ban.TrangThai;
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static List<Ban> GetBanByKhuVuc(string IDKhuVuc)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    List<Ban> bans = new List<Ban>();
                    bans = (from b in dataContext.Bans where b.IDKhuVuc == IDKhuVuc
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

        public static ThongTinNguoiDung GetThongTinNguoiDung(string IDNguoiDung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    ThongTinNguoiDung thongtinnguoidung = new ThongTinNguoiDung();
                    thongtinnguoidung = (from ttnd in dataContext.ThongTinNguoiDungs
                                 where ttnd.IDNguoiDung == IDNguoiDung
                                 select ttnd).FirstOrDefault();
                    return thongtinnguoidung;
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

        public static List<ThongTinNguoiDung> GetAllThongTinNguoiDung()
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    dataContext.DeferredLoadingEnabled = false;
                    List<ThongTinNguoiDung> nguoidungs = new List<ThongTinNguoiDung>();
                    nguoidungs = (from ttnd in dataContext.ThongTinNguoiDungs
                                  select ttnd).OrderBy(id => id.IDNguoiDung).ToList();


                    return nguoidungs;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static void DeleteThongTinNguoiDung(string idnguoidung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {

                    var ttnguoidung = (from ttnd in dataContext.ThongTinNguoiDungs
                                       select ttnd).Where(t => t.IDNguoiDung == idnguoidung).FirstOrDefault();

                    dataContext.ThongTinNguoiDungs.DeleteOnSubmit(ttnguoidung);
                    dataContext.SubmitChanges();
                    
                }
                catch 
                {
                    
                }
            }
        }

        public static void InsertThongTinNguoiDung(ThongTinNguoiDung thongtinnguoidung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    dataContext.ThongTinNguoiDungs.InsertOnSubmit(thongtinnguoidung);
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }

        public static void SuaThongTinNguoiDung(ThongTinNguoiDung thongtinnguoidung)
        {
            using (dataContext = new LOUPAYDataContext())
            {
                try
                {
                    var nd = (from ttnd in dataContext.ThongTinNguoiDungs select ttnd).Where(t => t.IDNguoiDung == thongtinnguoidung.IDNguoiDung).FirstOrDefault();


                    nd.HoTen = thongtinnguoidung.HoTen;
                    nd.DiaChi = thongtinnguoidung.DiaChi;
                    nd.Email = thongtinnguoidung.Email;
                    nd.SoDienThoai = thongtinnguoidung.SoDienThoai;
                    nd.GioiTinh = thongtinnguoidung.GioiTinh;
                    nd.NgaySinh = thongtinnguoidung.NgaySinh;
                    nd.CanCuocCD = thongtinnguoidung.CanCuocCD;
                    nd.FileAnh = thongtinnguoidung.FileAnh;

                    
                    dataContext.SubmitChanges();
                }
                catch
                {

                }
            }
        }
    }
}
