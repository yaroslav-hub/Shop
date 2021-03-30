using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class MilkItem : IItem
    {
        public string ItemName => "milk";
        public string ItemCategory => "B";
        public int ItemPrice { get; set; }
        public MilkItem( int price )
        {
            ItemPrice = price;
        }
    }
}
