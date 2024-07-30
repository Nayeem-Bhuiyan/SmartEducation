using System;
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
        [Required]
        [StringLength(250)]
        public string fullName { get; set; }
        [StringLength(80)]
        public string shortName { get; set; }
        [StringLength(250)]
        public string displayName { get; set; }

        [StringLength(50)]
        public string code { get; set; }
        [StringLength(100)]
        public string eiinNumber { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? establishDate { get; set; }
        [StringLength(250)]
        public string address { get; set; }
        [StringLength(250)]
        public string websiteUrl { get; set; }
        [StringLength(500)]
        public string founderNames { get; set; } //comma separated
        [StringLength(500)]
        public string presentOwnerNames { get; set; } //comma separated
        [StringLength(250)]
        public string contactPerson { get; set; }
        [StringLength(30)]
        public string contactNumber { get; set; }
        [StringLength(30)]
        public string alternetContactNumber { get; set; }
        [StringLength(120)]
        public string email { get; set; }
        [StringLength(120)]
        public string logoName { get; set; }
        [StringLength(120)]
        public string alternetEmail { get; set; }
        [DefaultValue(false)]
        public bool? isMotherInstitution { get; set; }=false;
        [StringLength(100)]
        public string reportSortingOrder { get; set; } //Designation,Grade etc


    }
}
