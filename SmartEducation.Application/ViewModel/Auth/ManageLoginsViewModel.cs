using Microsoft.AspNetCore.Identity;
namespace SmartEducation.Application.ViewModel.Auth
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        //public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}
