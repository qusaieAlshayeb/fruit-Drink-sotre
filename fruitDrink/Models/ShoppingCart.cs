using fruitDrink.Data;
using fruitDrink.Models.interfaces;


using Microsoft.EntityFrameworkCore;

namespace fruitDrink.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string shoppingCartId { get; set; }
    
        public  List<ShoppingCartItems>ShoppingCartItems { get; set; }
    
       public static ShoppingCart GetCart (IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            return new ShoppingCart (context) { shoppingCartId = cartId };
        }

        public void AddToCart(Drink drink, int Amount)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Drink.DrinkId == drink.DrinkId && s.ShoppingCardId == shoppingCartId);


            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItems
                {
                    ShoppingCardId = shoppingCartId,
                    Drink = drink,
                    Amount = 1


                };

                _appDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }

            else
            {
                ShoppingCartItem.Amount++;

            }
            _appDbContext.SaveChanges();

        }


        public int RemoveFromCart(Drink drink)
        {
            var ShoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Drink.DrinkId == drink.DrinkId && s.ShoppingCardId == shoppingCartId);

            var LocalAmount = 0;
            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                    LocalAmount = ShoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }


            }
            _appDbContext.SaveChanges();

            return LocalAmount;


        }


        public List<ShoppingCartItems> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCardId == shoppingCartId).Include(s => s.Drink).ToList());




        }





        public void clearCard()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCardId == shoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();

        }





        public decimal GetShoppingCartTotal()
        {

            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCardId == shoppingCartId).Select(c => c.Drink.price * c.Amount).Sum();

            return total;


        }














    }

}
