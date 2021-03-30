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
                new MilkItem( 60 ),
                new WaterItem( 20 ),
                new BreadItem( 50 )
            };
            IShop myShop = new GroceryShop( items );
            List<IDiscount> discounts = new()
            {
                new IDiscount
                {
                    ItemsCategory = "A",
                    Amount = 20
                },
                new IDiscount
                {
                    ItemsCategory = "C",
                    Amount = 15
                }
            };
            myShop.DefineDiscounts( discounts );
            int total = myShop.Calculate( "milk, BrEad, water, butter" );
            Console.WriteLine( $"Your total price: { total } rubles." );
        }
    }
}
