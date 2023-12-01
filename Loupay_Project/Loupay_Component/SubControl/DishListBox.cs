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
                string filePath = mons[i].FileAnh;
                dish.SetImage("..\\..\\Images\\" + filePath);
                dishes.Add(dish);
                dish.Top = currentTop;
                dish.Left = 5;
                dish.Click += Dish_Click;
                dish.SetId(mons[i].IDMon);
                dish.SetName(mons[i].TenMon);
                dish.SetPrice(mons[i].GiaMon.ToString());
                this.Controls.Add(dish);
                currentTop += 80;
            }
        }

        private void Dish_Click(object sender, EventArgs e)
        {
            if (CurrentSelectedTable.Table != null) 
            {
                DialogResult r = DialogResult.No;
                if (CurrentSelectedTable.Table.Ban.TrangThai == TableStatus.TRONG)
                {
                    r = MessageBox.Show("Bàn hiện đang trống. Mở bàn " + CurrentSelectedTable.Table.Ban.IDBan.ToString() + " và đặt món này?", "Thông báo", MessageBoxButtons.YesNo);
                }
                else
                {
                    r = MessageBox.Show("Đặt món này?", "Thông báo", MessageBoxButtons.YesNo);
                }
                if (r == DialogResult.Yes)
                {
                    Dish dish = (Dish)sender;
                    CurrentOrder newOrder = new CurrentOrder(dish.Mon.IDMon, dish.Mon.TenMon, 1, (decimal)dish.Mon.GiaMon, dish.Mon.FileAnh);
                    CurrentSelectedTable.Table.Add(newOrder);

                    if (CurrentSelectedTable.Table.Ban.TrangThai == TableStatus.TRONG)
                    {
                        CurrentSelectedTable.Table.Ban.TrangThai = TableStatus.DADAT;
                        CurrentSelectedTable.Table.SetBackColor(TableStatus.DADAT);
                        DatabaseHandler.UpdateBan(CurrentSelectedTable.Table.Ban);
                    }

                    CurrentTableOrder.TableOrder.Reload(CurrentSelectedTable.Table);
                    CurrentTableMainBoard.TableMainBoard.Reload();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn để đặt món!", "Thông báo");
            }
        }

        private void ControlEventsInit()
        {

        }
    }
}
