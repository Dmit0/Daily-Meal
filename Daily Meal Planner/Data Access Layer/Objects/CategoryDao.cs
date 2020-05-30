using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    public class CategoryDao : ICategoryDao
    {
        static DB db = DB.GetInstance();

        public List<Category> GetCategories()
        {
            return db.categories;
        }

        public Category GetCategoryByProduct(Product product)
        {
            return product.Category;
        }


        public void AddCategory(Category category)
        {
            db.AddCategory(category);
        }
        public void DeleteCategory(string name)
        {
            db.DeleteCategory(name);
        }
        public Category GetCategory(string name)
        {
            for (int i = 0; i < db.categories.Count; i++)
            {
                if (name == db.categories[i].CategoryName)
                {
                    return db.categories[i];
                }
            }
            return null;
        }
    }

}
