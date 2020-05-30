using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    public interface IUserDao
    {
        double DailyColoriesCount(User user);
    }
}
