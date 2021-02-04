using System.ComponentModel.DataAnnotations;
namespace All_Range_Market.Models.ViewModels
{
    public class ForgottenModel
    {
        [Required]
        public string Email { get; set; }
    }
}
