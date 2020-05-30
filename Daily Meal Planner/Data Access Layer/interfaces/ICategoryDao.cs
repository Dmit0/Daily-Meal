using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    public interface ICategoryDao
    {
        Category GetCategory(string name);
        List<Category> GetCategories();
        Category GetCategoryByProduct(Product product);
        void AddCategory(Category category);
        void DeleteCategory(string name);
      
    }
}

