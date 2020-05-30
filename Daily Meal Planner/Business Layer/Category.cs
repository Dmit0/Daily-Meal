using Business_Layer.BusinessRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakerOfMeal.Business_Layer
{
    public class Category : BusinessObject
    {
        public Category() { }

        public List<Product> products = new List<Product>();
        public string CategoryName { get; set; }
        public string Description { get; set; }

    }
}
