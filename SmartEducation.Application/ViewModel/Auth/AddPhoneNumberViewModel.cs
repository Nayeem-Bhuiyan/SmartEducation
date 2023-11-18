using System.ComponentModel.DataAnnotations;
namespace SmartEducation.Application.ViewModel.Auth
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
