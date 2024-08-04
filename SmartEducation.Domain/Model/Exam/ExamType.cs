using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Exam
{
    [Table("ExamType")]
    public class ExamType:BaseEntity
    {
        [StringLength(150)]
        public string examTypeName { get; set; } //MCQ,Written,Viva,Practical,Presentation
    }
}
