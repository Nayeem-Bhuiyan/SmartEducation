IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AccademicClass] (
    [Id] int NOT NULL IDENTITY,
    [className] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_AccademicClass] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AccademicYear] (
    [Id] int NOT NULL IDENTITY,
    [yearCaption] nvarchar(100) NULL,
    [aliasName] nvarchar(100) NULL,
    [fromDate] datetime2 NULL,
    [toDate] datetime2 NULL,
    [yearStatus] int NULL,
    [lockMonth] datetime2 NULL,
    CONSTRAINT [PK_AccademicYear] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AddressType] (
    [Id] int NOT NULL IDENTITY,
    [typeName] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_AddressType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Description] nvarchar(max) NULL,
    [IpAddress] nvarchar(max) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [BankType] (
    [Id] int NOT NULL IDENTITY,
    [bankTypeName] nvarchar(max) NULL,
    CONSTRAINT [PK_BankType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [BloodGroup] (
    [Id] int NOT NULL IDENTITY,
    [bloodGroupName] nvarchar(max) NULL,
    CONSTRAINT [PK_BloodGroup] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CityCorporation] (
    [Id] int NOT NULL IDENTITY,
    [cityCorporationName] nvarchar(100) NOT NULL,
    [code] nvarchar(100) NULL,
    CONSTRAINT [PK_CityCorporation] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Country] (
    [Id] int NOT NULL IDENTITY,
    [countryName] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [shortName] nvarchar(50) NULL,
    [mobileDialingCode] nvarchar(50) NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EducationLevel] (
    [Id] int NOT NULL IDENTITY,
    [educationLevelName] nvarchar(100) NOT NULL,
    [code] nvarchar(30) NULL,
    CONSTRAINT [PK_EducationLevel] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EmailConfiguration] (
    [Id] int NOT NULL IDENTITY,
    [fromName] nvarchar(250) NULL,
    [fromMail] nvarchar(250) NULL,
    [ccEmail] nvarchar(250) NULL,
    [bccEmail] nvarchar(250) NULL,
    [smtpServer] nvarchar(150) NULL,
    [serverPort] int NOT NULL,
    [hostName] nvarchar(250) NULL,
    [userName] nvarchar(250) NULL,
    [password] nvarchar(250) NULL,
    [isServerUseSsl] bit NOT NULL,
    CONSTRAINT [PK_EmailConfiguration] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EmployeeCategory] (
    [Id] int NOT NULL IDENTITY,
    [employeeCategoryName] nvarchar(100) NULL,
    [code] nvarchar(30) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_EmployeeCategory] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EmployeeType] (
    [Id] int NOT NULL IDENTITY,
    [employeeTypeName] nvarchar(100) NULL,
    CONSTRAINT [PK_EmployeeType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ExamHead] (
    [Id] int NOT NULL IDENTITY,
    [examHeadName] nvarchar(150) NULL,
    CONSTRAINT [PK_ExamHead] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ExamType] (
    [Id] int NOT NULL IDENTITY,
    [examTypeName] nvarchar(150) NULL,
    CONSTRAINT [PK_ExamType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Gender] (
    [Id] int NOT NULL IDENTITY,
    [genderName] nvarchar(120) NULL,
    [shortName] nvarchar(30) NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [GradeScale] (
    [Id] int NOT NULL IDENTITY,
    [gradeName] nvarchar(max) NULL,
    [minimumSalary] decimal(18,2) NOT NULL,
    [maximumSalary] decimal(18,2) NOT NULL,
    [probitionSalary] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_GradeScale] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Guardian] (
    [Id] int NOT NULL IDENTITY,
    [guardianCode] nvarchar(50) NULL,
    [firstName] nvarchar(150) NULL,
    [middleName] nvarchar(150) NULL,
    [lastName] nvarchar(150) NULL,
    [fatherName] nvarchar(150) NULL,
    [motherName] nvarchar(150) NULL,
    [contactNumber] nvarchar(30) NULL,
    [email] nvarchar(150) NULL,
    [presentAddress] nvarchar(250) NULL,
    [permanentAddress] nvarchar(250) NULL,
    [occupation] nvarchar(150) NULL,
    [yearlyIncome] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Guardian] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [HolydayType] (
    [Id] int NOT NULL IDENTITY,
    [name] nvarchar(max) NULL,
    CONSTRAINT [PK_HolydayType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Institution] (
    [Id] int NOT NULL IDENTITY,
    [fullName] nvarchar(250) NOT NULL,
    [shortName] nvarchar(80) NULL,
    [displayName] nvarchar(250) NULL,
    [code] nvarchar(50) NULL,
    [eiinNumber] nvarchar(100) NULL,
    [establishDate] datetime2 NULL,
    [address] nvarchar(250) NULL,
    [websiteUrl] nvarchar(250) NULL,
    [founderNames] nvarchar(500) NULL,
    [presentOwnerNames] nvarchar(500) NULL,
    [contactPerson] nvarchar(250) NULL,
    [contactNumber] nvarchar(30) NULL,
    [alternetContactNumber] nvarchar(30) NULL,
    [email] nvarchar(120) NULL,
    [logoName] nvarchar(120) NULL,
    [alternetEmail] nvarchar(120) NULL,
    [isMotherInstitution] bit NULL,
    [reportSortingOrder] nvarchar(100) NULL,
    [baseUrl] nvarchar(1000) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Institution] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Language] (
    [Id] int NOT NULL IDENTITY,
    [languageName] nvarchar(150) NULL,
    [shortName] nvarchar(50) NULL,
    CONSTRAINT [PK_Language] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [LocationMapping] (
    [Id] int NOT NULL IDENTITY,
    [mappingAreaName] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_LocationMapping] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [MobileBank] (
    [Id] int NOT NULL IDENTITY,
    [bankName] nvarchar(150) NULL,
    [shortName] nvarchar(100) NULL,
    [code] nvarchar(100) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_MobileBank] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Occupation] (
    [Id] int NOT NULL IDENTITY,
    [occupationName] nvarchar(150) NOT NULL,
    [shortName] nvarchar(50) NULL,
    CONSTRAINT [PK_Occupation] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Relation] (
    [Id] int NOT NULL IDENTITY,
    [relationName] nvarchar(120) NOT NULL,
    CONSTRAINT [PK_Relation] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Religion] (
    [Id] int NOT NULL IDENTITY,
    [religionName] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Religion] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [SalaryType] (
    [Id] int NOT NULL IDENTITY,
    [salaryTypeName] nvarchar(100) NULL,
    [shortName] nvarchar(50) NULL,
    CONSTRAINT [PK_SalaryType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Subject] (
    [Id] int NOT NULL IDENTITY,
    [subjectName] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [reportDisplayName] nvarchar(150) NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AccademicSection] (
    [Id] int NOT NULL IDENTITY,
    [accademicSectionName] nvarchar(max) NULL,
    [AccademicClassId] int NULL,
    CONSTRAINT [PK_AccademicSection] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AccademicSection_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Bank] (
    [Id] int NOT NULL IDENTITY,
    [name] nvarchar(100) NULL,
    [shortName] nvarchar(50) NULL,
    [BankTypeId] int NULL,
    [description] nvarchar(150) NULL,
    [address] nvarchar(max) NULL,
    CONSTRAINT [PK_Bank] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bank_BankType_BankTypeId] FOREIGN KEY ([BankTypeId]) REFERENCES [BankType] ([Id])
);
GO

CREATE TABLE [CityCorporationCounsil] (
    [Id] int NOT NULL IDENTITY,
    [counsilName] nvarchar(150) NOT NULL,
    [counsilNo] int NULL,
    [CityCorporationId] int NULL,
    CONSTRAINT [PK_CityCorporationCounsil] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CityCorporationCounsil_CityCorporation_CityCorporationId] FOREIGN KEY ([CityCorporationId]) REFERENCES [CityCorporation] ([Id])
);
GO

CREATE TABLE [Division] (
    [Id] int NOT NULL IDENTITY,
    [divisionName] nvarchar(250) NOT NULL,
    [code] nvarchar(50) NULL,
    [CountryId] int NULL,
    CONSTRAINT [PK_Division] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Division_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([Id])
);
GO

CREATE TABLE [Education] (
    [Id] int NOT NULL IDENTITY,
    [educationName] nvarchar(120) NOT NULL,
    [code] nvarchar(30) NULL,
    [EducationLevelId] int NULL,
    CONSTRAINT [PK_Education] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Education_EducationLevel_EducationLevelId] FOREIGN KEY ([EducationLevelId]) REFERENCES [EducationLevel] ([Id])
);
GO

CREATE TABLE [InstitutionalDivision] (
    [Id] int NOT NULL IDENTITY,
    [fullName] nvarchar(250) NOT NULL,
    [displayName] nvarchar(250) NULL,
    [code] nvarchar(50) NULL,
    [isMainDivision] bit NULL,
    [InstitutionId] int NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_InstitutionalDivision] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_InstitutionalDivision_Institution_InstitutionId] FOREIGN KEY ([InstitutionId]) REFERENCES [Institution] ([Id])
);
GO

