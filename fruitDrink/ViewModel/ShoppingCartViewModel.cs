using fruitDrink.Models;
using fruitDrink.Models.interfaces;

namespace fruitDrink.ViewModel
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal shoppingCartTotal { get; set; }
    }
}
