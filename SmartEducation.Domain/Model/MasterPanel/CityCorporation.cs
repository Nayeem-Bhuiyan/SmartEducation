using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class CityCorporation:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string cityCorporationName { get; set; }
        [StringLength(100)]
        public string code { get; set; }
    }
}
