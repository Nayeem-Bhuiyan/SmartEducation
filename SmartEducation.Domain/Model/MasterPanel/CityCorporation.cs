using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("CityCorporation")]
    public class CityCorporation:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string cityCorporationName { get; set; }
        [StringLength(100)]
        public string code { get; set; }
    }
}
