using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Address:BaseEntity
    {
        [ForeignKey("AddressAreaTypeId")]
        public int? AddressAreaTypeId { get; set; }           //Present,Permanent
        public AddressAreaType AddressAreaType { get; set; }


        [ForeignKey("AddressTypeId")]
        public int? AddressTypeId { get; set; }         //Citycoporation=C,Municipality=M,General=G
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

        [ForeignKey("UnionId")]
        public int? UnionId { get; set; }
        public Union Union { get; set; }  
        
        [ForeignKey("WordId")]
        public int? WordId { get; set; }
        public Word Word { get; set; }

        [ForeignKey("PostOfficeId")]
        public int? PostOfficeId { get; set; }
        public PostOffice PostOffice { get; set; }
        [StringLength(50)]
        public string block_Sector { get; set; }
        [StringLength(120)]
        public string house_Village { get; set; }

        public string type { get; set; }  //Organization or Resourse or Company
    }
}
