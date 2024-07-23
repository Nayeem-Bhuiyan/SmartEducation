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
        [Required]
        public string holidayName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime fromDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime toDate { get; set; }

        [Required]
        [ForeignKey("AccademicYearId")]
        public int AccademicYearId { get; set; }
        public AccademicYear AccademicYear { get; set; }     
        
        [ForeignKey("HolydayTypeId")]
        public int? HolydayTypeId { get; set; }
        public HolydayType HolydayType { get; set; }


        [ForeignKey("AccademicInstitutionId")]
        public int? AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }
    }
}
