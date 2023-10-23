using ComponentFactory.Krypton.Toolkit;
using Loupay_Application.Forms.MainForms;
using Loupay_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loupay_Service.Account;
using Loupay_Service.Security;

namespace Loupay_Application.Forms.LoginForms
{
    public partial class LoginForm : Loupay_Component.BaseFormMain
    {
        #region CONTROLS
        PictureBox pictureBox = new PictureBox();
        KryptonLabel label_Username = new KryptonLabel();
        KryptonLabel label_Password = new KryptonLabel();
        KryptonTextBox tBox_Username = new KryptonTextBox();
        KryptonTextBox tBox_Password = new KryptonTextBox();
        KryptonButton btn_Login = new KryptonButton();
        KryptonButton btn_Config = new KryptonButton();
        #endregion CONTROLS

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Tag = "FORM_0";
            ControlInit();
            ControlEventsInit();
        }

        private void ControlInit()
        {
            this.Text = "Đăng nhập hệ thống";

            this.Size = Loupay_Component.FormSize.LoginFormSize();
            this.pictureBox.Image = Resources.loupaybanner;
            this.pictureBox.Size = Resources.loupaybanner.Size;

            this.tBox_Username.Size = this.tBox_Password.Size = Loupay_Component.FormComponentSize.RegularTextBox();

            this.tBox_Username.Top = this.pictureBox.Height + 35;
            Loupay_Component.FormComponentSize.CenterChildControl(this.tBox_Username, this);
            this.label_Username.Text = "Tên tài khoản";
            this.label_Username.Top = this.tBox_Username.Top - this.label_Username.Height + 5;


            this.tBox_Password.Top = this.tBox_Username.Top + this.tBox_Username.Height + 30;
            this.tBox_Password.PasswordChar = '•';
            Loupay_Component.FormComponentSize.CenterChildControl(this.tBox_Password, this);
            this.label_Password.Text = "Mật khẩu";
            this.label_Password.Top = this.tBox_Password.Top - this.label_Password.Height + 5;

            this.btn_Login.Top = this.tBox_Password.Top + this.tBox_Password.Height + 30;
            this.btn_Login.Size = Loupay_Component.FormComponentSize.RegularButton();
            this.btn_Login.Text = "Đăng nhập";
            Loupay_Component.FormComponentSize.CenterChildControl(this.btn_Login, this);

            this.btn_Config.Size = Loupay_Component.FormComponentSize.SmallWideButton();
            this.btn_Config.Top = this.Height - this.btn_Config.Height - 50;
            this.btn_Config.Left = this.Width - this.btn_Config.Width - 30;
            this.btn_Config.Text = "Cài đặt kết nối";

            this.Controls.Add(label_Username);
            this.Controls.Add(tBox_Username);
            this.Controls.Add(label_Password);
            this.Controls.Add(tBox_Password);
            this.Controls.Add(btn_Login);
            this.Controls.Add(btn_Config);
            this.Controls.Add(pictureBox);
        }

        private void ControlEventsInit()
        {
            this.btn_Login.Click += Btn_Login_Click;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            LoginProcessing process = new LoginProcessing();
            LoginResult result = process.Process(tBox_Username.Text, tBox_Password.Text);

            if (result == LoginResult.FAILED)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
            }
            else if (result == LoginResult.DISABLED)
            {
                MessageBox.Show("Tài khoản bị khóa!");
            }
            else
            {
                Program.mainForm = new MainForm();
                Program.mainForm.Show();
                this.Visible = false;
            }
        }
    }
}
