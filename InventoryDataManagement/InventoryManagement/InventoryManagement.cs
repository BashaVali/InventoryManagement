using InventoryDataManagement.InventoryDataManagement;
using InventoryDataManagement.InventoryManagement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement.InventoryManagement
{
    public class InventoryManagements
    {
        public void ReadJSONFile(string file)
        {
            var json = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(json);
            List<Inventory> RiceList = inventories.Rice;
            Console.WriteLine("RICELIST :");
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
            Console.WriteLine("WHEATLIST");
            Display(WheatList);
            List<Inventory> PulsesList = inventories.Pulses;
            Console.WriteLine("PULSESLIST");
            Display(PulsesList);
        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine("Inventory Name: " + data.Name + "\n" + "Weight: " + data.Weight + "\n" + "Price Per Kg: " + data.PricePerKg + "\n" + "Total Price: " + data.Weight * data.PricePerKg);

            }
        }
    }
}