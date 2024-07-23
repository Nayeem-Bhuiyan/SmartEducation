using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AccademicClass:BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string className { get; set; } //One,Two,Three---
    }
}
