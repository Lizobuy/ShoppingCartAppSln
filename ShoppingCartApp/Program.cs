using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            ShoppingCartItem item = new ShoppingCartItem("xbox", 3999);
            cart.AddShoppingCartItem(item);
            item = new ShoppingCartItem("ps4", 5000);
            cart.AddShoppingCartItem(item);
            item = new ShoppingCartItem("nintendo", 6000);
            cart.AddShoppingCartItem(item);


            List<ShoppingCartItem> items = cart.GetShoppingCartItems();

            foreach (ShoppingCartItem shoppingItem in items)
            {

                Console.WriteLine(shoppingItem.ProductName +"\t" + shoppingItem.ProductPrice);
            }

            Console.WriteLine("Sub Total: " + cart.GetSubTotal());
            Console.WriteLine("With Vat:  "  +  cart.GetSubTotalWithVat());
           
        }
    }
}
