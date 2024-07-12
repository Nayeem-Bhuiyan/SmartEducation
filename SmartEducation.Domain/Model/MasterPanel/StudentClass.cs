using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class StudentClass:BaseEntity
    {
        public string className { get; set; }
        public string code { get; set; }
    }
}
