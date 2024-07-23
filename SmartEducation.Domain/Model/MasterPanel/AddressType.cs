using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AddressType : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string typeName { get; set; } //Present,Permanent
    }
}
