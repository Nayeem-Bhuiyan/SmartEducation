using SmartEducation.Domain.Model.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("SubjectDetails")]
    public class SubjectDetails:BaseEntity
    {
        [ForeignKey("SubjectId")]
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }

        [ForeignKey("ExamTypeId")]
        public int? ExamTypeId { get; set; }
        public ExamType ExamType { get; set; }

        public int marks { get; set; }

        public int totalMarks { get; set; }
    }
}