CREATE TABLE [Exam] (
    [Id] int NOT NULL IDENTITY,
    [examName] nvarchar(150) NULL,
    [code] nvarchar(50) NULL,
    [SubjectId] int NULL,
    [ExamTypeId] int NULL,
    [ExamHeadId] int NULL,
    [marks] int NOT NULL,
    CONSTRAINT [PK_Exam] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Exam_ExamHead_ExamHeadId] FOREIGN KEY ([ExamHeadId]) REFERENCES [ExamHead] ([Id]),
    CONSTRAINT [FK_Exam_ExamType_ExamTypeId] FOREIGN KEY ([ExamTypeId]) REFERENCES [ExamType] ([Id]),
    CONSTRAINT [FK_Exam_Subject_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [Subject] ([Id])
);
GO

CREATE TABLE [ExamRoutine] (
    [Id] int NOT NULL IDENTITY,
    [AccademicClassId] int NULL,
    [SubjectId] int NULL,
    [ExamTypeId] int NULL,
    [examDate] datetime2 NULL,
    [fromHour] nvarchar(50) NULL,
    [toHour] nvarchar(50) NULL,
    CONSTRAINT [PK_ExamRoutine] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ExamRoutine_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]),
    CONSTRAINT [FK_ExamRoutine_ExamType_ExamTypeId] FOREIGN KEY ([ExamTypeId]) REFERENCES [ExamType] ([Id]),
    CONSTRAINT [FK_ExamRoutine_Subject_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [Subject] ([Id])
);
GO

CREATE TABLE [SubjectDetails] (
    [Id] int NOT NULL IDENTITY,
    [SubjectId] int NULL,
    [AccademicClassId] int NULL,
    [ExamTypeId] int NULL,
    [marks] int NOT NULL,
    [totalMarks] int NOT NULL,
    CONSTRAINT [PK_SubjectDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SubjectDetails_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]),
    CONSTRAINT [FK_SubjectDetails_ExamType_ExamTypeId] FOREIGN KEY ([ExamTypeId]) REFERENCES [ExamType] ([Id]),
    CONSTRAINT [FK_SubjectDetails_Subject_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [Subject] ([Id])
);
GO

CREATE TABLE [BankBranch] (
    [Id] int NOT NULL IDENTITY,
    [name] nvarchar(120) NULL,
    [address] nvarchar(250) NULL,
    [isMainBranch] bit NOT NULL,
    [contact] nvarchar(30) NULL,
    [email] nvarchar(120) NULL,
    [BankId] int NOT NULL,
    CONSTRAINT [PK_BankBranch] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BankBranch_Bank_BankId] FOREIGN KEY ([BankId]) REFERENCES [Bank] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [District] (
    [Id] int NOT NULL IDENTITY,
    [districtName] nvarchar(max) NOT NULL,
    [code] nvarchar(50) NULL,
    [DivisionId] int NULL,
    CONSTRAINT [PK_District] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_District_Division_DivisionId] FOREIGN KEY ([DivisionId]) REFERENCES [Division] ([Id])
);
GO

CREATE TABLE [BranchIncharge] (
    [Id] int NOT NULL IDENTITY,
    [name] nvarchar(150) NULL,
    [code] nvarchar(50) NULL,
    [fatherName] nvarchar(150) NULL,
    [motherName] nvarchar(150) NULL,
    [contactNumber] nvarchar(30) NULL,
    [email] nvarchar(100) NULL,
    [address] nvarchar(max) NULL,
    [InstitutionalDivisionId] int NULL,
    CONSTRAINT [PK_BranchIncharge] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BranchIncharge_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id])
);
GO

CREATE TABLE [GeneralConfiguration] (
    [Id] int NOT NULL IDENTITY,
    [purpose] nvarchar(120) NULL,
    [configLabel] nvarchar(120) NULL,
    [configName] nvarchar(120) NULL,
    [configOptions] nvarchar(50) NULL,
    [configValue] nvarchar(50) NULL,
    [InstitutionalDivisionId] int NULL,
    CONSTRAINT [PK_GeneralConfiguration] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_GeneralConfiguration_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id])
);
GO

CREATE TABLE [Holiday] (
    [Id] int NOT NULL IDENTITY,
    [holidayName] nvarchar(max) NOT NULL,
    [fromDate] datetime2 NOT NULL,
    [toDate] datetime2 NOT NULL,
    [AccademicYearId] int NOT NULL,
    [HolydayTypeId] int NULL,
    [InstitutionalDivisionId] int NULL,
    CONSTRAINT [PK_Holiday] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Holiday_AccademicYear_AccademicYearId] FOREIGN KEY ([AccademicYearId]) REFERENCES [AccademicYear] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Holiday_HolydayType_HolydayTypeId] FOREIGN KEY ([HolydayTypeId]) REFERENCES [HolydayType] ([Id]),
    CONSTRAINT [FK_Holiday_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id])
);
GO

CREATE TABLE [Shift] (
    [Id] int NOT NULL IDENTITY,
    [shiftName] nvarchar(120) NULL,
    [shortName] nvarchar(50) NULL,
    [fromDate] datetime2 NULL,
    [toDate] datetime2 NULL,
    [beginTime] nvarchar(50) NULL,
    [endTime] nvarchar(50) NULL,
    [shiftUser] nvarchar(30) NULL,
    [isActive] bit NOT NULL,
    [InstitutionalDivisionId] int NULL,
    CONSTRAINT [PK_Shift] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Shift_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id])
);
GO

