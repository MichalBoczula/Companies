﻿using FluentMigrator;
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
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
                .WithColumn("Name").AsString(250).NotNullable()
                .WithColumn("Sector").AsString(60).NotNullable()
                .WithColumn("EmployeesNumber").AsInt32().NotNullable()
                .WithColumn("CompanyDetailsId").AsInt32();

            Create.Table("CompanyDetails")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
               .WithColumn("Description").AsString(1000).Nullable()
               .WithColumn("History").AsString(1000).Nullable()
               .WithColumn("Offer").AsString(1000).Nullable()
               .WithColumn("Information").AsString(1000).Nullable();

            Create.Table("JobsOffers")
              .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
              .WithColumn("CompanyId").AsInt32().NotNullable()
              .WithColumn("IntegrationId").AsString(1000).Nullable().Indexed()
              .WithColumn("StatusId").AsInt32().NotNullable();

            Create.Table("Project")
              .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
              .WithColumn("Name").AsString(1000).Nullable()
              .WithColumn("Desc").AsString(1000).Nullable()
              .WithColumn("CompanyId").AsInt32().NotNullable();

            Create.Table("JobStatuses")
                  .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity().Indexed()
                  .WithColumn("Name").AsString(1000).Nullable();

            Alter.Table("Companies")
             .AlterColumn("CompanyDetailsId").AsInt32().Indexed().ForeignKey("CompanyDetails", "Id");

            Alter.Table("JobsOffers")
              .AlterColumn("CompanyId").AsInt32().NotNullable().Indexed().ForeignKey("Companies", "Id")
              .AlterColumn("StatusId").AsInt32().NotNullable().Indexed().ForeignKey("JobStatuses", "Id");

            Alter.Table("Project")
              .AlterColumn("CompanyId").AsInt32().NotNullable().Indexed().ForeignKey("Companies", "Id");
        }
    }
}
