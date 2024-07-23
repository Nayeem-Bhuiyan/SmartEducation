using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Student
{
    public class Student : BaseAuditEntity
    {
        public string studentCode { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string guardianName { get; set; }

        #region Local_Guardian_Info  //lg=Local Guardian
        public string lgName { get; set; }
        public string lgAddress { get; set; }
        public string lgContact { get; set; }
        public string lgEmail { get; set; }
        public string lgOccupation { get; set; }
        public string lgAge { get; set; }
        #endregion


    }
}