CREATE TABLE [StudentRegistration] (
    [Id] int NOT NULL IDENTITY,
    [studentCode] nvarchar(100) NULL,
    [firstName] nvarchar(150) NULL,
    [middleName] nvarchar(150) NULL,
    [lastName] nvarchar(150) NULL,
    [fatherName] nvarchar(150) NULL,
    [motherName] nvarchar(150) NULL,
    [guardianName] nvarchar(150) NULL,
    [GenderId] int NULL,
    [ReligionId] int NULL,
    [lgName] nvarchar(150) NULL,
    [lgAddress] nvarchar(250) NULL,
    [lgContact] nvarchar(30) NULL,
    [lgEmail] nvarchar(150) NULL,
    [lgOccupation] nvarchar(150) NULL,
    [lgAge] int NULL,
    [AccademicYearId] int NULL,
    [AccademicClassId] int NULL,
    [BankBranchId] int NULL,
    [bankAccountNumber] nvarchar(max) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_StudentRegistration] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StudentRegistration_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]),
    CONSTRAINT [FK_StudentRegistration_AccademicYear_AccademicYearId] FOREIGN KEY ([AccademicYearId]) REFERENCES [AccademicYear] ([Id]),
    CONSTRAINT [FK_StudentRegistration_BankBranch_BankBranchId] FOREIGN KEY ([BankBranchId]) REFERENCES [BankBranch] ([Id]),
    CONSTRAINT [FK_StudentRegistration_Gender_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Gender] ([Id]),
    CONSTRAINT [FK_StudentRegistration_Religion_ReligionId] FOREIGN KEY ([ReligionId]) REFERENCES [Religion] ([Id])
);
GO

CREATE TABLE [Thana] (
    [Id] int NOT NULL IDENTITY,
    [thanaName] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [DistrictId] int NULL,
    CONSTRAINT [PK_Thana] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Thana_District_DistrictId] FOREIGN KEY ([DistrictId]) REFERENCES [District] ([Id])
);
GO

CREATE TABLE [Branch] (
    [Id] int NOT NULL IDENTITY,
    [branchName] nvarchar(250) NOT NULL,
    [code] nvarchar(50) NULL,
    [shortName] nvarchar(50) NULL,
    [contact] nvarchar(30) NULL,
    [email] nvarchar(150) NULL,
    [address] nvarchar(250) NULL,
    [isMainBranch] bit NULL,
    [reportSortingOrder] nvarchar(100) NULL,
    [BranchInchargeId] int NULL,
    [InstitutionalDivisionId] int NOT NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Branch] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Branch_BranchIncharge_BranchInchargeId] FOREIGN KEY ([BranchInchargeId]) REFERENCES [BranchIncharge] ([Id]),
    CONSTRAINT [FK_Branch_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [StudentInfo] (
    [Id] int NOT NULL IDENTITY,
    [registrationNumber] nvarchar(100) NULL,
    [firstName] nvarchar(150) NULL,
    [middleName] nvarchar(150) NULL,
    [lastName] nvarchar(150) NULL,
    [fatherName] nvarchar(150) NULL,
    [motherName] nvarchar(150) NULL,
    [fatherOccupation] nvarchar(150) NULL,
    [motherOccupation] nvarchar(150) NULL,
    [dateOfBirth] datetime2 NULL,
    [email] nvarchar(150) NULL,
    [contact] nvarchar(30) NULL,
    [pictureName] nvarchar(400) NULL,
    [height] nvarchar(100) NULL,
    [weight] nvarchar(100) NULL,
    [GenderId] int NULL,
    [ReligionId] int NULL,
    [BloodGroupId] int NULL,
    [lgName] nvarchar(150) NULL,
    [lgAddress] nvarchar(250) NULL,
    [lgContact] nvarchar(30) NULL,
    [lgEmail] nvarchar(150) NULL,
    [lgOccupation] nvarchar(150) NULL,
    [lgAge] int NULL,
    [InstitutionalDivisionId] int NULL,
    [AccademicYearId] int NULL,
    [MeritPosition] int NULL,
    [ClassRoll] nvarchar(max) NULL,
    [AccademicClassId] int NULL,
    [AccademicSectionId] int NULL,
    [ShiftId] int NULL,
    [BankBranchId] int NULL,
    [bankAccountNumber] nvarchar(max) NULL,
    [MobileBankId] int NULL,
    [mobileBankAccountNumber] nvarchar(50) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_StudentInfo] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StudentInfo_AccademicClass_AccademicClassId] FOREIGN KEY ([AccademicClassId]) REFERENCES [AccademicClass] ([Id]),
    CONSTRAINT [FK_StudentInfo_AccademicSection_AccademicSectionId] FOREIGN KEY ([AccademicSectionId]) REFERENCES [AccademicSection] ([Id]),
    CONSTRAINT [FK_StudentInfo_AccademicYear_AccademicYearId] FOREIGN KEY ([AccademicYearId]) REFERENCES [AccademicYear] ([Id]),
    CONSTRAINT [FK_StudentInfo_BankBranch_BankBranchId] FOREIGN KEY ([BankBranchId]) REFERENCES [BankBranch] ([Id]),
    CONSTRAINT [FK_StudentInfo_BloodGroup_BloodGroupId] FOREIGN KEY ([BloodGroupId]) REFERENCES [BloodGroup] ([Id]),
    CONSTRAINT [FK_StudentInfo_Gender_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Gender] ([Id]),
    CONSTRAINT [FK_StudentInfo_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]),
    CONSTRAINT [FK_StudentInfo_MobileBank_MobileBankId] FOREIGN KEY ([MobileBankId]) REFERENCES [MobileBank] ([Id]),
    CONSTRAINT [FK_StudentInfo_Religion_ReligionId] FOREIGN KEY ([ReligionId]) REFERENCES [Religion] ([Id]),
    CONSTRAINT [FK_StudentInfo_Shift_ShiftId] FOREIGN KEY ([ShiftId]) REFERENCES [Shift] ([Id])
);
GO

CREATE TABLE [Municipality] (
    [Id] int NOT NULL IDENTITY,
    [municipalityName] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [address] nvarchar(150) NULL,
    [ThanaId] int NULL,
    CONSTRAINT [PK_Municipality] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Municipality_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id])
);
GO

CREATE TABLE [PostOffice] (
    [Id] int NOT NULL IDENTITY,
    [postOfficeName] nvarchar(120) NOT NULL,
    [postCode] nvarchar(50) NULL,
    [ThanaId] int NULL,
    CONSTRAINT [PK_PostOffice] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PostOffice_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id])
);
GO

CREATE TABLE [Union] (
    [Id] int NOT NULL IDENTITY,
    [unionName] nvarchar(150) NOT NULL,
    [code] nvarchar(50) NULL,
    [ThanaId] int NULL,
    CONSTRAINT [PK_Union] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Union_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id])
);
GO

CREATE TABLE [Building] (
    [Id] int NOT NULL IDENTITY,
    [buildingName] nvarchar(150) NULL,
    [buildingPosition] nvarchar(50) NULL,
    [buildingType] nvarchar(100) NULL,
    [BranchId] int NULL,
    [InstitutionalDivisionId] int NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Building] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Building_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]),
    CONSTRAINT [FK_Building_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id])
);
GO

