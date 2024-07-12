using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class ClassRoomDetails:BaseEntity
    {
        [ForeignKey("SectionOfStudentClassId")]
        public int? SectionOfStudentClassId { get; set; }
        public SectionOfStudentClass SectionOfStudentClass { get; set; }

        [ForeignKey("ClassRoomId")]
        public int? ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
