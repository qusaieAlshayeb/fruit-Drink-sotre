

using fruitDrink.Models;
using fruitDrink.Models.interfaces;
using fruitDrink.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fruitDrink.ViewComponents
{
    public class TutorialMenuViewComponent : ViewComponent
    {
        private readonly ICategoryRepoistry _categoryRepoistry;
        public TutorialMenuViewComponent(ICategoryRepoistry categoryRepoistry)
        {
            _categoryRepoistry = categoryRepoistry;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepoistry.categories.OrderBy(p => p.categoryname);
            return View(categories);

        }


    }
}