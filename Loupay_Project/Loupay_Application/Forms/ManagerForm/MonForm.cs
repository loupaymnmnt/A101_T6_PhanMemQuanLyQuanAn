using ComponentFactory.Krypton.Toolkit;
using Loupay_Component;
using Loupay_Service.Database;
using Loupay_Service.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loupay_Application.Forms.ManagerForm
{
    public partial class MonForm : Loupay_Component.BaseFormMain
    {
        KryptonButton previousBtn1;
        KryptonButton previousBtn2;

        public MonForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.Load += MonForm_Load;
            this.kryptonDockableNavigator1.TabClicked += KryptonDockableNavigator1_TabClicked;
            this.datagridview_mon.CellClick += Datagridview_mon_CellClick;
            this.datagridview_loaimon.CellClick += Datagridview_loaimon_CellClick;
        }

        private void Datagridview_loaimon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ComponentHandler.SetEnabled(true, btn_xoa_2, btn_sua_2);
                BindingLoaiMonTab();
            }
        }

        private void Datagridview_mon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ComponentHandler.SetEnabled(true, btn_xoa_1, btn_sua_1);
                BindingMonTab();
            }
        }

        private void KryptonDockableNavigator1_TabClicked(object sender, ComponentFactory.Krypton.Navigator.KryptonPageEventArgs e)
        {
            ComponentHandler.SetEnabled(false, btn_xoa_1, btn_luu_1, btn_huy_1, btn_sua_1, btn_sua_2, btn_xoa_2, btn_huy_2, btn_luu_2,
                tb_tt_maloaimon_2, tb_tt_tenloaimon_2, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
        }

        private void MonForm_Load(object sender, EventArgs e)
        {
            cbbox_tenloaimon.DataSource = DatabaseHandler.GetAllLoaiMon();
            cbbox_tenloaimon.DisplayMember = "TenLoaiMon";
            cbbox_tenloaimon.ValueMember = "IDLoaiMon";
            cbbox_tt_tenloaimon_1.DataSource = DatabaseHandler.GetAllLoaiMon();
            cbbox_tt_tenloaimon_1.DisplayMember = "TenLoaiMon";
            cbbox_tt_tenloaimon_1.ValueMember = "IDLoaiMon";
            SetDataToDataGridView_Mon();
            SetDataToDataGridView_LoaiMon();
            ComponentHandler.SetEnabled(false, btn_xoa_1, btn_luu_1, btn_huy_1, btn_sua_1, btn_sua_2, btn_xoa_2, btn_huy_2, btn_luu_2,
                tb_tt_maloaimon_2, tb_tt_tenloaimon_2, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
        }

        private void SetDataToDataGridView_Mon()
        {
            datagridview_mon.Rows.Clear();
            List<Mon> list = DatabaseHandler.GetAllMon();
            foreach (Mon item in list)
            {
                datagridview_mon.Rows.Add(item.IDMon, item.LoaiMon.TenLoaiMon, item.TenMon, item.GiaMon, item.DonViTinh);
            }
        }

        private void SetDataToDataGridView_LoaiMon()
        {
            datagridview_loaimon.Rows.Clear();
            List<LoaiMon> list = DatabaseHandler.GetAllLoaiMon();
            foreach (LoaiMon item in list)
            {
                datagridview_loaimon.Rows.Add(item.IDLoaiMon, item.TenLoaiMon);
            }
        }

        private void SearchMon()
        {
            datagridview_mon.Rows.Clear();
            List<Mon> list = DatabaseHandler.GetAllMon();
            list = list.FindAll(id => id.LoaiMon.TenLoaiMon.Contains(cbbox_tenloaimon.Text) && id.IDMon.Contains(tb_mamon.Text) && id.TenMon.Contains(tb_tenmon.Text));
            foreach (Mon item in list)
            {
                datagridview_mon.Rows.Add(item.IDMon, item.LoaiMon.TenLoaiMon, item.TenMon, item.GiaMon, item.DonViTinh);
            }
        }

        private void SearchLoaiMon()
        {
            datagridview_loaimon.Rows.Clear();
            List<LoaiMon> list = DatabaseHandler.GetAllLoaiMon();
            list = list.FindAll(id => id.IDLoaiMon.Contains(tb_maloaimon_2.Text) && id.TenLoaiMon.Contains(tb_tenloaimon_2.Text));
            foreach (LoaiMon item in list)
            {
                datagridview_loaimon.Rows.Add(item.IDLoaiMon, item.TenLoaiMon);
            }
        }

        private void BindingMonTab()
        {
            tb_tt_mamon_1.Text = datagridview_mon.CurrentRow.Cells[0].Value.ToString();
            cbbox_tt_tenloaimon_1.Text = datagridview_mon.CurrentRow.Cells[1].Value.ToString();
            tb_tt_tenmon_1.Text = datagridview_mon.CurrentRow.Cells[2].Value.ToString();
            tb_tt_giamon_1.Text = datagridview_mon.CurrentRow.Cells[3].Value.ToString();
            tb_tt_donvitinh_1.Text = datagridview_mon.CurrentRow.Cells[4].Value.ToString();
            tb_tt_hinhanh_1.Text = DatabaseHandler.GetFileName(new Mon() { IDMon = tb_tt_mamon_1.Text });
        }

        private void BindingLoaiMonTab()
        {
            tb_tt_maloaimon_2.Text = datagridview_loaimon.CurrentRow.Cells[0].Value.ToString();
            tb_tt_tenloaimon_2.Text = datagridview_loaimon.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_them_1_Click(object sender, EventArgs e)
        {
            previousBtn1 = btn_them_1;
            ComponentHandler.SetEnabled(false, btn_sua_1, btn_xoa_1, btn_them_1, datagridview_mon);
            ComponentHandler.SetEnabled(true, btn_luu_1, btn_huy_1, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
            ComponentHandler.SetText(string.Empty, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
        }

        private void btn_sua_1_Click(object sender, EventArgs e)
        {
            previousBtn1 = btn_sua_1;
            ComponentHandler.SetEnabled(false, btn_sua_1, btn_xoa_1, btn_them_1, datagridview_mon);
            ComponentHandler.SetEnabled(true, btn_luu_1, btn_huy_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
        }

        private void btn_xoa_1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    Mon mon = new Mon() { IDMon = tb_tt_mamon_1.Text };
                    DatabaseHandler.DeleteMon(mon);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            SetDataToDataGridView_Mon();
        }

        private void btn_luu_1_Click(object sender, EventArgs e)
        {
            if (previousBtn1 == btn_them_1)
            {
                try
                {
                    Mon mon = new Mon();
                    if (InputValidation.IsQualifiedInputString(StandardInput.ST2, tb_tt_mamon_1.Text, tb_tt_tenmon_1.Text, tb_tt_hinhanh_1.Text, tb_tt_giamon_1.Text, tb_tt_donvitinh_1.Text,
                cbbox_tt_tenloaimon_1.Text) && InputValidation.IsOnlyDigitString(tb_tt_giamon_1.Text))
                    {
                        mon.IDMon = tb_tt_mamon_1.Text;
                        mon.IDLoaiMon = cbbox_tt_tenloaimon_1.SelectedValue.ToString();
                        mon.TenMon = tb_tt_tenmon_1.Text;
                        mon.GiaMon = Convert.ToDecimal(tb_tt_giamon_1.Text);
                        mon.DonViTinh = tb_tt_donvitinh_1.Text;
                        mon.FileAnh = tb_tt_hinhanh_1.Text;
                        DatabaseHandler.InsertMon(mon);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không phù hợp!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!!!");
                }
            }
            if (previousBtn1 == btn_sua_1)
            {
                try
                {
                    Mon mon = new Mon();
                    if (InputValidation.IsQualifiedInputString(StandardInput.ST2, tb_tt_mamon_1.Text, tb_tt_tenmon_1.Text, tb_tt_hinhanh_1.Text, tb_tt_giamon_1.Text, tb_tt_donvitinh_1.Text,
                cbbox_tt_tenloaimon_1.Text) && InputValidation.IsOnlyDigitString(tb_tt_giamon_1.Text))
                    {
                        mon.IDMon = tb_tt_mamon_1.Text;
                        mon.IDLoaiMon = cbbox_tt_tenloaimon_1.SelectedValue.ToString();
                        mon.TenMon = tb_tt_tenmon_1.Text;
                        mon.GiaMon = Convert.ToDecimal(tb_tt_giamon_1.Text);
                        mon.DonViTinh = tb_tt_donvitinh_1.Text;
                        mon.FileAnh = tb_tt_hinhanh_1.Text;
                        DatabaseHandler.UpdateMon(mon);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không phù hợp!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!!!");
                }
            }
            SetDataToDataGridView_Mon();
            previousBtn1 = null;
            ComponentHandler.SetText(string.Empty, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
            ComponentHandler.SetEnabled(true, btn_sua_1, btn_xoa_1, btn_them_1, datagridview_mon);
            ComponentHandler.SetEnabled(false, btn_luu_1, btn_huy_1, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
        }

        private void btn_huy_1_Click(object sender, EventArgs e)
        {
            ComponentHandler.SetEnabled(true, btn_sua_1, btn_xoa_1, btn_them_1, datagridview_mon);
            ComponentHandler.SetEnabled(false, btn_luu_1, btn_huy_1, tb_tt_mamon_1, tb_tt_tenmon_1, tb_tt_hinhanh_1, tb_tt_giamon_1, tb_tt_donvitinh_1,
                cbbox_tt_tenloaimon_1);
            BindingMonTab();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            SearchMon();
        }

        private void btn_timkiem_2_Click(object sender, EventArgs e)
        {
            SearchLoaiMon();
        }

        private void btn_them_2_Click(object sender, EventArgs e)
        {
            previousBtn2 = btn_them_2;
            ComponentHandler.SetEnabled(false, btn_sua_2, btn_xoa_2, btn_them_2, datagridview_loaimon);
            ComponentHandler.SetEnabled(true, btn_luu_2, btn_huy_2, tb_tt_maloaimon_2, tb_tt_tenloaimon_2);
            ComponentHandler.SetText(string.Empty, tb_tt_maloaimon_2, tb_tt_tenloaimon_2);
        }

        private void btn_sua_2_Click(object sender, EventArgs e)
        {
            previousBtn2 = btn_sua_2;
            ComponentHandler.SetEnabled(false, btn_sua_2, btn_xoa_2, btn_them_2, datagridview_loaimon);
            ComponentHandler.SetEnabled(true, btn_luu_2, btn_huy_2, tb_tt_tenloaimon_2);
        }

        private void btn_xoa_2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa loại món này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    DatabaseHandler.DeleteLoaiMon(new LoaiMon() { IDLoaiMon = tb_tt_maloaimon_2.Text });
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            SetDataToDataGridView_LoaiMon();
        }

        private void btn_luu_2_Click(object sender, EventArgs e)
        {
            if (previousBtn2 == btn_them_2)
            {
                try
                {
                    if (InputValidation.IsQualifiedInputString(StandardInput.ST2, tb_tt_maloaimon_2.Text, tb_tt_tenloaimon_2.Text))
                    {
                        LoaiMon loaiMon = new LoaiMon();
                        loaiMon.IDLoaiMon = tb_tt_maloaimon_2.Text;
                        loaiMon.TenLoaiMon = tb_tt_tenloaimon_2.Text;
                        DatabaseHandler.InsertLoaiMon(loaiMon);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không phù hợp!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!!!");
                }
            }
            if (previousBtn2 == btn_sua_2)
            {
                try
                {
                    if (InputValidation.IsQualifiedInputString(StandardInput.ST2, tb_tt_maloaimon_2.Text, tb_tt_tenloaimon_2.Text))
                    {
                        LoaiMon loaiMon = new LoaiMon();
                        loaiMon.IDLoaiMon = tb_tt_maloaimon_2.Text;
                        loaiMon.TenLoaiMon = tb_tt_tenloaimon_2.Text;
                        DatabaseHandler.DeleteLoaiMon(loaiMon);
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không phù hợp!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra!!!");
                }
            }
            SetDataToDataGridView_LoaiMon();
            previousBtn2 = null;
            ComponentHandler.SetText(string.Empty, tb_tt_maloaimon_2, tb_tt_tenloaimon_2);
            ComponentHandler.SetEnabled(true, btn_sua_2, btn_xoa_2, btn_them_2, datagridview_loaimon);
            ComponentHandler.SetEnabled(false, btn_luu_2, btn_huy_2, tb_tt_maloaimon_2, tb_tt_tenloaimon_2);
        }

        private void btn_huy_2_Click(object sender, EventArgs e)
        {
            ComponentHandler.SetEnabled(true, btn_sua_2, btn_xoa_2, btn_them_2, datagridview_loaimon);
            ComponentHandler.SetEnabled(false, btn_luu_2, btn_huy_2, tb_tt_maloaimon_2, tb_tt_tenloaimon_2);
            BindingMonTab();
        }
    }
}
