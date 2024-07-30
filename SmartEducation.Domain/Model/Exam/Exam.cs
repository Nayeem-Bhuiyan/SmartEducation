using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Exam
{
    public class Exam:BaseEntity
    {
        [StringLength(150)]
        public string examName { get; set; } //ClasTest1,ClassTest2
        [StringLength(50)]
        public string code { get; set; }

        [ForeignKey("SubjectId")]
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("ExamTypeId")]
        public int? ExamTypeId { get; set; }
        public ExamType ExamType { get; set; }

        [ForeignKey("ExamHeadId")]
        public int? ExamHeadId { get; set; }
        public ExamHead ExamHead { get; set; }

        public int marks { get; set; }
    }
}
