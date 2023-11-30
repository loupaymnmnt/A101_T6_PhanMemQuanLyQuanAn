using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loupay_Service;
using ComponentFactory.Krypton.Toolkit;
using Loupay_Service.Database;

namespace Loupay_Application.Forms.ManagerForm
{
    public partial class NhanVienForms : Loupay_Component.BaseFormMain
    {
        string nameImage = "";
        List<ThongTinNguoiDung> lstTTND;

        public NhanVienForms()
        {
            InitializeComponent();
            CenterToScreen();

        }

        void LoadCBOGT()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Nam", "Nam");
            test.Add("Nữ", "Nữ");
            cboGT.DataSource = new BindingSource(test, null);
           
            cboGT.DisplayMember = "Key";
            cboGT.ValueMember = "Key";

        }

        void LoadDGVNhanVien()
        {
            lstTTND = DatabaseHandler.GetAllThongTinNguoiDung();
            dgvNhanVien.DataSource = lstTTND;
            dgvNhanVien.Columns["NguoiDung"].Visible = false;
        }
        bool CheckDataInput()
        {
            foreach (Control txt in gbNhanVien.Panel.Controls)
            {
                if (txt is KryptonTextBox)
                {
                    if (string.IsNullOrEmpty(txt.Text.Trim()))
                    {
                        return false;
                    }

                }
            }






            return true;

        }

        bool CheckPrimaryKey()
        {
            NguoiDung ng = DatabaseHandler.GetNguoiDung(txtID.Text.Trim());
            if (ng == null)
            {
                return true;

            }
            return false;
        }
        void LoadNameimage()
        {
            string pathApplication = Application.StartupPath;
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Images\\" + nameImage;
            pbImage.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);

        }
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckDataInput() == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
                }
                else {
                    if (CheckPrimaryKey())
                    {

                        NguoiDung nd = new NguoiDung();
                        nd.IDNguoiDung = txtID.Text.Trim();
                        


                        ThongTinNguoiDung ttnd = new ThongTinNguoiDung();
                        ttnd.IDNguoiDung = txtID.Text.Trim();
                        ttnd.HoTen = txtName.Text.Trim();
                        ttnd.DiaChi = txtAddress.Text.Trim();
                        ttnd.Email = txtEmail.Text.Trim();
                        ttnd.SoDienThoai = txtPhone.Text.Trim();
                        ttnd.GioiTinh = cboGT.SelectedItem.ToString();
                        ttnd.NgaySinh = dtpBorn.Value.Date;
                        ttnd.CanCuocCD = txtCCCD.Text.Trim();
                        ttnd.FileAnh = nameImage;
                        
                        //Save image
                        if (!String.IsNullOrEmpty(nameImage))
                        {
                            string pathApplication = Application.StartupPath;
                            string[] s = { "\\bin" };
                            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Images\\" + nameImage;
                            pbImage.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        
                        MessageBox.Show("Thêm người dùng thành công");
                       

                        DatabaseHandler.InsertNguoiDung(nd);
                        DatabaseHandler.InsertThongTinNguoiDung(ttnd);
                    }
                    else {
                        MessageBox.Show("Người dùng này đã tồn tại");
                    }
                }

            }
            catch {
                MessageBox.Show("Thêm người dùng thất bại");

            }
        }

        private void pageNV_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.bmp,*.png;)|*.jpg;*.jpeg;*.bmp;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = new Bitmap(opnfd.FileName);
                string imgPath = opnfd.FileName;
                nameImage = imgPath.Substring(imgPath.LastIndexOf('\\') + 1);

                
            }   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            try {
                if (!String.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    DatabaseHandler.DeleteThongTinNguoiDung(txtID.Text.Trim());
                    MessageBox.Show("Xóa thông tin nhân viên thành công");
                    LoadDGVNhanVien();
                }
                else {
                    MessageBox.Show("Vui lòng chọn nhân viên");

                }
                
            
            }
            catch { }
        }

        private void pageNV_Load(object sender, EventArgs e)
        {
            LoadCBOGT();
            LoadDGVNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txtID.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                cboGT.SelectedValue = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                dtpBorn.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells[6].Value.ToString());
                txtCCCD.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                if ((String)dgvNhanVien.CurrentRow.Cells[8].Value != String.Empty || (String)dgvNhanVien.CurrentRow.Cells[8].Value != null)
                {
                    nameImage = (String)dgvNhanVien.CurrentRow.Cells[8].Value;
                    string pathApplication = Application.StartupPath;
                    string[] s = { "\\bin" };
                    string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Images\\" + nameImage;
                    pbImage.Image = new Bitmap(path);
                }
                else {
                    nameImage = null;
                    pbImage.Image = null;
                }
                

                

            } catch { }
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            try {


                if (!String.IsNullOrEmpty(txtID.Text.Trim()))
                {
                    ThongTinNguoiDung ttnd = new ThongTinNguoiDung();
                    ttnd.IDNguoiDung = txtID.Text.Trim();
                    ttnd.HoTen = txtName.Text.Trim();
                    ttnd.DiaChi = txtAddress.Text.Trim();
                    ttnd.Email = txtEmail.Text.Trim();
                    ttnd.SoDienThoai = txtPhone.Text.Trim();
                    ttnd.GioiTinh = cboGT.SelectedValue.ToString();
                    ttnd.NgaySinh = dtpBorn.Value.Date;
                    ttnd.CanCuocCD = txtCCCD.Text.Trim();
                    ttnd.FileAnh = nameImage;

                    DatabaseHandler.SuaThongTinNguoiDung(ttnd);
                    MessageBox.Show("Cập nhập thông tin nhân viên thành công");
                    LoadDGVNhanVien();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa");

                }
            } catch { 
            
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            try {

                nameImage = "";
                pbImage.Image = null;


            }
            catch{}
        }
    }
}
