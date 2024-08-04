using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("AddressType")]
    public class AddressType : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string typeName { get; set; } //Present,Permanent
    }
}