CREATE TABLE [Department] (
    [Id] int NOT NULL IDENTITY,
    [departmentName] nvarchar(150) NOT NULL,
    [code] nvarchar(30) NULL,
    [shortName] nvarchar(50) NULL,
    [BranchId] int NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Department] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Department_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id])
);
GO

CREATE TABLE [ExamMarks] (
    [Id] int NOT NULL IDENTITY,
    [StudentInfoId] int NULL,
    [ExamId] int NULL,
    [obtainMarks] int NOT NULL,
    [examDate] datetime2 NULL,
    CONSTRAINT [PK_ExamMarks] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ExamMarks_Exam_ExamId] FOREIGN KEY ([ExamId]) REFERENCES [Exam] ([Id]),
    CONSTRAINT [FK_ExamMarks_StudentInfo_StudentInfoId] FOREIGN KEY ([StudentInfoId]) REFERENCES [StudentInfo] ([Id])
);
GO

CREATE TABLE [StudentClassPromotion] (
    [Id] int NOT NULL IDENTITY,
    [StudentInfoId] int NULL,
    [AccademicYearId] int NULL,
    [fromDate] datetime2 NULL,
    [toDate] datetime2 NULL,
    [effectiveDate] datetime2 NULL,
    [OldAccademicClassId] int NULL,
    [NewAccademicClassId] int NULL,
    [OldAccademicSectionId] int NULL,
    [NewAccademicSectionId] int NULL,
    [OldMeritPosition] int NULL,
    [OldClassRoll] nvarchar(150) NULL,
    [newMeritPosition] int NULL,
    [newClassRoll] nvarchar(150) NULL,
    [promotionType] nvarchar(max) NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_StudentClassPromotion] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StudentClassPromotion_AccademicClass_NewAccademicClassId] FOREIGN KEY ([NewAccademicClassId]) REFERENCES [AccademicClass] ([Id]),
    CONSTRAINT [FK_StudentClassPromotion_AccademicClass_OldAccademicClassId] FOREIGN KEY ([OldAccademicClassId]) REFERENCES [AccademicClass] ([Id]),
    CONSTRAINT [FK_StudentClassPromotion_AccademicSection_NewAccademicSectionId] FOREIGN KEY ([NewAccademicSectionId]) REFERENCES [AccademicSection] ([Id]),
    CONSTRAINT [FK_StudentClassPromotion_AccademicSection_OldAccademicSectionId] FOREIGN KEY ([OldAccademicSectionId]) REFERENCES [AccademicSection] ([Id]),
    CONSTRAINT [FK_StudentClassPromotion_AccademicYear_AccademicYearId] FOREIGN KEY ([AccademicYearId]) REFERENCES [AccademicYear] ([Id]),
    CONSTRAINT [FK_StudentClassPromotion_StudentInfo_StudentInfoId] FOREIGN KEY ([StudentInfoId]) REFERENCES [StudentInfo] ([Id])
);
GO

CREATE TABLE [MunicipalityCounsil] (
    [Id] int NOT NULL IDENTITY,
    [counsilName] nvarchar(150) NOT NULL,
    [counsilNo] int NULL,
    [MunicipalityId] int NULL,
    CONSTRAINT [PK_MunicipalityCounsil] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_MunicipalityCounsil_Municipality_MunicipalityId] FOREIGN KEY ([MunicipalityId]) REFERENCES [Municipality] ([Id])
);
GO

CREATE TABLE [Word] (
    [Id] int NOT NULL IDENTITY,
    [wordName] nvarchar(150) NOT NULL,
    [wordNo] int NULL,
    [UnionId] int NULL,
    CONSTRAINT [PK_Word] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Word_Union_UnionId] FOREIGN KEY ([UnionId]) REFERENCES [Union] ([Id])
);
GO

CREATE TABLE [BuildingRoom] (
    [Id] int NOT NULL IDENTITY,
    [floorNumber] int NULL,
    [roomNumber] nvarchar(max) NULL,
    [BuildingId] int NULL,
    CONSTRAINT [PK_BuildingRoom] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BuildingRoom_Building_BuildingId] FOREIGN KEY ([BuildingId]) REFERENCES [Building] ([Id])
);
GO

CREATE TABLE [Designation] (
    [Id] int NOT NULL IDENTITY,
    [designationName] nvarchar(120) NOT NULL,
    [code] nvarchar(50) NULL,
    [shortName] nvarchar(50) NULL,
    [DepartmentId] int NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_Designation] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Designation_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id])
);
GO

CREATE TABLE [Section] (
    [Id] int NOT NULL IDENTITY,
    [sectionName] nvarchar(100) NOT NULL,
    [code] nvarchar(30) NULL,
    [DepartmentId] int NULL,
    CONSTRAINT [PK_Section] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Section_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id])
);
GO

CREATE TABLE [StudentAddress] (
    [Id] int NOT NULL IDENTITY,
    [StudentInfoId] int NULL,
    [AddressTypeId] int NULL,
    [CountryId] int NULL,
    [DivisionId] int NULL,
    [DistrictId] int NULL,
    [ThanaId] int NULL,
    [LocationMappingId] int NULL,
    [UnionId] int NULL,
    [WordId] int NULL,
    [CityCorporationId] int NULL,
    [CityCorporationCounsilId] int NULL,
    [MunicipalityId] int NULL,
    [MunicipalityCounsilId] int NULL,
    [PostOfficeId] int NULL,
    [Sector] nvarchar(50) NULL,
    [block] nvarchar(50) NULL,
    [streetNo] nvarchar(120) NULL,
    [house_Village] nvarchar(120) NULL,
    CONSTRAINT [PK_StudentAddress] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StudentAddress_AddressType_AddressTypeId] FOREIGN KEY ([AddressTypeId]) REFERENCES [AddressType] ([Id]),
    CONSTRAINT [FK_StudentAddress_CityCorporationCounsil_CityCorporationCounsilId] FOREIGN KEY ([CityCorporationCounsilId]) REFERENCES [CityCorporationCounsil] ([Id]),
    CONSTRAINT [FK_StudentAddress_CityCorporation_CityCorporationId] FOREIGN KEY ([CityCorporationId]) REFERENCES [CityCorporation] ([Id]),
    CONSTRAINT [FK_StudentAddress_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([Id]),
    CONSTRAINT [FK_StudentAddress_District_DistrictId] FOREIGN KEY ([DistrictId]) REFERENCES [District] ([Id]),
    CONSTRAINT [FK_StudentAddress_Division_DivisionId] FOREIGN KEY ([DivisionId]) REFERENCES [Division] ([Id]),
    CONSTRAINT [FK_StudentAddress_LocationMapping_LocationMappingId] FOREIGN KEY ([LocationMappingId]) REFERENCES [LocationMapping] ([Id]),
    CONSTRAINT [FK_StudentAddress_MunicipalityCounsil_MunicipalityCounsilId] FOREIGN KEY ([MunicipalityCounsilId]) REFERENCES [MunicipalityCounsil] ([Id]),
    CONSTRAINT [FK_StudentAddress_Municipality_MunicipalityId] FOREIGN KEY ([MunicipalityId]) REFERENCES [Municipality] ([Id]),
    CONSTRAINT [FK_StudentAddress_PostOffice_PostOfficeId] FOREIGN KEY ([PostOfficeId]) REFERENCES [PostOffice] ([Id]),
    CONSTRAINT [FK_StudentAddress_StudentInfo_StudentInfoId] FOREIGN KEY ([StudentInfoId]) REFERENCES [StudentInfo] ([Id]),
    CONSTRAINT [FK_StudentAddress_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id]),
    CONSTRAINT [FK_StudentAddress_Union_UnionId] FOREIGN KEY ([UnionId]) REFERENCES [Union] ([Id]),
    CONSTRAINT [FK_StudentAddress_Word_WordId] FOREIGN KEY ([WordId]) REFERENCES [Word] ([Id])
);
GO

