using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDbContext _appDbContext;

        public ShopCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public string ShopCartId { get; set; }
        
        public List<ShopCartItem> ListShopCartItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>(); // to work with db tables
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            
            session.SetString("CartId", shopCartId);

            return new ShopCart(context) {ShopCartId = shopCartId};
        }

        public void AddToCart(Car car)
        {
            _appDbContext.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });

            _appDbContext.SaveChanges();
        }

        public List<ShopCartItem> GetShopCartItems()
        {
            return _appDbContext.ShopCartItem.Where(c => c.ShopCartId == ShopCartId)
                .Include(s => s.car).ToList();
        }
    }
}