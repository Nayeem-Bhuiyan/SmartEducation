using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Designation : BaseAuditEntity
    {

        [Required]
        [StringLength(120)]
        public string designationName { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
