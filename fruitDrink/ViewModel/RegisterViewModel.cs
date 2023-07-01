using System.ComponentModel.DataAnnotations;

namespace fruitDrink.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="please enter your email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare("Password" ,ErrorMessage ="try a again your password didn't match")]
        public string ConfirmPassword { get; set; }


    }
}
