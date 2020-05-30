using System;
using System.Collections.Generic;
using System.Text;
using MakerOfMeal.Business_Layer;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace MakerOfMeal.Data_Access_Layer
{
    public class MealTimeDao : IMealTimeDao
    {
        static DB db = DB.GetInstance();
        public void AddProductM(Product product, MealTime mealTime)
        {
            db.AddProductM(product, mealTime);
          
        }
        public Product GetProductFromMeal(string productname)
        {
            for (int i = 0; i < db.meal.Count; i++)
            {
                for (int j = 0; j < db.meal[i].mealproducts.Count; j++)
                {
                    if (productname == db.meal[i].mealproducts[j].ProductName)
                    {
                        return db.meal[i].mealproducts[j];
                    }
                }
            }
            return null;
        }
        public double GetAllCalories()
        {
            double count = 0;
            for (int i = 0; i < db.meal.Count; i++)
            {
                for (int j = 0; j < db.meal[i].mealproducts.Count; j++)
                {
                    count += db.meal[i].mealproducts[j].Calories;
                }
            }
            return count;
        }
        public void DeleteProductFromMealTime(string MealName,string ProductName)
        {
            db.DeleteProductFromMealTime(MealName,ProductName);
        }

        public List<MealTime> Getmealtimess()
        {
            return db.meal;
        }
        public void AddMealtime(MealTime mealTime)
        {
            db.AddMealtime(mealTime);
        }
        public void DeleteMealTime(string name)
        {
            db.DeleteMealTime(name);
        }
        public bool checkMeal(string name)
        {
            
                for (int i = 0; i < db.meal.Count; i++)
                {
                   
                        if (name == db.meal[i].MealName)
                        {
                            return true;
                        }
                    
                }
                return false;
            
        }

        public void ExportRation(string sum, string daily_norm, User user)
        {
            XFont small_font = new XFont("sans-serif", 15, XFontStyle.Regular);
            XFont large_font = new XFont("sans-serif", 18, XFontStyle.Regular);
            XFont xlarge_font = new XFont("sans-serif", 25, XFontStyle.Regular);
            int x = 40, y = 10;

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Мой дневной рацион";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            gfx.DrawString("Мой дневной рацион",
            xlarge_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 35;
            gfx.DrawString("Информация о пользователе",
            large_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 25;
            gfx.DrawString($"Возраст: {user.Age}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Рост: {user.Height}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Вес: {user.Weight}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Тип Активности: {user.Activitytype}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 30;
            gfx.DrawString($"Рекомендуемая дневная норма: {daily_norm}",
            xlarge_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            foreach (MealTime meals in db.meal)
            {
                y += 35;
                if (y + 35 > page.Height)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    y = 10;
                }
                gfx.DrawString(meals.MealName, large_font, XBrushes.Black, new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
                foreach (Product product in meals.mealproducts)
                {
                    y += 25;
                    if (y + 25 > page.Height)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        y = 10;
                    }
                    gfx.DrawString($"{product.ProductName}: {product.Grams} грамм",
                    small_font, XBrushes.Black,
                    new XRect(x + 25, y, page.Width, page.Height), XStringFormats.TopLeft);
                }
            }
            y += 50;
            if (y > page.Height)
            {
                page = document.AddPage();
                gfx = XGraphics.FromPdfPage(page);
                y = 0;
            }
            gfx.DrawString($"Калорийность рациона: {sum}",
            xlarge_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);

            const string filename = "Daily Food Ration.pdf";
            document.Save(filename);
        }


    }
}
