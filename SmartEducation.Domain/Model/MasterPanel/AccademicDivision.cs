using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AccademicDivision: BaseAuditEntity
    {
        [Required]
        public string divisionName { get; set; }
        public string code { get; set; }
        [DefaultValue(false)]
        public bool isActive { get; set; } = false;


        [ForeignKey("AccademicInstitutionId")]
        public int AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }
    }
}
