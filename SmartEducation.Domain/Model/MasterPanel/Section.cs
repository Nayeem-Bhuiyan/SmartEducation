using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Section:BaseEntity  //this table is not for student data
    {
        [Required]
        [StringLength(100)]
        public string sectionName { get; set; }
        [StringLength(30)]
        public string code { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
