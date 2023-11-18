using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Application.IEntityService.MasterPanel
{
    public interface ICountryService
    {
        IQueryable<Country> Get_All_Country_Record();
    }
}
