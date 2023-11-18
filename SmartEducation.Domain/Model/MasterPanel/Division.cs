using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Division : BaseEntity
    {
        public string divisionCode { get; set; }
        [Required]
        public string divisionName { get; set; }
        public string shortName { get; set; }
        public int countryId { get; set; }
        public Country country { get; set; }
    }
}
