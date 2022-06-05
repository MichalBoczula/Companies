using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Migrations
{
    [Migration(202205230001)]
    public class InitialTables_202205230001 : Migration
    {
        public override void Down()
        {
            Delete.Table("Companies");
            Delete.Table("CompanyDetails");
            Delete.Table("JobsOffers");
            Delete.Table("Projects");
            Delete.Table("JobStatuses");
        }

        public override void Up()
        {
            Create.Table("Companies")
                .WithColumn("CompanyId").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
                .WithColumn("CompanyName").AsString(250).NotNullable()
                .WithColumn("CompanySector").AsString(60).NotNullable()
                .WithColumn("CompanyEmployeesNumber").AsInt32().NotNullable();

            Create.Table("CompanyDetails")
               .WithColumn("CompanyDetailsId").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
               .WithColumn("CompanyDetailsDescription").AsString(1000).Nullable()
               .WithColumn("CompanyDetailsHistory").AsString(1000).Nullable()
               .WithColumn("CompanyDetailsOffer").AsString(1000).Nullable()
               .WithColumn("CompanyDetailsInformation").AsString(1000).Nullable()
               .WithColumn("CompanyId").AsInt32();

            Create.Table("JobsOffers")
              .WithColumn("JobsOfferId").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
              .WithColumn("CompanyId").AsInt32().NotNullable()
              .WithColumn("IntegrationId").AsString(1000).Nullable().Indexed()
              .WithColumn("StatusId").AsInt32().NotNullable();

            Create.Table("Projects")
              .WithColumn("ProjectId").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
              .WithColumn("ProjectName").AsString(1000).Nullable()
              .WithColumn("ProjectDesc").AsString(1000).Nullable()
              .WithColumn("CompanyId").AsInt32().NotNullable();

            Create.Table("JobStatuses")
                  .WithColumn("JobStatuseId").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
                  .WithColumn("JobStatuseName").AsString(1000).Nullable();

            Alter.Table("CompanyDetails")
             .AlterColumn("CompanyId").AsInt32().Indexed().ForeignKey("Companies", "CompanyId");

            Alter.Table("JobsOffers")
              .AlterColumn("CompanyId").AsInt32().NotNullable().Indexed().ForeignKey("Companies", "CompanyId")
              .AlterColumn("StatusId").AsInt32().NotNullable().Indexed().ForeignKey("JobStatuses", "JobStatuseId");

            Alter.Table("Projects")
              .AlterColumn("CompanyId").AsInt32().NotNullable().Indexed().ForeignKey("Companies", "CompanyId");
        }
    }
}
