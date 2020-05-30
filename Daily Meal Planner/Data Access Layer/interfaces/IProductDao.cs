using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;
namespace MakerOfMeal.Data_Access_Layer
{
    public interface IProductDao
    {
        List<Product> GetProductsByCategory(string categoryName);
       
        Product GetProduct(string productName);
        void AddProduct(Product product, string categoryName);
        bool CheckProduct(string name);
        void DeleteProduct(string productName, string categoryName);
      
    }
}
