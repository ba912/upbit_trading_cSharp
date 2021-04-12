using System;
using System.Collections.Generic;
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
    }
}
