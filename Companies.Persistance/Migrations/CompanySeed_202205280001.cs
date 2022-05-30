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
               Name = "Software Solution",
               Sector = "Software House",
               EmployeesNumber = 100,
           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               Name = "Swiss Union Bank",
               Sector = "Finance",
               EmployeesNumber = 10000,
           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               Name = "Creativity",
               Sector = "Technology",
               EmployeesNumber = 1000,

           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               Name = "It Opportunity",
               Sector = "Technology",
               EmployeesNumber = 2000,
           });
            Insert.IntoTable("Companies")
           .Row(new
           {
               Name = "Soft Matter",
               Sector = "Software House",
               EmployeesNumber = 2000,
           });
        }

        public override void Down()
        {
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Software Solution",
               Sector = "Software House",
               EmployeesNumber = 100,
           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Swiss Union Bank",
               Sector = "Finance",
               EmployeesNumber = 10000,
           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Creativity",
               Sector = "Technology",
               EmployeesNumber = 1000,

           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "It Opportunity",
               Sector = "Technology",
               EmployeesNumber = 2000,
           });
            Delete.FromTable("Companies")
           .Row(new
           {
               Name = "Soft Matter",
               Sector = "Software House",
               EmployeesNumber = 2000,
           });
        }
    }
}
