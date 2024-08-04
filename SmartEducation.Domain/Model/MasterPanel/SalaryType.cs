using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class SalaryType:BaseEntity
    {
        [StringLength(100)]
        public string salaryTypeName { get; set; } //Consolidated,Regular
        [StringLength(50)]
        public string shortName { get; set; } //Consolidated=C,Regular=R
    }
}
