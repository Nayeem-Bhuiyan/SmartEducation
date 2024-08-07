﻿using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Student
{
    public class StudentRegistration:BaseAuditEntity
    {
        #region General_Information
        [StringLength(100)]
        public string studentCode { get; set; } //Life Time School Identity
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
        [StringLength(150)]
        public string guardianName { get; set; }

        [ForeignKey("GenderId")]
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("ReligionId")]
        public int? ReligionId { get; set; }
        public Religion Religion { get; set; }
        #endregion

        #region Local_Guardian_Info  
        //lg=Local Guardian
        [StringLength(150)]
        public string lgName { get; set; }
        [StringLength(250)]
        public string lgAddress { get; set; }
        [StringLength(30)]
        public string lgContact { get; set; }
        [StringLength(150)]
        public string lgEmail { get; set; }
        [StringLength(150)]
        public string lgOccupation { get; set; }
        public int? lgAge { get; set; }
        #endregion

        #region Accademic_Information
        [ForeignKey("AccademicYearId")]
        public int? AccademicYearId { get; set; }
        public AccademicYear AccademicYear { get; set; }

        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }

        #endregion

        #region Bank_Information
        [ForeignKey("BankBranchId")]
        public int? BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }
        public string bankAccountNumber { get; set; }

        #endregion
    }
}
