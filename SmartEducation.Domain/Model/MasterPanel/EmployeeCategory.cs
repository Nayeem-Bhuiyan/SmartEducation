using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class EmployeeCategory
    {
        [StringLength(100)]
        public string employeeCategoryName { get; set; } //Teacher,Employee etc
        [StringLength(30)]
        public string code { get; set; }
    }
}
