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
    public class StudentInfo:BaseAuditEntity
    {
        #region General_Information
        [StringLength(100)]
        public string registrationNumber { get; set; } //Life Time School Identity
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
        public string fatherOccupation { get; set; }
        [StringLength(150)]
        public string motherOccupation { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? dateOfBirth { get; set; }

        [StringLength(150)]
        public string email { get; set; }
        [StringLength(30)]
        public string contact { get; set; }

        [StringLength(400)]
        public string pictureName { get; set; }

        [StringLength(100)]
        public string height { get; set; }
        [StringLength(100)]
        public string weight { get; set; }

        [ForeignKey("GenderId")]
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("ReligionId")]
        public int? ReligionId { get; set; }
        public Religion Religion { get; set; }

        [ForeignKey("BloodGroupId")]
        public int? BloodGroupId { get; set; }
        public BloodGroup BloodGrop { get; set; }

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
        [ForeignKey("InstitutionalDivisionId")]
        public int? InstitutionalDivisionId { get; set; }
        public InstitutionalDivision InstitutionalDivision { get; set; }

        [ForeignKey("AccademicYearId")]
        public int? AccademicYearId { get; set; }
        public AccademicYear AccademicYear { get; set; }

        public int? MeritPosition { get; set; }
        public string ClassRoll { get; set; }

        [ForeignKey("AccademicClassId")]
        public int? AccademicClassId { get; set; }
        public AccademicClass AccademicClass { get; set; }


        [ForeignKey("AccademicSectionId")]
        public int? AccademicSectionId { get; set; }
        public AccademicSection AccademicSection { get; set; }

        [ForeignKey("ShiftId")]
        public int? ShiftId { get; set; }
        public Shift Shift { get; set; }

        #endregion

        #region Bank_Information
        [ForeignKey("BankBranchId")]
        public int? BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }
        public string bankAccountNumber { get; set; }


        [ForeignKey("MobileBankId")]
        public int? MobileBankId { get; set; }
        public MobileBank MobileBank { get; set; }
        [StringLength(50)]
        public string mobileBankAccountNumber { get; set; }
        #endregion
    }
}
