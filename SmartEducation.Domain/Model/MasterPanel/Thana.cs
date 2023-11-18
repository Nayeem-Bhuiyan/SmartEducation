using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Thana : BaseEntity
    {

        public string thanaCode { get; set; }
        public string thanaName { get; set; }
        public string shortName { get; set; }
        public int districtId { get; set; }
        public District district { get; set; }
    }
}
