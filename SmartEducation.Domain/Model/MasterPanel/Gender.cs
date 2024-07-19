using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Gender:BaseEntity
    {
        [StringLength(120)]
        public string genderName { get; set; }
        [StringLength(30)]
        public string shortName { get; set; }
    }
}
