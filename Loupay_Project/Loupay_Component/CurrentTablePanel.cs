using Loupay_Component.SubControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Component
{
    public static class CurrentTablePanel
    {
        private static TablesPanel tablesPanel;
        public static TablesPanel TablesPanel { get { return tablesPanel; } set { tablesPanel = value; } }
    }
}
