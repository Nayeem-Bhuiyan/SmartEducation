using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SmartEducation.Domain.Model.Auth
{
    public class ApplicationUser : IdentityUser
    {
        [DefaultValue(true)]
        public bool? isActive { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? createdAt { get; set; }
        [MaxLength(120)]
        public string createdBy { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? updatedAt { get; set; }
        [MaxLength(120)]
        public string updatedBy { get; set; }
    }
}
