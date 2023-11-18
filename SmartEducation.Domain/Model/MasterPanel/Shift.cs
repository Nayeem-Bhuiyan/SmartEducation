using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Shift:BaseEntity
    {
        public Shift() {
         this.isActive=false;
        }
        public string name { get; set; }
        public string shortName { get; set; }
        public DateTime? startDate { get; set; }
        public string beginTime { get; set; }
        public string endTime { get; set; }
        public bool isActive { get; set; }



    }
}
