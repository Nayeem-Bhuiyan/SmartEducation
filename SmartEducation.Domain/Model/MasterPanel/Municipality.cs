using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Municipality")]
    public class Municipality:BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string municipalityName { get; set; }

        [StringLength(50)]
        public string code { get; set; }
        [StringLength(150)]
        public string address { get; set; }

        [ForeignKey("ThanaId")]
        public int? ThanaId { get; set; }
        public Thana Thana { get; set; }
    }
}
