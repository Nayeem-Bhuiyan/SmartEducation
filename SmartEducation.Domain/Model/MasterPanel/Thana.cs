using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("DistrictId")]
        public int? DistrictId { get; set; }
        public District District { get; set; }
    }
}
