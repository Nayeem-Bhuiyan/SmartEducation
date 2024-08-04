using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Employee
{
    public class EmployeeCategory : BaseAuditEntity
    {
        [StringLength(100)]
        public string employeeCategoryName { get; set; } //Teacher,Employee etc
        [StringLength(30)]
        public string code { get; set; }
    }
}
