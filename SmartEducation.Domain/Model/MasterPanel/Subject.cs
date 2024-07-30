using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
        public class Subject : BaseEntity
        {
            [Required]
            [StringLength(150)]
            public string subjectName { get; set; }
            [StringLength(50)]
            public string code { get; set; }
            [StringLength(150)]
            public string reportDisplayName { get; set; }
            
        }          
    
}
