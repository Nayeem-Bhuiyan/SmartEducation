using Microsoft.Extensions.DependencyInjection;
using SmartEducation.Application.IEntityService.MasterPanel;
using SmartEducation.Service.EntityService.MasterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEducation.Service
{
    public static class SmartEducationServicesActivation
    {
        public static void AddSmartEducationServices(this IServiceCollection services)
        {
            services.AddTransient<ICountryService, CountryService>();

        }
    }
}
