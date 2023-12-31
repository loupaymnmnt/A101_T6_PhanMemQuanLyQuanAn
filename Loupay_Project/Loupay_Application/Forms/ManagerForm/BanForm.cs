﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loupay_Component.SubControl;
using Loupay_Component;
using Loupay_Service.Database;
using Loupay_Application.Forms.ManagerForm;
using ComponentFactory.Krypton.Toolkit;

namespace Loupay_Application.Forms.ManagerForm
{
    public partial class BanForm : Loupay_Component.BaseFormMain
    {
        List<Ban> lstBan;
        List<KhuVuc> lstKhuVuc;
        public BanForm()
        {
            InitializeComponent();



        }

        void LoadCBOKV()
        {

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = DatabaseHandler.GetAllKhuVuc();
            cboKV.DataSource = bindingSource.DataSource;
            cboKV.DisplayMember = "TenKhuVuc";
            cboKV.ValueMember = "IDKhuVuc";

        }
        void LoadDGVBan()
        {
            lstBan = DatabaseHandler.GetAllBan();
            dgvBan.DataSource = lstBan;
            dgvBan.Columns["KhuVuc"].Visible = false;

        }
        void LoadDGVKV()
        {
            lstKhuVuc = DatabaseHandler.GetAllKhuVuc();
            dgvKV.DataSource = lstKhuVuc;
        }


        private void BanForm_Load(object sender, EventArgs e)
        {
            LoadCBOKV();
            LoadDGVBan();
            LoadDGVKV();
            LoadCBOTrangThai();
        }
        bool CheckPrimaryKeyBan()
        {
            Ban ban = DatabaseHandler.GetBan(txtIDBan.Text.Trim());
            if (ban != null)
            {
                return false;
            }
            return true;

        }
        bool CheckPrimaryKeyKhuVuc()
        {
            KhuVuc kv = DatabaseHandler.GetKhuVuc(txtMKV.Text.Trim());
            if (kv != null)
            {
                return false;
            }
            return true;

        }
        void LoadCBOTrangThai()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Trống", "Trống");
            test.Add("Đã đặt", "Đã đặt");
            cboTrangThai.DataSource = new BindingSource(test, null);
            cboTrangThai.DisplayMember = "Key";
            cboTrangThai.ValueMember = "Key";
        }
        private void btnAddKV_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckPrimaryKeyKhuVuc())
                {
                    KhuVuc kv = new KhuVuc();
                    kv.IDKhuVuc = txtMKV.Text.Trim();
                    kv.TenKhuVuc = txtTKV.Text.Trim();                  
                    DatabaseHandler.InsertKhuVuc(kv);
                    LoadCBOKV();
                    

                }
            }
            catch { }
        }

        private void btnAddBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckPrimaryKeyBan())
                {
                    Ban ban = new Ban();
                    ban.IDBan = txtIDBan.Text.Trim();
                    ban.IDKhuVuc = cboKV.SelectedValue.ToString();
                    ban.TrangThai = cboTrangThai.SelectedValue.ToString();
                    DatabaseHandler.InsertBan(ban);
                    LoadDGVBan();

                }
            }
            catch { 
            
            
            
            }
        }

        private void contextDGVBan_Opening(object sender, CancelEventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {

                DatabaseHandler.DeleteBan(dgvBan.CurrentRow.Cells[0].Value.ToString());
                LoadDGVBan();
                MessageBox.Show("Xóa thành công");
            
            }
            catch {

                MessageBox.Show("Xóa thất bại");
            }
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                DatabaseHandler.DeleteKhuVuc(dgvKV.CurrentRow.Cells[0].Value.ToString());
                LoadDGVKV();
                MessageBox.Show("Xóa thành công");

            }
            catch
            {

                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
