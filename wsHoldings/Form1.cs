﻿using Newtonsoft.Json;
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
        private CommonFunction commonFunction = new CommonFunction();
        public Form1()
        {
            InitializeComponent();
            commonFunction.setKeys();
            setMarketLookup();
            timer_1sce.Enabled = false;
            
            DataTable ticker = quotationFunction.allTicker();
            DataTable minCandle = quotationFunction.getMinCandle();
            DataTable account = exchangeFunction.getAccount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 1초단위 타이머
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_1sce_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 10분단위 타이머
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_10min_Tick(object sender, EventArgs e)
        {
            setMarketLookup();
        }
        /// <summary>
        /// 마켓 정보 API 호출 후 COMBO 바인딩
        /// </summary>
        private void setMarketLookup()
        {
            quotationFunction.InitializeMarketList();
            DataTable marketList = quotationFunction.getMarketList();

            cb_coin.DataSource = marketList;
            cb_coin.DisplayMember = "korean_name";
            cb_coin.ValueMember = "market";
        }

        private void getSaveList()
        {

        }
    }
}
