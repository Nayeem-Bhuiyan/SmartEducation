using System.ComponentModel.DataAnnotations;
namespace SmartEducation.Application.ViewModel.Auth
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
