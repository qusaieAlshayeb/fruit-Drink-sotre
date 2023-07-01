using System.ComponentModel.DataAnnotations;

namespace fruitDrink.Models
{
    public class Drink
    {
        [Key]
        public int DrinkId { get; set; }


        public string? Name { get; set; }

        public string shortDescription { get; set; }


        public string LongDescription { get; set; }
        
        public decimal price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageDrinkUrl { get; set; }

        public bool  IspreferredDrink { get; set; }


        public bool InStock { get; set; }
        
        public int categoryId { get; set; }
        public  virtual category Category { get; set; }



    }
}
