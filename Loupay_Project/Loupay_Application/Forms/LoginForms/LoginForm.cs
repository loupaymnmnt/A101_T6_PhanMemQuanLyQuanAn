using ComponentFactory.Krypton.Toolkit;
using Loupay_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loupay_Application.Forms.LoginForms
{
    public partial class LoginForm : BaseForms.BaseFormMain
    {
        PictureBox pictureBox = new PictureBox();
        KryptonLabel label_Username = new KryptonLabel();
        KryptonLabel label_Password = new KryptonLabel();
        KryptonTextBox tBox_Username = new KryptonTextBox();
        KryptonTextBox tBox_Password = new KryptonTextBox();
        KryptonButton btn_Login = new KryptonButton();
        KryptonButton btn_Config = new KryptonButton();

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Size = BaseForms.FormSize.LoginFormSize();
            this.pictureBox.Image = Resources.loupaybanner;
            this.pictureBox.Size = Resources.loupaybanner.Size;

            this.tBox_Username.Size = this.tBox_Password.Size = BaseForms.FormComponentSize.RegularTextBox();
            
            this.tBox_Username.Top = this.pictureBox.Height + 35;
            BaseForms.FormComponentSize.CenterChildControl(this.tBox_Username, this);
            this.label_Username.Text = "Tên tài khoản";
            this.label_Username.Top = this.tBox_Username.Top - this.label_Username.Height + 5;


            this.tBox_Password.Top = this.tBox_Username.Top + this.tBox_Username.Height + 30;
            this.tBox_Password.PasswordChar = '•';
            BaseForms.FormComponentSize.CenterChildControl(this.tBox_Password, this);
            this.label_Password.Text = "Mật khẩu";
            this.label_Password.Top = this.tBox_Password.Top - this.label_Password.Height + 5;

            this.btn_Login.Top = this.tBox_Password.Top + this.tBox_Password.Height + 30;
            this.btn_Login.Size = BaseForms.FormComponentSize.RegularButton();
            this.btn_Login.Text = "Đăng nhập";
            BaseForms.FormComponentSize.CenterChildControl(this.btn_Login, this);

            this.Controls.Add(label_Username);
            this.Controls.Add(tBox_Username);
            this.Controls.Add(label_Password);
            this.Controls.Add(tBox_Password);
            this.Controls.Add(btn_Login);
            this.Controls.Add(pictureBox);
        }
    }
}
