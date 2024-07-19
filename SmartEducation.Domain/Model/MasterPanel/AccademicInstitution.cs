﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class AccademicInstitution:BaseEntity
    {
        public AccademicInstitution() {
            this.isMotherInstitution=false;
        }
        public string fullName { get; set; }
        public string displayName { get; set; }
        public string shortName { get; set; }
        public string eiinNumber { get; set; }
        public string code { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? establishDate { get; set; }
        public string location { get; set; }
        public string ownerName { get; set; }
        public string contactPerson { get; set; }
        public string contactNumber { get; set; }
        public string email { get; set; }
        public string alternetEmail { get; set; }
        [DefaultValue(false)]
        public bool? isMotherInstitution { get; set; }


    }
}
