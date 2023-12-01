using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Service.Client.Order
{
    public class CurrentOrder
    {
        private string _MaMon;
        private string _TenMon;
        private int _SoLuong;
        private decimal _GiaMon;
        private string _ImagePath;


        public string MaMon { get { return _MaMon; } set { _MaMon = value; } }
        public string TenMon { get { return _TenMon; } set { _TenMon = value; } }
        public int SoLuong { get { return _SoLuong; } set { _SoLuong = value; } }
        public string ImagePath { get { return _ImagePath; } set { _ImagePath = value; } }
        public decimal GiaMon { get { return _GiaMon; } set { _GiaMon = value; } }
        public decimal TongGia { get { return _GiaMon * _SoLuong; } }

        private CurrentOrder()
        {

        }
        public CurrentOrder(string _MaMon, string _TenMon, int _SoLuong, decimal _GiaMon, string _ImagePath)
        {
            this._MaMon = _MaMon;
            this._TenMon = _TenMon;
            this._SoLuong = _SoLuong;
            this._GiaMon = _GiaMon;
            this._ImagePath = _ImagePath;
        }

    }
}
