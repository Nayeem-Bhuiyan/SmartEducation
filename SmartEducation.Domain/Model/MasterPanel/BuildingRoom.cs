using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class BuildingRoom:BaseEntity
    {
        [ForeignKey("BuildingId")]
        public int? BuildingId { get; set; }
        public Building Building { get; set; }

        public int? floorNumber { get; set; }
        public int? roomNumber { get; set; }
    }
}
