using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Exam
{
    public class ExamType:BaseEntity
    {
        [StringLength(150)]
        public string examTypeName { get; set; } //MCQ,Written,Viva,Practical,Presentation
    }
}
