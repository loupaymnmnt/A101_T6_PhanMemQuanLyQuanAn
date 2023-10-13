using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loupay_Application.Forms.MainForms
{
    public partial class MainForm : BaseForms.BaseFormMain
    {
        ContextMenuStrip menuStrip = new ContextMenuStrip();
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ControlInit();
            ControlEventsInit();
        }

        private void ControlInit()
        {
            this.ContextMenuStrip = this.menuStrip;
            this.menuStrip.Name = "hehe";
            this.menuStrip.Show();
        }

        private void ControlEventsInit()
        {

        }
    }
}
