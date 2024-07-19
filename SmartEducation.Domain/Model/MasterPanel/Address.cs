using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Address
    {

        public int? addressCategoryId { get; set; }
        public AddressCategory addressCategory { get; set; }

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

        [ForeignKey("PostOfficeId")]
        public int? PostOfficeId { get; set; }
        public PostOffice PostOffice { get; set; }

        public string blockSector { get; set; }

        public string houseVillageName { get; set; }

        public string type { get; set; }  //Organization or Resourse or Company
    }
}
