using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int AccademicYearId { get; set; }
    }
}
