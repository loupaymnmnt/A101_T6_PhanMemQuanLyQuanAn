using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loupay_Service.Account;
using Loupay_Component.SubControl;
using Loupay_Component;

namespace Loupay_Application.Forms.MainForms
{
    public partial class MainForm : Loupay_Component.BaseFormMain
    {
        TablesPanel tablePanel = new TablesPanel();
        TableMainBoard board = new TableMainBoard();
        OrderPanel orderPanel = new OrderPanel();
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Tag = "FORM_2";
            ControlInit();
            ControlEventsInit();
        }

        private void ControlInit()
        {
            this.Text = Global.AppTitle;
            tablePanel.TableMainBoard = board;
            tablePanel.Top = 35;
            this.Controls.Add(tablePanel);
            board.Top = 55;
            board.Left = 795;
            this.Controls.Add(board);
            this.orderPanel.Top = 35;
            this.orderPanel.Left = tablePanel.Width + 5;
            this.Controls.Add(orderPanel);
        }

        private void ControlEventsInit()
        {

        }
    }
}
