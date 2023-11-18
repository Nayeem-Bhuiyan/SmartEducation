using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Department : BaseEntity
    {
        [Required]
        public string deptCode { get; set; }

        [Required]
        public string deptName { get; set; }
        public string shortName { get; set; }

    }
}
