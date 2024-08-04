using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartEducation.Domain.Model.Auth;
using SmartEducation.Domain.Model.Employee;
using SmartEducation.Domain.Model.Exam;
using SmartEducation.Domain.Model.Guardian;
using SmartEducation.Domain.Model.MasterPanel;
using SmartEducation.Domain.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.DataAccess.DBContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        internal object tblName;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        #region Account
         //public DbSet<Country> Country { get; set; }
        #endregion

        #region Attendance
        //public DbSet<Country> Country { get; set; }
        #endregion

        #region Auth
        //public DbSet<Country> Country { get; set; }
        #endregion

        #region Employee
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducation { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        #endregion

        #region Event
        //public DbSet<Country> Country { get; set; }
        #endregion

        #region Exam
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExamHead> ExamHead { get; set; }
        public DbSet<ExamMarks> ExamMarks { get; set; }
        public DbSet<ExamRoutine> ExamRoutine { get; set; }
        public DbSet<ExamType> ExamType { get; set; }
        #endregion

        #region Guardian
        public DbSet<Guardian> Guardian { get; set; }
        #endregion

        #region MasterPanel
        public DbSet<AccademicClass> AccademicClass { get; set; }
        public DbSet<AccademicSection> AccademicSection { get; set; }
        public DbSet<AccademicYear> AccademicYear { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankBranch> BankBranch { get; set; }
        public DbSet<BankType> BankType { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<BranchIncharge> BranchIncharge { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<BuildingRoom> BuildingRoom { get; set; }
        public DbSet<CityCorporation> CityCorporation { get; set; }
        public DbSet<CityCorporationCounsil> CityCorporationCounsil { get; set; }
        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<EmailConfiguration> EmailConfiguration { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<GeneralConfiguration> GeneralConfiguration { get; set; }
        public DbSet<GradeScale> GradeScale { get; set; }
        //public DbSet<GradeScaleDetails> GradeScaleDetails { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<HolydayType> HolydayType { get; set; }
        public DbSet<Institution> Institution { get; set; }
        public DbSet<InstitutionalDivision> InstitutionalDivision { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<LocationMapping> LocationMapping { get; set; }
        public DbSet<MobileBank> MobileBank { get; set; }
        public DbSet<Municipality> Municipality { get; set; }
        public DbSet<MunicipalityCounsil> MunicipalityCounsil { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<Relation> Relation { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<SalaryType> SalaryType { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectDetails> SubjectDetails { get; set; }
        public DbSet<Thana> Thana { get; set; }
        public DbSet<Union> Union { get; set; }
        public DbSet<Word> Word { get; set; }
        #endregion

        #region Student
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<StudentClassPromotion> StudentClassPromotion { get; set; }
        public DbSet<StudentInfo> StudentInfo { get; set; }
        public DbSet<StudentRegistration> StudentRegistration { get; set; }
        #endregion





        #region ViewModel_Data_Retrive
        //public DbSet<VmStudent> VmStudent { get; set; } = null;
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Parent>().HasKey(t => t.Id);
            //modelBuilder.Entity<Parent>().HasMany(t => t.Student).WithOne(t => t.Parent);

            //modelBuilder.Entity<Country>().HasKey(t => t.Id);
            //modelBuilder.Entity<Country>().HasMany(t => t.Student).WithOne(t => t.Country);

            //modelBuilder.Entity<Student>().HasKey(t => t.Id);

            //modelBuilder.Entity<VmStudent>().HasNoKey().ToView("view_name_that_doesnt_exist");
            //modelBuilder.Entity<VmStudent>().HasNoKey();

            #region SEED_DATA

            #region SalaryType
            modelBuilder.Entity<SalaryType>().HasData(new List<SalaryType>
            {
                new SalaryType // 1
                {
                    Id=1,
                    salaryTypeName = "Consolidated",
                    shortName="C"
                },
               new SalaryType // 1
                {
                    Id=2,
                    salaryTypeName = "Regular",
                    shortName="R"
                }
            });
            #endregion

            #region languageName
            modelBuilder.Entity<Language>().HasData(new List<Language>
            {
                new Language // 1
                {
                    Id=1,
                    languageName = "English",
                    shortName="ENG"
                },
               new Language // 1
                {
                   Id=2,
                    languageName = "Bangla",
                    shortName="BAN"
                }
            });
            #endregion

            #region MobileBank
            modelBuilder.Entity<MobileBank>().HasData(new List<MobileBank>
            {
                new MobileBank
                {
                    Id=1,
                    bankName = "Bikash",
                    shortName="BK"
                },
               new MobileBank
                {
                   Id=2,
                    bankName = "Nagad",
                    shortName="ND"
                }
               ,
               new MobileBank
               {
                   Id=3,
                   bankName = "Rocket",
                   shortName="RKT"
               }
            });
            #endregion

            #region EducationLevel
            modelBuilder.Entity<EducationLevel>().HasData(new List<EducationLevel>
            {
                new EducationLevel
                {
                    Id=1,
                    educationLevelName = "Primary",
                    code="P101"
                },
                new EducationLevel
                {
                    Id=2,
                    educationLevelName = "Secondary",
                    code="S201"
                },
                new EducationLevel
                {
                    Id=3,
                    educationLevelName = "Higher Secondary",
                    code="HS301"
                },
                 new EducationLevel
                {
                     Id=4,
                    educationLevelName = "Under-graduate",
                    code="UG401"
                },
                  new EducationLevel
                {
                      Id=5,
                    educationLevelName = "Post-graduate",
                    code="PG501"
                },
                  new EducationLevel
                {
                      Id=6,
                    educationLevelName = "Dimploma",
                    code="D101"
                },
                new EducationLevel
                {
                    Id=7,
                    educationLevelName = "Post-Graduate Dimploma",
                    code="PGD201"
                },
            });
            #endregion

            #region Gender
            modelBuilder.Entity<Gender>().HasData(new List<Gender>
            {
                new Gender
                {
                    Id=1,
                    genderName = "Male",
                    shortName="M"
                },
                new Gender
                {
                    Id=2,
                    genderName = "Female",
                    shortName="Fe"
                },
                new Gender
                {
                    Id=3,
                    genderName = "Third-Gender",
                    shortName="TG"
                }
            });
            #endregion

            #region HolydayType
            modelBuilder.Entity<HolydayType>().HasData(new List<HolydayType>
            {
                new HolydayType
                {
                    Id=1,
                    name = "Govt"
                },
               new HolydayType
                {
                   Id=2,
                    name = "Eid"
                },
               new HolydayType
                {Id=3,
                   name = "Puza"
                },
               new HolydayType
                {
                   Id=4,
                    name = "Weekly"
                },
                new HolydayType
                {
                    Id=5,
                    name = "Others"
                },
            });
            #endregion

            #region AccademicClass
            modelBuilder.Entity<AccademicClass>().HasData(new List<AccademicClass>
            {
                new AccademicClass // 1
                {
                    Id=1,
                    className = "One"
                },
               new AccademicClass // 1
                {
                   Id=2,
                    className = "Two",
                },
               new AccademicClass // 1
                {Id = 3,
                    className = "Three",
                }
               ,
               new AccademicClass // 1
                {Id = 4,
                    className = "Four",
                }
               ,
               new AccademicClass // 1
                {
                   Id=5,
                    className = "Five",
                }
               ,
               new AccademicClass // 1
                {
                   Id=6,
                    className = "Six",
                }
               ,
               new AccademicClass // 1
                {
                   Id=7,
                    className = "Seven",
                }
               ,
               new AccademicClass // 1
                {
                   Id=8,
                    className = "Eight",
                }
               ,
               new AccademicClass // 1
                {
                   Id=9,
                    className = "Nine",
                }
               ,
               new AccademicClass // 1
                {
                   Id=10,
                    className = "Ten",
                }
               ,
               new AccademicClass // 1
                {
                   Id=11,
                    className = "Eleven",
                }
               ,
               new AccademicClass // 1
                {
                    Id=12,
                    className = "Twelve",
                }
            });
            #endregion

            #region AddressType
            modelBuilder.Entity<AddressType>().HasData(new List<AddressType>
            {
                new AddressType // 1
                {
                    Id=1,
                    typeName = "Present"
                },
                 new AddressType // 1
                {
                     Id=2,
                    typeName = "Permanent"
                }
            });
            #endregion

            #region BloodGroup
            modelBuilder.Entity<BloodGroup>().HasData(new List<BloodGroup>
            {
                new BloodGroup
                {
                    Id=1,
                    bloodGroupName = "A+"
                },
                 new BloodGroup
                {Id=2,
                    bloodGroupName = "A-"
                },
                 new BloodGroup
                {
                     Id=3,
                    bloodGroupName = "B+"
                },
                 new BloodGroup
                {
                     Id=4,
                    bloodGroupName = "B-"
                },
                 new BloodGroup
                {
                     Id=5,
                    bloodGroupName = "O+"
                },
                 new BloodGroup
                {
                     Id=6,
                    bloodGroupName = "O-"
                },
                 new BloodGroup
                {
                     Id=7,
                    bloodGroupName = "AB+"
                },
                 new BloodGroup
                {
                     Id=8,
                    bloodGroupName = "AB-"
                }
            });
            #endregion

            #region Relation
            modelBuilder.Entity<Relation>().HasData(new List<Relation>
            {
                new Relation
                {
                    Id=1,
                    relationName = "Father"
                },
                 new Relation
                {Id = 2,
                    relationName = "Mother"
                },
                 new Relation
                {
                     Id=3,
                    relationName = "Brother"
                },
                 new Relation
                {
                     Id=4,
                    relationName = "Sister"
                }
                 ,
                 new Relation
                {
                     Id=5,
                    relationName = "Uncle"
                }
                 ,
                 new Relation
                {
                     Id=6,
                    relationName = "Aunty"
                }
                 ,
                 new Relation
                {
                     Id=7,
                    relationName = "Grand-Father"
                }
                 ,
                 new Relation
                {
                     Id=8,
                    relationName = "Grand-Mother"
                }
            });
            #endregion

            #region Religion

            modelBuilder.Entity<Religion>().HasData(new List<Religion>
            {
                new Religion
                {
                    Id=1,
                    religionName = "Islam"
                },
                 new Religion
                {
                     Id=2,
                    religionName = "Hindu"
                },
                 new Religion
                {
                     Id=3,
                    religionName = "Christian"
                },
                 new Religion
                {
                     Id=4,
                    religionName = "Buddist"
                }
            });
            #endregion

            #endregion


            //modelBuilder.Entity<VmStudent>(builder =>
            //{
            //    builder.HasNoKey();
            //});



        }
    }
}
