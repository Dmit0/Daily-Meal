using System;
using System.Collections.Generic;
using System.Text;
using Business_Layer.BusinessRules;


namespace MakerOfMeal.Business_Layer
{
    
    public class User : BusinessObject
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        private string activitytype;
        public bool isValidType(string type)
        {
            if(type == "Low" || type == "Normal" || type == "Average" || type == "High")
            {
                return true;
            }
            return false;
        }
        
        public string Activitytype { 
            set
            {
                Console.WriteLine(value);
                if (isValidType(value))
                {
                    activitytype = value;
                }
                else throw new Exception("need normal type");
            }
            get {
                return activitytype;
            }
        }
        public User()
        {

        }

    }
}
