using Business_Layer.BusinessRules;
using System;
using System.Collections.Generic;

using System.Text;



using System.Linq;

using System.Threading.Tasks;
namespace MakerOfMeal.Business_Layer
{
    public abstract class BusinessObject
    {
        List<BusinessRule> rules = new List<BusinessRule>();
        List<string> errors = new List<string>();
        public List<string> Errors
        {
            get { return errors; }
        }
        protected void AddRule(BusinessRule rule)
        {
            rules.Add(rule);
        }
        public bool IsValid()
        {
            bool valid = true;

            errors.Clear();

            foreach (var rule in rules)
            {
                if (!rule.Validate(this))
                {
                    valid = false;
                    errors.Add(rule.Error);
                }
            }
            return valid;
        }
    }
}