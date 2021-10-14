using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDbContext context)
        {
            

            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Car.Any())
            {
                context.AddRange(
                    new Car() {
                        name = "Tesla", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "/img/car_img_046b944e70f11b3a1cde9724e3da2e44.jpg", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = Categories["electric"]
                    },
                    new Car()
                    {
                        name = "4epirka", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "/img/fastest-cars-world-2021-luxe-digital@2x.jpg",
                        price = 1000, 
                        isFavourite = true, 
                        available = true, 
                        Category = Categories["classic"]
                    },
                    new Car()
                    {
                        name = "Toyota El", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "/img/toyota-bz4x-3.jpg", 
                        price = 1000, 
                        isFavourite = true, 
                        available = true, 
                        Category = Categories["electric"]
                    },
                    new Car()
                    {
                        name = "Vasl", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "/img/image.jpg", 
                        price = 0, 
                        isFavourite = true, 
                        available = true, 
                        Category = Categories["classic"]
                    }
                    );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "electric", desc = "Modern transport"},
                        new Category {categoryName = "classic", desc = "Cars with benzine engine"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                    
                }
                return category;
            }
        }
    }
}