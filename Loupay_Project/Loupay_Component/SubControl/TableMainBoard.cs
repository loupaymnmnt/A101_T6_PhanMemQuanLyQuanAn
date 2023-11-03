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
        KryptonGroupBox groupBox = new KryptonGroupBox();
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
            this.BorderStyle = BorderStyle.Fixed3D;
            this.tableId.Top = 0;
            this.tableId.Text = "";
            this.tableId.Left = 0;
            this.groupBox.Top = 25;
            this.groupBox.Text = "Thông tin bàn";
            this.groupBox.Panel.Controls.Add(this.tableId);
            this.Controls.Add(this.groupBox);
        }
    }
}
