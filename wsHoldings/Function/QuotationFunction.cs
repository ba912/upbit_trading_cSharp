using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wsHoldings.API;

namespace wsHoldings.Function
{
    public class QuotationFunction
    {
        private Quotation quotation = new Quotation();
        private string marketPath = Application.StartupPath + @"\\Market.json";
        public void InitializeMarketList()
        {
            string marketList = quotation.getMarketList();
            File.WriteAllText(marketPath, marketList);
        }

        public DataTable getMarketList()
        {
            string market = File.ReadAllText(marketPath);
            return JsonConvert.DeserializeObject<DataTable>(market);
        }

        public DataTable allTicker()
        {
            string param = string.Empty;
            DataTable markets = getMarketList();
            string[] columns = markets.AsEnumerable().Select(r => r.Field<string>("market")).ToArray();
            param = String.Join(",", columns);
            return JsonConvert.DeserializeObject<DataTable>(quotation.GetTicer(param));
        }

        public DataTable getMinCandle()
        {
            DataTable table =  JsonConvert.DeserializeObject<DataTable>(quotation.getMincandle("KRW-BTC"));
            table.Columns.Add("Up", typeof(double));
            table.Columns.Add("Down", typeof(double));
            table.Columns.Add("AU", typeof(double));
            table.Columns.Add("AD", typeof(double));
            table.Columns.Add("RSI", typeof(double));

            double upSum = 0;
            double downSum = 0;
            for(int i=table.Rows.Count-1; i>=0; i--)
            {
                if (i == table.Rows.Count - 1) continue;

                double diff = Convert.ToDouble(table.Rows[i]["trade_price"]) - Convert.ToDouble(table.Rows[i + 1]["trade_price"]);

                DataRow row = table.Rows[i];
                row["Up"] = diff > 0 ? diff : 0;
                row["Down"] = diff < 0 ? (diff * -1) : 0;

                if(i > table.Rows.Count - 15)
                {
                    upSum += Convert.ToDouble(table.Rows[i]["Up"]);
                    downSum += Convert.ToDouble(table.Rows[i]["Down"]);
                }

                else if(i == table.Rows.Count -15)
                {
                    upSum += Convert.ToDouble(table.Rows[i]["Up"]);
                    downSum += Convert.ToDouble(table.Rows[i]["Down"]);

                    table.Rows[i]["AU"] = upSum;
                    table.Rows[i]["AD"] = downSum;
                }

                else
                {
                    double curAu = Convert.ToDouble(table.Rows[i]["Up"]);
                    double preAu = Convert.ToDouble(table.Rows[i + 1]["AU"]);
                    double curAd = Convert.ToDouble(table.Rows[i]["Down"]);
                    double preAd = Convert.ToDouble(table.Rows[i + 1]["AD"]);

                    table.Rows[i]["AU"] = ((preAu * 13) + curAu) / 14;
                    table.Rows[i]["AD"] = ((preAd * 13) + curAd) / 14;

                    double au = Convert.ToDouble(table.Rows[i]["AU"]);
                    double ad = Convert.ToDouble(table.Rows[i]["AD"]);
                    table.Rows[i]["RSI"] = au / (au + ad) * 100;
                }
            }

            return table;
        }
    }
}
