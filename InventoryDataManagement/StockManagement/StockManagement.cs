using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StockManagement.StockUtility;

namespace StockManagement
{
    class StockManager
    {
        int totalshare;
        //Display Stock Details
        public void DisplayStocks(List<StockUtility.Stocks> stocksList)
        {
            Console.WriteLine("**********DISPLAYING STOCK DETAILS**************");
            foreach (var i in stocksList)
            {
                Console.WriteLine("Stock name is: {0} \nStock share is: {1} \nStock Price is: {2}", i.StockName, i.shares, i.Price);
                int temp = i.shares * i.Price;
                totalshare += temp;
                Console.WriteLine("Total stock price for {0} is : {1}", i.StockName, temp);
            }
            Console.WriteLine("Total store is : {0}", totalshare);

        }
    }
}
