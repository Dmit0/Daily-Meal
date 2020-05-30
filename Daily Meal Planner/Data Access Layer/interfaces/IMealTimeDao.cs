using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    public interface IMealTimeDao
    {
        void AddProductM(Product product, MealTime mealTime);
        void DeleteProductFromMealTime(string MealName,string ProductName);
        List<MealTime> Getmealtimess();
        void AddMealtime(MealTime mealTime);
        void DeleteMealTime(string name);
        bool checkMeal(string name);
        Product GetProductFromMeal(string productname);
        double GetAllCalories();
        void ExportRation(string sum, string daily_norm, User user);


    }
}
