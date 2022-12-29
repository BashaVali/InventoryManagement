using InventoryDataManagement.InventoryDataManagement;
using InventoryDataManagement.InventoryManagement;
using InventoryDataManagement.StockAccounts;
using Newtonsoft.Json;
using StockManagement;
using System;
namespace InventoryDataManagement
{
    class Program
    {
        static string jsonFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\InventoryDataManagement\Inventory.json";
        static string jsonDataFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\InventoryManagement\InventoryData.json";
        static string customerPath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\StockAccount\Customer.json";
        static string MarketPath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\StockAccount\Market.json";
        //getting path of json file 
        static void Main(string[] args)
        {
            //Creating obj for StockManager
            StockManager stockManager = new StockManager();
            //getting path of json file
            string file = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\StockManagement\Stock.json";
            //DeserializeO Json file
            StockUtility stockUtility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(file));
            var fs = stockUtility.stocksList;
            {
                InventoryManagements inventoryManager = new InventoryManagements();
                Console.WriteLine("Welcome to the Inventory Data Management Programs");
                bool flag = true;
                while (flag)
                {
                    
                    Console.WriteLine("***Select Options:*** \n1.InventoryDataManagement \n2.InventoryManagement  \n3.AddInventoryData \n4.EditInventoryData \n5.DeleteInventoryData \n6.WriteToJsonFile \n7 StockDataManagement \n8.AddStock \n9.DeleteStock \n10.StockAccount \n11.Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                            case 1:
                                InventoryDetailManagement inventory = new InventoryDetailManagement();
                                inventory.ReadJSONFile(jsonFilePath);
                                break;
                            case 2:
                                inventoryManager.ReadJSONFile(jsonDataFilePath);
                                inventoryManager.Displayy();
                                break;
                            case 3:
                                inventoryManager.AddInventoryData();
                                break;
                            case 4:
                                inventoryManager.EditInventoryData();
                                break;
                            case 5:
                                inventoryManager.DeleteInventoryData();
                                break;
                            case 6:
                                inventoryManager.WriteToJsonFile(jsonDataFilePath);
                                break;
                            case 7:
                                stockManager.DisplayStocks(fs);
                                break;
                            case 8:
                                stockManager.AddStock(fs);
                                stockManager.DisplayStocks(fs);
                                break;
                            case 9:
                                stockManager.DeleteInventory(fs);
                                File.WriteAllText(file, JsonConvert.SerializeObject(stockUtility));
                                stockManager.DisplayStocks(fs);
                                break;
                           case 10:
                                StockAccount stockAccount = new StockAccount();
                                stockAccount.ReadMarketStockFile(customerPath);
                                stockAccount.ReadCustomerStockFile(MarketPath);
                                break; 
                           case 11:
                                flag = false;
                                break;
                    } 
                }
            }
        }
    }
}
