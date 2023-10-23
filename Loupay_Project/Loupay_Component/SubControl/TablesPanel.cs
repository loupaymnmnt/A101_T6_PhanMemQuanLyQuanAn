using Loupay_Component.Interfaces;
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
    public partial class TablesPanel : UserControl
    {
        private string _id = string.Empty;

        public string Id { get => _id; set => _id = value; }

        List<Table> tables = new List<Table>();

        public TablesPanel()
        {
            InitializeComponent();
            this.Load += TablesPanel_Load;
        }

        private void TablesPanel_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 350;
        }

        private void ControlInit()
        {
            
        }

    }
}
