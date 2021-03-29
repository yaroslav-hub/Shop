using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class BreadItem : IItem
    {
        public string ItemName => "bread";
        public int ItemPrice { get; set; }
        public BreadItem( int price )
        {
            ItemPrice = price;
        }
    }
}
