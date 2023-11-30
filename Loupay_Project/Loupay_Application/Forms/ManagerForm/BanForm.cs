using System;
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
            test.Add("Còn trống", "Còn trống");
            test.Add("Bàn đang sử dụng", "Bàn đang sử dụng");
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

                }
            }
            catch { }
        }
    }
}
