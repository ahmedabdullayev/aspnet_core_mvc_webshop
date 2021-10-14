using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> Cars => _appDbContext.Car.Include(c => c.Category);
        
        public IEnumerable<Car> getFavCars => _appDbContext.Car.Where(p => p.isFavourite)
            .Include(c => c.Category);

        public Car getObjectCar(int carId) => _appDbContext.Car.FirstOrDefault(p => p.id == carId);
        
    }
}