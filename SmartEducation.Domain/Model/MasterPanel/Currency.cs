using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Currency : BaseEntity
    {
        public string formalName { get; set; }

        public string symbolText { get; set; }

        public string symbolSign { get; set; }

        public int? decimalAllow { get; set; }
    }
}
