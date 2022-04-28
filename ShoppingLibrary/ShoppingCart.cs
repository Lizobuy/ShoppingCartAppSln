using System;
using System.Collections.Generic;

namespace ShoppingLibrary
{


    public class ShoppingCart
    {
        List<ShoppingCartItem> _products = new List<ShoppingCartItem>();


        public void AddShoppingCartItem(ShoppingCartItem item)
        {
            _products.Add(item);
        }


        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return _products;
        }

        public double GetSubTotal()
        {
            double total = 0;

            foreach (ShoppingCartItem item in _products)
            {
                total = total + item.ProductPrice;
            }

            return total;

        }

        public double GetSubTotalWithVat()
        {
            double subTotal = GetSubTotal();

            return subTotal * 1.15;
        }

    }

}
