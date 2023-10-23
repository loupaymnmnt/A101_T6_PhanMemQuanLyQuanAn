using Loupay_Component.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loupay_Application.Forms.ActionForms
{
    public partial class ConfigurationForm : Loupay_Component.BaseFormMain
    {
        public ConfigurationForm()
        {
            InitializeComponent();
            this.Load += ConfigurationForm_Load;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            this.Tag = "FORM_1";
        }

        private void ControlInit()
        {
            throw new NotImplementedException();
        }

        private void ControlEventsInit()
        {
            throw new NotImplementedException();
        }
    }
}
