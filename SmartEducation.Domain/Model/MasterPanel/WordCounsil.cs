using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class WordCounsil:BaseEntity
    {
        [MaxLength(250)]
        [StringLength(100)]
        public string name { get; set; }

        [ForeignKey("UnionId")]
        public int? UnionId { get; set; }
        public Union Union { get; set; }
    }
}
