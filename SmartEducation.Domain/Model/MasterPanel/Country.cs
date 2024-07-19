using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Country: BaseEntity
    {
        [Required]
        public string countryCode { get; set; }
        [Required]
        [StringLength(150)]
        public string countryName { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }
    }
}
