using Syncfusion.XlsIO.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loupay_Service.Client.Forecasting
{
    public static class RevenueForecast
    {
        public static List<int> Get12MonthValue()
        {
            List<int> list = new List<int>();

            StreamReader reader = new StreamReader("data.csv");
            bool firstLine = true;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (firstLine == true)
                    firstLine = false;
                else
                {
                    list.Add(Convert.ToInt32(values[1]));
                }
            }
            return list;
        }

        public static int Get13thValue()
        {
            var result = MLModel.Predict();
            float x = result.Sale.Max();
            int e = Convert.ToInt32(x);
            return e;
        }
    }
}
