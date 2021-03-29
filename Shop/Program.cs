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
                new WaterItem( 20 )
            };
            IShop myShop = new GroceryShop( items );
            int total = myShop.Calculate( "milk, BrEad, water, butter" );
            Console.WriteLine( $"Your total price: { total } rubles." );
        }
    }
}
