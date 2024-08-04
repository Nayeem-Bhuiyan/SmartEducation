using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Branch:BaseAuditEntity
    {
        [Required]
        [StringLength(250)]
        public string branchName { get; set; }
        [StringLength(50)]
        public string code { get; set; }   //Required
        [StringLength(50)]
        public string shortName { get; set; }
        [StringLength(30)]
        public string contact { get; set; }
        [StringLength(150)]
        public string email { get; set; }
        [StringLength(250)]
        public string address { get; set; }

        public bool? isMainBranch { get; set; }=false;

        [StringLength(100)]
        public string reportSortingOrder { get; set; } //Designation,Grade etc

        [ForeignKey("BranchInchargeId")]
        public int? BranchInchargeId { get; set; }
        public BranchIncharge BranchIncharge { get; set; }

        [ForeignKey("InstitutionalDivisionId")]
        public int InstitutionalDivisionId { get; set; }
        public InstitutionalDivision InstitutionalDivision { get; set; }      

    }
}
