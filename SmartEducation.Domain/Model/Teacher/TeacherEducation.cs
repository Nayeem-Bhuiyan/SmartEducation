using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Teacher
{
    public class TeacherEducation:BaseEntity
    {
        [ForeignKey("TeacherInfoId")]
        public int? TeacherInfoId { get; set; }
        public TeacherInfo TeacherInfo { get; set; }


        [ForeignKey("EducationlId")]
        public int? EducationId { get; set; }
        public Education Education { get; set; }
    }
}
