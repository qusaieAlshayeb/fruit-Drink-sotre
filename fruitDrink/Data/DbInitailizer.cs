
using fruitDrink.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace fruitDrink.Data
{
    public class DbInitailizer
    {


        public static void Seed(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            // use context

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Tea",
                        price = 7.95M,
                        shortDescription = "Tea is an aromatic beverage prepared by pouring ",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://www.verywellhealth.com/thmb/HaV7uoEuBXbg3SDbn1YfOZoiylc=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/GettyImages-693893647-588d21e413dd411cb1f2b0a0ea3e02da.jpg",
                        InStock = true,
                        IspreferredDrink = true,
                        ImageDrinkUrl = "https://www.verywellhealth.com/thmb/HaV7uoEuBXbg3SDbn1YfOZoiylc=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/GettyImages-693893647-588d21e413dd411cb1f2b0a0ea3e02da.jpg"
                    },
                    new Drink
                    {
                        Name = "cappuccino",
                        price = 12.95M,
                        shortDescription = "s an espresso drink with steamed milk, milk foam and espresso. It's very similar to a latte (cafe latte).",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSW49r5ZxmwLNJ3bt3O6vcwRupQZBIVqCfSf3rER2FVJFR1PVX5YN4nUMdSUXQT21qE",
                        InStock = true,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSW49r5ZxmwLNJ3bt3O6vcwRupQZBIVqCfSf3rER2FVJFR1PVX5YN4nUMdSUXQT21qE"
                    },
                  
                   
                    new Drink
                    {
                        Name = "steaming coffee",
                        price = 17.95M,
                        shortDescription = "Nothing beats a mug of steaming coffee or tea when the weather turns cool.",
                        Category = Categories["HotDrinks"],
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2022/08/Homemade-Hot-Chocolate-with-Marshmallows-683x1024.webp",
                        InStock = true,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2022/08/Homemade-Hot-Chocolate-with-Marshmallows-683x1024.webp"
                    },
                    new Drink
                    {
                        Name = "Homemade Hot Chocolate",
                        price = 15.95M,
                        shortDescription = " best homemade hot chocolate",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://www.acouplecooks.com/wp-content/uploads/2021/09/Hot-Chocolate-008-735x919.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://www.acouplecooks.com/wp-content/uploads/2021/09/Hot-Chocolate-008-735x919.jpg"
                    },
                    new Drink
                    {
                        Name = "Hot chocolate",
                        price = 15.95M,
                        shortDescription = "AHot chocolate",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://www.aljawharamag.com/aljawhara/uploads/2019/10/شوكو.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://www.aljawharamag.com/aljawhara/uploads/2019/10/شوكو.jpg"
                    },
                    new Drink
                    {
                        Name = "Hot chocolate with cream",
                        price = 15.95M,
                        shortDescription = "enjoy with cream in hot chocolate",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://i0.wp.com/www.al-jawaab.com/wp-content/uploads/2017/06/قهوة-بالقشطة.jpg?w=640&ssl=1",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://i0.wp.com/www.al-jawaab.com/wp-content/uploads/2017/06/قهوة-بالقشطة.jpg?w=640&ssl=1"
                    },
                    new Drink
                    {
                        Name = "Almond coffee ",
                        price = 15.95M,
                        shortDescription = "A sweet coffee made with Almond.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://i0.wp.com/www.al-jawaab.com/wp-content/uploads/2017/06/قهوة-اللوز.jpeg?w=640&ssl=1",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://i0.wp.com/www.al-jawaab.com/wp-content/uploads/2017/06/قهوة-اللوز.jpeg?w=640&ssl=1"
                    },
                    new Drink
                    {
                        Name = "milk choco",
                        price = 15.95M,
                        shortDescription = "warm yourself with milk choco ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["HotDrinks"],
                        ImageUrl = "https://ik.imagekit.io/wez2loho68v/prod/recipes/hot%20drinks/chocolate%20peanut%20butter%20milk/chocolate-peanut-butter-milk.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://ik.imagekit.io/wez2loho68v/prod/recipes/hot%20drinks/chocolate%20peanut%20butter%20milk/chocolate-peanut-butter-milk.jpg"
                    },
                    new Drink
                    {
                        Name = "watermelon slash",
                        price = 15.95M,
                        shortDescription = "ice drink ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://atbaki.com/wp-content/uploads//recipe/5787903324681.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://atbaki.com/wp-content/uploads//recipe/5787903324681.jpg"
                    },
                    new Drink
                    {
                        Name = "Zero Sugar Flavored Water",
                        price = 15.95M,
                        shortDescription = "Zero Sugar Flavored Water",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/616Yb-UbBAL._SX569_.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/616Yb-UbBAL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = "Pink Grapefruit Sparkling",
                        price = 15.95M,
                        shortDescription = "Zero Sugar Flavored Water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/616Yb-UbBAL._SX569_.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/616Yb-UbBAL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = "Berry Lemonade Sparkling",
                        price = 15.95M,
                        shortDescription = "Zero Sugar Flavored Water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/71zBeWbsmrL._SX569_.jpg",
                        InStock = false,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/71zBeWbsmrL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = "oconut Pineapple Sparkling ",
                        price = 12.95M,
                        shortDescription = "Zero Sugar Flavored Water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/71AERBs1iQL._SX569_.jpg",
                        InStock = true,
                        IspreferredDrink = true,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/71AERBs1iQL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = "Fruit Punch Sparkling",
                        price = 12.95M,
                        shortDescription = " Zero Sugar Flavored Water ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/71PaQuJWToL._SX569_.jpg",
                        InStock = true,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/71PaQuJWToL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = "Caffeine Black Raspberry ",
                        price = 12.95M,
                        shortDescription = "Zero Sugar Flavored Water,",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/71IQo0R9bWL._SX569_.jpg",
                        InStock = true,
                        IspreferredDrink = true,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/71IQo0R9bWL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = "Orange Mango Sparkling",
                        price = 12.95M,
                        shortDescription = "Zero Sugar Flavored Water,",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/71XnJ+xn3DL._SX569_.jpg",
                        InStock = true,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/71XnJ+xn3DL._SX569_.jpg"
                    },
                    new Drink
                    {
                        Name = " Ice Black Cherry Sparkling",
                        price = 12.95M,
                        shortDescription = "Zero Sugar Flavored Water,",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["cold-drinks"],
                        ImageUrl = "https://m.media-amazon.com/images/I/31KDHHvYyZL.jpg",
                        InStock = true,
                        IspreferredDrink = false,
                        ImageDrinkUrl = "https://m.media-amazon.com/images/I/31KDHHvYyZL.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, category> categories;
        public static Dictionary<string, category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new category[]
                    {
                        new category { categoryname = "HotDrinks", description="hot drinks" },
                        new category { categoryname = "cold-drinks", description=" cold drinks" }
                    };

                    categories = new Dictionary<string, category>();

                    foreach (category genre in genresList)
                    {
                        categories.Add(genre.categoryname, genre);
                    }
                }

                return categories;






















            }


            }
    }
          



 }


