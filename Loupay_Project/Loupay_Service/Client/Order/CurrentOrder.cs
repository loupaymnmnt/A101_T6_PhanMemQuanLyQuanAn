using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Service.Client.Order
{
    public class CurrentOrder
    {
        private string _IDBan;
        private string _HoaDonID;

        public string IDBan { get { return _IDBan; } set { _IDBan = value; } }
        
    }
}
