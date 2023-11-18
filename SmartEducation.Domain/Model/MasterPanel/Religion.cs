using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Religion : BaseEntity
    {
        [Required]
        [Column(TypeName = "NVARCHAR(150)")]
        public string name { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string shortName { get; set; }
    }
}
