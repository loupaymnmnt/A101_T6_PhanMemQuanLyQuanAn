using ComponentFactory.Krypton.Toolkit;
using Loupay_Service.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component.SubControl
{
    public partial class Dish : UserControl
    {
        PictureBox pictureBox = new PictureBox();
        KryptonLabel dishIdLabel = new KryptonLabel();
        KryptonLabel dishPriceLabel = new KryptonLabel();
        KryptonLabel dishNameLabel = new KryptonLabel();
        KryptonLabel dishIdLabelMain = new KryptonLabel();
        KryptonLabel dishPriceLabelMain = new KryptonLabel();
        KryptonLabel dishNameLabelMain = new KryptonLabel();

        private Mon mon;

        public Mon Mon { get => mon; set => mon = value; }

        public Dish()
        {
            InitializeComponent();
            this.Load += Dish_Load;
        }

        private void Dish_Load(object sender, EventArgs e)
        {
            ControlInit();
            ControlEventsInit();
        }

        private void ControlInit()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Width = 445;
            this.Height = 75;
            pictureBox.Top = 0;
            pictureBox.Size = new Size(75, 75);
            pictureBox.Image = new Bitmap(Properties.Resources.noimage, new Size(75, 75));
            this.Controls.Add(pictureBox);
            dishIdLabel.Text = "Mã món";
            dishNameLabel.Text = "Tên món";
            dishPriceLabel.Text = "Giá món";

            dishIdLabel.Top = 5;
            dishNameLabel.Top = 5;
            dishPriceLabel.Top = 5;

            dishIdLabelMain.Top = 30;
            dishNameLabelMain.Top = 30;
            dishPriceLabelMain.Top = 30;
            dishIdLabelMain.MaximumSize = new Size(70, 0);
            dishNameLabelMain.MaximumSize = new Size(150, 0);
            dishPriceLabelMain.MaximumSize = new Size(80, 0);
            dishIdLabelMain.AutoSize = true;
            dishNameLabelMain.AutoSize = true;
            dishPriceLabelMain.AutoSize = true;
            dishIdLabelMain.StateCommon.ShortText.Color1 = Color.BlueViolet;
            dishNameLabelMain.StateCommon.ShortText.Color1 = Color.BlueViolet;
            dishPriceLabelMain.StateCommon.ShortText.Color1 = Color.Red;

            dishIdLabel.Left = 80;
            dishNameLabel.Left = 150;
            dishPriceLabel.Left = 300;
            dishIdLabelMain.Left = 80;
            dishNameLabelMain.Left = 150;
            dishPriceLabelMain.Left = 300;
            this.Controls.Add(dishIdLabel);
            this.Controls.Add(dishNameLabel);
            this.Controls.Add(dishPriceLabel);
            this.Controls.Add(dishIdLabelMain);
            this.Controls.Add(dishNameLabelMain);
            this.Controls.Add(dishPriceLabelMain);
        }

        private void ControlEventsInit()
        {

        }

        public void SetId(string id)
        {
            dishIdLabelMain.Text = id;
        }
        public void SetName(string name)
        {
            dishNameLabelMain.Text = name;
        }

        public void SetPrice(string priceString)
        {
            dishPriceLabelMain.Text = priceString + "đ";
        }
    }
}
