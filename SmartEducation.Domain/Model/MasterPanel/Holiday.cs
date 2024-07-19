using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Holiday:BaseEntity
    {
        public DateTime? weeklyHoliday { get; set; }
        [Required]
        public string holidayName { get; set; }
        [Required]

        [ForeignKey("AccademicYearId")]
        public int AccademicYearId { get; set; }
        public AccademicYear AccademicYear { get; set; }
    }
}
