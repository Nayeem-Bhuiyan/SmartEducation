using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Country: BaseEntity
    {
        public string countryCode { get; set; }
        public string countryName { get; set; }
        public string shortName { get; set; }
    }
}
