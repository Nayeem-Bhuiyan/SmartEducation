using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("EducationLevel")]
    public class EducationLevel:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string educationLevelName { get; set; }
        [StringLength(30)]
        public string code { get; set; }
    }
}
