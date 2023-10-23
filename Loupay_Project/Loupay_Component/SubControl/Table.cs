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
        public string Id { get => _id; set => _id = value; }

        #region CONTROLS
        KryptonLabel label = new KryptonLabel();
        PictureBox pictureBox = new PictureBox();
        KryptonButton orderButton = new KryptonButton();
        KryptonButton payButton = new KryptonButton();
        #endregion CONTROLS

        public Table()
        {
            InitializeComponent();
            this.Load += Table_Load;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.label.Text = "BÀN XXX";
            FormComponentSize.CenterChildControl(this.label, this);
            this.Controls.Add(this.label);
            Image image = new Bitmap(Properties.Resources.diningTable, 80, 80);
            this.pictureBox.Image = image;
            this.pictureBox.Top = this.label.Height + 15;
            FormComponentSize.CenterChildControl(this.pictureBox, this);
            this.Controls.Add(this.pictureBox);
        }
    }
}
