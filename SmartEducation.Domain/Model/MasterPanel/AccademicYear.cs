using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AccademicYear
    {
        public string yearCaption { get; set; }

        public string aliasName { get; set; }

        public DateTime? yearStartFrom { get; set; }

        public DateTime? yearEndOn { get; set; }

        public int? yearStatus { get; set; }

        public DateTime? lockMonth { get; set; }
    }
}
