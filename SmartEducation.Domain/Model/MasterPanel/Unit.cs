using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Unit : BaseEntity
    {
        [MaxLength(250)]
        public string unitName { get; set; }
        [MaxLength(250)]
        public string description { get; set; }
    }
}
