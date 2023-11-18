using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Relation : BaseEntity
    {
        [Required]
        public string relationName { get; set; }
        public string relationShortName { get; set; }
    }
}
