﻿using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Student
{
    public class Student : BaseAuditEntity
    {
        #region General_Information
        public string studentCode { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string guardianName { get; set; }
        #endregion

        #region Local_Guardian_Info  //lg=Local Guardian
        public string lgName { get; set; }
        public string lgAddress { get; set; }
        public string lgContact { get; set; }
        public string lgEmail { get; set; }
        public string lgOccupation { get; set; }
        public string lgAge { get; set; }
        #endregion

        #region Accademic_Information
        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }
        #endregion
    }
}
