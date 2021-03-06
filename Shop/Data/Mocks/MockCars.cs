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
                        img = "/img/car_img_046b944e70f11b3a1cde9724e3da2e44.jpg", 
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
                        img = "/img/fastest-cars-world-2021-luxe-digital@2x.jpg",
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
                        img = "/img/toyota-bz4x-3.jpg", 
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
                        img = "/img/image.jpg", 
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