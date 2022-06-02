using Companies.Application.Contracts;
using Companies.Persistance.Context;
using Companies.Persistance.Contexts;
using Companies.Persistance.Contexts.Abstract;
using Companies.Persistance.Contexts.Concrete;
using Companies.Persistance.Contexts.DataAccess;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DapperContext>();
            services.AddSingleton<Database>();
            services.AddLogging(c => c.AddFluentMigratorConsole())
                .AddFluentMigratorCore()
                .ConfigureRunner(c => c.AddSqlServer2012()
                    .WithGlobalConnectionString(configuration.GetConnectionString("SqlConnection"))
                    .ScanIn(Assembly.GetExecutingAssembly()).For.Migrations());
            services.AddTransient<IDapperContext, DapperContext>();
            services.AddTransient<ICompanyRepository, CompanyRepository> ();
            return services;
        }
    }
}