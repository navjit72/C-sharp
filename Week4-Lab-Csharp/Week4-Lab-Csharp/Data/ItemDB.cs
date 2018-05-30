using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_Lab_Csharp.Business;

namespace Week4_Lab_Csharp.Data
{
    public class ItemDB
    {
        private static List<InventoryItem> ItemList = new List<InventoryItem>()
        {
            new InventoryItem("CS12","Csharp",54.5m),
            new InventoryItem("A4CS","Asp.NET",57.5m),
            new InventoryItem("SQ12","SQL Server",52.3m)
        };

        public static List<InventoryItem> GetData()
        {
            return ItemList;
        }

        public static void SaveData(List<InventoryItem> list)
        {
            ItemList = list;
        }
    }
}
