using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Toolkit;
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
        private string _id = string.Empty;
        private byte _seats = 0;
        public string Id { get => _id; set => _id = value; }
        public byte Seats { get => _seats; set => _seats = value; }


        #region CONTROLS
        KryptonLabel label = new KryptonLabel();
        #endregion CONTROLS

        public Table()
        {
            InitializeComponent();
            this.Load += Table_Load;
            this.MouseLeave += Table_MouseLeave;
            this.MouseHover += Table_MouseHover;
            this.MouseMove += Table_MouseHover;
            this.MouseEnter += Table_MouseHover;
        }

        private void Table_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
        }

        private void Table_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.BackColor = DefaultBackColor;
            this.label.StateCommon.ShortText.Font = new Font("Arial", 16, FontStyle.Bold);
            this.label.StateCommon.ShortText.Color1 = Color.Black;
            this.label.Text = "BÀN " + Id.ToString();
            this.Width = 110;
            this.Height = 110;
            this.BorderStyle = BorderStyle.FixedSingle;
            FormComponentSize.CenterChildControl(this.label, this);
            FormComponentSize.CenterChildControlVertical(this.label, this);
            this.Controls.Add(this.label);
        }
    }
}
