using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            allOrders = _allOrders;
            shopCart = _shopCart;
        }

        public IActionResult Checkout() // page where we also have form or some other big actions
        {
            return View();
        }
    }
}