using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Domain.Model.MasterPanel
{
    public class Address
    {

        public int? addressCategoryId { get; set; }
        public AddressCategory addressCategory { get; set; }


        public int? countryId { get; set; }
        public Country country { get; set; }

        public int? divisionId { get; set; }
        public Division division { get; set; }

        public int? districtId { get; set; }
        public District district { get; set; }

        public int? thanaId { get; set; }
        public Thana thana { get; set; }

        public string union { get; set; }

        public string postOffice { get; set; }

        public string postCode { get; set; }

        public string blockSector { get; set; }

        public string houseVillage { get; set; }

        public string type { get; set; }  //Organization or Resourse or Company
    }
}
