using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class DefineItem : IItem
    {
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public int ItemPrice { get; set; }
        public DefineItem( string name, string category, int price )
        {
            ItemName = name;
            ItemCategory = category;
            ItemPrice = price;
        }
    }
}
