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
        public DishListBox()
        {
            InitializeComponent();
            this.Load += DishListBox_Load;
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
            for (int i = 0; i < 20; ++i)
            {
                Dish dish = new Dish();
                dishes.Add(dish);
                dish.Top = currentTop;
                dish.Left = 5;
                dish.SetId("ID_" + i.ToString());
                dish.SetName("DISH_NAME_" + i.ToString());
                dish.SetPrice("999,999");
                this.Controls.Add(dish);
                currentTop += 80;
            }
        }

        private void ControlEventsInit()
        {

        }
    }
}
