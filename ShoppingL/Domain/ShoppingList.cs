using ShoppingL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingL
{
    public class ShoppingList
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
