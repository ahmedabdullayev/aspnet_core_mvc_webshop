using System;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            appDbContext = _appDbContext;
            shopCart = _shopCart;
        }
        
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            _appDbContext.Order.Add(order);

            var items = _shopCart.ListShopCartItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = el.car.id,
                    orderID = order.id,
                    price = el.car.price,
                };
                _appDbContext.OrderDetail.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}