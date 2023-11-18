using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class BankBranch:BaseEntity
    {
        public string name { get; set; }
        public string address { get; set; }
        public bool isMainBranch { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        
        //ForeignKey
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
