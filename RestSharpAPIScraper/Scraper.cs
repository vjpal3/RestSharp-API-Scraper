using System;
using RestSharpAPIScraper.Services;

namespace RestSharpAPIScraper
{
    public class Scraper
    {
        
        public void Start()
        {
            string baseUrl = "https://financialmodelingprep.com/api/";
            var caller = new FinanceAPICaller(baseUrl);

            var stockData = caller.GetStockData();
            Console.WriteLine(stockData);
        }
    }
}