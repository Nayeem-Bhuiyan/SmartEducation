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
        public string countryName { get; set; }
        public string shortName { get; set; }
    }
}
