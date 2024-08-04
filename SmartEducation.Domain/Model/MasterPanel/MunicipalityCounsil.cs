using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("MunicipalityCounsil")]
    public class MunicipalityCounsil:BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string counsilName { get; set; }
        public int? counsilNo { get; set; }

        [ForeignKey("MunicipalityId")]
        public int? MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }
    }
}
