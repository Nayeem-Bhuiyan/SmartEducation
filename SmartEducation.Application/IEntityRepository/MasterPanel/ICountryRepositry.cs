using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Application.IEntityRepository.MasterPanel
{
    public interface ICountryRepositry
    {
        IQueryable<Country> Get_All_Country();
    }
}
