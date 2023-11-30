using Loupay_Service.Database;
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
        public MonForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.Load += MonForm_Load;
        }

        private void MonForm_Load(object sender, EventArgs e)
        {
            cbbox_tenloaimon.DataSource = DatabaseHandler.GetAllLoaiMon();
            cbbox_tenloaimon.DisplayMember = "TenLoaiMon";
            cbbox_tenloaimon.ValueMember = "IDLoaiMon";
            cbbox_tenloaimon_2.DataSource = DatabaseHandler.GetAllLoaiMon();
            cbbox_tenloaimon_2.DisplayMember = "TenLoaiMon";
            cbbox_tenloaimon_2.ValueMember = "IDLoaiMon";
            SetDataToDataGridView_Mon();
            SetDataToDataGridView_LoaiMon();
        }

        private void SetDataToDataGridView_Mon()
        {
            List<Mon> list = DatabaseHandler.GetAllMon();
            foreach (Mon item in list)
            {
                datagridview_mon.Rows.Add(item.IDMon, item.LoaiMon.TenLoaiMon, item.TenMon, item.GiaMon, item.DonViTinh);
            }
        }

        private void SetDataToDataGridView_LoaiMon()
        {
            List<LoaiMon> list = DatabaseHandler.GetAllLoaiMon();
            foreach (LoaiMon item in list)
            {
                datagridview_loaimon.Rows.Add(item.IDLoaiMon, item.TenLoaiMon);
            }
        }
    }
}
