using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAPIScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var scraper = new Scraper();
            scraper.Start();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
