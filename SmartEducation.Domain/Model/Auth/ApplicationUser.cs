using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SmartEducation.Domain.Interface;

namespace SmartEducation.Domain.Model.Auth
{
    public class ApplicationUser : IdentityUser, IAuditableEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
        }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ProfilePicUrl { get; set; }

        [DefaultValue(true)]
        public bool? isActive { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool IsLockedOut => LockoutEnabled && LockoutEnd >= DateTimeOffset.Now;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
