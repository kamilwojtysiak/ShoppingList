using ShoppingL.Domain;
using ShoppingL.Services;
using System;
using System.Collections.Generic;

namespace ShoppingL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>();
            CategoryService categoryService = new CategoryService();

            categories.Add(categoryService.CreateCategory(new Category("Meat")));
            categories.Add(categoryService.CreateCategory(new Category("Fruits")));
            categories.Add(categoryService.CreateCategory(new Category("Diary")));

            categoryService.DisplayCategories(categories);
            categoryService.SelectCategory();
        }
    }
}
