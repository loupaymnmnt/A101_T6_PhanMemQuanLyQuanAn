using Loupay_Component.SubControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Component
{
    public static class CurrentTableMainBoard
    {
        private static TableMainBoard tableMainBoard;
        public static TableMainBoard TableMainBoard { get { return tableMainBoard; } set { tableMainBoard = value; } }
    }
}
