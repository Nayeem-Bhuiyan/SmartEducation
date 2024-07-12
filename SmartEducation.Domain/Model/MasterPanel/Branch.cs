using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Branch
    {
        [Required]
        public string branchName { get; set; }
        public string code { get; set; }
        public string shortName { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        [ForeignKey("BranchInchargeId")]
        public int? BranchInchargeId { get; set; }
        public BranchIncharge BranchIncharge { get; set; }

        [ForeignKey("AccademicInstitutionId")]
        public int AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }
    }
}
