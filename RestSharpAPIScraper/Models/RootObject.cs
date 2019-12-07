using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestSharpAPIScraper.Models
{
    class RootObject
    {
        [JsonProperty("mostActiveStock")]
        public List<StockData> MostActiveStocks { get; set; }
    }
}
