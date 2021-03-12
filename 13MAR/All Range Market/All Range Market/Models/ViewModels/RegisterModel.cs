using System.ComponentModel.DataAnnotations;

namespace All_Range_Market.Models.ViewModels
{
    public class RegisterModel
    {
        [Required]
        [Display(Name="Имя")]
        public string Name { get; set; }
        [Required]
        [Display (Name="Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name="Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Подтвердите пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
        [Required]
        [Display(Name ="Телефон")]
        public string PhoneNumber { get; set; }

    }
}
