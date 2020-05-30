using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    public class ProductDao : IProductDao
    {
        private DB db = DB.GetInstance();
        public List<Product> GetProductsByCategory(string name)
        {
            for (int i = 0; i < db.categories.Count; i++)
            {
                if (name == db.categories[i].CategoryName)
                {
                    return db.categories[i].products;
                }
            }
            return null;
        }
        public Product GetProduct(string name)
        {
            for (int i = 0; i < db.categories.Count; i++)
            {
                for (int j = 0; j < db.categories[i].products.Count; j++)
                {
                    if (name == db.categories[i].products[j].ProductName)
                    {
                        return db.categories[i].products[j];
                    }
                }
            }
            return null;
        }
        public bool CheckProduct(string name)
        {
            for (int i = 0; i < db.categories.Count; i++)
            {
                for (int j = 0; j < db.categories[i].products.Count; j++)
                {
                    if (name == db.categories[i].products[j].ProductName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AddProduct(Product product, string categoryName)
        {
            db.AddProduct(product, categoryName);
        }
        public void DeleteProduct(string productName, string categoryName)
        {
            db.DeleteProduct(productName, categoryName);
        }
    
    }
}
