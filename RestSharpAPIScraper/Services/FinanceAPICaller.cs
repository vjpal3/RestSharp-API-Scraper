using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

using RestSharpAPIScraper.Models;

namespace RestSharpAPIScraper.Services
{
    class FinanceAPICaller
    {
        private RestClient client;
        
        public FinanceAPICaller(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }

        public List<StockData> GetStockData()
        {
            var request = new RestRequest("v3/stock/actives", Method.GET);
            var response = client.Execute<RootObject>(request);
            var root = JsonConvert.DeserializeObject<RootObject>(response.Content);
            var mostActiveStocks = root.MostActiveStocks;
            return mostActiveStocks;
        }
    }
}
