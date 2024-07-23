using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Thana : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string thanaName { get; set; }
        [StringLength(50)]
        public string code { get; set; }

        [ForeignKey("DistrictId")]
        public int? DistrictId { get; set; }
        public District District { get; set; }
    }
}
