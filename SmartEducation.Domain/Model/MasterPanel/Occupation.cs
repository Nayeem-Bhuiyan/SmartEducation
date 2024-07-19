using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Occupation
    {
        [Required]
        [StringLength(150)]
        public string occupationName { get; set; }
        [StringLength(50)]
        public string occupationShortName { get; set; }
    }
}
