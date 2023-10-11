﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForms
{
    /// <summary>
    /// Get all defined Form Component Size of BaseFormMain inherited forms. Author: deethesaint
    /// </summary>
    public static class FormComponentSize
    {
        /// <summary>
        /// Return new Size for TextBox with Width: 320
        /// </summary>
        /// <returns></returns>
        public static Size RegularTextBox()
        {
            return new Size(320, 0);
        }

        public static Size RegularButton()
        {
            return new Size(85, 40);
        }

        public static void CenterChildControl(Control child, Control parent)
        {
            child.Left = (parent.Width - child.Width) / 2 - 10;
        }
    }
}
