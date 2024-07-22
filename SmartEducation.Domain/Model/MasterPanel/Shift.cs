using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Shift:BaseEntity
    {
        public Shift() {
         this.isActive=false;
        }
        [StringLength(120)]
        public string shiftName { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? fromDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? toDate { get; set; }
        [StringLength(50)]
        public string beginTime { get; set; }
        [StringLength(50)]
        public string endTime { get; set; }
        [StringLength(30)]
        public string shiftUsedFor { get; set; } //Student=S,Teacher=T,Staff=S,General etc
        public bool isActive { get; set; }
  
        
        [ForeignKey("AccademicInstitutionId")]
        public int? AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }

        [ForeignKey("AccademicDivisionId")]
        public int? AccademicDivisionId { get; set; }
        public AccademicDivision AccademicDivision { get; set; }
    }
}
