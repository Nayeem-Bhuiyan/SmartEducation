using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class GeneralConfiguration : BaseEntity
    {
        public string purpose { get; set; }
        public string configLabel { get; set; }
        public string configName { get; set; }
        public string configOptions { get; set; }  //Yes,No
        public string configValue { get; set; }


        [ForeignKey("AccademicInstitutionId")]
        public int? AccademicInstitutionId { get; set; }
        public AccademicInstitution AccademicInstitution { get; set; }

        [ForeignKey("AccademicDivisionId")]
        public int? AccademicDivisionId { get; set; }
        public AccademicDivision AccademicDivision { get; set; }
    }
}
