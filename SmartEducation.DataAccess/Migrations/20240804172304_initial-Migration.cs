using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartEducation.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccademicClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccademicClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccademicYear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yearCaption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    aliasName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    yearStatus = table.Column<int>(type: "int", nullable: true),
                    lockMonth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccademicYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bloodGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityCorporation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityCorporationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCorporation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mobileDialingCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educationLevelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fromName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fromMail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ccEmail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    bccEmail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    smtpServer = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    serverPort = table.Column<int>(type: "int", nullable: false),
                    hostName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    userName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isServerUseSsl = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamHead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    examHeadName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamHead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    examTypeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genderName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GradeScale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minimumSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    maximumSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    probitionSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeScale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guardian",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guardianCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    middleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    contactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    presentAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    permanentAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    occupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    yearlyIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardian", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HolydayType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolydayType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    shortName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    displayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eiinNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    establishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    websiteUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    founderNames = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    presentOwnerNames = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    contactPerson = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    contactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    alternetContactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    logoName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    alternetEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    isMotherInstitution = table.Column<bool>(type: "bit", nullable: true),
                    reportSortingOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    baseUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    languageName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mappingAreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileBank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    occupationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    relationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    religionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salaryTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    reportDisplayName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccademicSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accademicSectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccademicSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccademicSection_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BankTypeId = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bank_BankType_BankTypeId",
                        column: x => x.BankTypeId,
                        principalTable: "BankType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CityCorporationCounsil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    counsilName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    counsilNo = table.Column<int>(type: "int", nullable: true),
                    CityCorporationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCorporationCounsil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CityCorporationCounsil_CityCorporation_CityCorporationId",
                        column: x => x.CityCorporationId,
                        principalTable: "CityCorporation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    divisionName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Division_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EducationLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_EducationLevel_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InstitutionalDivision",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    displayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    isMainDivision = table.Column<bool>(type: "bit", nullable: true),
                    InstitutionId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionalDivision", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionalDivision_Institution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    examName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    ExamTypeId = table.Column<int>(type: "int", nullable: true),
                    ExamHeadId = table.Column<int>(type: "int", nullable: true),
                    marks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exam_ExamHead_ExamHeadId",
                        column: x => x.ExamHeadId,
                        principalTable: "ExamHead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exam_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exam_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamRoutine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    ExamTypeId = table.Column<int>(type: "int", nullable: true),
                    examDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fromHour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    toHour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRoutine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamRoutine_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamRoutine_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamRoutine_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true),
                    ExamTypeId = table.Column<int>(type: "int", nullable: true),
                    marks = table.Column<int>(type: "int", nullable: false),
                    totalMarks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectDetails_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubjectDetails_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubjectDetails_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BankBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isMainBranch = table.Column<bool>(type: "bit", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    BankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBranch_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    districtName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BranchIncharge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    contactNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchIncharge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchIncharge_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GeneralConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purpose = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    configLabel = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    configName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    configOptions = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    configValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralConfiguration_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    holidayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccademicYearId = table.Column<int>(type: "int", nullable: false),
                    HolydayTypeId = table.Column<int>(type: "int", nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holiday_AccademicYear_AccademicYearId",
                        column: x => x.AccademicYearId,
                        principalTable: "AccademicYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Holiday_HolydayType_HolydayTypeId",
                        column: x => x.HolydayTypeId,
                        principalTable: "HolydayType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Holiday_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shiftName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    beginTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    endTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shiftUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shift_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    middleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    guardianName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    lgName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lgAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    lgContact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    lgEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lgOccupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lgAge = table.Column<int>(type: "int", nullable: true),
                    AccademicYearId = table.Column<int>(type: "int", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true),
                    BankBranchId = table.Column<int>(type: "int", nullable: true),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentRegistration_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentRegistration_AccademicYear_AccademicYearId",
                        column: x => x.AccademicYearId,
                        principalTable: "AccademicYear",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentRegistration_BankBranch_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "BankBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentRegistration_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentRegistration_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Thana",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thanaName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thana_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branchName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    isMainBranch = table.Column<bool>(type: "bit", nullable: true),
                    reportSortingOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BranchInchargeId = table.Column<int>(type: "int", nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_BranchIncharge_BranchInchargeId",
                        column: x => x.BranchInchargeId,
                        principalTable: "BranchIncharge",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Branch_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    middleName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fatherOccupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherOccupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pictureName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    height = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    weight = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    BloodGroupId = table.Column<int>(type: "int", nullable: true),
                    lgName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lgAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    lgContact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    lgEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lgOccupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    lgAge = table.Column<int>(type: "int", nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true),
                    AccademicYearId = table.Column<int>(type: "int", nullable: true),
                    MeritPosition = table.Column<int>(type: "int", nullable: true),
                    ClassRoll = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccademicClassId = table.Column<int>(type: "int", nullable: true),
                    AccademicSectionId = table.Column<int>(type: "int", nullable: true),
                    ShiftId = table.Column<int>(type: "int", nullable: true),
                    BankBranchId = table.Column<int>(type: "int", nullable: true),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileBankId = table.Column<int>(type: "int", nullable: true),
                    mobileBankAccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentInfo_AccademicClass_AccademicClassId",
                        column: x => x.AccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_AccademicSection_AccademicSectionId",
                        column: x => x.AccademicSectionId,
                        principalTable: "AccademicSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_AccademicYear_AccademicYearId",
                        column: x => x.AccademicYearId,
                        principalTable: "AccademicYear",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_BankBranch_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "BankBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_BloodGroup_BloodGroupId",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_MobileBank_MobileBankId",
                        column: x => x.MobileBankId,
                        principalTable: "MobileBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentInfo_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Municipality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    municipalityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipality_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostOffice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postOfficeName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    postCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostOffice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostOffice_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Union",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Union", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Union_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    buildingName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    buildingPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    buildingType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Building_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Building_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamMarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentInfoId = table.Column<int>(type: "int", nullable: true),
                    ExamId = table.Column<int>(type: "int", nullable: true),
                    obtainMarks = table.Column<int>(type: "int", nullable: false),
                    examDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamMarks_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamMarks_StudentInfo_StudentInfoId",
                        column: x => x.StudentInfoId,
                        principalTable: "StudentInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentClassPromotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentInfoId = table.Column<int>(type: "int", nullable: true),
                    AccademicYearId = table.Column<int>(type: "int", nullable: true),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    effectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OldAccademicClassId = table.Column<int>(type: "int", nullable: true),
                    NewAccademicClassId = table.Column<int>(type: "int", nullable: true),
                    OldAccademicSectionId = table.Column<int>(type: "int", nullable: true),
                    NewAccademicSectionId = table.Column<int>(type: "int", nullable: true),
                    OldMeritPosition = table.Column<int>(type: "int", nullable: true),
                    OldClassRoll = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    newMeritPosition = table.Column<int>(type: "int", nullable: true),
                    newClassRoll = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    promotionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClassPromotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentClassPromotion_AccademicClass_NewAccademicClassId",
                        column: x => x.NewAccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentClassPromotion_AccademicClass_OldAccademicClassId",
                        column: x => x.OldAccademicClassId,
                        principalTable: "AccademicClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentClassPromotion_AccademicSection_NewAccademicSectionId",
                        column: x => x.NewAccademicSectionId,
                        principalTable: "AccademicSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentClassPromotion_AccademicSection_OldAccademicSectionId",
                        column: x => x.OldAccademicSectionId,
                        principalTable: "AccademicSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentClassPromotion_AccademicYear_AccademicYearId",
                        column: x => x.AccademicYearId,
                        principalTable: "AccademicYear",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentClassPromotion_StudentInfo_StudentInfoId",
                        column: x => x.StudentInfoId,
                        principalTable: "StudentInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MunicipalityCounsil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    counsilName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    counsilNo = table.Column<int>(type: "int", nullable: true),
                    MunicipalityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunicipalityCounsil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MunicipalityCounsil_Municipality_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipality",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wordName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    wordNo = table.Column<int>(type: "int", nullable: true),
                    UnionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Word_Union_UnionId",
                        column: x => x.UnionId,
                        principalTable: "Union",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BuildingRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    floorNumber = table.Column<int>(type: "int", nullable: true),
                    roomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingRoom_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designationName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designation_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentInfoId = table.Column<int>(type: "int", nullable: true),
                    AddressTypeId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true),
                    LocationMappingId = table.Column<int>(type: "int", nullable: true),
                    UnionId = table.Column<int>(type: "int", nullable: true),
                    WordId = table.Column<int>(type: "int", nullable: true),
                    CityCorporationId = table.Column<int>(type: "int", nullable: true),
                    CityCorporationCounsilId = table.Column<int>(type: "int", nullable: true),
                    MunicipalityId = table.Column<int>(type: "int", nullable: true),
                    MunicipalityCounsilId = table.Column<int>(type: "int", nullable: true),
                    PostOfficeId = table.Column<int>(type: "int", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    block = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    streetNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    house_Village = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAddress_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_CityCorporationCounsil_CityCorporationCounsilId",
                        column: x => x.CityCorporationCounsilId,
                        principalTable: "CityCorporationCounsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_CityCorporation_CityCorporationId",
                        column: x => x.CityCorporationId,
                        principalTable: "CityCorporation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_LocationMapping_LocationMappingId",
                        column: x => x.LocationMappingId,
                        principalTable: "LocationMapping",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_MunicipalityCounsil_MunicipalityCounsilId",
                        column: x => x.MunicipalityCounsilId,
                        principalTable: "MunicipalityCounsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_Municipality_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_PostOffice_PostOfficeId",
                        column: x => x.PostOfficeId,
                        principalTable: "PostOffice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_StudentInfo_StudentInfoId",
                        column: x => x.StudentInfoId,
                        principalTable: "StudentInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_Union_UnionId",
                        column: x => x.UnionId,
                        principalTable: "Union",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAddress_Word_WordId",
                        column: x => x.WordId,
                        principalTable: "Word",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccademicSectionId = table.Column<int>(type: "int", nullable: true),
                    BuildingRoomId = table.Column<int>(type: "int", nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRoom_AccademicSection_AccademicSectionId",
                        column: x => x.AccademicSectionId,
                        principalTable: "AccademicSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClassRoom_BuildingRoom_BuildingRoomId",
                        column: x => x.BuildingRoomId,
                        principalTable: "BuildingRoom",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    employeeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fatherOccupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    motherOccupation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    joiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    pictureName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    height = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    BloodGroupId = table.Column<int>(type: "int", nullable: true),
                    ShiftId = table.Column<int>(type: "int", nullable: true),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: true),
                    EmployeeCategoryId = table.Column<int>(type: "int", nullable: false),
                    InstitutionalDivisionId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    SectionId = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    GradeScaleId = table.Column<int>(type: "int", nullable: false),
                    SalaryTypeId = table.Column<int>(type: "int", nullable: false),
                    basicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    grossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tentativeConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    confirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BankBranchId = table.Column<int>(type: "int", nullable: true),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MobileBankId = table.Column<int>(type: "int", nullable: true),
                    mobileBankAccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastAchievedEducationId = table.Column<int>(type: "int", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_BankBranch_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "BankBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_BloodGroup_BloodGroupId",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Designation_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_EmployeeCategory_EmployeeCategoryId",
                        column: x => x.EmployeeCategoryId,
                        principalTable: "EmployeeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_GradeScale_GradeScaleId",
                        column: x => x.GradeScaleId,
                        principalTable: "GradeScale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_InstitutionalDivision_InstitutionalDivisionId",
                        column: x => x.InstitutionalDivisionId,
                        principalTable: "InstitutionalDivision",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_MobileBank_MobileBankId",
                        column: x => x.MobileBankId,
                        principalTable: "MobileBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_SalaryType_SalaryTypeId",
                        column: x => x.SalaryTypeId,
                        principalTable: "SalaryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeInfo_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfilePicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    deletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeInfoId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_EmployeeInfo_EmployeeInfoId",
                        column: x => x.EmployeeInfoId,
                        principalTable: "EmployeeInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeInfoId = table.Column<int>(type: "int", nullable: true),
                    AddressTypeId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    DivisionId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    ThanaId = table.Column<int>(type: "int", nullable: true),
                    LocationMappingId = table.Column<int>(type: "int", nullable: true),
                    UnionId = table.Column<int>(type: "int", nullable: true),
                    WordId = table.Column<int>(type: "int", nullable: true),
                    CityCorporationId = table.Column<int>(type: "int", nullable: true),
                    CityCorporationCounsilId = table.Column<int>(type: "int", nullable: true),
                    MunicipalityId = table.Column<int>(type: "int", nullable: true),
                    MunicipalityCounsilId = table.Column<int>(type: "int", nullable: true),
                    PostOfficeId = table.Column<int>(type: "int", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    block = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    streetNo = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    house_Village = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_CityCorporationCounsil_CityCorporationCounsilId",
                        column: x => x.CityCorporationCounsilId,
                        principalTable: "CityCorporationCounsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_CityCorporation_CityCorporationId",
                        column: x => x.CityCorporationId,
                        principalTable: "CityCorporation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_EmployeeInfo_EmployeeInfoId",
                        column: x => x.EmployeeInfoId,
                        principalTable: "EmployeeInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_LocationMapping_LocationMappingId",
                        column: x => x.LocationMappingId,
                        principalTable: "LocationMapping",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_MunicipalityCounsil_MunicipalityCounsilId",
                        column: x => x.MunicipalityCounsilId,
                        principalTable: "MunicipalityCounsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Municipality_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_PostOffice_PostOfficeId",
                        column: x => x.PostOfficeId,
                        principalTable: "PostOffice",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Thana_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thana",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Union_UnionId",
                        column: x => x.UnionId,
                        principalTable: "Union",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeAddress_Word_WordId",
                        column: x => x.WordId,
                        principalTable: "Word",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEducation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeInfoId = table.Column<int>(type: "int", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeEducation_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeEducation_EmployeeInfo_EmployeeInfoId",
                        column: x => x.EmployeeInfoId,
                        principalTable: "EmployeeInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccademicClass",
                columns: new[] { "Id", "className" },
                values: new object[,]
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, "Five" },
                    { 6, "Six" },
                    { 7, "Seven" },
                    { 8, "Eight" },
                    { 9, "Nine" },
                    { 10, "Ten" },
                    { 11, "Eleven" },
                    { 12, "Twelve" }
                });

            migrationBuilder.InsertData(
                table: "AddressType",
                columns: new[] { "Id", "typeName" },
                values: new object[,]
                {
                    { 1, "Present" },
                    { 2, "Permanent" }
                });

            migrationBuilder.InsertData(
                table: "BloodGroup",
                columns: new[] { "Id", "bloodGroupName" },
                values: new object[,]
                {
                    { 1, "A+" },
                    { 2, "A-" },
                    { 3, "B+" },
                    { 4, "B-" },
                    { 5, "O+" },
                    { 6, "O-" },
                    { 7, "AB+" },
                    { 8, "AB-" }
                });

            migrationBuilder.InsertData(
                table: "EducationLevel",
                columns: new[] { "Id", "code", "educationLevelName" },
                values: new object[,]
                {
                    { 1, "P101", "Primary" },
                    { 2, "S201", "Secondary" },
                    { 3, "HS301", "Higher Secondary" },
                    { 4, "UG401", "Under-graduate" },
                    { 5, "PG501", "Post-graduate" },
                    { 6, "D101", "Dimploma" },
                    { 7, "PGD201", "Post-Graduate Dimploma" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "genderName", "shortName" },
                values: new object[,]
                {
                    { 1, "Male", "M" },
                    { 2, "Female", "Fe" },
                    { 3, "Third-Gender", "TG" }
                });

            migrationBuilder.InsertData(
                table: "HolydayType",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 1, "Govt" },
                    { 2, "Eid" },
                    { 3, "Puza" },
                    { 4, "Weekly" },
                    { 5, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "languageName", "shortName" },
                values: new object[,]
                {
                    { 1, "English", "ENG" },
                    { 2, "Bangla", "BAN" }
                });

            migrationBuilder.InsertData(
                table: "MobileBank",
                columns: new[] { "Id", "bankName", "code", "createdBy", "createdDate", "deletedBy", "deletedDate", "isDeleted", "shortName", "updatedBy", "updatedDate" },
                values: new object[,]
                {
                    { 1, "Bikash", null, null, null, null, null, null, "BK", null, null },
                    { 2, "Nagad", null, null, null, null, null, null, "ND", null, null },
                    { 3, "Rocket", null, null, null, null, null, null, "RKT", null, null }
                });

            migrationBuilder.InsertData(
                table: "Relation",
                columns: new[] { "Id", "relationName" },
                values: new object[,]
                {
                    { 1, "Father" },
                    { 2, "Mother" },
                    { 3, "Brother" },
                    { 4, "Sister" },
                    { 5, "Uncle" },
                    { 6, "Aunty" },
                    { 7, "Grand-Father" },
                    { 8, "Grand-Mother" }
                });

            migrationBuilder.InsertData(
                table: "Religion",
                columns: new[] { "Id", "religionName" },
                values: new object[,]
                {
                    { 1, "Islam" },
                    { 2, "Hindu" },
                    { 3, "Christian" },
                    { 4, "Buddist" }
                });

            migrationBuilder.InsertData(
                table: "SalaryType",
                columns: new[] { "Id", "salaryTypeName", "shortName" },
                values: new object[,]
                {
                    { 1, "Consolidated", "C" },
                    { 2, "Regular", "R" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccademicSection_AccademicClassId",
                table: "AccademicSection",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeInfoId",
                table: "AspNetUsers",
                column: "EmployeeInfoId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_BankTypeId",
                table: "Bank",
                column: "BankTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BankId",
                table: "BankBranch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_BranchInchargeId",
                table: "Branch",
                column: "BranchInchargeId");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_InstitutionalDivisionId",
                table: "Branch",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchIncharge_InstitutionalDivisionId",
                table: "BranchIncharge",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BranchId",
                table: "Building",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_InstitutionalDivisionId",
                table: "Building",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingRoom_BuildingId",
                table: "BuildingRoom",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_CityCorporationCounsil_CityCorporationId",
                table: "CityCorporationCounsil",
                column: "CityCorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_AccademicSectionId",
                table: "ClassRoom",
                column: "AccademicSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_BuildingRoomId",
                table: "ClassRoom",
                column: "BuildingRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_BranchId",
                table: "Department",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Designation_DepartmentId",
                table: "Designation",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_District_DivisionId",
                table: "District",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Division_CountryId",
                table: "Division",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_EducationLevelId",
                table: "Education",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_AddressTypeId",
                table: "EmployeeAddress",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_CityCorporationCounsilId",
                table: "EmployeeAddress",
                column: "CityCorporationCounsilId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_CityCorporationId",
                table: "EmployeeAddress",
                column: "CityCorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_CountryId",
                table: "EmployeeAddress",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_DistrictId",
                table: "EmployeeAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_DivisionId",
                table: "EmployeeAddress",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_EmployeeInfoId",
                table: "EmployeeAddress",
                column: "EmployeeInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_LocationMappingId",
                table: "EmployeeAddress",
                column: "LocationMappingId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_MunicipalityCounsilId",
                table: "EmployeeAddress",
                column: "MunicipalityCounsilId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_MunicipalityId",
                table: "EmployeeAddress",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_PostOfficeId",
                table: "EmployeeAddress",
                column: "PostOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_ThanaId",
                table: "EmployeeAddress",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_UnionId",
                table: "EmployeeAddress",
                column: "UnionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddress_WordId",
                table: "EmployeeAddress",
                column: "WordId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducation_EducationId",
                table: "EmployeeEducation",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducation_EmployeeInfoId",
                table: "EmployeeEducation",
                column: "EmployeeInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_BankBranchId",
                table: "EmployeeInfo",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_BloodGroupId",
                table: "EmployeeInfo",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_BranchId",
                table: "EmployeeInfo",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_DepartmentId",
                table: "EmployeeInfo",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_DesignationId",
                table: "EmployeeInfo",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_EducationId",
                table: "EmployeeInfo",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_EmployeeCategoryId",
                table: "EmployeeInfo",
                column: "EmployeeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_EmployeeTypeId",
                table: "EmployeeInfo",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_GenderId",
                table: "EmployeeInfo",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_GradeScaleId",
                table: "EmployeeInfo",
                column: "GradeScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_InstitutionalDivisionId",
                table: "EmployeeInfo",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_MobileBankId",
                table: "EmployeeInfo",
                column: "MobileBankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_ReligionId",
                table: "EmployeeInfo",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_SalaryTypeId",
                table: "EmployeeInfo",
                column: "SalaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_SectionId",
                table: "EmployeeInfo",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_ShiftId",
                table: "EmployeeInfo",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ExamHeadId",
                table: "Exam",
                column: "ExamHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ExamTypeId",
                table: "Exam",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SubjectId",
                table: "Exam",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_ExamId",
                table: "ExamMarks",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_StudentInfoId",
                table: "ExamMarks",
                column: "StudentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutine_AccademicClassId",
                table: "ExamRoutine",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutine_ExamTypeId",
                table: "ExamRoutine",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutine_SubjectId",
                table: "ExamRoutine",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralConfiguration_InstitutionalDivisionId",
                table: "GeneralConfiguration",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_AccademicYearId",
                table: "Holiday",
                column: "AccademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_HolydayTypeId",
                table: "Holiday",
                column: "HolydayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Holiday_InstitutionalDivisionId",
                table: "Holiday",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionalDivision_InstitutionId",
                table: "InstitutionalDivision",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipality_ThanaId",
                table: "Municipality",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_MunicipalityCounsil_MunicipalityId",
                table: "MunicipalityCounsil",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PostOffice_ThanaId",
                table: "PostOffice",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_Section_DepartmentId",
                table: "Section",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_InstitutionalDivisionId",
                table: "Shift",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_AddressTypeId",
                table: "StudentAddress",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_CityCorporationCounsilId",
                table: "StudentAddress",
                column: "CityCorporationCounsilId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_CityCorporationId",
                table: "StudentAddress",
                column: "CityCorporationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_CountryId",
                table: "StudentAddress",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_DistrictId",
                table: "StudentAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_DivisionId",
                table: "StudentAddress",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_LocationMappingId",
                table: "StudentAddress",
                column: "LocationMappingId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_MunicipalityCounsilId",
                table: "StudentAddress",
                column: "MunicipalityCounsilId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_MunicipalityId",
                table: "StudentAddress",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_PostOfficeId",
                table: "StudentAddress",
                column: "PostOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_StudentInfoId",
                table: "StudentAddress",
                column: "StudentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_ThanaId",
                table: "StudentAddress",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_UnionId",
                table: "StudentAddress",
                column: "UnionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_WordId",
                table: "StudentAddress",
                column: "WordId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassPromotion_AccademicYearId",
                table: "StudentClassPromotion",
                column: "AccademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassPromotion_NewAccademicClassId",
                table: "StudentClassPromotion",
                column: "NewAccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassPromotion_NewAccademicSectionId",
                table: "StudentClassPromotion",
                column: "NewAccademicSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassPromotion_OldAccademicClassId",
                table: "StudentClassPromotion",
                column: "OldAccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassPromotion_OldAccademicSectionId",
                table: "StudentClassPromotion",
                column: "OldAccademicSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassPromotion_StudentInfoId",
                table: "StudentClassPromotion",
                column: "StudentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_AccademicClassId",
                table: "StudentInfo",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_AccademicSectionId",
                table: "StudentInfo",
                column: "AccademicSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_AccademicYearId",
                table: "StudentInfo",
                column: "AccademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_BankBranchId",
                table: "StudentInfo",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_BloodGroupId",
                table: "StudentInfo",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_GenderId",
                table: "StudentInfo",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_InstitutionalDivisionId",
                table: "StudentInfo",
                column: "InstitutionalDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_MobileBankId",
                table: "StudentInfo",
                column: "MobileBankId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_ReligionId",
                table: "StudentInfo",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_ShiftId",
                table: "StudentInfo",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_AccademicClassId",
                table: "StudentRegistration",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_AccademicYearId",
                table: "StudentRegistration",
                column: "AccademicYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_BankBranchId",
                table: "StudentRegistration",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_GenderId",
                table: "StudentRegistration",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistration_ReligionId",
                table: "StudentRegistration",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDetails_AccademicClassId",
                table: "SubjectDetails",
                column: "AccademicClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDetails_ExamTypeId",
                table: "SubjectDetails",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDetails_SubjectId",
                table: "SubjectDetails",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Thana_DistrictId",
                table: "Thana",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Union_ThanaId",
                table: "Union",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_Word_UnionId",
                table: "Word",
                column: "UnionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClassRoom");

            migrationBuilder.DropTable(
                name: "EmailConfiguration");

            migrationBuilder.DropTable(
                name: "EmployeeAddress");

            migrationBuilder.DropTable(
                name: "EmployeeEducation");

            migrationBuilder.DropTable(
                name: "ExamMarks");

            migrationBuilder.DropTable(
                name: "ExamRoutine");

            migrationBuilder.DropTable(
                name: "GeneralConfiguration");

            migrationBuilder.DropTable(
                name: "Guardian");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "Relation");

            migrationBuilder.DropTable(
                name: "StudentAddress");

            migrationBuilder.DropTable(
                name: "StudentClassPromotion");

            migrationBuilder.DropTable(
                name: "StudentRegistration");

            migrationBuilder.DropTable(
                name: "SubjectDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BuildingRoom");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "HolydayType");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "CityCorporationCounsil");

            migrationBuilder.DropTable(
                name: "LocationMapping");

            migrationBuilder.DropTable(
                name: "MunicipalityCounsil");

            migrationBuilder.DropTable(
                name: "PostOffice");

            migrationBuilder.DropTable(
                name: "Word");

            migrationBuilder.DropTable(
                name: "StudentInfo");

            migrationBuilder.DropTable(
                name: "EmployeeInfo");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "ExamHead");

            migrationBuilder.DropTable(
                name: "ExamType");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "CityCorporation");

            migrationBuilder.DropTable(
                name: "Municipality");

            migrationBuilder.DropTable(
                name: "Union");

            migrationBuilder.DropTable(
                name: "AccademicSection");

            migrationBuilder.DropTable(
                name: "AccademicYear");

            migrationBuilder.DropTable(
                name: "BankBranch");

            migrationBuilder.DropTable(
                name: "BloodGroup");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "EmployeeCategory");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "GradeScale");

            migrationBuilder.DropTable(
                name: "MobileBank");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "SalaryType");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Thana");

            migrationBuilder.DropTable(
                name: "AccademicClass");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "EducationLevel");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "BankType");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "BranchIncharge");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "InstitutionalDivision");

            migrationBuilder.DropTable(
                name: "Institution");
        }
    }
}
