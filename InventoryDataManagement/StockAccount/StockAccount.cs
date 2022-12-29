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
        double amount = 1000;
        List<StockDetails> Market;
        List<StockDetails> Customer;
        StockDetails stockList = new StockDetails();

        public void ReadMarketStockFile(string file)
        {
            var companyStockData = File.ReadAllText(file);
            Market = JsonConvert.DeserializeObject<List<StockDetails>>(companyStockData);
            foreach (var data in Market)
            {
                Console.WriteLine(data.Name + " " + data.NumberOfshares + " " + data.PricePerShare);
            }
        }
        public void ReadCustomerStockFile(string file)
        {
            var customerStockData = File.ReadAllText(file);
            Customer = JsonConvert.DeserializeObject<List<StockDetails>>(customerStockData);
            foreach (var data in Customer)
            {
                Console.WriteLine(data.Name + " " + data.NumberOfshares + " " + data.PricePerShare);
            }
        }
        public void BuyStock(string name)
        {  
            foreach (var data in Market)
            {
                int count = 0;
                if (data.Name.Equals(name))
                {
                    count++;

                    Console.WriteLine("Enter The Number Of Stocks You Need To Buy");
                    int noOfStocks = Convert.ToInt32(Console.ReadLine());
                    if (noOfStocks * data.PricePerShare <= amount && noOfStocks <= data.NumberOfshares)
                    {
                        StockDetails stock = new StockDetails();
                        {
                            stock.Name = data.Name;
                            stock.NumberOfshares = noOfStocks;
                            stock.PricePerShare = data.PricePerShare;
                        }
                        data.NumberOfshares -= noOfStocks;

                        foreach (var stocks in Customer.ToList())
                        {
                            if (stocks.Name.Equals(name))
                            {
                                count++;
                            }
                        }
                        if (count == 1)
                        {
                            Customer.Add(stock);
                        }
                    }
                }
            }
                   
        }
        public void WriteToCustomerJsonfile(string file)
        {
            var customerjson = JsonConvert.SerializeObject(Customer);
            File.WriteAllText(file, customerjson);
        }
        public void WriteToMarketJsonfile(string file)
        {
            var Marketjson = JsonConvert.SerializeObject(Market);
            File.WriteAllText(file, Marketjson);
        }

    }
}
