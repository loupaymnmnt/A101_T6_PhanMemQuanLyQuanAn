using Loupay_Component.SubControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Component
{
    public static class CurrentTableOrder
    {
        private static TableOrder tableOrder;
        public static TableOrder TableOrder { get { return tableOrder; } set { tableOrder = value; } }
    }
}
