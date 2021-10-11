using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car() {
                        name = "Tesla", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "https://i.insider.com/60f860760729770012b91c62?width=700", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car()
                    {
                        name = "4epirka", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "https://www.trippycar.com/upload/car_img/2021/aug/31/car_img_046b944e70f11b3a1cde9724e3da2e44.jpg", 
                        price = 1000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.ElementAtOrDefault(1)
                    },
                    new Car()
                    {
                        name = "Toyota El", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "https://daily-motor.ru/wp-content/uploads/2021/04/toyota-bz4x-3.jpg", 
                        price = 1000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.ElementAtOrDefault(1)
                    },
                    new Car()
                    {
                        name = "Vasl", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "https://cdn.luxe.digital/media/2020/12/15110747/fastest-cars-world-2021-luxe-digital%402x.jpg", 
                        price = 1000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.ElementAtOrDefault(0)
                    }
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }
        
        public Car getObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
        
    }
}