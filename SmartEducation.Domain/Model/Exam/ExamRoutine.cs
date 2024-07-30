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
    public class ExamRoutine:BaseEntity
    {
        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }

        [ForeignKey("SubjectId")]
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }

        [ForeignKey("ExamTypeId")]
        public int? ExamTypeId { get; set; }
        public ExamType ExamType { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? examDate { get; set; }

        public string fromHour { get; set; }
        public string toHour { get; set; }

    }
}
