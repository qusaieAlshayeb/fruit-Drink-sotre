using fruitDrink.Data;
using fruitDrink.Models;
using fruitDrink.Models.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace fruitDrink.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepoistry _orderRepoistry;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepoistry orderRepoistry, ShoppingCart shoppingCart)
        {
            _orderRepoistry = orderRepoistry;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (ModelState.IsValid)
            {
                _orderRepoistry.CreateOrder(order);
                _shoppingCart.clearCard();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }


        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank for your order :) ";
            return View();
        }



    }
}
