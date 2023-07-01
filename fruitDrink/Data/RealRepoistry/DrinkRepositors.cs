using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using fruitDrink.Data;
using fruitDrink.Models;
using Microsoft.AspNetCore.Mvc;

namespace fruitDrink.Data.RealRepoistry
{
    public class DrinkRepositors : IDrinkReporistry
    {

        private readonly AppDbContext _appDbContext;
        public DrinkRepositors(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks.Where(p => p.IspreferredDrink).Include(c => c.Category);

        public void add(Drink drink)
        {
            
            _appDbContext.Drinks.Add(drink);
            _appDbContext.SaveChanges();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Drink GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);

        public Drink update(int id, Drink newdrink)
        {
            _appDbContext.Update(newdrink);
            _appDbContext.SaveChanges();
            return newdrink;
        }
    }
}
