using Microsoft.EntityFrameworkCore;
using SmartEducation.Application.IEntityRepository.MasterPanel;
using SmartEducation.DataAccess.DBContext;
using SmartEducation.DataAccess.Repository;
using SmartEducation.Domain.Model.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.DataAccess.EntityRepository.MasterPanel
{
    public class CountryRepositry : BaseRepository<Country>, ICountryRepositry
    {
        public readonly ApplicationDbContext _dbContext;
        public CountryRepositry(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }

        public IQueryable<Country> Get_All_Country()
        {
            return _dbContext.Country.FromSqlRaw(@"Sp_Get_All_Country");
        }
    }
}
