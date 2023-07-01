using System.ComponentModel.DataAnnotations;

namespace fruitDrink.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name ="Remember me")]
        public  bool RememberMe { get; set; }
    }
}
