﻿using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Student
{
    public class StudentClassPromotion:BaseAuditEntity
    {
        [ForeignKey("StudentId")]
        public int? StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("AccademicYearId")]
        public int? AccademicYearId { get; set; }
        public AccademicYear AccademicYear { get; set; }   
        

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? fromDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? toDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? effectiveDate { get; set; }

        [ForeignKey("OldAccademicClassId")]
        public int? OldAccademicClassId { get; set; }
        public AccademicClass OldAccademicClass { get; set; }

        [ForeignKey("NewAccademicClassId")]
        public int? NewAccademicClassId { get; set; }
        public AccademicClass NewAccademicClass { get; set; }


        [ForeignKey("OldAccademicSectionId")]
        public int? OldAccademicSectionId { get; set; }
        public AccademicSection OldAccademicSection { get; set; }

        [ForeignKey("NewAccademicSectionId")]
        public int? NewAccademicSectionId { get; set; }
        public AccademicSection NewAccademicSection { get; set; }
    }
}
