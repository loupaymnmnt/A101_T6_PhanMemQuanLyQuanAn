using Loupay_Service.Client.Order;
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
    public partial class TableOrder : UserControl
    {
        List<OrderedDish> orderedDishes = new List<OrderedDish>();
        public TableOrder()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        public void Reload(Table table)
        {
            this.Controls.Clear();
            int currentTop = 5;
            int left = 5;
            foreach (CurrentOrder order in table.CurrentOrders)
            {
                OrderedDish dish = new OrderedDish();
                dish.SetImage("..\\..\\Images\\" + order.ImagePath);
                dish.SetName(order.TenMon);
                dish.SetPrice(order.SoLuong * order.GiaMon);
                dish.SetNudValue(order.SoLuong);
                dish.Top = currentTop;
                dish.Left = left;
                this.Controls.Add(dish);
                currentTop += dish.Height + 10;
            }
        }
    }
}
