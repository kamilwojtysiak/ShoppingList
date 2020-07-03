using ShoppingL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingL.Services
{
    public class ProductService
    {
        public List<Product> MeatProducts = new List<Product>();
        public List<Product> DiaryProducts = new List<Product>();
        public List<Product> Fruits = new List<Product>();

        public void AddProduct()
        {
            Console.WriteLine("Products in this cateogry: ");

            MeatProducts.Add(new Product("Ham"));
            MeatProducts.Add(new Product("Sausage"));
            MeatProducts.Add(new Product("Chicken"));
            MeatProducts.Add(new Product("Beef"));

            DiaryProducts.Add(new Product("Milk"));
            DiaryProducts.Add(new Product("Butter"));
            DiaryProducts.Add(new Product("Cheese"));

            Fruits.Add(new Product("Bananas"));
            Fruits.Add(new Product("Strawberies"));
            Fruits.Add(new Product("Apples"));
            Fruits.Add(new Product("Grape"));
        }

        public void DisplayProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
