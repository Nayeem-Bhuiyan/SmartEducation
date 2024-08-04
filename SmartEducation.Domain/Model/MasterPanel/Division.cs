using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Division")]
    public class Division : BaseEntity
    {
        [Required]
        [StringLength(250)]
        public string divisionName { get; set; }
        [StringLength(50)]
        public string code { get; set; }

        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}
