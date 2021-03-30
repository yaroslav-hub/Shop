using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public interface IShop
    {
        void DefineDiscounts( List<ItemDiscount> discounts );
        int Calculate( string inputString );
    }
}
