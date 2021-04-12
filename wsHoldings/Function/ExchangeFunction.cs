using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wsHoldings.API;

namespace wsHoldings.Function
{
    class ExchangeFunction
    {
        private Exchange exchange = new Exchange();

        public DataTable getAccount()
        {
            return JsonConvert.DeserializeObject<DataTable>(exchange.getAccount());
        }
    }
}
