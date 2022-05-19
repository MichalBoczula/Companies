using Companies.Persistance.Context;
using Companies.Persistance.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddSingleton<Database>();
            return services;
        }
    }
}