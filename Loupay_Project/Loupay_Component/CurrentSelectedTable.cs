using Loupay_Component.SubControl;
using Loupay_Service.Client.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Component
{
    public static class CurrentSelectedTable
    {
        private static Table _table;
        public static Table Table { get { return _table; } set { _table = value; } }
    }
}
