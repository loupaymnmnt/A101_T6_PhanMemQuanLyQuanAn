﻿using System;
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
            NguoiDung user = (from u in dataContext.NguoiDungs
                              where u.IDNguoiDung == userId
                              select u).FirstOrDefault();
            return user;
        }

        public static List<KhuVuc> GetAllKhuVuc()
        {
            List<KhuVuc> khuVucs = new List<KhuVuc>();
            khuVucs = (from kv in dataContext.KhuVucs
                       select kv).OrderBy(id => id.IDKhuVuc).ToList();
            return khuVucs;
        }

        public static KhuVuc GetKhuVuc(string khuVucId)
        {
            KhuVuc khuVucs = new KhuVuc();
            khuVucs = (from kv in dataContext.KhuVucs
                       where kv.IDKhuVuc == khuVucId
                       select kv).FirstOrDefault();
            return khuVucs;
        }

        public static List<Ban> GetAllBan()
        {
            List<Ban> bans = new List<Ban>();
            bans = (from b in dataContext.Bans
                    select b).OrderBy(id => id.IDBan).ToList();
            return bans;
        }

        public static Ban GetBan(string BanId)
        {
            Ban ban = new Ban();
            ban = (from b in dataContext.Bans
                   where b.IDBan == BanId
                   select b).FirstOrDefault();
            return ban;
        }

        public static List<Mon> GetAllMon()
        {
            List<Mon> mons = new List<Mon>();
            mons = (from mon in dataContext.Mons
                    select mon).OrderBy(id => id.IDMon).ToList();
            return mons;
        }

        public static List<LoaiMon> GetAllLoaiMon()
        {
            List<LoaiMon> loais = new List<LoaiMon>();
            loais = (from loai in dataContext.LoaiMons
                     select loai).OrderBy(id => id.IDLoaiMon).ToList();
            return loais;
        }


        public static List<NguoiDung> GetAllNguoiDung()
        {
            List<NguoiDung> nguoidungs = new List<NguoiDung>();
            nguoidungs = (from nguoidung in dataContext.NguoiDungs
                          select nguoidung).OrderBy(id => id.IDNguoiDung).ToList();
            return nguoidungs;
        }

        public static NguoiDung GetNguoiDung(string IDNguoiDung)
        {
            NguoiDung nguoidung = new NguoiDung();
            nguoidung = (from nd in dataContext.NguoiDungs
                         where nd.IDNguoiDung == IDNguoiDung
                         select nd).FirstOrDefault();
            return nguoidung;
        }

        public static List<PhanQuyen> GetAllPhanQuyen()
        {
            List<PhanQuyen> phanQuyens = new List<PhanQuyen>();
            phanQuyens = (from phanquyen in dataContext.PhanQuyens
                          select phanquyen).ToList();
            return phanQuyens;
        }

        public static List<PhanQuyen> GetAllPhanQuyenOfQuyenNguoiDung(string IDQuyenNguoiDung)
        {
            List<PhanQuyen> phanQuyens = new List<PhanQuyen>();
            phanQuyens = (from phanquyen in dataContext.PhanQuyens
                          where phanquyen.IDQuyenNguoiDung == IDQuyenNguoiDung
                          select phanquyen).ToList();
            return phanQuyens;
        }

        public static void InsertNguoiDung(NguoiDung nguoiDung)
        {
            dataContext.NguoiDungs.InsertOnSubmit(nguoiDung);
            dataContext.SubmitChanges();
        }

        public static void UpdateNguoiDung(NguoiDung nguoiDung)
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

        public static string GetFileName(ThongTinNguoiDung thongTinNguoiDung)
        {
            return "";
        }

        public static string GetFileName(Mon mon)
        {
            Mon smon = (from m in dataContext.Mons
                        where m.IDMon == mon.IDMon
                        select m).FirstOrDefault();
            return smon.FileAnh;
        }

        public static void DeleteNguoiDung(NguoiDung nguoiDung)
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

        public static void InsertMon(Mon mon)
        {
            dataContext.Mons.InsertOnSubmit(mon);
            dataContext.SubmitChanges();
        }

        public static void UpdateMon(Mon imon)
        {
            Mon mon = (from _mon in dataContext.Mons
                       where _mon.IDMon == imon.IDMon
                       select _mon).
                       FirstOrDefault();
            mon.TenMon = imon.TenMon;
            mon.IDLoaiMon = imon.IDLoaiMon;
            mon.GiaMon = imon.GiaMon;
            mon.DonViTinh = imon.DonViTinh;
            mon.FileAnh = imon.FileAnh;
            dataContext.SubmitChanges();
        }

        public static void DeleteMon(Mon mon)
        {
            Mon dmon = (from _mon in dataContext.Mons
                        where _mon.IDMon == mon.IDMon
                        select _mon).
                       FirstOrDefault();
            dataContext.Mons.DeleteOnSubmit(dmon);
            dataContext.SubmitChanges();
        }

        public static void InsertLoaiMon(LoaiMon lmon)
        {
            dataContext.LoaiMons.InsertOnSubmit(lmon);
            dataContext.SubmitChanges();
        }

        public static void UpdateLoaiMon(LoaiMon lmon)
        {
            LoaiMon lm = (from l in dataContext.LoaiMons
                          where l.IDLoaiMon == lmon.IDLoaiMon
                          select l).FirstOrDefault();
            lm.TenLoaiMon = lmon.TenLoaiMon;
            dataContext.SubmitChanges();
        }

        public static void DeleteLoaiMon(LoaiMon lmon)
        {
            LoaiMon lm = (from l in dataContext.LoaiMons
                          where l.IDLoaiMon == lmon.IDLoaiMon
                          select l).FirstOrDefault();
            dataContext.LoaiMons.DeleteOnSubmit(lm);
            dataContext.SubmitChanges();
        }

        public static List<ThongTinNguoiDung> GetAllThongTinNguoiDung()
        {
            List<ThongTinNguoiDung> nguoidungs = new List<ThongTinNguoiDung>();
            nguoidungs = (from ttnd in dataContext.ThongTinNguoiDungs
                          select ttnd).OrderBy(id => id.IDNguoiDung).ToList();
            return nguoidungs;
        }

        public static void DeleteThongTinNguoiDung(string idnguoidung)
        {
            var ttnguoidung = (from ttnd in dataContext.ThongTinNguoiDungs
                               select ttnd).Where(t => t.IDNguoiDung == idnguoidung).FirstOrDefault();

            dataContext.ThongTinNguoiDungs.DeleteOnSubmit(ttnguoidung);
            dataContext.SubmitChanges();
        }

        public static void InsertThongTinNguoiDung(ThongTinNguoiDung thongtinnguoidung)
        {
            dataContext.ThongTinNguoiDungs.InsertOnSubmit(thongtinnguoidung);
            dataContext.SubmitChanges();
        }

        public static void SuaThongTinNguoiDung(ThongTinNguoiDung thongtinnguoidung)
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

        public static void InsertKhuVuc(KhuVuc khuvuc)
        {
            dataContext.KhuVucs.InsertOnSubmit(khuvuc);
            dataContext.SubmitChanges();
        }
        public static void DeleteKhuVuc(string IDKhuVuc)
        {
            KhuVuc kv = (from KV in dataContext.KhuVucs select KV).Where(t => t.IDKhuVuc == IDKhuVuc).FirstOrDefault();
            dataContext.KhuVucs.DeleteOnSubmit(kv);
            dataContext.SubmitChanges();
        }

        public static void UpdateKhuVuc(KhuVuc khuvuc)
        {
            KhuVuc kv = (from KV in dataContext.KhuVucs select KV).Where(t => t.IDKhuVuc == khuvuc.IDKhuVuc).FirstOrDefault();
            kv.TenKhuVuc = khuvuc.TenKhuVuc;
            dataContext.SubmitChanges();
        }

        public static void InsertBan(Ban ban)
        {
            dataContext.Bans.InsertOnSubmit(ban);
            dataContext.SubmitChanges();
        }

        public static void DeleteBan(string IDBan)
        {
            Ban ban = (from b in dataContext.Bans select b).Where(t => t.IDBan == IDBan).FirstOrDefault();
            dataContext.Bans.DeleteOnSubmit(ban);
            dataContext.SubmitChanges();
        }


        public static void UpdateBan(Ban ban)
        {
            Ban item = (from b in dataContext.Bans select b).Where(t => t.IDBan == ban.IDBan).FirstOrDefault();
            item.IDKhuVuc = ban.IDKhuVuc;
            item.TrangThai = ban.TrangThai;
            dataContext.SubmitChanges();
        }

        public static void InsertHoaDon(HoaDon hoaDon)
        {
            dataContext.HoaDons.InsertOnSubmit(hoaDon);
            dataContext.SubmitChanges();
        }

        public static void InsertDatMon(DatMon dm)
        {
            dataContext.DatMons.InsertOnSubmit(dm);
            dataContext.SubmitChanges();
        }

    }
}
