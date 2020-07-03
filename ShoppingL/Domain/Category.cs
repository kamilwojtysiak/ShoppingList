using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingL.Domain
{
    public class Category
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
