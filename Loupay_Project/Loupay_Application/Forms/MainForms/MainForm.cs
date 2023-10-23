using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loupay_Service.Account;

namespace Loupay_Application.Forms.MainForms
{
    public partial class MainForm : Loupay_Component.BaseFormMain
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Tag = "FORM_2";
            ControlInit();
            ControlEventsInit();
        }

        private void ControlInit()
        {
            
        }

        private void ControlEventsInit()
        {

        }
    }
}
