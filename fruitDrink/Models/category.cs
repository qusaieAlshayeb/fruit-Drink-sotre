using System.ComponentModel.DataAnnotations;

namespace fruitDrink.Models
{
    public  class category
    {
        [Key]
        public int categoryid { get; set; }

         public string categoryname { get; set; }

        public string description { get; set; }

         public List<Drink> Drinks { get; set; }


    }
}
