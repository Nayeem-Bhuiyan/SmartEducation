using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Language:BaseEntity
    {
        [StringLength(150, ErrorMessage = "Maximum length should be 150")]
        public string LanguageName { get; set; }
    }
}
