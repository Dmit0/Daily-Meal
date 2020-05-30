using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;


namespace Business_Layer.BusinessRules
{
    public abstract class BusinessRule
    {
        public string Error { get; set; }
        public string Property { get; set; }
        public abstract bool Validate(BusinessObject businessObject);
        
    }
}
