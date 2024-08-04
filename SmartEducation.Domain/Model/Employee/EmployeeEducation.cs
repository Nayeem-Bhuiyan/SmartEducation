using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Employee
{
    [Table("EmployeeEducation")]
    public class EmployeeEducation:BaseEntity
    {
        [ForeignKey("EmployeeInfoId")]
        public int? EmployeeInfoId { get; set; }
        public EmployeeInfo EmployeeInfo { get; set; }


        [ForeignKey("EducationlId")]
        public int? EducationId { get; set; }
        public Education Education { get; set; }
    }
}
