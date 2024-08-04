using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("BankType")]
    public class BankType:BaseEntity
    {
        public string bankTypeName { get; set; } //Mobile,Online,Bank
    }
}
