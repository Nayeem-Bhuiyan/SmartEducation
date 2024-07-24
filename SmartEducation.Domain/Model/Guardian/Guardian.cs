using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Guardian
{
    public class Guardian : BaseEntity
    {
        [StringLength(50)]
        public string guardianCode { get; set; }
        [StringLength(150)]
        public string firstName { get; set; }
        [StringLength(150)]
        public string middleName { get; set; }
        [StringLength(150)]
        public string lastName { get; set; }
        [StringLength(150)]
        public string fatherName { get; set; }
        [StringLength(150)]
        public string motherName { get; set; }
        [StringLength(30)]
        public string contactNumber { get; set; }
        [StringLength(150)]
        public string email { get; set; }
        [StringLength(250)]
        public string presentAddress { get; set; }
        [StringLength(250)]
        public string permanentAddress { get; set; }
        [StringLength(150)]
        public string occupation { get; set; }
        public decimal yearlyIncome { get; set; }

    }
}
