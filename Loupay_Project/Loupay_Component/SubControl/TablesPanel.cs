using Loupay_Component.Interfaces;
using Loupay_Service.Database;
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
        private TableMainBoard mainBoard;
        private List<Ban> bans;
        private List<Table> xtables;
        private DishListBox listBox;
        public string Id { get => _id; set => _id = value; }
        public TableMainBoard TableMainBoard { get { return mainBoard; } set { mainBoard = value; } }
        public DishListBox ListBox { get { return listBox; } set { listBox = value; } }
        public List<Ban> Bans { get { return bans; } set { bans = value; } }
        public List<Table> Tables { get { return xtables; } set { xtables = value; } }

        Panel panel = new Panel();
        List<Table> tables = new List<Table>();

        public TablesPanel()
        {
            InitializeComponent();
            this.Load += TablesPanel_Load;
            CurrentTablePanel.TablesPanel = this;
        }

        public TablesPanel(List<Ban> bans)
        {
            InitializeComponent();
            this.Load += TablesPanel_Load;
            this.bans = bans;
            CurrentTablePanel.TablesPanel = this;
        }

        private void TablesPanel_Load(object sender, EventArgs e)
        {
            ControlInit();
            ControlEventsInit();
        }

        private void ControlInit()
        {
            xtables = new List<Table>();
            this.Width = 310;
            this.Height = 515;
            this.BorderStyle = BorderStyle.Fixed3D;

            this.panel.Top = 0;
            this.panel.Left = 0;
            this.panel.Size = this.Size;
            this.Controls.Add(this.panel);
            this.panel.AutoScroll = true;

            int position = 0;
            int currentTop = 85;
            int currentLeft = 5;
            for (int i = 0; i < bans.Count; ++i)
            {
                Table table = new Table();
                table.Ban = bans[i];
                table.SetBackColor(bans[i].TrangThai);
                table.Top = currentTop;
                table.Left = currentLeft;
                this.panel.Controls.Add(table);
                tables.Add(table);
                ++position;
                currentLeft += table.Width + 5;
                if (position == 4)
                {
                    position = 0;
                    currentTop += table.Height + 5;
                    currentLeft = 5;
                }
                xtables.Add(table);
            }
        }

        private void ControlEventsInit()
        {
            foreach (Table table in tables)
            {
                table.Click += Table_Click;
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            CurrentSelectedTable.Table = (Table)sender;
            if ((sender as Table).states.Count == 0)
            {
                mainBoard.Reload();
            }
            else
            {
                mainBoard.ReloadBanGop();
            }
        }
    }
}
