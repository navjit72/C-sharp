using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Lab_Csharp.Business
{
    public class InventoryItem
    {
        public string ItemNum { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public InventoryItem() { }

        public InventoryItem(string itemNum, string desc, decimal cost)
        {
            ItemNum = itemNum;
            Description = desc;
            Price = cost;
        }

        public string DisplayData(string sep)
        {
            return ItemNum + sep + Price.ToString("c") + sep + Description;
        }
        
        public string DisplayData()
        {
            return ItemNum + " " + Price.ToString("c") + " " + Description;
        }
    }
}
