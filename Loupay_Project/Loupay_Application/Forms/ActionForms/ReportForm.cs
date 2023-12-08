using Loupay_Service.Client.Forecasting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Loupay_Application.Forms.ActionForms
{
    public partial class ReportForm : Loupay_Component.BaseFormMain
    {
        public ReportForm()
        {
            InitializeComponent();


            this.Load += ReportForm_Load;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            List<int> dt = RevenueForecast.Get12MonthValue();
            Series sr = new Series("Doanh thu thực");
            this.chart1.Series.Clear();
            foreach (int i in dt)
            {
                sr.Points.Add(i, 100000000);
            }
            sr.Points.Add(RevenueForecast.Get13thValue(), 100000000);
            sr.Points[dt.Count].Color = Color.Orange;
            this.chart1.Series.Add(sr);
            this.chart1.Series.Add("Doanh thu dự báo");
        }
    }
}
