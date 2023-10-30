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
        #region CONTROLS
        KryptonTextBox tableId = new KryptonTextBox();
        
        #endregion CONTROLS
        public TableMainBoard()
        {
            InitializeComponent();
            this.Load += TableMainBoard_Load;
        }

        public void Reload(Table table)
        {
            this.tableId.Text = table.Id;
        }

        private void TableMainBoard_Load(object sender, EventArgs e)
        {
            this.tableId.Top = 0;
            this.tableId.ReadOnly = true;
            this.tableId.Text = "";
            this.tableId.Left = 0;
            this.Controls.Add(this.tableId);
        }
    }
}
