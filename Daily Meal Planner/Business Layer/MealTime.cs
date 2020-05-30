using System.Collections.Generic;

namespace MakerOfMeal.Business_Layer
{
    public class MealTime : BusinessObject
    {

        public List<Product> mealproducts = new List<Product>();
        public string MealName { get; set; }
        public MealTime()
        {

        }
        public MealTime(string mealName)
        {
            MealName = mealName;
        }

    }
}
