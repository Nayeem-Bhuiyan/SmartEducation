using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Bank:BaseEntity
    {
        [StringLength(100)]
        public string  name { get; set; }
        [StringLength(50)]
        public string  shortName { get; set; }
       
        [ForeignKey("BankTypeId")]
        public int? BankTypeId { get; set; }
        public BankType BankType { get; set; } //Mobile,Online,Bank
       
        [StringLength(150)]
        public string description { get; set; }
        public string address { get; set; }
    }
}
