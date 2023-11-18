using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class District : BaseEntity
    {
        public string districtCode { get; set; }
        [Required]
        public string districtName { get; set; }
        public string shortName { get; set; }
        public int divisionId { get; set; }
        public Division division { get; set; }
    }
}
