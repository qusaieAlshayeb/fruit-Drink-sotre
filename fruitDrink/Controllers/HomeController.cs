using fruitDrink.Data.RealRepoistry;
using fruitDrink.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace fruitDrink.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkReporistry _drinkReporistry;

        public HomeController(IDrinkReporistry drinkReporistry)
        {
          this.  _drinkReporistry = drinkReporistry;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                preferredDrink = _drinkReporistry.PreferredDrinks
            };
      


            return View(homeViewModel);
        }
    }
}
