using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class CityCorporationCounsil:BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string counsilName { get; set; }
        public int? counsilNo { get; set; }

        [ForeignKey("CityCorporationId")]
        public int? CityCorporationId { get; set; }
        public CityCorporation CityCorporation { get; set; }
    }
}
