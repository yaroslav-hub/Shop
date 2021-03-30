using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLib
{
    public class GroceryShop : IShop
    {
        private List<IDiscount> _definedDiscounts;
        private List<IItem> _inStockItems;
        public GroceryShop( List<IItem> items )
        {
            _inStockItems = items;
        }
        public void DefineDiscounts( List<IDiscount> discounts )
        {
            _definedDiscounts = discounts;
        }
        public int Calculate( string inputString )
        {
            inputString = inputString.ToLower();
            string[] itemsList = inputString.Split( ',' );
            int total = 0;
            for ( int i = 0; i < itemsList.Length; i++ )
            {
                string itemName = itemsList[i].Trim();
                IItem item = _inStockItems.Find( x => x.ItemName == itemName );
                if ( item == null )
                {
                    Console.WriteLine( $"Unfortunately we do not have { itemName }!" );
                }
                else
                {
                    total += item.ItemPrice;
                    IDiscount discount = _definedDiscounts.Find( x => x.ItemsCategory == item.ItemCategory );
                    if ( discount != null )
                    {
                        total -= discount.Amount;
                    }
                }
            }

            return total;
        }
    }
}
