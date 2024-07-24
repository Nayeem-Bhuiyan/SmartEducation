using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Department")]
    public class Department :BaseAuditEntity
    {
        [Required]
        [StringLength(150)]
        public string departmentName { get; set; }
        [StringLength(30)]
        public string code { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }

        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

    }
}
