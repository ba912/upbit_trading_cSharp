using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace wsHoldings.Function
{
    public class CommonFunction
    {
        public void setKeys()
        {
            XmlDocument xml = new XmlDocument();

            xml.Load(Application.StartupPath + @"\Config.xml");

            XmlNodeList xmlList = xml.SelectNodes("/config");

            foreach(XmlNode node in xmlList)
            {
                Config.config.ACCESS_KEY = node["ACCESS_KEY"].InnerText;
                Config.config.SECRET_KEY = node["SECRET_KEY"].InnerText;
            }
        }

        public DataTable getMonitoringList()
        {
            string filePath = Application.StartupPath + @"\\Monitoring.json";
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<DataTable>(jsonString);
        }
        
        public void setMonitoringList(string market, double rsiBuy, double rsiSell, double lossCut, double unitPrice)
        {
            DataTable list = getMonitoringList();

            DataRow[] rows = list.Select($"market = '{market}'");

            if(rows.Length > 0)
            {
                foreach(DataRow row in list.Rows)
                {
                    if(row["market"].ToString() == market)
                    {
                        row["rsiBuy"] = rsiBuy;
                        row["rsiSell"] = rsiSell;
                        row["lossCut"] = lossCut;
                        row["unitPrice"] = unitPrice;
                    }

                }
            }
            else
            {
                if(list.Rows.Count < 8)
                {
                    DataRow row = list.NewRow();
                    row["market"] = market;
                    row["rsiBuy"] = rsiBuy;
                    row["rsiSell"] = rsiSell;
                    row["lossCut"] = lossCut;
                    row["unitPrice"] = unitPrice;

                    list.Rows.Add(row);
                }
                
            }
            ConvertDatatableToJson(list);
        }

        public void ConvertDatatableToJson(DataTable table)
        {
            string filePath = Application.StartupPath + @"\\Monitoring.json";
            string json = JsonConvert.SerializeObject(table);
            File.WriteAllText(filePath, JValue.Parse(json).ToString(Newtonsoft.Json.Formatting.Indented));
        }
    }
}
