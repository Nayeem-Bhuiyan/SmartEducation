using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Building: BaseAuditEntity
    {

        [StringLength(150)]
        public string buildingName { get; set; }
        [StringLength(50)]
        public string buildingPosition { get; set; }
        [StringLength(100)]
        public string buildingType { get; set; } //Accademic,Administrative--etc


        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("AccademicInstitutionId")]
        public int? AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }
    }
}
