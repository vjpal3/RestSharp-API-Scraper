using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestSharpAPIScraper.Models
{
    class StockData
    {
        public int Id { get; set; }
        public DateTime ScrapeDate { get; set; }

        [JsonProperty("ticker")]
        public string Symbol { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("changes")]
        public decimal? Change { get; set; }

        [JsonProperty("changesPercentage")] 
        public string PercentChange { get; set; }
    }
}
