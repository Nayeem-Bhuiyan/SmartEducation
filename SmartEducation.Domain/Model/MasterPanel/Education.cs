using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Education:BaseEntity
    {
        [Required]
        [StringLength(120)]
        public string educationName { get; set; }
        [StringLength(30)]
        public string code { get; set; }

        [ForeignKey("EducationLevelId")]
        public int? EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }
    }
}
