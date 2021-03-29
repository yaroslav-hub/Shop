using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class ButterItem : IItem
    {
        public string ItemName => "butter";
        public int ItemPrice { get; set; }
        public ButterItem( int price )
        {
            ItemPrice = price;
        }
    }
}
