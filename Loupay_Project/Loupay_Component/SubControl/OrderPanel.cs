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
    public partial class OrderPanel : UserControl
    {
        KryptonLabel tableNameLabel = new KryptonLabel();
        KryptonTextBox tableNameTextBox = new KryptonTextBox();
        KryptonLabel prodNameLabel = new KryptonLabel();
        KryptonTextBox prodNameTextBox = new KryptonTextBox();
        KryptonButton orderButton = new KryptonButton();
        DishListBox dishListBox = new DishListBox();

        public OrderPanel()
        {
            InitializeComponent();
            this.Load += OrderPanel_Load;
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {
            ControlInit();
        }

        private void ControlInit()
        {
            this.Height = 515;
            this.Width = 470;
            this.BorderStyle = BorderStyle.Fixed3D;
            tableNameLabel.Text = "Bàn";
            prodNameLabel.Text = "Món";
            orderButton.Text = "Đặt";
            tableNameTextBox.Width = 250;
            prodNameTextBox.Width = 250;
            tableNameLabel.Left = 10;
            tableNameLabel.Top = 10;
            tableNameTextBox.Left = 70;
            tableNameTextBox.Top = 10;
            prodNameLabel.Left = 10;
            prodNameLabel.Top = 40;
            prodNameTextBox.Left = 70;
            prodNameTextBox.Top = 40;
            orderButton.Top = 70;
            dishListBox.Top = 100;
            dishListBox.Left = 2;
            FormComponentSize.CenterChildControl(orderButton, this);
            this.Controls.Add(tableNameLabel);
            this.Controls.Add(tableNameTextBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(prodNameTextBox);
            this.Controls.Add(orderButton);
            
            this.Controls.Add(dishListBox);
        }

        private void ControlEventsInit()
        {

        }
    }
}
