using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Employee
{
    [Table("EmployeeCategory")]
    public class EmployeeCategory : BaseAuditEntity
    {
        [StringLength(100)]
        public string employeeCategoryName { get; set; } //Teacher,Employee etc
        [StringLength(30)]
        public string code { get; set; }
    }
}
