using DocumentFormat.OpenXml.Office2010.ExcelAc;
using fruitDrink.Data.RealRepoistry;
using fruitDrink.Models;
using fruitDrink.Models.interfaces;
using fruitDrink.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fruitDrink.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepoistry _categoryRepoistry;

        private readonly IDrinkReporistry _drinkReporistry;

        public DrinkController(ICategoryRepoistry categoryRepoistry, IDrinkReporistry drinkReporistry)
        {
            _categoryRepoistry = categoryRepoistry;
            _drinkReporistry = drinkReporistry;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkReporistry.Drinks.OrderBy(p => p.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("HotDrinks", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkReporistry.Drinks.Where(p => p.Category.categoryname.Equals("HotDrinks")).OrderBy(p => p.Name);
                else
                    drinks = _drinkReporistry.Drinks.Where(p => p.Category.categoryname.Equals("cold-drinks")).OrderBy(p => p.Name);
                
            }

            return View(new DrinkListViewModel
            {
                Drinks = drinks,
                crurrentcategory = currentCategory
            });

        }




     
       
    }






}