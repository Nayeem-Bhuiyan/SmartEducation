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
            public string subjectName { get; set; }
            public string subjectShortName { get; set; }
        }
    
}
