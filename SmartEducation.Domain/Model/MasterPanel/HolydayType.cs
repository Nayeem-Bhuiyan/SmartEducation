using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("HolydayType")]
    public class HolydayType:BaseEntity
    {
        public string name { get; set; } //Govt,Eid,Puza,Weekly,Others
    }
}
