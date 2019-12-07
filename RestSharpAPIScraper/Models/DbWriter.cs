using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAPIScraper.Models
{
    class DbWriter
    {
        public static void InsertStocksData(List<StockData> mostActiveStocks)
        {
            using (var db = new AppDbContext())
            {
                foreach (var stockData in mostActiveStocks)
                {
                    db.Add(new StockData
                    {
                        ScrapeDate = DateTime.Now,
                        Symbol = stockData.Symbol,
                        CompanyName = stockData.CompanyName,
                        Price = stockData.Price,
                        Change = stockData.Change,
                        PercentChange = stockData.PercentChange
                    });

                }
                db.SaveChanges();
            }
        }
    }
}
