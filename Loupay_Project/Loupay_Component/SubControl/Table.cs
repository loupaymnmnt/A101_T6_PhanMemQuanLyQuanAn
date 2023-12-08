using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
using Loupay_Service.Client.Order;
using Loupay_Service.Client.Table;
using Loupay_Service.Database;
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
    public partial class Table : UserControl
    {
        private Color currentColor = DefaultBackColor;
        private Ban ban;
        private List<CurrentOrder> _currentOrders = new List<CurrentOrder>();
        public List<CurrentOrder> CurrentOrders { get { return _currentOrders; } set { _currentOrders = value; } }
        public List<string> states = new List<string>();

        public Ban Ban { get { return ban; } set { ban = value; } }

        public void Add(CurrentOrder newOrder)
        {
            CurrentOrder order = CurrentOrders.Find(d => d.MaMon == newOrder.MaMon);
            if (order != null)
            {
                order.SoLuong += 1;
            }
            else
            {
                CurrentOrders.Add(newOrder);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal sum = 0;
            foreach (CurrentOrder order in _currentOrders)
            {
                sum += order.GiaMon * order.SoLuong;
            }
            return sum;
        }

        public int GetTotalDishes()
        {
            int q = 0;
            foreach (CurrentOrder order in _currentOrders)
            {
                q += order.SoLuong;
            }
            return q;
        }

        #region CONTROLS
        KryptonLabel label = new KryptonLabel();
        #endregion CONTROLS

        public Table()
        {
            InitializeComponent();
            this.Load += Table_Load;
            this.MouseLeave += Table_MouseLeave;
            this.MouseMove += Table_MouseHover;
            this.MouseEnter += Table_MouseHover;
        }

        private void Table_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = currentColor;
        }

        private void Table_MouseHover(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Aqua)
                this.BackColor = Color.Aqua;
        }

        public void SetBackColor(string status)
        {
            if (status == TableStatus.TRONG)
            {
                currentColor = DefaultBackColor;
                this.BackColor = currentColor;
                
            }
            else if (status == TableStatus.DADAT)
            {
                currentColor = Color.Red;
                this.BackColor = currentColor;
            }
            else
            {
                currentColor = Color.Yellow;
                this.BackColor = currentColor;
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.BackColor = currentColor;
            this.label.StateCommon.ShortText.Font = new Font("Arial", 10, FontStyle.Bold);
            this.label.StateCommon.ShortText.Color1 = Color.Black;
            this.label.Width = 50;
            this.label.Text = "BÀN " + ban.IDBan.ToString();
            this.label.Enabled = false;
            this.Width = 70;
            this.Height = 50;
            this.BorderStyle = BorderStyle.FixedSingle;
            FormComponentSize.CenterChildControl(this.label, this);
            FormComponentSize.CenterChildControlVertical(this.label, this);
            this.Controls.Add(this.label);
        }
    }
}