CREATE TABLE [ClassRoom] (
    [Id] int NOT NULL IDENTITY,
    [AccademicSectionId] int NULL,
    [BuildingRoomId] int NULL,
    [remarks] nvarchar(150) NULL,
    CONSTRAINT [PK_ClassRoom] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ClassRoom_AccademicSection_AccademicSectionId] FOREIGN KEY ([AccademicSectionId]) REFERENCES [AccademicSection] ([Id]),
    CONSTRAINT [FK_ClassRoom_BuildingRoom_BuildingRoomId] FOREIGN KEY ([BuildingRoomId]) REFERENCES [BuildingRoom] ([Id])
);
GO

CREATE TABLE [EmployeeInfo] (
    [Id] int NOT NULL IDENTITY,
    [employeeCode] nvarchar(100) NULL,
    [employeeName] nvarchar(250) NULL,
    [fatherName] nvarchar(150) NULL,
    [motherName] nvarchar(150) NULL,
    [fatherOccupation] nvarchar(150) NULL,
    [motherOccupation] nvarchar(150) NULL,
    [dateOfBirth] datetime2 NULL,
    [joiningDate] datetime2 NULL,
    [email] nvarchar(150) NULL,
    [contact] nvarchar(30) NULL,
    [pictureName] nvarchar(400) NULL,
    [height] nvarchar(100) NULL,
    [GenderId] int NULL,
    [ReligionId] int NULL,
    [BloodGroupId] int NULL,
    [ShiftId] int NULL,
    [EmployeeTypeId] int NULL,
    [EmployeeCategoryId] int NOT NULL,
    [InstitutionalDivisionId] int NULL,
    [BranchId] int NULL,
    [DepartmentId] int NULL,
    [SectionId] int NULL,
    [DesignationId] int NOT NULL,
    [GradeScaleId] int NOT NULL,
    [SalaryTypeId] int NOT NULL,
    [basicSalary] decimal(18,2) NOT NULL,
    [grossSalary] decimal(18,2) NOT NULL,
    [tentativeConfirmationDate] datetime2 NULL,
    [confirmationDate] datetime2 NULL,
    [BankBranchId] int NULL,
    [bankAccountNumber] nvarchar(150) NULL,
    [MobileBankId] int NULL,
    [mobileBankAccountNumber] nvarchar(50) NULL,
    [LastAchievedEducationId] int NULL,
    [EducationId] int NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    CONSTRAINT [PK_EmployeeInfo] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EmployeeInfo_BankBranch_BankBranchId] FOREIGN KEY ([BankBranchId]) REFERENCES [BankBranch] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_BloodGroup_BloodGroupId] FOREIGN KEY ([BloodGroupId]) REFERENCES [BloodGroup] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_Branch_BranchId] FOREIGN KEY ([BranchId]) REFERENCES [Branch] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_Department_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Department] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_Designation_DesignationId] FOREIGN KEY ([DesignationId]) REFERENCES [Designation] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EmployeeInfo_Education_EducationId] FOREIGN KEY ([EducationId]) REFERENCES [Education] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_EmployeeCategory_EmployeeCategoryId] FOREIGN KEY ([EmployeeCategoryId]) REFERENCES [EmployeeCategory] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EmployeeInfo_EmployeeType_EmployeeTypeId] FOREIGN KEY ([EmployeeTypeId]) REFERENCES [EmployeeType] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_Gender_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Gender] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_GradeScale_GradeScaleId] FOREIGN KEY ([GradeScaleId]) REFERENCES [GradeScale] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EmployeeInfo_InstitutionalDivision_InstitutionalDivisionId] FOREIGN KEY ([InstitutionalDivisionId]) REFERENCES [InstitutionalDivision] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_MobileBank_MobileBankId] FOREIGN KEY ([MobileBankId]) REFERENCES [MobileBank] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_Religion_ReligionId] FOREIGN KEY ([ReligionId]) REFERENCES [Religion] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_SalaryType_SalaryTypeId] FOREIGN KEY ([SalaryTypeId]) REFERENCES [SalaryType] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EmployeeInfo_Section_SectionId] FOREIGN KEY ([SectionId]) REFERENCES [Section] ([Id]),
    CONSTRAINT [FK_EmployeeInfo_Shift_ShiftId] FOREIGN KEY ([ShiftId]) REFERENCES [Shift] ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Contact] nvarchar(max) NULL,
    [Gender] nvarchar(max) NULL,
    [DateOfBirth] datetime2 NULL,
    [ProfilePicUrl] nvarchar(max) NULL,
    [isActive] bit NULL,
    [LastLoginTime] datetime2 NULL,
    [createdBy] nvarchar(120) NULL,
    [createdDate] datetime2 NULL,
    [updatedBy] nvarchar(120) NULL,
    [updatedDate] datetime2 NULL,
    [isDeleted] bit NULL,
    [deletedBy] nvarchar(120) NULL,
    [deletedDate] datetime2 NULL,
    [UserType] nvarchar(50) NULL,
    [EmployeeInfoId] int NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUsers_EmployeeInfo_EmployeeInfoId] FOREIGN KEY ([EmployeeInfoId]) REFERENCES [EmployeeInfo] ([Id])
);
GO

CREATE TABLE [EmployeeAddress] (
    [Id] int NOT NULL IDENTITY,
    [EmployeeInfoId] int NULL,
    [AddressTypeId] int NULL,
    [CountryId] int NULL,
    [DivisionId] int NULL,
    [DistrictId] int NULL,
    [ThanaId] int NULL,
    [LocationMappingId] int NULL,
    [UnionId] int NULL,
    [WordId] int NULL,
    [CityCorporationId] int NULL,
    [CityCorporationCounsilId] int NULL,
    [MunicipalityId] int NULL,
    [MunicipalityCounsilId] int NULL,
    [PostOfficeId] int NULL,
    [Sector] nvarchar(50) NULL,
    [block] nvarchar(50) NULL,
    [streetNo] nvarchar(120) NULL,
    [house_Village] nvarchar(120) NULL,
    CONSTRAINT [PK_EmployeeAddress] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EmployeeAddress_AddressType_AddressTypeId] FOREIGN KEY ([AddressTypeId]) REFERENCES [AddressType] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_CityCorporationCounsil_CityCorporationCounsilId] FOREIGN KEY ([CityCorporationCounsilId]) REFERENCES [CityCorporationCounsil] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_CityCorporation_CityCorporationId] FOREIGN KEY ([CityCorporationId]) REFERENCES [CityCorporation] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [Country] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_District_DistrictId] FOREIGN KEY ([DistrictId]) REFERENCES [District] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_Division_DivisionId] FOREIGN KEY ([DivisionId]) REFERENCES [Division] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_EmployeeInfo_EmployeeInfoId] FOREIGN KEY ([EmployeeInfoId]) REFERENCES [EmployeeInfo] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_LocationMapping_LocationMappingId] FOREIGN KEY ([LocationMappingId]) REFERENCES [LocationMapping] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_MunicipalityCounsil_MunicipalityCounsilId] FOREIGN KEY ([MunicipalityCounsilId]) REFERENCES [MunicipalityCounsil] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_Municipality_MunicipalityId] FOREIGN KEY ([MunicipalityId]) REFERENCES [Municipality] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_PostOffice_PostOfficeId] FOREIGN KEY ([PostOfficeId]) REFERENCES [PostOffice] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_Thana_ThanaId] FOREIGN KEY ([ThanaId]) REFERENCES [Thana] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_Union_UnionId] FOREIGN KEY ([UnionId]) REFERENCES [Union] ([Id]),
    CONSTRAINT [FK_EmployeeAddress_Word_WordId] FOREIGN KEY ([WordId]) REFERENCES [Word] ([Id])
);
GO

