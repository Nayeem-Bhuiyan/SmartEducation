using Microsoft.AspNetCore.Mvc.Rendering;

namespace SmartEducation.Application.ViewModel.Auth
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
        public string Email { get; set; }
    }
}
