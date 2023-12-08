using Loupay_Service.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loupay_Component
{
    public partial class PickBan : Loupay_Component.BaseFormMain
    {
        public PickBan()
        {
            InitializeComponent();
            this.Load += PickBan_Load;
        }

        private void PickBan_Load(object sender, EventArgs e)
        {
            foreach (Ban b in CurrentTablePanel.TablesPanel.Bans)
            {
                if (b.TrangThai == "Trống")
                {
                    comboBox1.Items.Add(b.IDBan);
                }
            }
            this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CurrentTablePanel.TablesPanel.Bans.Find(i => i.IDBan == comboBox1.Text) != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Không đúng định dạng!");
            }
        }

        public string GetSelected()
        {
            return comboBox1.Text;
        }
    }
}
