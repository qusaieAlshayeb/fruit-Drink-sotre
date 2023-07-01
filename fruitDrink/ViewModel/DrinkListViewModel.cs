using fruitDrink.Models;

namespace fruitDrink.ViewModel
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink>? Drinks { get; set; }

        public string crurrentcategory { get; set; }
    }
}
