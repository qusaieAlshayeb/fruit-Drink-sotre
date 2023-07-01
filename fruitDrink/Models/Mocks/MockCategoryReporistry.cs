using fruitDrink.Models.interfaces;

namespace fruitDrink.Models.Mocks
{
    public class MockCategoryReporistry : ICategoryRepoistry
    {
        public IEnumerable<category> categories { 
            
            
            get
            {

                return new List<category>()
                {
                    new category { categoryname ="HotDrinks" , description="Hot drinks"    },

                    new category {  categoryname = "cold-drinks"  , description = "cold drinks " }
                };




            }
        
        
        
        
        
        }
    }
}
