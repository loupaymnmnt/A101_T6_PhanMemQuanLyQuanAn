using Loupay_Component.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component.SubControl
{
    public partial class TablesPanel : UserControl
    {
        private string _id = string.Empty;

        public string Id { get => _id; set => _id = value; }

        Panel panel = new Panel();
        List<Table> tables = new List<Table>();

        public TablesPanel()
        {
            InitializeComponent();
            this.Load += TablesPanel_Load;
        }

        private void TablesPanel_Load(object sender, EventArgs e)
        {
            ControlInit();
        }

        private void ControlInit()
        {
            this.Width = 500;
            this.Height = 400;
            this.BorderStyle = BorderStyle.Fixed3D;

            this.panel.Top = 0;
            this.panel.Left = 0;
            this.panel.Size = this.Size;
            this.Controls.Add(this.panel);
            this.panel.AutoScroll = true;

            int position = 0;
            int currentTop = 5;
            int currentLeft = 5;
            for (int i = 0; i < 19; ++i)
            {
                Table table = new Table();
                table.Id = i.ToString();
                table.Top = currentTop;
                table.Left = currentLeft;
                this.panel.Controls.Add(table);

                ++position;
                currentLeft += table.Width + 5;
                if (position == 4)
                {
                    position = 0;
                    currentTop += table.Height + 5;
                    currentLeft = 5;
                }    
            }
        }

    }
}
