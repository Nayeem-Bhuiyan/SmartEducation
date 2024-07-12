using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class SectionOfStudentClass:BaseEntity
    {
        public string sectionName { get; set; }
        public string code { get; set; }

        [ForeignKey("StudentClassId")]
        public int? StudentClassId { get; set; }
        public StudentClass StudentClass { get; set; }
    }
}
