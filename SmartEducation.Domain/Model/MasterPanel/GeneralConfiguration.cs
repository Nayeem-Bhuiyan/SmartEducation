using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("GeneralConfiguration")]
    public class GeneralConfiguration : BaseEntity
    {
        [StringLength(120)]
        public string purpose { get; set; }
        [StringLength(120)]
        public string configLabel { get; set; }
        [StringLength(120)]
        public string configName { get; set; }
        [StringLength(50)]
        public string configOptions { get; set; }  //Yes,No
        [StringLength(50)]
        public string configValue { get; set; }


        [ForeignKey("InstitutionalDivisionId")]
        public int? InstitutionalDivisionId { get; set; }
        public InstitutionalDivision InstitutionalDivision { get; set; }

    }
}
