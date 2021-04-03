using System;
using System.Collections.Generic;
using ShopLib;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IItem> items = new()
            {
                new DefineItem( "milk", "A", 60 ),
                new DefineItem( "water", "A", 20 ),
                new DefineItem( "bread", "B", 50 )
            };
            IShop myShop = new GroceryShop( items );
            List<ItemDiscount> discounts = new()
            {
                new ItemDiscount
                {
                    ItemsCategory = "A",
                    AmountPercentage = 33
                },
                new ItemDiscount
                {
                    ItemsCategory = "C",
                    AmountPercentage = 15
                }
            };
            myShop.DefineDiscounts( discounts );
            int total = myShop.Calculate( "milk, BrEad, water, butter" );
            Console.WriteLine( $"Your total price: { total } rubles." );
        }
    }
}
