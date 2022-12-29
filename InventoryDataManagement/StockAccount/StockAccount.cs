using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement.StockAccounts
{
    public class StockAccount
    {
        List<StockDetails> Market;
        List<StockDetails> Customer;

        public void ReadMarketStockFile(string file)
        {
            var MarketStockData = File.ReadAllText(file);
            Market = JsonConvert.DeserializeObject<List<StockDetails>>(MarketStockData);
            PrintStockReport(Market);
        }
        public void ReadCustomerStockFile(string file)
        {
            var customerStockData = File.ReadAllText(file);
            Customer = JsonConvert.DeserializeObject<List<StockDetails>>(customerStockData);
            PrintStockReport(Customer);
        }
        private static void PrintStockReport(List<StockDetails> stock)
        {
            foreach (var data in stock)
            {
                Console.WriteLine("\nStock Name: " + data.Name + "\n" + "Number of Shares: " + data.NumberOfshares + "\n" + "PricePerShare: " + data.PricePerShare + "\n" + "Total Stock Price: " + data.NumberOfshares * data.PricePerShare);
            }

        }
    }
}