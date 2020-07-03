using ShoppingL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingL.Services
{
    public class CategoryService
    {
        ProductService productService = new ProductService();

        private int _categoryIndex = 1;

        public Category CreateCategory(Category category)
        {
            return category;
        }

        public void DisplayCategories(List<Category> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine($"{_categoryIndex}. {category}");

                _categoryIndex++;
            }
        }

        public void SelectCategory()
        {
            Console.WriteLine("Select category");

            string choosenCategory = Console.ReadLine();

            productService.AddProduct();

            switch (choosenCategory)
            {
                case "Meat":
                    productService.DisplayProducts(productService.MeatProducts);
                    break;
                case "Fruits":
                    productService.DisplayProducts(productService.Fruits);
                    break;
                case "Diary":
                    productService.DisplayProducts(productService.DiaryProducts);
                    break;
                default:
                    break;
            }
        }
    }
}
