using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AccademicSection
    {
        [Required]
        [StringLength(150)]
        public string sectionName { get; set; } //A,B,C---
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(150)]
        public string remarks { get; set; }
    }
}
