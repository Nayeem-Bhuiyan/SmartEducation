using SmartEducation.Application.IEntityRepository.MasterPanel;
using SmartEducation.Application.IEntityService.MasterPanel;
using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Service.EntityService.MasterPanel
{

    public class CountryService : ICountryService
    {
        private readonly ICountryRepositry _CountryRepositry;
        public CountryService(ICountryRepositry CountryRepositry)
        {
            this._CountryRepositry = CountryRepositry;
        }


        public IQueryable<Country> Get_All_Country_Record()
        {
            return _CountryRepositry.Get_All_Country();
        }



    }
}
