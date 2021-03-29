using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class WaterItem : IItem
    {
        public string ItemName => "water";
        public int ItemPrice { get; set; }
        public WaterItem( int price )
        {
            ItemPrice = price;
        }
    }
}
