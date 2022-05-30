using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Migrations
{
    [Migration(202205280004)]
    public class JobsOfferSeed_202205280004 : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 1,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 1,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 1,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });

            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 2,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 3
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 2,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 2,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });

            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 3,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 3
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 3,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 3,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });

            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 4,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 4,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 4,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });

            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 5,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 5,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 3
                });
            Insert.IntoTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 5,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });
        }

        public override void Down()
        {
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 1,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 1,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 1,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });

            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 2,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 3
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 2,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 2,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });

            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 3,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 3
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 3,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 3,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });

            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 4,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 1
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 4,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 4,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });

            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 5,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 4
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 5,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 3
                });
            Delete.FromTable("JobsOffers")
                .Row(new
                {
                    CompanyId = 5,
                    IntegrationId = Guid.NewGuid().ToString(),
                    StatusId = 2
                });
        }
    }
}
