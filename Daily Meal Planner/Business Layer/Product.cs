using System;
using System.Collections.Generic;
using System.Text;
using Business_Layer.BusinessRules;

namespace MakerOfMeal.Business_Layer
{
    public class Product : BusinessObject
    {

        public string ProductName { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Calories { get; set; }
        public double Grams { get; set; }

        public Product() { }
        public Category Category { get; set; }
        
    }
}
