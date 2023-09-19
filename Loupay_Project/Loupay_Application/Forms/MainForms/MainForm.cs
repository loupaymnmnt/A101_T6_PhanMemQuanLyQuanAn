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
        public MainForm()
        {
            InitializeComponent();
            LockResizing();
        }
    }
}
