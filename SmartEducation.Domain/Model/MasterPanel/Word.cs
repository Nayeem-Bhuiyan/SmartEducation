using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Word")]
    public class Word:BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string wordName { get; set; }
        public int? wordNo { get; set; }

        [ForeignKey("UnionId")]
        public int? UnionId { get; set; }
        public Union Union { get; set; }
    }
}
