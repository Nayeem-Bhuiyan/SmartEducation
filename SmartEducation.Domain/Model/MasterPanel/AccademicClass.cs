using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("AccademicClass")]
    public class AccademicClass:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string className { get; set; } //One,Two,Three---
    }
}
