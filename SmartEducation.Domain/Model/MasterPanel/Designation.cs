using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Designation : BaseEntity
    {
        [Required]
        public string designationCode { get; set; }

        [Required]
        public string designationName { get; set; }

        public string shortName { get; set; }

    }
}
