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
    public class InstitutionalDivision:BaseAuditEntity
    {
        [Required]
        [StringLength(250)]
        public string fullName { get; set; }
        [StringLength(250)]
        public string displayName { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [DefaultValue(false)]
        public bool? isMainDivision { get; set; } = false;
       
        [ForeignKey("InstitutionId")]
        public int? InstitutionId { get; set; }
        public Institution Institution { get; set; }
    }
}
