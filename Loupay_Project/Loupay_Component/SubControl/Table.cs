using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
using Loupay_Service.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component.SubControl
{
    public partial class Table : UserControl
    {
        private Ban ban;
        public Ban Ban { get => ban; set => ban = value; }

        #region CONTROLS
        KryptonLabel label = new KryptonLabel();
        #endregion CONTROLS

        public Table()
        {
            InitializeComponent();
            this.Load += Table_Load;
            this.MouseLeave += Table_MouseLeave;
            this.MouseMove += Table_MouseHover;
            this.MouseEnter += Table_MouseHover;
        }

        private void Table_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
        }

        private void Table_MouseHover(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Aqua)
                this.BackColor = Color.Aqua;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.BackColor = DefaultBackColor;
            this.label.StateCommon.ShortText.Font = new Font("Arial", 10, FontStyle.Bold);
            this.label.StateCommon.ShortText.Color1 = Color.Black;
            this.label.Width = 50;
            this.label.Text = "BÀN " + ban.IDBan.ToString();
            this.label.Enabled = false;
            this.Width = 70;
            this.Height = 50;
            this.BorderStyle = BorderStyle.FixedSingle;
            FormComponentSize.CenterChildControl(this.label, this);
            FormComponentSize.CenterChildControlVertical(this.label, this);
            this.Controls.Add(this.label);
        }
    }
}
