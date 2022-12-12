using InventoryDataManagement.InventoryDataManagement;
using System;
namespace InventoryDataManagement
{
    class Program
    {
        static string jsonFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\InventoryDataManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            InventoryDetailManagement inventory = new InventoryDetailManagement();
            inventory.ReadJSONFile(jsonFilePath);
        }
    }
}
