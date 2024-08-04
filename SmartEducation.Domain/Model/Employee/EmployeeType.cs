using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Employee
{
    public class EmployeeType : BaseEntity
    {
        [StringLength(100)]
        public string employeeTypeName { get; set; } //Permanent,Contactual
    }
}
