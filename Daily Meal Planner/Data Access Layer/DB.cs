using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using MakerOfMeal.Business_Layer;

namespace MakerOfMeal.Data_Access_Layer
{
    class DB
    {

        XDocument xdoc = XDocument.Load("FoodProducts.xml");
        XDocument xdoc_for_rations = XDocument.Load("DailyRation.xml");
        public List<Category> categories = new List<Category>();
        public List<MealTime> meal = new List<MealTime>();

        private static DB instance;

        private DB()
        {
            Read();
        }
        public static DB GetInstance()
        {
            if (instance == null)
            {
                instance = new DB();
            }
            return instance;
        }

        public void Read()
        {

            foreach (XElement category in xdoc.Element("Db").Elements("Category"))
            {
                Category categ = new Category()
                {
                    CategoryName = category.Attribute("name").Value,
                    Description = category.Attribute("description").Value
                };
                categories.Add(categ);
                List<Product> categoryProducts = new List<Product>();
                foreach (XElement Product in category.Elements("Product"))
                {
                    Product product = new Product();
                    product.ProductName =Product.Element("Name").Value;
                    product.Grams = Convert.ToDouble(Product.Element("Gramms").Value);
                    product.Proteins = Convert.ToDouble(Product.Element("Protein").Value);
                    product.Fats = Convert.ToDouble(Product.Element("Fats").Value);
                    product.Carbs = Convert.ToDouble(Product.Element("Carbs").Value);
                    product.Calories = Convert.ToDouble(Product.Element("Calories").Value);
                    categoryProducts.Add(product);
                }
                categ.products = categoryProducts;
            }


            foreach (XElement ration in xdoc_for_rations.Element("rations").Elements("ration"))
             {
                 MealTime mealtime = new MealTime()
                 {
                     MealName = ration.Attribute("name").Value
                 };
                 meal.Add(mealtime);

                List<Product> mealTimesyProducts = new List<Product>();
                foreach (XElement mealtim in ration.Elements("product"))
                {
                    Product Mealproduct = new Product();
                    Mealproduct.ProductName = mealtim.Element("Name").Value;
                    Mealproduct.Grams = double.Parse(mealtim.Element("Gramms").Value);
                    Mealproduct.Proteins = double.Parse(mealtim.Element("Protein").Value);
                    Mealproduct.Fats = Convert.ToDouble(mealtim.Element("Fats").Value);
                    Mealproduct.Carbs = Convert.ToDouble(mealtim.Element("Carbs").Value);
                    Mealproduct.Calories = Convert.ToDouble(mealtim.Element("Calories").Value);

                    mealTimesyProducts.Add(Mealproduct);
                }
                mealtime.mealproducts = mealTimesyProducts;

             }

        }
        public void AddCategory(Category category)
        {
            XElement catElem = new XElement("Category", new XAttribute("name", category.CategoryName), new XAttribute("description", category.Description));
            xdoc.Root.Add(catElem);
            xdoc.Save("FoodProducts.xml");
            categories.Add(category);
        }
        public void DeleteCategory(string name)
        {

            foreach (XElement xNode in xdoc.Root.Elements())
            {
                var atribute = xNode.Attribute("name");
                if (atribute.Value == name)
                {
                    xNode.Remove();
                }
            }
            xdoc.Save("FoodProducts.xml");
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].CategoryName == name)
                {
                    categories.Remove(categories[i]);
                }
            }
        }
       public void DeleteMealTime(string name)
        {
            foreach (XElement xNode in xdoc_for_rations.Root.Elements())
            {
                var atr = xNode.Attribute("name");
                if (atr.Value == name)
                {
                    xNode.Remove();
                }
            }
            xdoc_for_rations.Save("DailyRation.xml");
            for (int i = 0; i < meal.Count; i++)
            {
                if (meal[i].MealName == name)
                {
                    meal.Remove(meal[i]);
                }
            }
        }

        public void AddProduct(Product product, string categoryName)
        {
            foreach (XElement xNode in xdoc.Root.Elements())
            {
                var atribute = xNode.Attribute("name");
                if (atribute.Value == categoryName)
                {
                    XElement productElem = new XElement("Product",
                        new XElement("Name", product.ProductName),
                        new XElement("Gramms", product.Grams),
                        new XElement("Protein", product.Proteins),
                        new XElement("Fats", product.Fats),
                        new XElement("Carbs", product.Carbs),
                        new XElement("Calories", product.Calories)
                        );
                    xNode.Add(productElem);
                }
            }
            xdoc.Save("FoodProducts.xml");
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].CategoryName == categoryName)
                {
                    categories[i].products.Add(product);
                }
            }
        }
        public void AddProductM(Product product, MealTime mealtime)
        {
            foreach (XElement xNode in xdoc_for_rations.Root.Elements())
            {
                var atribute = xNode.Attribute("name");
                if (atribute.Value == mealtime.MealName)
                {
                        XElement productElem = new XElement("product",
                        new XElement("Name", product.ProductName),
                        new XElement("Gramms", Convert.ToString(product.Grams)),
                        new XElement("Protein", Convert.ToString(product.Proteins)),
                        new XElement("Fats", Convert.ToString(product.Fats)),
                        new XElement("Carbs", Convert.ToString(product.Carbs)),
                        new XElement("Calories", Convert.ToString(product.Calories))
                        );
                    xNode.Add(productElem);
                }
            }
            xdoc_for_rations.Save("DailyRation.xml");
            for (int i = 0; i < meal.Count; i++)
            {
                if (meal[i].MealName == mealtime.MealName)
                {
                    meal[i].mealproducts.Add(product);
                }
            }
        }

        public void DeleteProduct(string productName, string categoryName)
        {
            foreach (XElement xNode in xdoc.Root.Elements("Category").Elements("Product"))
            {
                var elem = xNode.Element("Name");
                if (elem.Value == productName)
                {
                    xNode.Remove();
                }
            }
            xdoc.Save("FoodProducts.xml");
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].CategoryName == categoryName)
                {
                    for (int j = 0; j < categories[i].products.Count; j++)
                    {
                        if (categories[i].products[j].ProductName == productName)
                        {
                            categories[i].products.Remove(categories[i].products[j]);
                        }
                    }
                }
            }
        }
        public void DeleteProductFromMealTime(string MealName,string ProductName)
        {
            foreach (XElement xNode in xdoc_for_rations.Root.Elements("ration").Elements("product"))
            {
                var elem = xNode.Element("Name");
                if (elem.Value == ProductName)
                {
                    xNode.Remove();
                }
            }
            xdoc_for_rations.Save("DailyRation.xml");
            for (int i = 0; i < meal.Count; i++)
            {
                if (meal[i].MealName == MealName)
                {
                    for (int j = 0; j < meal[i].mealproducts.Count; j++)
                    {
                        if (meal[i].mealproducts[j].ProductName == ProductName)
                        {
                            meal[i].mealproducts.Remove(meal[i].mealproducts[j]);
                        }
                    }
                }
            }
        }


          
            public void AddMealtime(MealTime mealTime)
           {
            XElement rationElem = new XElement("ration",new XAttribute("name",mealTime.MealName));
               xdoc_for_rations.Root.Add(rationElem);
               xdoc_for_rations.Save("DailyRation.xml");
               meal.Add(mealTime);
           }
       }
    
}
