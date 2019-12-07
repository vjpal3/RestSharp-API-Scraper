using System;
using System.Collections.Generic;
using RestSharpAPIScraper.Models;
using RestSharpAPIScraper.Services;

namespace RestSharpAPIScraper
{
    public class Scraper
    {
        private List<StockData> mostActiveStocks;

        public void Start()
        {
            string baseUrl = "https://financialmodelingprep.com/api/";
            var caller = new FinanceAPICaller(baseUrl);

            mostActiveStocks = caller.GetStockData();
            Display();
            SaveData();
        }

        private void SaveData()
        {
            DbWriter.InsertStocksData(mostActiveStocks);
        }

        private void Display()
        {
            foreach (var stockdata in mostActiveStocks)
            {
                Console.Write(stockdata.CompanyName + "\t");
                Console.Write(stockdata.Symbol + "\t");
                Console.Write(stockdata.Price + "\t");
                Console.Write(stockdata.Change + "\t");
                Console.Write(stockdata.PercentChange + "\t");

                Console.WriteLine();
            }
        }
    }
}