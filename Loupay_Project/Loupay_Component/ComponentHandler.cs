using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component
{
    public static class ComponentHandler
    {
        public static void SetEnabled(bool value, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = value;
            }
        }

        public static void SetText(string text, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Text = text;
            }
        }
    }
}
