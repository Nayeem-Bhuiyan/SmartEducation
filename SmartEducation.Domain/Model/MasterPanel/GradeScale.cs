using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("GradeScale")]
    public class GradeScale:BaseEntity
    {
        public string gradeName { get; set; }
        public decimal minimumSalary { get; set; }
        public decimal maximumSalary { get; set; }
        public decimal probitionSalary { get; set; }
    }
}
