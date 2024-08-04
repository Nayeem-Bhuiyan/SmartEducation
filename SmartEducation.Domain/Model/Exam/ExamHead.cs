using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Exam
{
    [Table("ExamHead")]
    public class ExamHead:BaseEntity
    {
        [StringLength(150)]
        public string examHeadName { get; set; }  //ClassTest,WeeklyTest,MonthlyTest,Midterm,SemisterFinal
    }
}
