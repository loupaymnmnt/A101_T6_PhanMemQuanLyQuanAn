using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component.SubControl
{
    public partial class TableMainBoard : UserControl
    {
        public TableMainBoard()
        {
            InitializeComponent();
            this.Load += TableMainBoard_Load;
        }

        public void Reload(Table table)
        {
            this.tableId.Text = table.Ban.IDBan;
        }

        private void TableMainBoard_Load(object sender, EventArgs e)
        {
            this.groupbox.Text = "Thông tin bàn";
        }
    }
}
