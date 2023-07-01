using fruitDrink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace fruitDrink.Data.RealRepoistry

{
    public interface IDrinkReporistry
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferredDrinks { get; }
        Drink GetDrinkById(int drinkId);

       void add (Drink drink);

        Drink update(int id ,Drink newdrink);

        void delete(int id);
    }
}
