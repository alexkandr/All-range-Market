using System.ComponentModel.DataAnnotations;

namespace All_Range_Market.Models.ViewModels
{

    public class LoginModel
    {

        [Required]
        [Display (Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Пароль")]

        public string Password { get; set; }
        [Required]
        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
