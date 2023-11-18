using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartEducation.Application.IEntityRepository.MasterPanel;
using SmartEducation.Application.IRepository;
using SmartEducation.DataAccess.DBContext;
using SmartEducation.DataAccess.EntityRepository.MasterPanel;
using SmartEducation.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.DataAccess
{
  public static class SmartEducationDataAccessServicesActivation
    {
        public static void AddSmartEducationDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("AppDbConnection"), x => x.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            #region EntityRepositoryConfig
            #region MasterPanel
            services.AddTransient<ICountryRepositry, CountryRepositry>();
            #endregion
            #endregion

        }
    }
}
