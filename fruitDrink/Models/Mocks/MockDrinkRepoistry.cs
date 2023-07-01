using fruitDrink.Data.RealRepoistry;
using fruitDrink.Models.interfaces;
using static System.Net.WebRequestMethods;

namespace fruitDrink.Models.Mocks
{



    public class MockDrinkRepository : IDrinkReporistry
    {
        private readonly ICategoryRepoistry _categoryRepository = new MockCategoryReporistry();

        public IEnumerable<Drink> Drinks
        {
            get
            {
                return new List<Drink>
                {
                    new Drink {
                        Name = "apple",
                        price = 7.95M, shortDescription = "The most widely consumed fruit",
                        LongDescription = "Nothing satisfies quite like Mott’s Original Apple Juice. Packed with ripe apple flavor, Mott’s Original Apple Juice is 100% fruit juice and delivers 2 servings of fruit in each 8 fl. oz cup, per current USDA Dietary Guidelines. It’s also an excellent source of Vitamin C, contains no added sugar and has a delicious taste the whole family will love. Mott’s Original Apple Juice is the perfect refreshment at dinnertime, lunchtime, or any time. Apples have always nourished us, inspired us, and provided for us. Mott's provides the nutrition and taste of real fruit that families have trusted since 1842, when our founder - Samuel R. Mott's - began growing and packaging apples in New York. In the years since then, Mott’s commitment to apple excellence and high-quality products has continued to provide healthy, delicious juices and snacks. Treat your family to the classic taste of Mott’s Original Apple Juice.;100% JUICE: Made from naturally sweet fresh-pressed apples and concentrate, Mott’s Natural 100% Apple Juice is 100% fruit juice;GREAT TASTE: Packed with fresh-from-the-orchard apple flavor, Mott’s Natural 100% Apple Juice is a delicious and healthy choice your whole family will love;GOOD FOR YOU: Mott’s Natural 100% Apple Juice delivers 2 servings of fruit per 8 fl oz cup, per current USDA Dietary Guidelines;NATURAL GOODNESS: Mott’s Natural 100% Apple Juice is gluten-free, caffeine-free, Kosher, and contains no artificial colors or sweeteners;TRUSTED BRAND: Since 1842, Mott's has committed to providing high-quality, nutritious juices and snacks, with the delicious taste of real fruit",
                        Category = _categoryRepository.categories.First(),
                        ImageUrl = "https://product.hstatic.net/1000282430/product/apple-juice-100_-prima-1l_5300a77f78f54c219e4469c06e7164c6_master.jpg",
                        InStock = true,
                        IspreferredDrink = true,
                        ImageDrinkUrl = "https://product.hstatic.net/1000282430/product/apple-juice-100_-prima-1l_5300a77f78f54c219e4469c06e7164c6_master.jpg"
                    },
                   new Drink {
                        Name = "mango",
                        price = 7.95M, shortDescription = "The most widely consumed fruit",
                        LongDescription = "Enjoy the yumminess of a Mango with the Mango Juice It is made of all the premium products and has a lip-smacking taste It does not contain any sugar. Its is made with the best of mangoes.",
                        Category = _categoryRepository.categories.First(),
                        ImageUrl = "https://cdnprod.mafretailproxy.com/sys-master-root/hd1/hb0/32730901184542/67077_main.jpg_480Wx480H",
                        InStock = true,
                       IspreferredDrink = true,
                        ImageDrinkUrl = "https://cdnprod.mafretailproxy.com/sys-master-root/hd1/hb0/32730901184542/67077_main.jpg_480Wx480H"
                    },
                   new Drink {
                        Name = "strawberryMango",
                        price = 7.95M, shortDescription = "The most widely consumed fruit",
                        LongDescription = "arbonated Water, Mixed Fruit Juices from Concentrate 3% (Apple, Mango, Pineapple & Strawberry), Acids (Citric Acid, Malic Acid), Flavourings, Stabilisers (Acacia Gum, Coconut Oil, Rapeseed Oil), Preservatives (Potassium Sorbate, Sodium Benzoate), Acidity Regulator (Sodium Citrate), Colour (Beta-Carotene), Sweeteners (Sucralose, Acesulfame K), Antioxidant (Ascorbic Acid) ",
                        Category = _categoryRepository.categories.First(),
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0074/0429/0111/products/VimtoSparklingMango_Strawberry_Pineapple500ml_1000x1000.jpg?v=1653677372",
                        InStock = true,
                        IspreferredDrink = true,
                        ImageDrinkUrl = "https://cdn.shopify.com/s/files/1/0074/0429/0111/products/VimtoSparklingMango_Strawberry_Pineapple500ml_1000x1000.jpg?v=1653677372"
                    },
                   new Drink {
                        Name = "orange",
                        price = 7.95M, shortDescription = "The most widely consumed fruit",
                        LongDescription = "Orange juice is a liquid extract of the orange tree fruit, produced by squeezing or reaming oranges. It comes in several different varieties, including blood orange, navel oranges, valencia orange, clementine, and tangerine.",
                        Category = _categoryRepository.categories.First(),
                        ImageUrl = "https://sc04.alicdn.com/kf/HTB13dAuac_vK1Rjy0Foq6xIxVXaT.jpg",
                        InStock = true,
                        IspreferredDrink = true,
                        ImageDrinkUrl = "https://sc04.alicdn.com/kf/HTB13dAuac_vK1Rjy0Foq6xIxVXaT.jpg"
                    },
                 
                };
           
            
           
            }
            set
            {

            }
        }

        public IEnumerable<Drink> PreferredDrinks => throw new NotImplementedException();

        public void add(Drink drink)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }

        public Drink update(int id, Drink newdrink)
        {
            throw new NotImplementedException();
        }
    }  
}