using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
using Loupay_Service.Account;
using Loupay_Service.Client.Order;
using Loupay_Service.Client.Table;
using Loupay_Service.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component.SubControl
{
    public partial class TableMainBoard : UserControl
    {
        public TableMainBoard()
        {
            InitializeComponent();
            this.Load += TableMainBoard_Load;
        }

        public void Reload()
        {
            this.tableId.Text = CurrentSelectedTable.Table.Ban.IDBan;
            this.tableStatus.Text = CurrentSelectedTable.Table.Ban.TrangThai;
            this.tienThanhToan.Text = CurrentSelectedTable.Table.GetTotalPrice().ToString();
            this.soMonDat.Text = CurrentSelectedTable.Table.GetTotalDishes().ToString();
            
            if (CurrentSelectedTable.Table.Ban.TrangThai == TableStatus.TRONG)
            {
                ComponentHandler.SetEnabled(false, btn_Thanhtoan, btn_lamMoi);
            }
            else
            {
                ComponentHandler.SetEnabled(true, btn_Thanhtoan, btn_lamMoi);
            }

            CurrentTableOrder.TableOrder.Reload(CurrentSelectedTable.Table);
        }

        private void TableMainBoard_Load(object sender, EventArgs e)
        {
            CurrentTableMainBoard.TableMainBoard = this;
            CurrentTableOrder.TableOrder = this.tableOrder1;
            this.groupbox.Text = "Thông tin bàn";
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Thanh toán bàn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    HoaDon hoaDon = new HoaDon();
                    Guid guid = Guid.NewGuid();
                    string id = guid.ToString();
                    id = id.Substring(0, 6);
                    hoaDon.IDHoaDon = id;
                    hoaDon.IDBan = CurrentSelectedTable.Table.Ban.IDBan;
                    hoaDon.IDNguoiDung = CurrentAccount.Instance.IDNguoiDung;
                    hoaDon.GiamGia = 0;
                    hoaDon.NgayLap = DateTime.Now;
                    hoaDon.ThanhTien = CurrentSelectedTable.Table.GetTotalPrice();
                    DatabaseHandler.InsertHoaDon(hoaDon);
                    foreach (CurrentOrder order in CurrentSelectedTable.Table.CurrentOrders)
                    {
                        DatMon dm = new DatMon();
                        dm.IDHoaDon = id;
                        dm.IDMon = order.MaMon;
                        dm.SoLuong = order.SoLuong;
                        DatabaseHandler.InsertDatMon(dm);
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                    return;
                }
                DialogResult r1 = MessageBox.Show("Thành công! Bạn có muốn xuất hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r1 == DialogResult.Yes)
                {

                }
                CurrentSelectedTable.Table.CurrentOrders.Clear();
                CurrentSelectedTable.Table.SetBackColor(TableStatus.TRONG);
                CurrentSelectedTable.Table.Ban.TrangThai = TableStatus.TRONG;
                DatabaseHandler.UpdateBan(CurrentSelectedTable.Table.Ban);
                Reload();
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn Reset bàn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                CurrentSelectedTable.Table.CurrentOrders.Clear();
                CurrentSelectedTable.Table.SetBackColor(TableStatus.TRONG);
                CurrentSelectedTable.Table.Ban.TrangThai = TableStatus.TRONG;
                DatabaseHandler.UpdateBan(CurrentSelectedTable.Table.Ban);
                Reload();
            }
        }
    }
}
