using Companies.Persistance.Context;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Extensions
{
	public static class MigrationManager
	{
		public static IHost MigrateDatabase(this IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				var databaseService = scope.ServiceProvider.GetRequiredService<Database>();
				var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

				try
				{
					databaseService.CreateDatabase("Companies");

                    migrationService.MigrateUp(001);
                    migrationService.MigrateUp(002);
                    migrationService.MigrateUp(003);
                    migrationService.MigrateUp(004);
                    migrationService.MigrateUp(005);
                    migrationService.MigrateUp(006);
                }
				catch
				{
					throw;
				}
			}

			return host;
		}
	}
}
