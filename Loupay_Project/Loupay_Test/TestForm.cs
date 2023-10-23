using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loupay_Component.SubControl;

namespace Loupay_Test
{
    public partial class TestForm : Loupay_Component.BaseFormMain
    {
        #region CONTROLS
        Table t = new Table();
        #endregion CONTROLS
        public TestForm()
        {
            InitializeComponent();
            this.Load += TestForm_Load;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(t);
        }
    }
}
