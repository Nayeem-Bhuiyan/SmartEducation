using SmartEducation.Application.ViewModel.Auth;
using SmartEducation.Domain.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Application.IEntityService.Auth
{
    public interface IApplicationUserService
    {
        Task<ApplicationUser> GetUserInfoByUser(string userName);
        Task<ApplicationUser> GetUserInfoByUserPhoneNumber(string phoneNumber);
        Task<ApplicationUser> GetUserInfoByEmailAsync(string email);
        Task<bool> DeleteRoleById(string Id);
        Task<string> GetUserRoleByUserName(string userName);
        Task<string> CheckUserName(string uname);
        Task<string> CheckEmail(string email);
        Task<string> CheckPhone(string phoneNumber);
        Task<string> DeleteUser(string id);
        Task<string> UpdateUserStatusByUserIdAndStatus(string id, int status);
        Task<IEnumerable<AspNetUsersViewModel>> GetUserInfoList();
        Task<string> GetUserRoleByByUserId(string userId);
        Task<IEnumerable<ApplicationUser>> GetUsers();
    }
}
