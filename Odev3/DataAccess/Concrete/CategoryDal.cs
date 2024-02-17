using Odev3.DataAccess.Abstract;
using Odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        Category category1 = new Category() { Id = 1, CategoryName = "Courses" };
        Category category2 = new Category() { Id = 2, CategoryName = "Instructors" };
        categories = new List<Category>() { category1, category2 };
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(int categoryId)
    {
        foreach (Category category in categories)
        {
            if (category.Id == categoryId)
            {
                categories.Remove(category);
                Console.WriteLine("Category name: " + category.CategoryName + " deleted!");
                break;
            }
        }
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Read(int categoryId)
    {
        var category = categories.FirstOrDefault(c => c.Id == categoryId);
        if (category != null)
        {
            Console.WriteLine("Category ID: " + category.Id);
            Console.WriteLine("Category Name: " + category.CategoryName);
        }
        else
        {
            Console.WriteLine("Category not found!");
        }
    }

    public void Update(Category updatedCategory)
    {
        var existingCategory = categories.FirstOrDefault(c => c.Id == updatedCategory.Id);
        if (existingCategory != null)
        {
            existingCategory.CategoryName = updatedCategory.CategoryName;
            Console.WriteLine("Category updated!");
        }
        else
        {
            Console.WriteLine("Category not found");
        }


    }
}
