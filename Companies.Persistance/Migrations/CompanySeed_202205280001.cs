using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Migrations
{
    [Migration(202205280001)]
    public class CompanySeed_202205280001 : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Companies")
           .Row(new
           {
               CompanyName = "Software Solution",
               CompanySector = "Software House",
               CompanyEmployeesNumber = 100,
           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               CompanyName = "Swiss Union Bank",
               CompanySector = "Finance",
               CompanyEmployeesNumber = 10000,
           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               CompanyName = "Creativity",
               CompanySector = "Technology",
               CompanyEmployeesNumber = 1000,

           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               CompanyName = "It Opportunity",
               CompanySector = "Technology",
               CompanyEmployeesNumber = 2000,
           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               CompanyName = "Soft Matter",
               CompanySector = "Software House",
               CompanyEmployeesNumber = 2000,
           });
        }

        public override void Down()
        {
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Software Solution",
               CompanySector = "Software House",
               CompanyEmployeesNumber = 100,
           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Swiss Union Bank",
               CompanySector = "Finance",
               CompanyEmployeesNumber = 10000,
           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Creativity",
               CompanySector = "Technology",
               CompanyEmployeesNumber = 1000,

           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "It Opportunity",
               CompanySector = "Technology",
               CompanyEmployeesNumber = 2000,
           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Soft Matter",
               CompanySector = "Software House",
               CompanyEmployeesNumber = 2000,
           });
        }
    }
}
