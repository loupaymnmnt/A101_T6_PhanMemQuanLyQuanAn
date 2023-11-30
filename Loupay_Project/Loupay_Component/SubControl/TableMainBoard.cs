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

        public void Reload()
        {
            this.tableId.Text = CurrentSelectedTable.Table.Ban.IDBan;
            this.tableStatus.Text = CurrentSelectedTable.Table.Ban.TrangThai;
            this.tienThanhToan.Text = CurrentSelectedTable.Table.GetTotalPrice().ToString();
            this.soMonDat.Text = CurrentSelectedTable.Table.GetTotalDishes().ToString();
            CurrentTableOrder.TableOrder.Reload(CurrentSelectedTable.Table);
        }

        private void TableMainBoard_Load(object sender, EventArgs e)
        {
            CurrentTableMainBoard.TableMainBoard = this;
            CurrentTableOrder.TableOrder = this.tableOrder1;
            this.groupbox.Text = "Thông tin bàn";
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {

        }
    }
}
