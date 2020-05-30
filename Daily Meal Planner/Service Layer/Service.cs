
using MakerOfMeal.Business_Layer;
using MakerOfMeal.Data_Access_Layer;
using System.Collections.Generic;
namespace MakerOfMeal.Service_Layer
{
    public class Service : IService
    {
        static readonly ICategoryDao categoryDao = new CategoryDao();
        static readonly IProductDao productDao = new ProductDao();
        static readonly IUserDao userDao = new UserDao();
        static readonly IMealTimeDao mealTimeDao = new MealTimeDao();
        public List<Category> GetCategories()
        {
            return categoryDao.GetCategories();
        }
          public List<MealTime> Getmealtimess()
          {
              return mealTimeDao.Getmealtimess();
          }
        public bool checkMeal(string name)
        {
            return mealTimeDao.checkMeal(name);
        }
        public void AddMealtime(MealTime mealTime)
        {
            mealTimeDao.AddMealtime(mealTime);
        }
        public Product GetProduct(string name)
        {
            return productDao.GetProduct(name);
        }
        public bool CheckProduct(string name)
        {
            
            return productDao.CheckProduct(name);
        }
        public void AddCategory(Category category)
        {
            categoryDao.AddCategory(category);
        }
        public void DeleteCategory(string name)
        {
            categoryDao.DeleteCategory(name);
        }
        public void AddProduct(Product product, string categoryName)
        {
            productDao.AddProduct(product, categoryName);
        }
        public void DeleteProduct(string productName, string categoryName)
        {
            productDao.DeleteProduct(productName, categoryName);
        }
        public void DeleteMealTime(string name)
        {
            mealTimeDao.DeleteMealTime(name);
        }
        public double DailyColoriesCount(User user)
        {
           return userDao.DailyColoriesCount(user);
        }

        public Product GetProductFromMeal(string productname)
        {
           return mealTimeDao.GetProductFromMeal(productname);
        }
        public void DeleteProductFromMealTime(string MealNmae, string ProductName)
        {
            mealTimeDao.DeleteProductFromMealTime(MealNmae, ProductName);
        }
        public void AddProductM(Product product, MealTime mealTime)
        {
            mealTimeDao.AddProductM(product, mealTime);
        }
        public double GetAllCalories()
        {
            return mealTimeDao.GetAllCalories();
        }
        public void ExportRation(string sum, string daily_norm, User user)
        {
            mealTimeDao.ExportRation(sum, daily_norm, user);
        }

    }

}
