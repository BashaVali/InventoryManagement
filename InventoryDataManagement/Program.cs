using InventoryDataManagement.InventoryDataManagement;
using InventoryDataManagement.InventoryManagement;
using System;
namespace InventoryDataManagement
{
    class Program
    {
        static string jsonFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\InventoryDataManagement\Inventory.json";
        static string jsonDataFilePath = @"C:\Users\Basha\Documents\DotNet\PracticePrograms\InventoryManagement\InventoryDataManagement\InventoryManagement\InventoryData.json";
        static void Main(string[] args)
        {
            {
                InventoryManagements inventoryManager = new InventoryManagements();
                Console.WriteLine("Welcome to the Inventory Data Management Programs");
                bool flag = true;
                while (flag)
                {
                    
                    Console.WriteLine("Select 1.InventoryDataManagement 2.InventoryManagement  3.AddInventoryData 4.EditInventoryData 5.Exit");
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
                                flag = false;
                                break;
                        } 

                }
            }
        }
    }
}