using System.ComponentModel.DataAnnotations;

namespace fruitDrink.Models
{
    public class ShoppingCartItems
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        public Drink Drink { get; set; }


        public  int  Amount { get; set; }

        public string ShoppingCardId { get; set; }
    }
}
