using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class PostOffice : BaseEntity
    {
        [Required]
        public string postCode { get; set; }
        [Required]
        public string postOfficeName { get; set; }

        public string thanaCode { get; set; }

    }
}
