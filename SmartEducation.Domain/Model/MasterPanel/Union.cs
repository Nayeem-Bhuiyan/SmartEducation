using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Union")]
    public class Union:BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string unionName { get; set; }
        [StringLength(50)]
        public string code { get; set; }


        [ForeignKey("ThanaId")]
        public int? ThanaId { get; set; }
        public Thana Thana { get; set; }

    }
}
