using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("AccademicSection")]
    public class AccademicSection:BaseEntity
    {
        public string accademicSectionName { get; set; }

        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }
    }
}
