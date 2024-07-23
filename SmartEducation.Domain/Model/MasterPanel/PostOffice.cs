using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class PostOffice : BaseEntity
    {
        [Required]
        [StringLength(120)]
        public string postOfficeName { get; set; }
        [StringLength(50)]
        public string postCode { get; set; }
       

        [ForeignKey("ThanaId")]
        public int? ThanaId { get; set; }
        public Thana Thana { get; set; }

    }
}
