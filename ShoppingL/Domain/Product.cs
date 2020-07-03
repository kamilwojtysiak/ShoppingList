using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingL.Domain
{
    public class Product
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}
