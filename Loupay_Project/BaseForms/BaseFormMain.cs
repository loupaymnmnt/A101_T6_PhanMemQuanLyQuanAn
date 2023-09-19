using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace BaseForms
{
    /// <summary>
    /// Creating a 1100 x 600 Form
    /// </summary>
    public partial class BaseFormMain : KryptonForm
    {
        public BaseFormMain()
        {
            InitializeComponent();
        }

        public BaseFormMain(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void LockResizing()
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }
    }
}
