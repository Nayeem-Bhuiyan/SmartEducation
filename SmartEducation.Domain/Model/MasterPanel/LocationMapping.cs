using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class LocationMapping:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string mappingAreaName { get; set; } //Citycoporation=C,Municipality=M,General=G  
    }
}
