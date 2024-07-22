using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class HolydayType:BaseEntity
    {
        public string name { get; set; } //Govt,Eid,Puza,Weekly,Others
        public string code { get; set; }
    }
}
