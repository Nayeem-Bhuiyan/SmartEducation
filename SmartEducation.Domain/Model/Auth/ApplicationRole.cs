using Microsoft.AspNetCore.Identity;
using SmartEducation.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Auth
{
    public class ApplicationRole : IdentityRole,IAuditableEntity
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName)
        {
        }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
