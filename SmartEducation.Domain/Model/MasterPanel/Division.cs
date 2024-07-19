using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Division : BaseEntity
    {
        [Required]
        public string divisionName { get; set; }
        public string divisionCode { get; set; }
        public string shortName { get; set; }

        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}
