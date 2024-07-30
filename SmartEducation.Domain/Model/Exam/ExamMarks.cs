using SmartEducation.Domain.Model.MasterPanel;
using SmartEducation.Domain.Model.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Exam
{
    public class ExamMarks:BaseEntity
    {
        [ForeignKey("StudentInfoId")]
        public int? StudentInfoId { get; set; }
        public StudentInfo StudentInfo { get; set; }

        [ForeignKey("SubjectId")]
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("ExamId")]
        public int? ExamId { get; set; }
        public Exam Exam { get; set; }

        public int obtainMarks { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? examDate { get; set; }

    }
}
