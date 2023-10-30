using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loupay_Component;
using Loupay_Component.SubControl;

namespace Loupay_Test
{
    public partial class TestForm : Loupay_Component.BaseFormMain
    {
        #region CONTROLS
        TablesPanel tablePanel = new TablesPanel();
        TableMainBoard board = new TableMainBoard();
        MenuStrip menuStrip = new MenuStrip();
        #endregion CONTROLS
        public TestForm()
        {
            InitializeComponent();
            this.Load += TestForm_Load;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.Text = Global.AppTitle;
            tablePanel.TableMainBoard = board;
            this.Controls.Add(menuStrip);
            tablePanel.Top = 35;
            this.Controls.Add(tablePanel);
            board.Top = 55;
            board.Left = 600;
            this.Controls.Add(board);
        }
    }
}
