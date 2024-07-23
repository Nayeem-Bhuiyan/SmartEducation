using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class District : BaseEntity
    {
        [Required]
        public string districtName { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }

        [ForeignKey("DivisionId")]
        public int? DivisionId { get; set; }
        public Division Division { get; set; }
    }
}
