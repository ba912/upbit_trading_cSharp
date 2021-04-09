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
    }
}
