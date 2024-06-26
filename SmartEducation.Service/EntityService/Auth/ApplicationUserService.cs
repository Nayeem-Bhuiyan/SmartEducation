﻿using Microsoft.EntityFrameworkCore;
using SmartEducation.Application.IEntityRepository.MasterPanel;
using SmartEducation.Application.IEntityService.Auth;
using SmartEducation.Application.IEntityService.MasterPanel;
using SmartEducation.Application.ViewModel.Auth;
using SmartEducation.DataAccess.DBContext;
using SmartEducation.Domain.Model.Auth;
using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Service.EntityService.Auth
{

    public class ApplicationUserService : IApplicationUserService
    {
        private readonly ApplicationDbContext _context;
        public ApplicationUserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> GetUserInfoByUser(string userName)
        {
            return await _context.Users.Where(x => x.UserName == userName).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<ApplicationUser> GetUserInfoByUserPhoneNumber(string phoneNumber)
        {
            return await _context.Users.Where(x => x.PhoneNumber == phoneNumber).AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<ApplicationUser> GetUserInfoByEmailAsync(string email)
        {
            return await _context.Users.Where(x => x.Email == email).AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<ApplicationUser>> GetUsers()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<AspNetUsersViewModel>> GetUserInfoList()
        {
            var result = await (from a in _context.Users
                                join ur in _context.UserRoles on a.Id equals ur.UserId
                                join r in _context.Roles on ur.RoleId equals r.Id
                                //join dl in _context.dealers on a.Id equals dl.ApplicationUserId
                                select new AspNetUsersViewModel
                                {
                                    aspnetId=a.Id,
                                    UserName = a.UserName,
                                    Email = a.Email,
                                    roleName=r.Name,
                                    //createdAt =a.createdAt,
                                    isActive=a.isActive,

                                }).ToListAsync();

            return result;
        }



        public async Task<bool> DeleteRoleById(string Id)
        {
            _context.Roles.Remove(_context.Roles.Where(x => x.Id == Id).First());
            return 1 == await _context.SaveChangesAsync();
        }

        public async Task<string> GetUserRoleByUserName(string userName)
        {
            var name = "";
            var user = await _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            var userRole = await _context.UserRoles.Where(x => x.UserId == user.Id).FirstOrDefaultAsync();
            if (userRole != null)
            {
                var role = await _context.Roles.Where(x => x.Id == userRole.RoleId).FirstOrDefaultAsync();
                name = role?.Name;
            }
            else { name = "no roles assingn"; }
            return name;
        }

        public async Task<string> GetUserRoleByByUserId(string userId)
        {
            var name = "";
            var user = await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            var userRole = await _context.UserRoles.Where(x => x.UserId == user.Id).FirstOrDefaultAsync();
            if (userRole != null)
            {
                var role = await _context.Roles.Where(x => x.Id == userRole.RoleId).FirstOrDefaultAsync();
                name = role?.Name;
            }
            else { name = "no roles assingn"; }
            return name;
        }

        public async Task<string> CheckUserName(string uname)
        {
            var user = await _context.Users.Where(x => x.UserName == uname).Select(x => x.UserName).FirstOrDefaultAsync();
            if (user == null)
            {
                user = "Not Used";
            }
            return user;
        }
        public async Task<string> CheckEmail(string email)
        {
            var user = await _context.Users.Where(x => x.Email == email).Select(x => x.Email).FirstOrDefaultAsync();
            if (user == null)
            {
                user = "Not Used";
            }
            return user;
        }


        public async Task<string> CheckPhone(string phoneNumber)
        {
            var user = await _context.Users.Where(x => x.PhoneNumber == phoneNumber).Select(x => x.PhoneNumber).FirstOrDefaultAsync();
            if (user == null)
            {
                user = "Not Used";
            }
            return user;
        }


        public async Task<string> DeleteUser(string id)
        {
            try
            {
                var user = await _context.Users.Where(s => s.Id == id).FirstOrDefaultAsync();
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return user.UserName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
        public async Task<string> UpdateUserStatusByUserIdAndStatus(string id, int status)
        {
            try
            {
                var user = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
                user.isActive = status==1 ? true : false;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return "success";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }




    }
}
