using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("Language")]
    public class Language:BaseEntity
    {
        [StringLength(150)]
        public string languageName { get; set; }
        [StringLength(50)]
        public string shortName { get; set; }
    }
}
