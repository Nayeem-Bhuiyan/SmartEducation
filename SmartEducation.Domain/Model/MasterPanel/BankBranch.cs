using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    [Table("BankBranch")]
    public class BankBranch:BaseEntity
    {
        [StringLength(120)]
        public string name { get; set; }
        [StringLength(250)]
        public string address { get; set; }
        public bool isMainBranch { get; set; }
        [StringLength(30)]
        public string contact { get; set; }
        [StringLength(120)]
        public string email { get; set; }

        //ForeignKey
        [ForeignKey("BankId")]
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
