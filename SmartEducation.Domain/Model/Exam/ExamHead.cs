using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Exam
{
    public class ExamHead:BaseEntity
    {
        [StringLength(150)]
        public string examHeadName { get; set; }  //ClassTest,WeeklyTest,MonthlyTest,Midterm,SemisterFinal
    }
}