CREATE TABLE [EmployeeEducation] (
    [Id] int NOT NULL IDENTITY,
    [EmployeeInfoId] int NULL,
    [EducationId] int NULL,
    CONSTRAINT [PK_EmployeeEducation] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EmployeeEducation_Education_EducationId] FOREIGN KEY ([EducationId]) REFERENCES [Education] ([Id]),
    CONSTRAINT [FK_EmployeeEducation_EmployeeInfo_EmployeeInfoId] FOREIGN KEY ([EmployeeInfoId]) REFERENCES [EmployeeInfo] ([Id])
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'className') AND [object_id] = OBJECT_ID(N'[AccademicClass]'))
    SET IDENTITY_INSERT [AccademicClass] ON;
INSERT INTO [AccademicClass] ([Id], [className])
VALUES (1, N'One'),
(2, N'Two'),
(3, N'Three'),
(4, N'Four'),
(5, N'Five'),
(6, N'Six'),
(7, N'Seven'),
(8, N'Eight'),
(9, N'Nine'),
(10, N'Ten'),
(11, N'Eleven'),
(12, N'Twelve');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'className') AND [object_id] = OBJECT_ID(N'[AccademicClass]'))
    SET IDENTITY_INSERT [AccademicClass] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'typeName') AND [object_id] = OBJECT_ID(N'[AddressType]'))
    SET IDENTITY_INSERT [AddressType] ON;
INSERT INTO [AddressType] ([Id], [typeName])
VALUES (1, N'Present'),
(2, N'Permanent');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'typeName') AND [object_id] = OBJECT_ID(N'[AddressType]'))
    SET IDENTITY_INSERT [AddressType] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'bloodGroupName') AND [object_id] = OBJECT_ID(N'[BloodGroup]'))
    SET IDENTITY_INSERT [BloodGroup] ON;
INSERT INTO [BloodGroup] ([Id], [bloodGroupName])
VALUES (1, N'A+'),
(2, N'A-'),
(3, N'B+'),
(4, N'B-'),
(5, N'O+'),
(6, N'O-'),
(7, N'AB+'),
(8, N'AB-');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'bloodGroupName') AND [object_id] = OBJECT_ID(N'[BloodGroup]'))
    SET IDENTITY_INSERT [BloodGroup] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'code', N'educationLevelName') AND [object_id] = OBJECT_ID(N'[EducationLevel]'))
    SET IDENTITY_INSERT [EducationLevel] ON;
INSERT INTO [EducationLevel] ([Id], [code], [educationLevelName])
VALUES (1, N'P101', N'Primary'),
(2, N'S201', N'Secondary'),
(3, N'HS301', N'Higher Secondary'),
(4, N'UG401', N'Under-graduate'),
(5, N'PG501', N'Post-graduate'),
(6, N'D101', N'Dimploma'),
(7, N'PGD201', N'Post-Graduate Dimploma');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'code', N'educationLevelName') AND [object_id] = OBJECT_ID(N'[EducationLevel]'))
    SET IDENTITY_INSERT [EducationLevel] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'genderName', N'shortName') AND [object_id] = OBJECT_ID(N'[Gender]'))
    SET IDENTITY_INSERT [Gender] ON;
INSERT INTO [Gender] ([Id], [genderName], [shortName])
VALUES (1, N'Male', N'M'),
(2, N'Female', N'Fe'),
(3, N'Third-Gender', N'TG');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'genderName', N'shortName') AND [object_id] = OBJECT_ID(N'[Gender]'))
    SET IDENTITY_INSERT [Gender] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'name') AND [object_id] = OBJECT_ID(N'[HolydayType]'))
    SET IDENTITY_INSERT [HolydayType] ON;
INSERT INTO [HolydayType] ([Id], [name])
VALUES (1, N'Govt'),
(2, N'Eid'),
(3, N'Puza'),
(4, N'Weekly'),
(5, N'Others');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'name') AND [object_id] = OBJECT_ID(N'[HolydayType]'))
    SET IDENTITY_INSERT [HolydayType] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'languageName', N'shortName') AND [object_id] = OBJECT_ID(N'[Language]'))
    SET IDENTITY_INSERT [Language] ON;
INSERT INTO [Language] ([Id], [languageName], [shortName])
VALUES (1, N'English', N'ENG'),
(2, N'Bangla', N'BAN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'languageName', N'shortName') AND [object_id] = OBJECT_ID(N'[Language]'))
    SET IDENTITY_INSERT [Language] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'bankName', N'code', N'createdBy', N'createdDate', N'deletedBy', N'deletedDate', N'isDeleted', N'shortName', N'updatedBy', N'updatedDate') AND [object_id] = OBJECT_ID(N'[MobileBank]'))
    SET IDENTITY_INSERT [MobileBank] ON;
INSERT INTO [MobileBank] ([Id], [bankName], [code], [createdBy], [createdDate], [deletedBy], [deletedDate], [isDeleted], [shortName], [updatedBy], [updatedDate])
VALUES (1, N'Bikash', NULL, NULL, NULL, NULL, NULL, NULL, N'BK', NULL, NULL),
(2, N'Nagad', NULL, NULL, NULL, NULL, NULL, NULL, N'ND', NULL, NULL),
(3, N'Rocket', NULL, NULL, NULL, NULL, NULL, NULL, N'RKT', NULL, NULL);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'bankName', N'code', N'createdBy', N'createdDate', N'deletedBy', N'deletedDate', N'isDeleted', N'shortName', N'updatedBy', N'updatedDate') AND [object_id] = OBJECT_ID(N'[MobileBank]'))
    SET IDENTITY_INSERT [MobileBank] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'relationName') AND [object_id] = OBJECT_ID(N'[Relation]'))
    SET IDENTITY_INSERT [Relation] ON;
INSERT INTO [Relation] ([Id], [relationName])
VALUES (1, N'Father'),
(2, N'Mother'),
(3, N'Brother'),
(4, N'Sister'),
(5, N'Uncle'),
(6, N'Aunty'),
(7, N'Grand-Father'),
(8, N'Grand-Mother');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'relationName') AND [object_id] = OBJECT_ID(N'[Relation]'))
    SET IDENTITY_INSERT [Relation] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'religionName') AND [object_id] = OBJECT_ID(N'[Religion]'))
    SET IDENTITY_INSERT [Religion] ON;
