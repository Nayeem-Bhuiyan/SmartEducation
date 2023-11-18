using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Bank:BaseEntity
    {
        public string  name { get; set; }
        public string  shortName { get; set; }
        public string description { get; set; }
        public string address { get; set; }
    }
}
