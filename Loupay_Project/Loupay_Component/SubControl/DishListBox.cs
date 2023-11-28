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
    public partial class DishListBox : UserControl
    {
        List<Dish> dishes = new List<Dish>();
        List<Mon> mons = new List<Mon>();
        public DishListBox(List<Mon> mons)
        {
            InitializeComponent();
            this.Load += DishListBox_Load;
            this.mons = mons;
        }

        private void DishListBox_Load(object sender, EventArgs e)
        {
            ControlInit();
        }

        private void ControlInit()
        {
            this.AutoScroll = true;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Height = 410;
            this.Width = 462;

            int currentTop = 10;
            for (int i = 0; i < mons.Count; ++i)
            {
                Dish dish = new Dish();
                dish.Mon = mons[i];
                dishes.Add(dish);
                dish.Top = currentTop;
                dish.Left = 5;
                dish.SetId(mons[i].IDMon);
                dish.SetName(mons[i].TenMon);
                dish.SetPrice(mons[i].GiaMon.ToString());
                this.Controls.Add(dish);
                currentTop += 80;
            }
        }

        private void ControlEventsInit()
        {

        }
    }
}
