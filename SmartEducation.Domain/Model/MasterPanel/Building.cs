using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Building:BaseEntity
    {
        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        public string buildingName { get; set; }
        public string buildingPosition { get; set; }
        public string buildingType { get; set; } //Accademic,Administrative--etc

    }
}
