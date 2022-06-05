using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Persistance.Migrations
{
    [Migration(202205280003)]
    public class JobStatusesSeed_202205280003 : Migration
    {
        public override void Up()
        {
          Insert.IntoTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "New",
          });
            Insert.IntoTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "Hot",
          });
            Insert.IntoTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "Close",
          });
            Insert.IntoTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "Default",
          });
        }

        public override void Down()
        {
            Delete.FromTable("JobStatuses")
           .Row(new
           {
               JobStatuseName = "New",
           });
            Delete.FromTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "Hot",
          });
            Delete.FromTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "Close",
          });
            Delete.FromTable("JobStatuses")
          .Row(new
          {
              JobStatuseName = "Default",
          });
        }
    }
}
