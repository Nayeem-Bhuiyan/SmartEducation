using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class BranchIncharge
    {
        [StringLength(150)]
        public string name { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(150)]
        public string fatherName { get; set; }
        [StringLength(150)]
        public string motherName { get; set; }
        [StringLength(30)]
        public string contactNumber { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        public string address { get; set; }

        [ForeignKey("AccademicInstitutionId")]
        public int? AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }
    }
}
