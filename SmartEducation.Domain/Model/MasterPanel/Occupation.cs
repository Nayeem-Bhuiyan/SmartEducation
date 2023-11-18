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
        public string occupationName { get; set; }
        public string occupationShortName { get; set; }
    }
}
