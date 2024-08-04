using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Occupation")]
    public class Occupation : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string occupationName { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }
    }
}
