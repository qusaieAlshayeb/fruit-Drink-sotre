using fruitDrink.Data;

using fruitDrink.Models.interfaces;

namespace fruitDrink.Models.Mocks
{
    public class OrderRepoistry : IOrderRepoistry
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderRepoistry(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order); 
            _appDbContext.SaveChanges();

            var shoppingCartItems = shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    DrinkId = shoppingCartItem.Drink.DrinkId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Drink.price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

           
        }
    }

}