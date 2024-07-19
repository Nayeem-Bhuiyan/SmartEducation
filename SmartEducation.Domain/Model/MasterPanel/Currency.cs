using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Currency : BaseEntity
    {
        [StringLength(150)]
        public string formalName { get; set; }
        [StringLength(120)]
        public string symbolText { get; set; }
        [StringLength(120)]
        public string symbolSign { get; set; }

        public int? decimalAllow { get; set; }
    }
}
