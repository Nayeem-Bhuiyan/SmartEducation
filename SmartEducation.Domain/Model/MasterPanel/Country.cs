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
        [StringLength(150)]
        public string countryName { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }      
        [StringLength(50)]
        public string mobileDialingCode { get; set; } //For BD +880

    }
}
