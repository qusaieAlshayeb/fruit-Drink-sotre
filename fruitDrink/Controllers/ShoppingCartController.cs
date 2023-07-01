using fruitDrink.Data.RealRepoistry;
using fruitDrink.Models;
using fruitDrink.Models.interfaces;
using fruitDrink.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace fruitDrink.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkReporistry _drinkReporistry;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkReporistry drinkReporistry, ShoppingCart shoppingCart)
        {
            _drinkReporistry = drinkReporistry;
            _shoppingCart = shoppingCart;
        }


        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingcartviewmodel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                shoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),

            };
          return View(shoppingcartviewmodel);
        }
   
    
        public  RedirectToActionResult AddToShoppingCart(int drinkid)
        {

            var selecteDrink = _drinkReporistry.Drinks.FirstOrDefault(id => id.DrinkId == drinkid);
            if (selecteDrink != null)
            {
                _shoppingCart.AddToCart(selecteDrink, 1);
            }
            return RedirectToAction("Index");
        }    
    
    
         public RedirectToActionResult  RemoveFromShoppingCart (int drinkid)
         {

            var selecteDrink = _drinkReporistry.Drinks.FirstOrDefault(id => id.DrinkId == drinkid);
            if(selecteDrink != null)
            {
                _shoppingCart.RemoveFromCart(selecteDrink);
            }

           return  RedirectToAction("Index");
        }
    
    
    
    
    
    
    
    
    }
}
