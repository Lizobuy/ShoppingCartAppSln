using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary

   {
    
    public class ShoppingCartItem
    {
      
            public string ProductName { get; private set; }
            public double ProductPrice { get; private set; }
      

        public ShoppingCartItem(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

    }
}
