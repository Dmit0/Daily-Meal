using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Service_Layer
{
    public interface IService
    {
        List<Category> GetCategories();
        //List<MealTime> Getmealtimess();
        Product GetProduct(string productName);
        List<MealTime> Getmealtimess();
        //DailyRation  Getration(string productName, DailyRation dailyRation);

        void AddCategory(Category category);
        void DeleteCategory(string index);
        void AddProduct(Product product, string categoryName);
        void DeleteProduct(string productName, string categoryName);
        //void SaveDailyRation(DailyRation dailyRation);
        //void DeleteMealTime(DailyRation ration, int index);
        void DeleteProductFromMealTime(string MealNmae,string ProductName);
        void AddProductM(Product product, MealTime mealTime);
        bool CheckProduct(string name);

        void AddMealtime(MealTime mealTime);
        void DeleteMealTime(string name);
        bool checkMeal(string name);
        double DailyColoriesCount(User user);
        Product GetProductFromMeal(string productname);

        double GetAllCalories();
        void ExportRation(string sum, string daily_norm, User user);
        // void AddDailyRation(MealTime meal);
    }
}
