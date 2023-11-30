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
using Loupay_Service.Database;
using Loupay_Application.Forms.ManagerForm;

namespace Loupay_Application.Forms.MainForms
{
    public partial class MainForm : Loupay_Component.BaseFormMain
    {
        TablesPanel tablePanel;
        OrderPanel orderPanel;
        TableMainBoard board = new TableMainBoard();

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
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
            tablePanel = new TablesPanel(DatabaseHandler.GetAllBan());
            tablePanel.TableMainBoard = board;
            tablePanel.Top = 35;
            this.Controls.Add(tablePanel);
            board.Top = 35;
            board.Left = 795;
            this.Controls.Add(board);
            orderPanel = new OrderPanel(DatabaseHandler.GetAllMon());
            this.orderPanel.Top = 35;
            this.orderPanel.Left = tablePanel.Width + 5;
            this.Controls.Add(orderPanel);
        }

        private void ControlEventsInit()
        {

        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienForms form = new NhanVienForms();
            form.ShowDialog();
        }
    }
}
