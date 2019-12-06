using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestSharpAPIScraper.Services
{
    class FinanceAPICaller
    {
        private RestClient client;
        
        public FinanceAPICaller(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }

        public string GetStockData()
        {
            var request = new RestRequest("v3/stock/actives", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
