using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wsHoldings.API;
using wsHoldings.Function;

namespace wsHoldings
{
    public partial class Form1 : Form
    {
        private QuotationFunction quotationFunction = new QuotationFunction();
        private ExchangeFunction exchangeFunction = new ExchangeFunction();
        public Form1()
        {
            InitializeComponent();
            quotationFunction.InitializeMarketList();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable marketList = quotationFunction.getMarketList();
            DataTable ticker = quotationFunction.allTicker();
            DataTable table = quotationFunction.getMinCandle();
            DataTable account = exchangeFunction.getAccount();
        }
    }
}
