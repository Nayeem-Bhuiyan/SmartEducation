using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class GradeScale:BaseEntity
    {
        public string gradeName { get; set; }
        public decimal minimumSalary { get; set; }
        public decimal maximumSalary { get; set; }
        public decimal probitionSalary { get; set; }
    }
}
