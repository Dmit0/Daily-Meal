using System;
using System.Collections.Generic;
using System.Text;
using Business_Layer.BusinessRules;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    public class UserDao : IUserDao
    {
        public double DailyColoriesCount(User user)
        {
            double BMR = 447.593 + (9.247 * user.Weight) + (3.098 * user.Height) - (4.330 * user.Age);
            if (user.Activitytype == "Low")
            {
                return BMR * 1.2;
            }
            if (user.Activitytype == "Normal")
            {
                return BMR * 1.375;
            }
            if (user.Activitytype == "Average")
            {
                return BMR * 1.55;
            }
            return BMR * 1.725;
        }
      
    }
}
