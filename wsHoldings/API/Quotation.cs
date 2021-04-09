using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsHoldings.API
{
    public class Quotation
    {
        public string getMarketList()
        {
            string url = "https://api.upbit.com/v1/market/all";
            return getRequest(url);
        }

        public string GetTicer(string marketCode)
        {
            string url = $"https://api.upbit.com/v1/ticker?markets={marketCode}";
            return getRequest(url);
        }

        private string getRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string result = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            return JValue.Parse(result).ToString(Formatting.Indented);
        }
    }
}