INSERT INTO [Religion] ([Id], [religionName])
VALUES (1, N'Islam'),
(2, N'Hindu'),
(3, N'Christian'),
(4, N'Buddist');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'religionName') AND [object_id] = OBJECT_ID(N'[Religion]'))
    SET IDENTITY_INSERT [Religion] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'salaryTypeName', N'shortName') AND [object_id] = OBJECT_ID(N'[SalaryType]'))
    SET IDENTITY_INSERT [SalaryType] ON;
INSERT INTO [SalaryType] ([Id], [salaryTypeName], [shortName])
VALUES (1, N'Consolidated', N'C'),
(2, N'Regular', N'R');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'salaryTypeName', N'shortName') AND [object_id] = OBJECT_ID(N'[SalaryType]'))
    SET IDENTITY_INSERT [SalaryType] OFF;
GO

CREATE INDEX [IX_AccademicSection_AccademicClassId] ON [AccademicSection] ([AccademicClassId]);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE INDEX [IX_AspNetUsers_EmployeeInfoId] ON [AspNetUsers] ([EmployeeInfoId]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

CREATE INDEX [IX_Bank_BankTypeId] ON [Bank] ([BankTypeId]);
GO

CREATE INDEX [IX_BankBranch_BankId] ON [BankBranch] ([BankId]);
GO

CREATE INDEX [IX_Branch_BranchInchargeId] ON [Branch] ([BranchInchargeId]);
GO

CREATE INDEX [IX_Branch_InstitutionalDivisionId] ON [Branch] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_BranchIncharge_InstitutionalDivisionId] ON [BranchIncharge] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_Building_BranchId] ON [Building] ([BranchId]);
GO

CREATE INDEX [IX_Building_InstitutionalDivisionId] ON [Building] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_BuildingRoom_BuildingId] ON [BuildingRoom] ([BuildingId]);
GO

CREATE INDEX [IX_CityCorporationCounsil_CityCorporationId] ON [CityCorporationCounsil] ([CityCorporationId]);
GO

CREATE INDEX [IX_ClassRoom_AccademicSectionId] ON [ClassRoom] ([AccademicSectionId]);
GO

CREATE INDEX [IX_ClassRoom_BuildingRoomId] ON [ClassRoom] ([BuildingRoomId]);
GO

CREATE INDEX [IX_Department_BranchId] ON [Department] ([BranchId]);
GO

CREATE INDEX [IX_Designation_DepartmentId] ON [Designation] ([DepartmentId]);
GO

CREATE INDEX [IX_District_DivisionId] ON [District] ([DivisionId]);
GO

CREATE INDEX [IX_Division_CountryId] ON [Division] ([CountryId]);
GO

CREATE INDEX [IX_Education_EducationLevelId] ON [Education] ([EducationLevelId]);
GO

CREATE INDEX [IX_EmployeeAddress_AddressTypeId] ON [EmployeeAddress] ([AddressTypeId]);
GO

CREATE INDEX [IX_EmployeeAddress_CityCorporationCounsilId] ON [EmployeeAddress] ([CityCorporationCounsilId]);
GO

CREATE INDEX [IX_EmployeeAddress_CityCorporationId] ON [EmployeeAddress] ([CityCorporationId]);
GO

CREATE INDEX [IX_EmployeeAddress_CountryId] ON [EmployeeAddress] ([CountryId]);
GO

CREATE INDEX [IX_EmployeeAddress_DistrictId] ON [EmployeeAddress] ([DistrictId]);
GO

CREATE INDEX [IX_EmployeeAddress_DivisionId] ON [EmployeeAddress] ([DivisionId]);
GO

CREATE INDEX [IX_EmployeeAddress_EmployeeInfoId] ON [EmployeeAddress] ([EmployeeInfoId]);
GO

CREATE INDEX [IX_EmployeeAddress_LocationMappingId] ON [EmployeeAddress] ([LocationMappingId]);
GO

CREATE INDEX [IX_EmployeeAddress_MunicipalityCounsilId] ON [EmployeeAddress] ([MunicipalityCounsilId]);
GO

CREATE INDEX [IX_EmployeeAddress_MunicipalityId] ON [EmployeeAddress] ([MunicipalityId]);
GO

CREATE INDEX [IX_EmployeeAddress_PostOfficeId] ON [EmployeeAddress] ([PostOfficeId]);
GO

CREATE INDEX [IX_EmployeeAddress_ThanaId] ON [EmployeeAddress] ([ThanaId]);
GO

CREATE INDEX [IX_EmployeeAddress_UnionId] ON [EmployeeAddress] ([UnionId]);
GO

CREATE INDEX [IX_EmployeeAddress_WordId] ON [EmployeeAddress] ([WordId]);
GO

CREATE INDEX [IX_EmployeeEducation_EducationId] ON [EmployeeEducation] ([EducationId]);
GO

CREATE INDEX [IX_EmployeeEducation_EmployeeInfoId] ON [EmployeeEducation] ([EmployeeInfoId]);
GO

CREATE INDEX [IX_EmployeeInfo_BankBranchId] ON [EmployeeInfo] ([BankBranchId]);
GO

CREATE INDEX [IX_EmployeeInfo_BloodGroupId] ON [EmployeeInfo] ([BloodGroupId]);
GO

CREATE INDEX [IX_EmployeeInfo_BranchId] ON [EmployeeInfo] ([BranchId]);
GO

CREATE INDEX [IX_EmployeeInfo_DepartmentId] ON [EmployeeInfo] ([DepartmentId]);
GO

CREATE INDEX [IX_EmployeeInfo_DesignationId] ON [EmployeeInfo] ([DesignationId]);
GO

CREATE INDEX [IX_EmployeeInfo_EducationId] ON [EmployeeInfo] ([EducationId]);
GO

CREATE INDEX [IX_EmployeeInfo_EmployeeCategoryId] ON [EmployeeInfo] ([EmployeeCategoryId]);
GO

CREATE INDEX [IX_EmployeeInfo_EmployeeTypeId] ON [EmployeeInfo] ([EmployeeTypeId]);
GO

CREATE INDEX [IX_EmployeeInfo_GenderId] ON [EmployeeInfo] ([GenderId]);
GO

CREATE INDEX [IX_EmployeeInfo_GradeScaleId] ON [EmployeeInfo] ([GradeScaleId]);
GO

CREATE INDEX [IX_EmployeeInfo_InstitutionalDivisionId] ON [EmployeeInfo] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_EmployeeInfo_MobileBankId] ON [EmployeeInfo] ([MobileBankId]);
GO

CREATE INDEX [IX_EmployeeInfo_ReligionId] ON [EmployeeInfo] ([ReligionId]);
GO

CREATE INDEX [IX_EmployeeInfo_SalaryTypeId] ON [EmployeeInfo] ([SalaryTypeId]);
GO

CREATE INDEX [IX_EmployeeInfo_SectionId] ON [EmployeeInfo] ([SectionId]);
GO

CREATE INDEX [IX_EmployeeInfo_ShiftId] ON [EmployeeInfo] ([ShiftId]);
GO

CREATE INDEX [IX_Exam_ExamHeadId] ON [Exam] ([ExamHeadId]);
GO

