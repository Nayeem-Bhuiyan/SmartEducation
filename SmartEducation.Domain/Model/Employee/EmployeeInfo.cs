using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Employee
{
    public class EmployeeInfo:BaseAuditEntity
    {
        #region General_Information
        [StringLength(100)]
        public string employeeCode { get; set; } //Life Time School Identity
        [StringLength(250)]
        public string employeeName { get; set; }

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

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? joiningDate { get; set; }

        [StringLength(150)]
        public string email { get; set; }
        [StringLength(30)]
        public string contact { get; set; }

        [StringLength(400)]
        public string pictureName { get; set; }

        [StringLength(100)]
        public string height { get; set; }



        #endregion

        #region General_Relational_Info
        [ForeignKey("GenderId")]
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("ReligionId")]
        public int? ReligionId { get; set; }
        public Religion Religion { get; set; }

        [ForeignKey("BloodGroupId")]
        public int? BloodGroupId { get; set; }
        public BloodGroup BloodGrop { get; set; }

        [ForeignKey("ShiftId")]
        public int? ShiftId { get; set; }
        public Shift Shift { get; set; }

        [ForeignKey("EmployeeTypeId")]
        public int? EmployeeTypeId { get; set; }    //Contactual,Permanent
        public EmployeeType EmployeeType { get; set; }

        [ForeignKey("EmployeeCategoryId")]
        public int EmployeeCategoryId { get; set; }   //Teacher,Staff,etc
        public EmployeeCategory EmployeeCategory { get; set; }
        #endregion

        #region Transfer_Info
        [ForeignKey("InstitutionalDivisionId")]
        public int? InstitutionalDivisionId { get; set; }
        public InstitutionalDivision InstitutionalDivision { get; set; }

        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("SectionId")]
        public int? SectionId { get; set; }
        public Section Section { get; set; }
        #endregion

        #region Promotion_Increment_Salary
        [ForeignKey("DesignationId")]
        public int DesignationId { get; set; }   
        public Designation Designation { get; set; }

        [ForeignKey("GradeScaleId")]
        public int GradeScaleId { get; set; }
        public GradeScale GradeScale { get; set; }   
        
        [ForeignKey("SalaryTypeId")]
        public int SalaryTypeId { get; set; }  //Consolidated=C,Regular=R
        public SalaryType SalaryType { get; set; } 

        public decimal basicSalary { get; set; }
        public decimal grossSalary { get; set; }
        #endregion

        #region Confirmation
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? tentativeConfirmationDate { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? confirmationDate { get; set; }
        #endregion

        #region Bank_Information
        [ForeignKey("BankBranchId")]
        public int? BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }
        [StringLength(150)]
        public string bankAccountNumber { get; set; }

        [ForeignKey("MobileBankId")]
        public int? MobileBankId { get; set; }
        public MobileBank MobileBank { get; set; }
        [StringLength(50)]
        public string mobileBankAccountNumber { get; set; }
        #endregion

        #region Education
        [ForeignKey("LastAchievedEducationId")]
        public int? LastAchievedEducationId { get; set; }
        public Education Education { get; set; }
        #endregion
    }
}
