using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.Student
{
    public class StudentAddress:BaseEntity
    {
       
        
        [ForeignKey("StudentInfoId")]
        public int? StudentInfoId { get; set; }      
        public StudentInfo StudentInfo { get; set; } 
        
        [ForeignKey("AddressTypeId")]
        public int? AddressTypeId { get; set; }      //Present,Permanent
        public AddressType AddressType { get; set; }

        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }

        [ForeignKey("DivisionId")]
        public int? DivisionId { get; set; }
        public Division Division { get; set; }


        [ForeignKey("DistrictId")]
        public int? DistrictId { get; set; }
        public District District { get; set; }

        [ForeignKey("ThanaId")]
        public int? ThanaId { get; set; }
        public Thana Thana { get; set; }

        [ForeignKey("LocationMappingId")]
        public int? LocationMappingId { get; set; }      //Citycoporation=C,Municipality=M,Union=U     
        public LocationMapping LocationMapping { get; set; }

        #region Union_Word
        [ForeignKey("UnionId")]
        public int? UnionId { get; set; }
        public Union Union { get; set; }

        [ForeignKey("WordId")]
        public int? WordId { get; set; }
        public Word Word { get; set; }
        #endregion

        #region CityCorporation_Counsil
        [ForeignKey("CityCorporationId")]
        public int? CityCorporationId { get; set; }
        public CityCorporation CityCorporation { get; set; }

        [ForeignKey("CityCorporationCounsilId")]
        public int? CityCorporationCounsilId { get; set; }
        public CityCorporationCounsil CityCorporationCounsil { get; set; }
        #endregion

        #region Municipality_Counsil
        [ForeignKey("MunicipalityId")]
        public int? MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }

        [ForeignKey("MunicipalityCounsilId")]
        public int? MunicipalityCounsilId { get; set; }
        public MunicipalityCounsil MunicipalityCounsil { get; set; }
        #endregion

        #region PostOffice
        [ForeignKey("PostOfficeId")]
        public int? PostOfficeId { get; set; }
        public PostOffice PostOffice { get; set; }
        #endregion

        [StringLength(50)]
        public string block_Sector { get; set; }
        [StringLength(120)]
        public string streetNo { get; set; }
        [StringLength(120)]
        public string house_Village { get; set; }
    }
}