CREATE INDEX [IX_Exam_ExamTypeId] ON [Exam] ([ExamTypeId]);
GO

CREATE INDEX [IX_Exam_SubjectId] ON [Exam] ([SubjectId]);
GO

CREATE INDEX [IX_ExamMarks_ExamId] ON [ExamMarks] ([ExamId]);
GO

CREATE INDEX [IX_ExamMarks_StudentInfoId] ON [ExamMarks] ([StudentInfoId]);
GO

CREATE INDEX [IX_ExamRoutine_AccademicClassId] ON [ExamRoutine] ([AccademicClassId]);
GO

CREATE INDEX [IX_ExamRoutine_ExamTypeId] ON [ExamRoutine] ([ExamTypeId]);
GO

CREATE INDEX [IX_ExamRoutine_SubjectId] ON [ExamRoutine] ([SubjectId]);
GO

CREATE INDEX [IX_GeneralConfiguration_InstitutionalDivisionId] ON [GeneralConfiguration] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_Holiday_AccademicYearId] ON [Holiday] ([AccademicYearId]);
GO

CREATE INDEX [IX_Holiday_HolydayTypeId] ON [Holiday] ([HolydayTypeId]);
GO

CREATE INDEX [IX_Holiday_InstitutionalDivisionId] ON [Holiday] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_InstitutionalDivision_InstitutionId] ON [InstitutionalDivision] ([InstitutionId]);
GO

CREATE INDEX [IX_Municipality_ThanaId] ON [Municipality] ([ThanaId]);
GO

CREATE INDEX [IX_MunicipalityCounsil_MunicipalityId] ON [MunicipalityCounsil] ([MunicipalityId]);
GO

CREATE INDEX [IX_PostOffice_ThanaId] ON [PostOffice] ([ThanaId]);
GO

CREATE INDEX [IX_Section_DepartmentId] ON [Section] ([DepartmentId]);
GO

CREATE INDEX [IX_Shift_InstitutionalDivisionId] ON [Shift] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_StudentAddress_AddressTypeId] ON [StudentAddress] ([AddressTypeId]);
GO

CREATE INDEX [IX_StudentAddress_CityCorporationCounsilId] ON [StudentAddress] ([CityCorporationCounsilId]);
GO

CREATE INDEX [IX_StudentAddress_CityCorporationId] ON [StudentAddress] ([CityCorporationId]);
GO

CREATE INDEX [IX_StudentAddress_CountryId] ON [StudentAddress] ([CountryId]);
GO

CREATE INDEX [IX_StudentAddress_DistrictId] ON [StudentAddress] ([DistrictId]);
GO

CREATE INDEX [IX_StudentAddress_DivisionId] ON [StudentAddress] ([DivisionId]);
GO

CREATE INDEX [IX_StudentAddress_LocationMappingId] ON [StudentAddress] ([LocationMappingId]);
GO

CREATE INDEX [IX_StudentAddress_MunicipalityCounsilId] ON [StudentAddress] ([MunicipalityCounsilId]);
GO

CREATE INDEX [IX_StudentAddress_MunicipalityId] ON [StudentAddress] ([MunicipalityId]);
GO

CREATE INDEX [IX_StudentAddress_PostOfficeId] ON [StudentAddress] ([PostOfficeId]);
GO

CREATE INDEX [IX_StudentAddress_StudentInfoId] ON [StudentAddress] ([StudentInfoId]);
GO

CREATE INDEX [IX_StudentAddress_ThanaId] ON [StudentAddress] ([ThanaId]);
GO

CREATE INDEX [IX_StudentAddress_UnionId] ON [StudentAddress] ([UnionId]);
GO

CREATE INDEX [IX_StudentAddress_WordId] ON [StudentAddress] ([WordId]);
GO

CREATE INDEX [IX_StudentClassPromotion_AccademicYearId] ON [StudentClassPromotion] ([AccademicYearId]);
GO

CREATE INDEX [IX_StudentClassPromotion_NewAccademicClassId] ON [StudentClassPromotion] ([NewAccademicClassId]);
GO

CREATE INDEX [IX_StudentClassPromotion_NewAccademicSectionId] ON [StudentClassPromotion] ([NewAccademicSectionId]);
GO

CREATE INDEX [IX_StudentClassPromotion_OldAccademicClassId] ON [StudentClassPromotion] ([OldAccademicClassId]);
GO

CREATE INDEX [IX_StudentClassPromotion_OldAccademicSectionId] ON [StudentClassPromotion] ([OldAccademicSectionId]);
GO

CREATE INDEX [IX_StudentClassPromotion_StudentInfoId] ON [StudentClassPromotion] ([StudentInfoId]);
GO

CREATE INDEX [IX_StudentInfo_AccademicClassId] ON [StudentInfo] ([AccademicClassId]);
GO

CREATE INDEX [IX_StudentInfo_AccademicSectionId] ON [StudentInfo] ([AccademicSectionId]);
GO

CREATE INDEX [IX_StudentInfo_AccademicYearId] ON [StudentInfo] ([AccademicYearId]);
GO

CREATE INDEX [IX_StudentInfo_BankBranchId] ON [StudentInfo] ([BankBranchId]);
GO

CREATE INDEX [IX_StudentInfo_BloodGroupId] ON [StudentInfo] ([BloodGroupId]);
GO

CREATE INDEX [IX_StudentInfo_GenderId] ON [StudentInfo] ([GenderId]);
GO

CREATE INDEX [IX_StudentInfo_InstitutionalDivisionId] ON [StudentInfo] ([InstitutionalDivisionId]);
GO

CREATE INDEX [IX_StudentInfo_MobileBankId] ON [StudentInfo] ([MobileBankId]);
GO

CREATE INDEX [IX_StudentInfo_ReligionId] ON [StudentInfo] ([ReligionId]);
GO

CREATE INDEX [IX_StudentInfo_ShiftId] ON [StudentInfo] ([ShiftId]);
GO

CREATE INDEX [IX_StudentRegistration_AccademicClassId] ON [StudentRegistration] ([AccademicClassId]);
GO

CREATE INDEX [IX_StudentRegistration_AccademicYearId] ON [StudentRegistration] ([AccademicYearId]);
GO

CREATE INDEX [IX_StudentRegistration_BankBranchId] ON [StudentRegistration] ([BankBranchId]);
GO

CREATE INDEX [IX_StudentRegistration_GenderId] ON [StudentRegistration] ([GenderId]);
GO

CREATE INDEX [IX_StudentRegistration_ReligionId] ON [StudentRegistration] ([ReligionId]);
GO

CREATE INDEX [IX_SubjectDetails_AccademicClassId] ON [SubjectDetails] ([AccademicClassId]);
GO

CREATE INDEX [IX_SubjectDetails_ExamTypeId] ON [SubjectDetails] ([ExamTypeId]);
GO

CREATE INDEX [IX_SubjectDetails_SubjectId] ON [SubjectDetails] ([SubjectId]);
GO

CREATE INDEX [IX_Thana_DistrictId] ON [Thana] ([DistrictId]);
GO

CREATE INDEX [IX_Union_ThanaId] ON [Union] ([ThanaId]);
GO

CREATE INDEX [IX_Word_UnionId] ON [Word] ([UnionId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240804172304_initial-Migration', N'8.0.4');
GO

COMMIT;
GO

