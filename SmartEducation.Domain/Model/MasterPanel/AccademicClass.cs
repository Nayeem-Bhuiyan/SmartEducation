using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AccademicClass:BaseEntity
    {
        public string className { get; set; } //One,Two,Three
        public string code { get; set; }
        public string remarks { get; set; }
    }
}
